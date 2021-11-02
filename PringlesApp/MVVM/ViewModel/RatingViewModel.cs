using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;
using PringlesApp.Commands;
using PringlesApp.MVVM.Model;
using PringlesDatabase.Models;

namespace PringlesApp.MVVM.ViewModel
{
    public class RatingViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Rating> Ratings { get; set; }
        public ObservableCollection<Rating> SelectedRatings { get; set; }

        private string _selectedFlavor;

        public string SelectedFlavor
        {
            get => _selectedFlavor;
            set
            {
                if (value == _selectedFlavor)
                    return;
                _selectedFlavor = value;
                SelectedRatings = _selectedFlavor == "" ? Ratings : new ObservableCollection<Rating>(Ratings.Where(x => x.Pringles.Flavor.IndexOf(_selectedFlavor, StringComparison.OrdinalIgnoreCase) >= 0));
            }
        }

        public Rating Rating { get; set; }
        public bool IsOpenAddRating { get; set; }
        public bool IsOpenAddFlavor { get; set; }
        public string Username { get; set; } = "Gość";

        public UserRating UserRating { get; set; }

        public ObservableCollection<Pringles> AvailablePringles { get; set; }
        public Pringles NewPringles { get; set; }
        public List<int> Scores { get; set; } = new List<int>(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });


        private ICommand _addCommand;

        public ICommand AddCommand
        {
            get
            {
                return _addCommand ??= new RelayCommand(param => this.Add(), null);
            }
        }

        private void Add()
        {
            UserRating = new UserRating();
            IsOpenAddRating = true;
        }

        private ICommand _cancelCommand;

        public ICommand CancelCommand
        {
            get
            {
                return _cancelCommand ??= new RelayCommand(param => this.Cancel(), null);
            }
        }

        private void Cancel()
        {
            IsOpenAddRating = false;
        }
        private ICommand _confirmCommand;

        public ICommand ConfirmCommand
        {
            get
            {
                return _confirmCommand ??= new RelayCommand(param => this.Confirm(), null);
            }
        }

        private void Confirm()
        {

            IsOpenAddRating = false;

            using (var dbContext = new PringlesContext())
            {
                var newRating = new Rating
                {
                    Description = UserRating.Description,
                    Pringles = dbContext.Pringleses.First(x => x.Id == AvailablePringles[UserRating.Flavor].Id),
                    Score = UserRating.Score,
                    User = dbContext.Users.First(x => x.Username == Username)
                };
                dbContext.Ratings.Add(newRating);
                Ratings.Add(newRating);
                dbContext.SaveChanges();
            }
        }

        private ICommand _deleteCommand;

        public ICommand DeleteCommand
        {
            get
            {
                return _deleteCommand ??= new RelayCommand(param => this.Delete(), null);
            }
        }

        private void Delete()
        {
            if (Rating is null)

            {
                MessageBox.Show("Nie wybrano wiersza do usunięcia");
                return;
            }
            using (var dbContext = new PringlesContext())
            {
                dbContext.Ratings.Remove(Rating);
                dbContext.SaveChanges();
            }
            Ratings.Remove(Rating);
            SelectedRatings.Remove(Rating);
        }
        private ICommand _addFlavorCommand;

        public ICommand AddFlavorCommand
        {
            get
            {
                return _addFlavorCommand ??= new RelayCommand(param => this.AddFlavor(), null);
            }
        }

        private void AddFlavor()
        {
            NewPringles = new Pringles();
            IsOpenAddFlavor = true;
        }

        private ICommand _cancelFlavorCommand;

        public ICommand CancelFlavorCommand
        {
            get
            {
                return _cancelFlavorCommand ??= new RelayCommand(param => this.CancelFlavor(), null);
            }
        }

        private void CancelFlavor()
        {
            IsOpenAddFlavor = false;
        }
        private ICommand _confirmFlavorCommand;

        public ICommand ConfirmFlavorCommand
        {
            get
            {
                return _confirmFlavorCommand ??= new RelayCommand(param => this.ConfirmFlavor(), null);
            }
        }

        private void ConfirmFlavor()
        {

            IsOpenAddFlavor = false;
            using (var dbContext = new PringlesContext())
            {
                dbContext.Pringleses.Add(NewPringles);
                AvailablePringles.Add(NewPringles);
                dbContext.SaveChanges();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public RatingViewModel()
        {
            var m = (MainViewModel)(Application.Current.MainWindow).DataContext;
            Username = m.LoggedUser;
            using (var dbContext = new PringlesContext())
            {
                var user = dbContext.Users.ToList();
                var pringles = dbContext.Pringleses.OrderBy(x=>x.Flavor).ToList();
                var rating = dbContext.Ratings.Where(x => x.User.Username == Username).ToList();
                Ratings = new ObservableCollection<Rating>(rating);
                AvailablePringles = new ObservableCollection<Pringles>(pringles);

            }

            SelectedRatings = Ratings;
        }
    }
}