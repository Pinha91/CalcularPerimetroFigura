using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPerimetroFigura
{
    class Rectangle:Figure
    {
        /// <summary>
        ///  Properties of Rectangule
        /// </summary>
        private float based;
        private float height;
        /// <summary>
        /// gets and set 
        /// </summary>
        public float Based
        {
            get
            {
                return based;
            }

            set
            {
                if (value < 0)//if the value is negative, its will give a zero
                {
                    based = 0;
                }
                else
                {
                    based = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public float Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value < 0)//if the value is negative, its will give a zero
                {
                    height = 0;
                }
                else
                {
                    height = value;
                }
            }

        }
        /// <summary>
        /// Calculate perimeter of rectangule
        /// </summary>
        /// <returns>Perimeter of rectangule</returns>
        public override float CalculatePerimeter()
        {
            return (height+based)*2;
        }
        /// <summary>
        /// Calculate Area of rectangle
        /// </summary>
        /// <returns>Area of rectangle</returns>
        public override float CalculateArea()
        {
            return height*based;
        }
    }
}
