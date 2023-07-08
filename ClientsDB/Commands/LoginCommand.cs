using ClientsDB.BaseClasses_Interfaces;
using ClientsDB.Pages.LoginPage;
using ClientsDB.Pages.MainPage;

namespace ClientsDB.Commands
{
    public class LoginCommand : BaseCommand
    {
        private readonly LoginPageViewModel _loginViewModel;

        public LoginCommand(LoginPageViewModel loginViewModel)
        {
            _loginViewModel = loginViewModel;
        }

        public async override void Execute(object parameter)
        {
            string workerType = _loginViewModel.GetPermission();
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}?WorkerType={workerType}");
        }
    }
}
