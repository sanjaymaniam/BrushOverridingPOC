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

Now, in MainPage.xaml, we can override the specific brush::

```
<local:ZTemplatedFeedbackControl Text="Potato 1">
	<local:ZTemplatedFeedbackControl.Resources>
		<SolidColorBrush x:Key="ZTemplatedFeedbackForegroundBrush" Color="DeepPink" />
	</local:ZTemplatedFeedbackControl.Resources>
</local:ZTemplatedFeedbackControl>
```

In conclusion, to enable style overriding for XAML resources, we need to:
- Make sure that the control is a custom control with a control template (and not a user control)
- Use the brush as a ThemeResource instead of a StaticResource within the control.

