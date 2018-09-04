using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;

namespace DeveloperTestXF.ViewModels
{
    public class ShoesPageViewModel : ViewModelBase
    {
        public ShoesPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Shoes";
            DefaultText = "This page must be implemented";
        }

        private string defaultText;
        public string DefaultText
        {
            get { return defaultText; }
            set { SetProperty(ref defaultText, value); }
        }
    }
}
