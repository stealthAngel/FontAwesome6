using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using DesktopClient.Framework.FontAwesome.core.Extensions;
using FontAwesome6;

namespace DesktopClient.Framework.FontAwesome.svgnet.Converters
{
    public class IconNameConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not EFontAwesomeIcon)
            {
                return null;
            }

            var icon = (EFontAwesomeIcon)value;
            var iconName = icon.GetIconName();
            if (string.IsNullOrEmpty(iconName))
            {
                return null;
            }

            return parameter is string format && !string.IsNullOrEmpty(format) ? string.Format(format, iconName) : iconName.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
