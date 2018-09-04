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
    public class YouPageViewModel : ViewModelBase
    {
        public YouPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "You";
        }
    }
}
