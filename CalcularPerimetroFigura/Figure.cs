using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPerimetroFigura
{

    class Figure
    {
        /// <summary>
        /// Calculate perimeter of figure
        /// </summary>
        /// <returns>zero for defect</returns>
        public virtual float CalculatePerimeter()
        {

            return 0;
        }
        /// <summary>
        ///  Calculate area of figure
        /// </summary>
        /// <returns>zero for defect</returns>
        public virtual float CalculateArea()
        {

            return 0;
        }
    }
}
