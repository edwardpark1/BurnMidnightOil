using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BurnMidnightOil
{
    public class ControlDimension
    {
        private int width;
        private int height;

        public Point Origin { get; }

        public int Width 
        { 
            get 
            { 
                return width; 
            }

            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Width), value, "Width must be greater than 0");
                }
                width = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Height), value, "Height must be greater than 0");
                }
                height = value;
            }
        }

        public ControlDimension(Point origin, int width, int height)
        {
            Origin = origin;
            Width = width;  
            Height = height;    
        }
    }
}
