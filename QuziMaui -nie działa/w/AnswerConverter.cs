using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace w
{
    public class AnswerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var selectedAnswer = value as string;
            var answer = parameter as string;

            return selectedAnswer == answer;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
