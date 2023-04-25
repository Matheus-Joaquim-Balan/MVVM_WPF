using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_WPF.ViewModels
{
    public class AddYoutubeViewerViewModel
    {
        public YoutubeViewerDetailsFormViewModel YoutubeViewerDetailsFormViewModel { get; }

        public AddYoutubeViewerViewModel()
        {
            YoutubeViewerDetailsFormViewModel = new YoutubeViewerDetailsFormViewModel();
        }
    }
}
