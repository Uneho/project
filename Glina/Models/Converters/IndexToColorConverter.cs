using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;




namespace Glina.Models.Converters;


public class IndexToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        int currentIndex = (int)value;
        int indicatorIndex = System.Convert.ToInt32(parameter);
        return currentIndex == indicatorIndex ? Brushes.White : Brushes.Black;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotSupportedException("ConvertBack не поддерживается.");
    }
}