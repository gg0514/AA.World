using Avalonia.Controls;
using Avalonia.Controls.Platform;
using ViewModelLocator.Services;
using Microsoft.Extensions.DependencyInjection;
using ViewModelLocator.ViewModels;

namespace ViewModelLocator;

public class ViewModelLocator
{
    public MainViewModel MainViewModel =>
        Design.IsDesignMode
            ? new MainViewModel(new FakeGreetingService())
            : (Avalonia.Application.Current as App)?.serviceProvider?.GetService<MainViewModel>();

            //: App.Services!.GetRequiredService<MainViewModel>();
}

