﻿using System;
using FontAwesome6;

namespace DesktopClient.Framework.FontAwesome.core.Extensions;

/// <summary>
/// EFontAwesomeIcon extensions
/// </summary>
public static class EFontAwesomeIconExtensions
{
    public static bool IsDuotone(this EFontAwesomeIcon icon)
    {
        var split = icon.ToString().Split('_');
        if (split.Length > 1 && Enum.TryParse<EFontAwesomeStyle>(split[0], out var style))
        {
            return style == EFontAwesomeStyle.Duotone;
        }

        return false;
    }

    public static EFontAwesomeStyle GetStyle(this EFontAwesomeIcon icon)
    {
        var split = icon.ToString().Split('_');
        if (split.Length > 1 && Enum.TryParse<EFontAwesomeStyle>(split[0], out var style))
        {
            return style;
        }

        return EFontAwesomeStyle.None;
    }

    public static string GetIconName(this EFontAwesomeIcon icon)
    {
        var split = icon.ToString().Split('_');
        if (split.Length > 1)
        {
            return split[1];
        }

        return null;
    }
}