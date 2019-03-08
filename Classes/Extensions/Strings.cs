using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Diagnostics;
namespace KyokuMusicPlayer.Classes.Extensions
{
    public static class Strings
    {
        /// <summary>
        /// Checks if the specific string is present in a supplied array of strings. 
        /// Returns the array position if present. Returns -1 otherwise.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int IsPresentInArray(this string value, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                    return i;
            }

            return -1;
        }

        /// <summary>
        /// Checks if the specific string is present in a supplied emum. 
        /// Returns the enum position if present. Returns -1 otherwise.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int IsPresentInEnum(this string value, Type theEnum)
        {

            Array _enumValues = Enum.GetValues(theEnum);

            for (int i = 0; i < _enumValues.Length; i++)
            {
                if (_enumValues.GetValue(i).ToString() == value)
                    return i;
            }

            return -1;
        }

        /// <summary>
        /// Converts a string RGB value to a Color. Supports "R,G,B" as the format.
        /// If the string is in an incorrect format, returns Color.Black.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="colorString"></param>
        /// <returns></returns>
        public static Color ToColor(this string colorString)
        {
            string[] rgbDivided = colorString.Split(',');
            if(rgbDivided.Length==3)
            {
                byte r = (byte)Convert.ToInt16(rgbDivided[0]).Clamp(0, 255);
                byte g = (byte)Convert.ToInt16(rgbDivided[1]).Clamp(0, 255);
                byte b = (byte)Convert.ToInt16(rgbDivided[2]).Clamp(0, 255);
                return Color.FromRgb(r, g, b);
            }

            return Color.FromRgb(0, 0, 0);
        }
    }
}
