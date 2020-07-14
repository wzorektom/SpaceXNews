using SpacexNews.States.Navigators;
using SpacexNews.ViewModel;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Input;

namespace SpacexNews.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                switch (viewType)
                {
                    case ViewType.Missions:
                        _navigator.CurrentViewModel = new MissionViewModel();
                        break;
                    case ViewType.Statistics:
                        _navigator.CurrentViewModel = new StatisticsViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
