using MVVM_WPF.Models;
using MVVM_WPF.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_WPF.ViewModels
{
    public class YoutubeViewersListingViewModel : ViewModelBase
    {
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;
        private readonly ObservableCollection<YoutubeViewersListingItemViewModel> _youtubeViewersListingItemViewModel;
        public IEnumerable<YoutubeViewersListingItemViewModel> YoutubeViewersListingItemViewModel => _youtubeViewersListingItemViewModel;

        private YoutubeViewersListingItemViewModel _selectedYoutubeViewerListingItemViewModel;
        public YoutubeViewersListingItemViewModel SelectedYoutubeViewerListingItemViewModel
        {
            get
            {
                return _selectedYoutubeViewerListingItemViewModel;
            }
            set
            {
                _selectedYoutubeViewerListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedYoutubeViewerListingItemViewModel));

                _selectedYoutubeViewerStore.SelectedYoutuberViewer = _selectedYoutubeViewerListingItemViewModel?.YoutubeViewer;
            }
        }
        public YoutubeViewersListingViewModel(SelectedYoutubeViewerStore selectedYoutubeViewerStore)
        {
            _selectedYoutubeViewerStore = selectedYoutubeViewerStore;
            _youtubeViewersListingItemViewModel = new ObservableCollection<YoutubeViewersListingItemViewModel>();

            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel(new YoutubeViewer("Rogerio",true,true)));
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel(new YoutubeViewer("Kleber",false, false)));
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel(new YoutubeViewer("Robert", true, false)));


        }
    }
}
