using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace SpacexNews.ViewModel
{
    public class WindowViewModel : BaseViewModel
    {

        private Window _window;

        public WindowViewModel(Window window)
        {
            _window = window;
        }

        public string TopBanner { get; } = "SpaceX_News";

        public int TopBannerHeight { get; } = 25;


    }
}
