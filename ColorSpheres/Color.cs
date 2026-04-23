using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int red, int green, int blue, int alpha){
            
        }

        public Color(int red, int green, int blue){
         int alpha = 255;
            
        }

        public int GetRed()
        {
            return red;
        }

        public int GetBlue()
        {
            return blue;
        }

        public int GetGreen()
        {
            return green;
        }

        public int GetAlpha()
        {
            return alpha;
        }

        public int GetCinczento()
        {
            return (green + red + blue) / 3;
        }
    }
}