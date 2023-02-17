using CommonHelpers.Common;

namespace DepInjecDemo;

public class MainViewModel : ViewModelBase
{
    private readonly INameService nameService;

    public MainViewModel(INameService srv)
    {
        nameService = srv;
    }

    public string Name => nameService.GetName();
}