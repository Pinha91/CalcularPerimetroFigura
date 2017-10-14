using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPerimetroFigura
{
    class Circule:Figure
    {
        /// <summary>
        /// Properties of Circule
        /// </summary>
        private float radio;
        private double pi = Math.PI;
        /// <summary>
        /// Gets and Sets by Radio
        /// </summary>
        public float Radio
        {
            get
            {
                return radio;
            }

            set
            {
                if(value < 0)//if the value is negative, its will give a zero
                {
                    radio = 0;
                }
                else
                {
                    radio = value;
                }
            }
        }
        /// <summary>
        /// Calculate area of circule
        /// </summary>
        /// <returns>Area of circule</returns>
        public override float CalculateArea()
        {
            return Convert.ToSingle(pi*Math.Pow(radio,2));
        }
        /// <summary>
        /// Calculate perimeter of circule
        /// </summary>
        /// <returns>perimeter of circule</returns>
        public override float CalculatePerimeter()
        {
            return Convert.ToSingle(2*pi*radio);
        }

    }
}
