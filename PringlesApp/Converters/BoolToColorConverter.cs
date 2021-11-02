using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace PringlesApp.Converters
{
    public class BoolToColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            foreach (var value in values)
            {
                if (value is bool && (bool)value == false)
                    return Brushes.Red;
            }
            return Brushes.Green;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}