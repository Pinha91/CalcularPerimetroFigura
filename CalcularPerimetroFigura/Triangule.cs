using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPerimetroFigura
{
    class Triangule:Figure
    {
        /// <summary>
        ///  Properties of Triangule
        /// </summary>
        private float sideRight;
        private float sideLeft;
        private float sideBased;
        private float based;
        private float height;
        /// <summary>
        /// Gets and Sets by SideRight
        /// </summary>
        public float SideRight
        {
            get
            {
                return sideRight;
            }

            set
            {
                if (value < 0)//if the value is negative, its will give a zero
                {
                    SideRight = 0;
                }
                else
                {
                    sideRight = value;
                }
            }

        }
        /// <summary>
        /// Gets and Sets by SideLeft
        /// </summary>
        public float SideLeft
        {

            get
            {
                return sideLeft;
            }

            set
            {
                if (value < 0)//if the value is negative, its will give a zero
                {
                    sideLeft = 0;
                }
                else
                {
                    sideLeft = value;
                }
            }

        }
        /// <summary>
        ///  Gets and Sets by SideBased
        /// </summary>
        public float SideBased
        {

            get
            {
                return sideBased;
            }

            set
            {
                if(value < 0)//if the value is negative, its will give a zero
                {
                    sideBased = 0;
                }
                else
                {
                    sideBased = value;
                }
            }

        }
        /// <summary>
        /// Gets and Sets by Based
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
        /// Gets and Sets by Height
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
        /// Calculate perimeter of triangule
        /// </summary>
        /// <returns>perimeter of triangule</returns>
        public override float CalculatePerimeter()
        {
            return sideRight+sideLeft+sideBased;
        }
        /// <summary>
        /// Calculate area of triangule
        /// </summary>
        /// <returns>area of triangule</returns>
        public override float CalculateArea()
        {
            return (based*height)/2;
        }

    }
}
