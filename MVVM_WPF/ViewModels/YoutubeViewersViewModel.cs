using MVVM_WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_WPF.ViewModels
{
    public class YoutubeViewersViewModel : ViewModelBase
    {
        public YoutubeViewersListingViewModel YoutubeViewersListingViewModel { get; }
        public YoutubeViewersDetailsViewModel YoutubeViewersDetailsViewModel { get; }
        public ICommand AddYoutubeViewerCommand { get; }

        public YoutubeViewersViewModel(SelectedYoutubeViewerStore _selectedYoutubeViewerStore)
        {
            YoutubeViewersListingViewModel = new YoutubeViewersListingViewModel(_selectedYoutubeViewerStore);
            YoutubeViewersDetailsViewModel = new YoutubeViewersDetailsViewModel(_selectedYoutubeViewerStore);
        }
    }
}
