using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Trapezoid : Shape
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


        private double sideLeg;

        public double SideLeg
        {
            get { return sideLeg; }
            set { sideLeg = value; }
        }

        public Trapezoid(double sidea, double sideb, double sideleg)
        {
            this.sideA = sidea;
            this.SideB = sideb;
            this.sideLeg = sideleg;
        }

        private double GetS()
        {
            return ((SideA + SideLeg - SideB + SideLeg) / 2);
        }

        private double GetHeight()
        {
            double S = GetS();
            return 2 / (SideA - SideB) * Math.Sqrt(S * (S - SideA + SideB) * (S - SideLeg) * (S - SideLeg));
        }


        public override double Area()
        {
            return 0.5 * (SideA + SideB) * GetHeight();
        }

        public override double Perimeter()
        {
            return SideA + SideB + (2 * SideLeg);
        }
    }
}
