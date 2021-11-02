using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using PringlesApp.Annotations;
using PringlesApp.Commands;
using PringlesApp.MVVM.Model;

namespace PringlesApp.MVVM.ViewModel
{

    public class MainViewModel : INotifyPropertyChanged
    {
        public HomePageViewModel HomePageViewModel { get; set; }
        public RatingViewModel RatingViewModel { get; set; }
        public ContactViewModel ContactViewModel { get; set; }
        public ProfileViewModel ProfileViewModel { get; set; }
        public LoginViewModel LoginViewModel { get; set; }
        public SignUpViewModel SignUpViewModel { get; set; }

        public int RowHome { get; set; }
        public int RowRating { get; set; }
        public int RowImage { get; set; }
        public int RowContact { get; set; }
        public object CurrentView { get; set; }

        public string LoggedUser { get; set; } = "Gość";

        public bool IsLogged { get; set; }

        private ICommand _changeToProfileCommand;

        public ICommand ChangeToProfileCommand
        {
            get
            {
                return _changeToProfileCommand ??= new RelayCommand(param => this.ChangeTo(nameof(ProfileViewModel)), null);

            }
        }

        private ICommand _changeToLoginCommand;

        public ICommand ChangeToLoginCommand
        {
            get
            {
                return _changeToLoginCommand ??= new RelayCommand(param => this.ChangeTo(nameof(LoginViewModel)), null);

            }
        }
        private ICommand _changeToHomePageCommand;

        public ICommand ChangeToHomePageCommand
        {
            get
            {
                return _changeToHomePageCommand ??=
                    new RelayCommand(param => this.ChangeTo(nameof(HomePageViewModel)), null);
            }
        }

        private ICommand _changeToRatingCommand;

        public ICommand ChangeToRatingCommand
        {
            get
            {
                return _changeToRatingCommand ??= new RelayCommand(param => this.ChangeTo(nameof(RatingViewModel)), null);

            }
        }
        private ICommand _changeToContactCommand;

        public ICommand ChangeToContactCommand
        {
            get
            {
                return _changeToContactCommand ??= new RelayCommand(param => this.ChangeTo(nameof(ContactViewModel)), null);

            }
        }

        private void ChangeTo(string view)
        {

            switch (view)
            {
                case nameof(HomePageViewModel):
                    HomePageViewModel ??= new HomePageViewModel();
                    CurrentView = HomePageViewModel;
                    RowHome = 0;
                    RowImage = 1;
                    RowRating = 11;
                    RowContact = 12;
                    break;
                case nameof(ContactViewModel):
                    ContactViewModel ??= new ContactViewModel();
                    CurrentView = ContactViewModel;
                    RowHome = 0;
                    RowRating = 1;
                    RowContact = 2;
                    RowImage = 3;
                    break;

                case nameof(RatingViewModel):
                    RatingViewModel ??= new RatingViewModel();
                    CurrentView = RatingViewModel;
                    RowHome = 0;
                    RowRating = 1;
                    RowImage = 2;
                    RowContact = 12;
                    break;

                case nameof(ProfileViewModel):
                    ProfileViewModel ??= new ProfileViewModel();
                    CurrentView = ProfileViewModel;
                    RowHome = 0;
                    RowImage = 1;
                    RowRating = 11;
                    RowContact = 12;
                    break;
                case nameof(LoginViewModel):
                    LoginViewModel ??= new LoginViewModel();
                    CurrentView = LoginViewModel;
                    RowHome = 0;
                    RowImage = 1;
                    RowRating = 11;
                    RowContact = 12;
                    if (IsLogged)
                    {
                        IsLogged = false;
                        LoggedUser = "Gość";
                    }
                    break;
                case nameof(SignUpViewModel):
                    SignUpViewModel ??= new SignUpViewModel();
                    CurrentView = SignUpViewModel;
                    RowHome = 0;
                    RowImage = 1;
                    RowRating = 11;
                    RowContact = 12;
                    break;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            HomePageViewModel = new HomePageViewModel();
            CurrentView = HomePageViewModel;
            RowHome = 0;
            RowImage = 1;
            RowRating = 11;
            RowContact = 12;
        }
    }
}