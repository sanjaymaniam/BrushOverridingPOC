# BrushOverridingPOC

POC to check style overriding behaviour in UWP.


## Style Overriding Behaviour in UWP
 
Consider a UserControl called ZFeedbackControl. Within FeedbackControl.Resources, we define a resource named ZFeedbackForegroundBrush and use it within the control like this:
 
```xml
<UserControl.Resources>
        <StaticResource x:Key="ZFeedbackForegroundBrush" ResourceKey="SystemControlForegroundBaseHighBrush" />
</UserControl.Resources>

<Grid>
	<TextBlock
		FontSize="42"
		Foreground="{ThemeResource ZFeedbackForegroundBrush}"
		Text="Hello 2" />
</Grid>
````

Now, let's say we want to override ZFeedbackForegroundBrush in MainPage.xaml. We'd do something like this:
```xml
<local:ZFeedbackControl>
	<local:ZFeedbackControl.Resources>
		<SolidColorBrush x:Key="ZFeedbackForegroundTransparentBrush" Color="DeepPink" />
	</local:ZFeedbackControl.Resources>
</local:ZFeedbackControl>
````

This approach does not work. 

To be able to override the brush, we need to convert FeedbackControl into a custom control and define its structure within a ControlTemplate:
```xml
<ResourceDictionary
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:App1">

    <!--  Define the brushes  -->
    <StaticResource x:Key="ZTemplatedFeedbackForegroundBrush" ResourceKey="SystemControlForegroundBaseHighBrush" />

    <!--  Define the control template for ZTemplatedFeedbackControl  -->
    <Style TargetType="local:ZTemplatedFeedbackControl">
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="local:ZTemplatedFeedbackControl">
                    <Grid>
                        <TextBlock
                            FontSize="42"
                            Foreground="{ThemeResource ZTemplatedFeedbackForegroundBrush}"
                            Text="{TemplateBinding Text}" />

                        <!--  can I use attachmentControl here?  -->
                    </Grid>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
</ResourceDictionary>
```

Now, in MainPage.xaml, we can override the specific brush:

```
<local:ZTemplatedFeedbackControl Text="Potato 1">
	<local:ZTemplatedFeedbackControl.Resources>
		<SolidColorBrush x:Key="ZTemplatedFeedbackForegroundBrush" Color="DeepPink" />
	</local:ZTemplatedFeedbackControl.Resources>
</local:ZTemplatedFeedbackControl>
```

So, to enable style overriding for XAML resources, we need to:
- Make sure that the control is a custom control with a control template (and not a user control)
- Use the brush as a ThemeResource instead of a StaticResource within the control.

## Conclusions
We've been exploring options to enable brush overriding for a UWP control that we're planning to distribute as part of a NuGet package. Here's what we've found so far:

- **UserControl Approach**: If we decide to keep `ZFeedbackControl` as a UserControl, it seems the only way to allow brush overriding is to expose the brushes as dependency properties within the control. This would allow users to directly set the `ZFeedbackForegroundBrush` property on the `ZFeedbackControl` instance, overriding the brush defined in the control's resources or template. However, we need to check if we can use `x:Bind` with a ThemeResource. For instance, if the user has `ZForegroundBrush` as a ThemeResource, we need to confirm if `ZFeedbackForegroundBrush` will update on theme change.

- **CustomControl Approach**: If we're open to defining `ZFeedbackControl` as a custom control (with its structure defined in a ControlTemplate), users can override `ZTemplatedFeedbackForegroundBrush` directly in the parent control/page's resources. Additionally, the can also override `ZForegroundBrush` or `SystemControlForegroundBaseHighBrush` for the change to be reflected in all other controls using these brushes. 
	- This approach seems more suitable for a pure UI component (like `ZCheckBox`) that doesn't need to interact with business logic directly.
	- From a development perspective, this requires us to create events for button clicks and other user interactions explicitly within the control.
	- We also have to check if we're able to use other custom controls and user controls within this in XAML.