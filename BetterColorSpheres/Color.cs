using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Color
    {
        public readonly int Red;
        public readonly int Green;
        public readonly int Blue;
        public readonly int Alpha;

        public Color(int red, int green, int blue, int alpha){
            
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(int red, int green, int blue){
            Red = red;
            Green = green;
            Blue = blue;
            
        }

        public int GetCinczento()
        {
            return (Green + Red + Blue) / 3;
        }
    }
}