using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterMauiApp.Converters
{
    internal class BoolToColorConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
#pragma warning disable CS8605 // Unboxing a possibly null value.
            bool isChecked = (bool)value;
#pragma warning restore CS8605 // Unboxing a possibly null value.
            if (isChecked)
                return new Color(1f, 0f, 0f); //Color.Red - inaczej
            else return new Color(0f, 1f, 0f); //Color.Green - inaczej
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
