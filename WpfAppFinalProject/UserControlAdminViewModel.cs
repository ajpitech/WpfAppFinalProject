using System;
using System.Diagnostics;
using System.Windows.Input;

namespace WpfAppFinalProject
{
    public class UserControlAdminViewModel : BaseViewModel
    {
        public ICommand AddProductCommand { get; set; }
        public ICommand ViewProductCommand { get; set; }
        public BaseViewModel ProductView { get; set; }
        public UserControlAdminViewModel()
        {
            AddProductCommand = new RelayCommand(AddProductCommandClick);
            ViewProductCommand = new RelayCommand(ViewProductCommandClick);
        }

        private void ViewProductCommandClick(object obj)
        {
            ProductView = new ViewProductViewModel();
            OnPropertyChanged(nameof(ProductView));
        }

        private void AddProductCommandClick(object obj)
        {
            ProductView = new AddProductViewModel();
            OnPropertyChanged(nameof(ProductView));
        }
    }
}