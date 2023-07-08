using ClientsDB.BaseClasses_Interfaces;
using ClientsDB.Commands;
using System.Windows.Input;

namespace ClientsDB.Pages.LoginPage
{
    public class LoginPageViewModel : BaseViewModel
    {
        private string permission;

        private bool isConsultant;
        public bool IsConsultant
        {
            get
            {
                return isConsultant;
            }
            set
            {
                if (isConsultant != value)
                {
                    isConsultant = value;
                    OnPropertyChanged(nameof(IsConsultant));
                    SetPermission();
                }
            }
        }

        private bool isManager;
        public bool IsManager
        {
            get
            {
                return isManager;
            }
            set
            {
                if (isManager != value)
                {
                    isManager = value;
                    OnPropertyChanged(nameof(IsManager));
                }
            }
        }

        public ICommand LoginCommand { get; }

        public LoginPageViewModel()
        {
            IsConsultant = true;
            IsManager = false;
            LoginCommand = new LoginCommand(this);
        }
        public string GetPermission() => permission;

        private void SetPermission()
        {
            permission = isConsultant ? "consultant" : "manager";
        }
    }
}
