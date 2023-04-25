using MVVM_WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_WPF.Stores
{
    public class SelectedYoutubeViewerStore
    {
        private YoutubeViewer _selectedyoutubeViewer;
        public YoutubeViewer SelectedYoutuberViewer
        {
            get
            {
                return _selectedyoutubeViewer;
            }
            set
            {
                _selectedyoutubeViewer = value;
                SelectedYoutubeViewerChanged?.Invoke();
            }
        }

        public event Action SelectedYoutubeViewerChanged;
    }
}
