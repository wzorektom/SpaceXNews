using SpacexNews.States.Navigators;
using SpacexNews.ViewModel;

namespace SpacexNews
{
    public class MainViewModel : BaseViewModel
    {
        public INavigator Navigator { get; set; } = new Navigator();
    }
}