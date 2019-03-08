using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyokuMusicPlayer.Classes.Extensions
{
    public static class Numbers
    {
        public static byte Clamp(this byte value, byte min, byte max)
        {
            return Math.Max(min, Math.Min(value, max));
        }
        public static short Clamp(this short value,short min, short max)
        {
            return Math.Max(min, Math.Min(value, max));
        }
    }
}
