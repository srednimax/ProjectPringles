using System.ComponentModel;
using System.Linq;
using System.Windows;
using PringlesDatabase.Models;
using User = PringlesApp.MVVM.Model.User;

namespace PringlesApp.MVVM.ViewModel
{
    public class ProfileViewModel: INotifyPropertyChanged
    {
        public User User { get; set; }
        public string Username { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public ProfileViewModel()
        {
            var m =(MainViewModel)(Application.Current.MainWindow).DataContext;
            Username = m.LoggedUser;
            using (var dbContext = new PringlesContext())
            {
                var user = dbContext.Users.FirstOrDefault(x => x.Username == Username);
                if (user is not null)
                {
                    User = new User
                    {
                        Username = user.Username,
                        Email = user.Email,
                        DateOfBirth = user.DateOfBirth,
                        Gender = user.Gender,
                        PhoneNumber = user.PhoneNumber,
                        CreatedOn = user.CreatedOn
                    };
                }
            }
        }
        
    }
}