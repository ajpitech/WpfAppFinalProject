using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppFinalProject
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public string ViewTitle { get; set; }
   
        public ObservableCollection<Product> ProductList { get; set; }

        public static ICommand LoginCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
