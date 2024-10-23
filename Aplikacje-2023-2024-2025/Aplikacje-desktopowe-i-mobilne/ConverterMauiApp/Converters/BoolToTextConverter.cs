using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterMauiApp.Converters
{
    class BoolToTextConverter : IValueConverter
    {

        public string? TrueMewssage { get; set; }
        public string? FalseMessage { get; set; }
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
#pragma warning disable CS8605 // Unboxing a possibly null value.
            bool isChecked = (bool)value;
#pragma warning restore CS8605 // Unboxing a possibly null value.
            
            if (isChecked)
                return TrueMessage;
            else return FalseMessage;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
