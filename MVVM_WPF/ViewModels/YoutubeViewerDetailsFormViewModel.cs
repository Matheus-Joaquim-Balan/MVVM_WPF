using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_WPF.ViewModels
{
    public class YoutubeViewerDetailsFormViewModel : ViewModelBase
    {
        private string _username;
        
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }
        private string _isSubscribed;
        
        public string IsSubscribed
        {
            get
            {
                return _isSubscribed;
            }
            set
            {
                _isSubscribed = value;
                OnPropertyChanged(nameof(IsSubscribed));
            }
        }
        private string _isMember;
        
        public string IsMember
        {
            get
            {
                return _isMember;
            }
            set
            {
                _isMember = value;
                OnPropertyChanged(nameof(IsMember));
            }
        }

        public bool CanSubmit => !string.IsNullOrEmpty(Username);

        public ICommand SubmitCommand { get; set; }
        public ICommand CancelCommand { get; set; }
    }
}
