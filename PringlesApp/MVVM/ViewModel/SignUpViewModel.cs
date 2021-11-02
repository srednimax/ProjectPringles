using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using PringlesApp.Annotations;
using PringlesApp.Commands;
using PringlesApp.MVVM.Model;
using PringlesDatabase.Models;
using User = PringlesApp.MVVM.Model.User;

namespace PringlesApp.MVVM.ViewModel
{

    public class SignUpViewModel : INotifyPropertyChanged
    {
        public User NewUser { get; set; }
        public int PasswordStrength { get; set; }
        public SolidColorBrush PasswordStrengthColor { get; set; }
        public int Progress { get; set; }


        private ICommand _signUpCommand;

        public ICommand SignUpCommand
        {
            get
            {
                if (_signUpCommand == null)
                {
                    _signUpCommand = new RelayCommand(param => this.SignUp(),
                        null);
                }
                return _signUpCommand;
            }
        }

        private ICommand _checkIfExistUsernameCommand;

        public ICommand CheckIfExistUsernameCommand
        {
            get
            {
                if (_checkIfExistUsernameCommand == null)
                {
                    _checkIfExistUsernameCommand = new RelayCommand(param => this.CheckIfExistUsername(),
                        null);
                }
                return _checkIfExistUsernameCommand;
            }
        }

        private void CheckIfExistUsername()
        {
            if(NewUser.Username is null)
                return;
            using (var dbContext = new PringlesContext())
            {
                var user = dbContext.Users.FirstOrDefault(x => x.Username == NewUser.Username);
                NewUser.IsAvUsername = user is null;
            }
        }

        private ICommand _checkCorrectUsernameCommand;

        public ICommand CheckCorrectUsernameCommand
        {
            get
            {
                if (_checkCorrectUsernameCommand == null)
                {
                    _checkCorrectUsernameCommand = new RelayCommand(param => this.CheckCorrectUsername(),
                        null);
                }
                return _checkCorrectUsernameCommand;
            }
        }

        private void CheckCorrectUsername()
        {
            if (NewUser.Username is null)
                return;
            NewUser.IsCorrectUsername = NewUser.Username.Length >= 3;
        }

        private ICommand _checkIfExistEmailCommand;

        public ICommand CheckIfExistEmailCommand
        {
            get
            {
                if (_checkIfExistEmailCommand == null)
                {
                    _checkIfExistEmailCommand = new RelayCommand(param => this.CheckIfExistEmail(),
                        null);
                }
                return _checkIfExistEmailCommand;
            }
        }

        private void CheckIfExistEmail()
        {
            if (NewUser.Email is null)
                return;
            using (var dbContext = new PringlesContext())
            {
                var user = dbContext.Users.FirstOrDefault(x => x.Email == NewUser.Email);
                NewUser.IsAvEmail = user is null;
                Progress = NewUser.CountBool();
            }
        }
        private ICommand _checkCorrectEmailCommand;

        public ICommand CheckCorrectEmailCommand
        {
            get
            {
                if (_checkCorrectEmailCommand == null)
                {
                    _checkCorrectEmailCommand = new RelayCommand(param => this.CheckCorrectEmail(),
                        null);
                }
                return _checkCorrectEmailCommand;
            }
        }

        private void CheckCorrectEmail()
        {
            if (NewUser.Email is null)
                return;
            if (NewUser.Email.Count(x => x == '@') != 1 || !NewUser.Email.Contains('.'))
                NewUser.IsCorrectEmail = false;
            else

                NewUser.IsCorrectEmail = true;

            Progress = NewUser.CountBool();
        }

        private ICommand _checkSameEmailCommand;

        public ICommand CheckSameEmailCommand
        {
            get
            {
                if (_checkSameEmailCommand == null)
                {
                    _checkSameEmailCommand = new RelayCommand(param => this.CheckSameEmail(),
                        null);
                }
                return _checkSameEmailCommand;
            }
        }

        private void CheckSameEmail()
        {
            if (NewUser.Email is null || NewUser.ConfirmEmail is null)
                return;
            NewUser.IsSameEmail = NewUser.Email == NewUser.ConfirmEmail;
            Progress = NewUser.CountBool();
        }

        private ICommand _checkStrongPasswordCommand;

        public ICommand CheckStrongPasswordCommand
        {
            get
            {
                if (_checkStrongPasswordCommand == null)
                {
                    _checkStrongPasswordCommand = new RelayCommand(param => this.CheckStrongPassword(),
                        null);
                }
                return _checkStrongPasswordCommand;
            }
        }

        private void CheckStrongPassword()
        {
            if (NewUser.Password is null)
                return;
            PasswordStrength = PasswordAdvisor.CheckStrength(NewUser.Password);
            switch (PasswordStrength)
            {
                case 0:
                    PasswordStrengthColor = Brushes.Black;
                    NewUser.IsStrongPassword = false;
                    break;
                case 1:
                    PasswordStrengthColor = Brushes.Red;
                    NewUser.IsStrongPassword = true;
                    break;
                case 2:
                    PasswordStrengthColor = Brushes.DarkOrange;
                    NewUser.IsStrongPassword = true;
                    break;
                case 3:
                    PasswordStrengthColor = Brushes.Yellow;
                    NewUser.IsStrongPassword = true;
                    break;
                case 4:
                    PasswordStrengthColor = Brushes.GreenYellow;
                    NewUser.IsStrongPassword = true;
                    break;
                case 5:
                    PasswordStrengthColor = Brushes.LimeGreen;
                    NewUser.IsStrongPassword = true;
                    break;
            }
            Progress = NewUser.CountBool();
        }

        private ICommand _checkSamePasswordCommand;

        public ICommand CheckSamePasswordCommand
        {
            get
            {
                if (_checkSamePasswordCommand == null)
                {
                    _checkSamePasswordCommand = new RelayCommand(param => this.CheckSamePassword(),
                        null);
                }
                return _checkSamePasswordCommand;
            }
        }

        private void CheckSamePassword()
        {
            if (NewUser.Password is null || NewUser.ConfirmPassword is null)
                return;
            NewUser.IsSamePassword = NewUser.Password == NewUser.ConfirmPassword;
            Progress = NewUser.CountBool();
        }

        private ICommand _checkCorrectPhoneNumberCommand;

        public ICommand CheckCorrectPhoneNumberCommand
        {
            get
            {
                if (_checkCorrectPhoneNumberCommand == null)
                {
                    _checkCorrectPhoneNumberCommand = new RelayCommand(param => this.CheckCorrectPhoneNumber(),
                        null);
                }
                return _checkCorrectPhoneNumberCommand;
            }
        }

        private void CheckCorrectPhoneNumber()
        {
            if (NewUser.PhoneNumber is null)
                return;
            NewUser.IsCorrectPhoneNumber = NewUser.PhoneNumber.Length == 9;

            NewUser.IsCorrectPhoneNumber = Regex.IsMatch(NewUser.PhoneNumber, "^[0-9]+$", RegexOptions.ECMAScript);
            Progress = NewUser.CountBool();
        }

        private ICommand _checkCorrectDateOfBirthCommand;

        public ICommand CheckCorrectDateOfBirthCommand
        {
            get
            {
                if (_checkCorrectDateOfBirthCommand == null)
                {
                    _checkCorrectDateOfBirthCommand = new RelayCommand(param => this.CorrectDateOfBirth(),
                        null);
                }
                return _checkCorrectDateOfBirthCommand;
            }
        }

        private void CorrectDateOfBirth()
        {

            if (NewUser.DateOfBirth.Year <= DateTime.Now.Year - 13 && NewUser.DateOfBirth.Year >= DateTime.Now.Year - 111)
                NewUser.IsCorrectDateOfBirth = true;
            else
                NewUser.IsCorrectDateOfBirth = false;
            Progress = NewUser.CountBool();

        }


       

        private void SignUp()
        {
            using (var dbContext = new PringlesContext())
            {
                dbContext.Users.Add(new PringlesDatabase.Models.User
                {
                    Username = NewUser.Username,
                    Password = NewUser.Password,
                    Email = NewUser.Email,
                    PhoneNumber = NewUser.PhoneNumber,
                    Gender = NewUser.Gender,
                    DateOfBirth = NewUser.DateOfBirth
                });
                dbContext.SaveChanges();
            }

            NewUser = null;
            var mainView = (MainViewModel)Application.Current.MainWindow.DataContext;
            mainView.CurrentView = mainView.LoginViewModel;
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public SignUpViewModel()
        {
            NewUser = new User
            {
                DateOfBirth = DateTime.Now,
            };

        }
    }
}

