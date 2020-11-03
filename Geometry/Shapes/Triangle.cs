using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Shapes
{
    class Triangle : Shape
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

        private double sideC;

        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }

        public Triangle(double sidea, double sideb, double sidec)
        {
            this.SideA = sidea;
            this.SideB = sideb;
            this.SideC = sidec;
        }

        public override double Area()
        {
            return (0.5 * SideA * SideB);
        }

        public override double Perimeter()
        {
            return (SideA * SideB * SideC);
        }
    }
}
