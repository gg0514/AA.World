using CommunityToolkit.Mvvm.ComponentModel;

namespace BindingConvertersExample.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private int _age;
}