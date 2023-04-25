using MVVM_WPF.Models;
using MVVM_WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_WPF.ViewModels
{
    public class YoutubeViewersDetailsViewModel : ViewModelBase
    {
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;
        private YoutubeViewer SelectedYoutubeViewer => _selectedYoutubeViewerStore.SelectedYoutuberViewer;

        public bool HasSelectedYoutubeViewer => SelectedYoutubeViewer != null;
        public string Username => SelectedYoutubeViewer?.Username;
        public string  IsSubscribedDisplay => (SelectedYoutubeViewer?.IsSubscribed ?? false) ? "Yes" : "No";
        public string  IsMemberDisplay => (SelectedYoutubeViewer?.IsMember ?? false) ? "Yes" : "No";


        public YoutubeViewersDetailsViewModel(SelectedYoutubeViewerStore selectedYoutubeViewerStore)
        {
            _selectedYoutubeViewerStore = selectedYoutubeViewerStore;

            _selectedYoutubeViewerStore.SelectedYoutubeViewerChanged += SelectedYoutubeViewerStore_SelectedYoutubeViewerChanged;
        }

        protected override void Dispose()
        {
            _selectedYoutubeViewerStore.SelectedYoutubeViewerChanged += SelectedYoutubeViewerStore_SelectedYoutubeViewerChanged;

            base.Dispose();
        }

        private void SelectedYoutubeViewerStore_SelectedYoutubeViewerChanged()
        {
            OnPropertyChanged(nameof(HasSelectedYoutubeViewer));
            OnPropertyChanged(nameof(Username));
            OnPropertyChanged(nameof(IsSubscribedDisplay));
            OnPropertyChanged(nameof(IsMemberDisplay));
        }
    }
}
