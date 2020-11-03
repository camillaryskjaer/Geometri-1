using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Shapes
{
    public class Parallelogram : Shape
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


        private double angle;

        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }


        public Parallelogram(double sidea, double sideb, double angle) 
        {
            this.sideA = sidea;
            this.SideB = sideb;
            this.Angle = angle;
        }

        /// <summary>
        /// Calulcates the area of the parallelogram using the following formula LxWxSIN(0)
        /// </summary>
        public override double Area()
        {
            return(SideA* sideB) * Math.Sin((Math.PI / 180) * Angle);
        }

        /// <summary>
        /// Calulcates the perimeter of the parallelogram using the following formula 2x(LxW)
        /// </summary>
        public override double Perimeter()
        {
            return (2 * (SideA+SideB));
        }
    }
}
