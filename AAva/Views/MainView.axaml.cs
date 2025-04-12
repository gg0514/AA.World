using Avalonia.Controls;
using Microsoft.Extensions.DependencyInjection;
using AAva.ViewModels;

namespace AAva.Views;


public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        DataContext = App.ServiceProvider.GetService<MainViewModel>();
    }
}
