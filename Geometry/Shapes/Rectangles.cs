using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rectangle : Shape
    {
        private double sideA;

        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        private double sideB;

        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public Rectangle(double sidea, double sideb)
        {
            this.sideA = sidea;
            this.SideB = sideb;
        }

        /// <summary>
        /// Calculates the area of the square using the following formula LxW
        /// </summary>
        public override double Area()
        {
            return SideA * SideB;
        }


        /// <summary>
        /// Calculates the perimeter of the square using the following formula 2X(L+W)
        /// </summary>
        public override double Perimeter()
        {
            return 2 * (SideA + SideB);
        }
    }
}
