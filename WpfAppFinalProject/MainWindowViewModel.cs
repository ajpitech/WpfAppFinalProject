using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppFinalProject
{
    public class MainWindowViewModel:BaseViewModel
    {
        public BaseViewModel ActiveView { get; set; }
        
        
        public MainWindowViewModel()
        {
            ActiveView = new UserControlLoginViewModel(this);
                OnPropertyChanged(nameof(ActiveView));
            

        }
        public void ChangetoUserMode()
        {
            ActiveView = new UserControlMenuViewModel();
            OnPropertyChanged(nameof(ActiveView));
        }

        public void ChangetoAdminMode()
        {
            ActiveView = new UserControlAdminViewModel();
            OnPropertyChanged(nameof(ActiveView));
        }
    }
}
