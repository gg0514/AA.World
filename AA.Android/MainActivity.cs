using Android.App;
using Android.Content.PM;

using Avalonia;
using Avalonia.Android;


//using AA;
//using AAva;
//using AndAva;

//using BindingConvertersExample;
//using ButtonCustomize;
using SimpleToDoList;


namespace AA.Android;

[Activity(
    Label = "AA.Android",
    Theme = "@style/MyTheme.NoActionBar",
    Icon = "@drawable/icon",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity<App>
{
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .WithInterFont();
    }
}
