using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	public class Square : Shape
	{
        private double sideA;

        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        public Square(double sidea)
        {
            this.SideA = sidea;
        }

        /// <summary>
        /// Calculates the area of the square using the following formula LxW
        /// </summary>
        public override double Area()
        {
            return SideA * SideA;
        }

        /// <summary>
        /// Calculates the perimeter of the square, and since all four sides are equally 
        /// long we simply multiply the one side that we are given by four.
        /// </summary>
        public override double Perimeter()
        {
            return SideA * 4;
        }
    }
}
