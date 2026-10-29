using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConvertersMauiApp.Converters
{
    internal class RgbToColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null
                || values.Length != 3
                || values[0] == null
                || values[0] is not double
                || values[1] == null
                || values[1] is not double
                || values[2] == null
                || values[2] is not double)
                return Binding.DoNothing;

            int red = (int)(double)values[0];
            int green = (int)(double)values[1];
            int blue = (int)(double)values[2];

            return new Color(red, green, blue);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            Color color = (Color)value;
            object[] objects = new object[3];

            objects[0] = color.Red * 255;
            objects[1] = color.Green * 255;
            objects[2] = color.Blue * 255;

            return objects;
        }
    }
}
