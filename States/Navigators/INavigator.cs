using SpacexNews.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SpacexNews.States.Navigators
{
    public interface INavigator
    {
        BaseViewModel CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }

    public enum ViewType
    {
        Missions,
        Statistics
    }
}
