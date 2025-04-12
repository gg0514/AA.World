using System;
using Avalonia;

//using AA;
//using AAva;
//using AndAva;

//using BindingConvertersExample;
//using ButtonCustomize;
//using SimpleToDoList;

//using ViewModelLocator;

namespace AA.Desktop;

class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<ViewModelLocator.App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();

}
