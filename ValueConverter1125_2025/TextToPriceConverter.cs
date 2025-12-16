using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace ValueConverter1125_2025;

public class TextToPriceConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value != null)
        {
            string text = value.ToString();
            if (decimal.TryParse(text, out var result))
            {
                return $"{result}{parameter}";
            }
        }

        return "Сумма не указана";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}