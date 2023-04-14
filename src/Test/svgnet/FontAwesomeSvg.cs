using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows;
using DesktopClient.Framework.FontAwesome.svgnetshared;
using FontAwesome6;
using Newtonsoft.Json;

namespace DesktopClient.Framework.FontAwesome.svgnet
{
    public static class FontAwesomeSvg
    {
        private static readonly Dictionary<string, FontAwesomeSvgInformation> _data = new Dictionary<string, FontAwesomeSvgInformation>();

        static FontAwesomeSvg()
        {
            //LoadFromResource("Test.Data.FontAwesomeSvg.all.json", typeof(FontAwesomeSvg).Assembly);
            LoadFromResource("DesktopClient.Framework.FontAwesome.Data.FontAwesomeSvg.all.json", typeof(FontAwesomeSvg).Assembly);
        }

        public static bool TryGetInformation(EFontAwesomeIcon icon, out FontAwesomeSvgInformation information)
        {
            return _data.TryGetValue(icon.ToString(), out information);
        }

        public static FontAwesomeSvgInformation GetInformation(EFontAwesomeIcon icon)
        {
            if (_data.TryGetValue(icon.ToString(), out var information))
            {
                return information;
            }

            if (!(bool)(DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue))
            {
                throw new Exception($"Couldn't load icon \"{icon}\". Please load the svg data for that icon first.");
            }

            return null;
        }

        public static void Clear()
        {
            _data.Clear();
        }

        public static void LoadFromResource(string resourceName, Assembly assembly)
        {
            var x = assembly.GetManifestResourceStream(resourceName);
            using (Stream stream = x)
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string content = reader.ReadToEnd();
                    ReadSvgData(content);
                }
            }
        }

        public static void LoadFromDirectory(string fullFileName)
        {
            if (!File.Exists(fullFileName))
            {
                throw new System.Exception("File not found.");
            }

            ReadSvgData(File.ReadAllText(fullFileName));
        }

        private static void ReadSvgData(string content)
        {
            var data = JsonConvert.DeserializeObject<Dictionary<string, FontAwesomeSvgInformation>>(content);
            foreach (var kvp in data)
            {
                _data[kvp.Key] = kvp.Value;
            }
        }
    }
}
