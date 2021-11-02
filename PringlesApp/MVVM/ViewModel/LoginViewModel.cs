using System;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Windows;
using System.Windows.Input;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using PringlesApp.Commands;
using PringlesDatabase.Models;

namespace PringlesApp.MVVM.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public string Username { get; set; }
        public string Password { private get; set; }
        public bool IsSuccessfulSignIn { get; set; } = true;

        private MainViewModel MainViewModel;

        private ICommand _changeToSignUpCommand;

        public ICommand ChangeToSignUpCommand
        {
            get
            {
                return _changeToSignUpCommand ??= new RelayCommand(param => this.ChangeTo(nameof(SignUpViewModel)), null);

            }
        }

        private void ChangeTo(string view)
        {
            switch (view)
            {

                case nameof(SignUpViewModel):

                    MainViewModel.CurrentView = MainViewModel.SignUpViewModel ??= new SignUpViewModel();
                    break;
            }
        }
        private ICommand _signInCommand;

        public ICommand SignInCommand
        {
            get
            {
                return _signInCommand ??= new RelayCommand(param => this.SignIn(), null);

            }
        }

        private void SignIn()
        {
            using (var dbContext = new PringlesContext())
            {
                if(Username is null || Password is null)
                    return;
                var b = dbContext.Users.FirstOrDefault(x => x.Username == Username && x.Password == Password);
                if (b is not null)
                {
                    MainViewModel.LoggedUser = Username;
                    Password = string.Empty;
                    IsSuccessfulSignIn = true;
                    MainViewModel.IsLogged = true;
                    MainViewModel.CurrentView = MainViewModel.HomePageViewModel;
                    
                }
                else
                {
                    IsSuccessfulSignIn = false;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel()
        {
            MainViewModel = (MainViewModel)(Application.Current.MainWindow).DataContext;
        }
    }
}