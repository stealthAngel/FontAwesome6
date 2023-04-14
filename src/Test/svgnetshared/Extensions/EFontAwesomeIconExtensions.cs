using DesktopClient.Framework.FontAwesome.svgnet;
using FontAwesome6;

namespace DesktopClient.Framework.FontAwesome.svgnetshared.Extensions
{
    /// <summary>
    /// EFontAwesomeIcon extensions
    /// </summary>
    public static partial class EFontAwesomeIconExtensions
    {
        public static bool TryGetSvgInformation(this EFontAwesomeIcon icon, out FontAwesomeSvgInformation svgInformation)
        {
            svgInformation = FontAwesomeSvg.GetInformation(icon);
            return svgInformation != null;
        }

        public static FontAwesomeSvgInformation GetSvgInformation(this EFontAwesomeIcon icon)
        {
            return FontAwesomeSvg.GetInformation(icon);
        }
    }

}
