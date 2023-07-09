using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppFinalProject
{
    public class UserControlLoginViewModel : BaseViewModel
    {
        public string TxtUserName { get; set; }
        public string TxtPassword { get; set; }
        ObservableCollection<LoginCredential> LogList { get; set; }
        public UserControlLoginViewModel(MainWindowViewModel mainWindowViewModel)
        {
            MainWindowViewModel = mainWindowViewModel;
            LoginCommand = new RelayCommand(LoginCommandClick);

        }
        private void LoginCommandClick()
        {
            LoginCredential LogUserType= new LoginCredential();
            if ((TxtPassword) != null && TxtUserName != null)
            {
                FillLogin();
                LogUserType = LogList.Where(h => h.UserName == (TxtUserName)).SingleOrDefault();                
                //&& h.Password.ToLower().Contains(TxtPassword)
               // ));
                if (LogUserType != null)
                {
                    if (LogUserType.Usertype == "User")
                    {
                        MainWindowViewModel.ChangetoUserMode();
                    }
                    if (LogUserType.Usertype == "Admin")
                    { 
                        MainWindowViewModel.ChangetoAdminMode();

                    }
                }
                else
                { }
            }
        }

        

        private void FillLogin()
        {
            LogList = new ObservableCollection<LoginCredential>() {
                new LoginCredential() { UserName = "Admin", Usertype = "Admin", Password = "Admin123" } ,
                new LoginCredential() { UserName = "Ajay", Usertype = "User", Password = "User123" }
            };
        }

        public class LoginCredential
        {
            public string Usertype { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }
        public MainWindowViewModel MainWindowViewModel { get; }
    }
}
