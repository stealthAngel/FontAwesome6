﻿using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using FontAwesome6;

namespace DesktopClient.Framework.FontAwesome.svgnet.Converters
{
    [ValueConversion(typeof(EFontAwesomeIcon), typeof(Visibility))]
    public class VisibilityConverter : MarkupExtension, IValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is not EFontAwesomeIcon)
            {
                throw new InvalidOperationException("The target must be a EFontAwesomeIcon");
            }

            return (EFontAwesomeIcon)value == EFontAwesomeIcon.None ? parameter ?? Visibility.Collapsed : Visibility.Visible;
        }


        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
