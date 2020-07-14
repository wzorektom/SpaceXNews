using SpacexNews.Commands;
using SpacexNews.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SpacexNews.States.Navigators
{
    public class Navigator : BaseViewModel, INavigator
    {
        private BaseViewModel currentViewModel;

        public BaseViewModel CurrentViewModel
        {
            get { return currentViewModel; }
            set 
            { 
                currentViewModel = value;
                OnPropertyChanged(nameof(currentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
