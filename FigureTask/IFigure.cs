using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureTask
{
    public interface IFigure
    {
        /// <summary>
        /// Get figure of current object
        /// </summary>
        /// <returns>Capacity of figure</returns>
        public double GetСapacity();

        /// <summary>
        /// Get perimeter of current object
        /// </summary>
        /// <returns>Perimeter of figure</returns>
        public double GetPerimeter();

        /// <summary>
        /// Get a half of perimeter of current object
        /// </summary>
        /// <returns>Half-perimeter of figure</returns>
        public double GetHalfPerimeter();
    }
}
