using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConvertersMauiApp.Converters
{
    internal class GradeToTextGradeConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return Binding.DoNothing;
            }

            string grade = value.ToString();

            switch (grade)
            {
                case "1":
                    return "Niedostateczny";
                case "2":
                    return "Dopuszczający";
                case "3":
                    return "Dostateczny";
                default:
                    return Binding.DoNothing;
            }

        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
