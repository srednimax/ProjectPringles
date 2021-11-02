using System.ComponentModel;
using System.Windows.Input;
using PringlesApp.Commands;

namespace PringlesApp.MVVM.ViewModel
{
    public class HomePageViewModel: INotifyPropertyChanged
    {
        public int Left { get; set; }
        public int Middle { get; set; }
        public int Right { get; set; }


        private ICommand _leftCommand;

        public ICommand LeftCommand
        {
            get
            {
                return _leftCommand ??= new RelayCommand(param => this.MoveToLeft(), null);
            }
        }

        private void MoveToLeft()
        {
            var l = Left;
            Left = Right;
            Right = Middle;
            Middle = l;

        }
        private ICommand _rightCommand;

        public ICommand RightCommand
        {
            get
            {
                return _rightCommand ??= new RelayCommand(param => this.MoveToRight(), null);
            }
        }

        private void MoveToRight()
        {
            var r = Right;
            Right = Left;
            Left = Middle;
            Middle = r;
        }
        public event PropertyChangedEventHandler PropertyChanged;
      
        public HomePageViewModel()
        {
            Left = 1;
            Middle = 3;
            Right = 5;
        }
    }
}