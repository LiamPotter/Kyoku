using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Data;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
//using System.Drawing;
using System.Diagnostics;
using System.Windows;
using KyokuMusicPlayer.Properties;
using KyokuMusicPlayer.Classes.Extensions;

namespace KyokuMusicPlayer.Classes.Themes
{
    public class Theme
    {
        public Color BGGradientStart { get; set; }
        public Color BGGradientEnd { get; set; }

        public bool SetGradients(Color start, Color end)
        {
            
            if (start == null || end == null)
                return false;
            BGGradientStart = start;
            BGGradientEnd = end;
            return true;
        }

        public static Theme Default()
        {
            return new Theme();
        }
    }

    public static class ThemeSwitcher
    {
        public static void Switch(string toTheme)
        {
            Settings.Default.ColorTheme = toTheme;
            Settings.Default.Save();
        }
        public static void Switch(string toTheme, bool forceUpdate,Window currentWindow)
        {
            Switch(toTheme);
            if (forceUpdate)
                ThemeApplier.Apply(ThemeLoader.Load(), currentWindow);
        }

    }

    public static class ThemeApplier
    {
        public static void Apply(Theme theme,Window window)
        {
            GradientBrush _tempBGBrush = (GradientBrush)window.Background;
            _tempBGBrush.GradientStops.Clear();
            _tempBGBrush.GradientStops.Add(new GradientStop(theme.BGGradientStart, 0));
            _tempBGBrush.GradientStops.Add(new GradientStop(theme.BGGradientEnd, 1));
            window.Background = _tempBGBrush;
        }
    }

    public static class ThemeLoader
    {
        public static Theme Load()
        {
            var _themestring = Settings.Default.ColorTheme;
            Theme _returnTheme = null;
            _returnTheme = FileToThemeConverter.Convert(_themestring);
            return _returnTheme;
        }
    
    }

    public static class FileToThemeConverter
    {
        protected enum elements {
            windowBGGradientStart,
            windowBGGradientEnd };

        public static Theme Convert(string fileName)
        {
            Theme _convertedTheme = new Theme();
            string _themeFolderPath=(AppDomain.CurrentDomain.BaseDirectory+@"Resource\Themes\");
            string _themePath = _themeFolderPath + fileName + ".theme";

            string[] _themeRawStringLines = File.ReadAllLines(_themePath);
            foreach (string _line in _themeRawStringLines)
            {
                string[] _elementAndValue = _line.Split('=');

                int _elementPosition = _elementAndValue[0].IsPresentInEnum(typeof(elements));
                elements _thisElement = new elements();
                _thisElement = (elements)_elementPosition;

                Debug.WriteLine("elementPosition is " + _elementPosition + ". That is " + _thisElement);

                Color _valueColor = _elementAndValue[1].ToColor();
                Debug.WriteLine(_valueColor);
                _convertedTheme.ApplyColorToThemeElement(_thisElement, _valueColor);
            }
            return _convertedTheme;
        }
        private static void ApplyColorToThemeElement(this Theme theme, elements element, Color color)
        {
            switch (element)
            {
                case elements.windowBGGradientStart:
                    theme.BGGradientStart = color;
                    break;
                case elements.windowBGGradientEnd:
                    theme.BGGradientEnd = color;
                    break;
                default:
                    break;
            }
        }
        
    }

  
}
