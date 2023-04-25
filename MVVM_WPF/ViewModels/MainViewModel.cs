using MVVM_WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public ViewModelBase CurrentModalViewModel => _modalNavigationStore.CurrentViewModel;
        public bool IsModaOpen => _modalNavigationStore.IsOpen;
        public YoutubeViewersViewModel YoutubeViewersViewModel { get; }
        public MainViewModel(ModalNavigationStore modalNavigationStore, YoutubeViewersViewModel youtubeViewersViewModel)
        {
            _modalNavigationStore = modalNavigationStore;
            YoutubeViewersViewModel = youtubeViewersViewModel;

            _modalNavigationStore.CurrentViewModelChanged += ModalNavigationStore_CurrentViewModelChanged;
        }

        protected override void Dispose()
        {
            _modalNavigationStore.CurrentViewModelChanged += ModalNavigationStore_CurrentViewModelChanged;

            base.Dispose();
        }

        private void ModalNavigationStore_CurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentModalViewModel));
            OnPropertyChanged(nameof(IsModaOpen));
        }
    }
}
