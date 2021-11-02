using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace PringlesApp.Converters
{
    public class MyBoolToVisibleConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is bool)
              return (bool)value ? Visibility.Collapsed : Visibility.Visible;
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}