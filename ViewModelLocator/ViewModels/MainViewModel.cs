using ViewModelLocator.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ViewModelLocator.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly IGreetingService _greetingService;

    [ObservableProperty]
    public string _greeting;

    public MainViewModel(IGreetingService greetingService)
    {
        _greetingService = greetingService;
        _greeting = _greetingService.GetGreeting();
    }
    public MainViewModel() : this(new FakeGreetingService()) { }
}
