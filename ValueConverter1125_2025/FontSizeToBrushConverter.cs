using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;

namespace ValueConverter1125_2025;
// конвертер создается как публичный класс
// реализующий интерфейс IValueConverter
public class FontSizeToBrushConverter : IValueConverter
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value">Значение, которое идет от источника привязки</param>
    /// <param name="targetType">тип, в который мы преобразовываем</param>
    /// <param name="parameter">доп значение, указываемое в привязке у конвертера</param>
    /// <param name="culture">инфо о языковой среде</param>
    /// <returns></returns>
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        //value - размер шрифта
        // мы должны вернуть кисть (SolidBrush и тп)
        double fontSize = (double)value;
        if (fontSize > 25)
            return Brushes.Red;
        else if (fontSize > 20)
            return Brushes.Blue;
        else if (fontSize > 15)
            return Brushes.Yellow;
        else if (fontSize > 10)
            return Brushes.Green;
        return Brushes.Black;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value">значение от интерфейса к источнику привязке</param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    ///  если привязка однонаправленная, можно метод не реализовывать
    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        // нам нужно было бы реализовать этот метод, если
        // мы захотим преобразовывать кисти в размер шрифта
        return null;
    }
}