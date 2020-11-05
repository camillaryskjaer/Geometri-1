using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	public class Rectangle : Shape
	{
        private float sideA;

        public float SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        private float sideB;

        public float SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public override double Area()
        {
            return SideA * SideB;
        }

//Bedre navngivning som f.eks. CalculatePerimeter
        public override double Perimeter()
        {
            return 2 * (SideA + SideB);
        }
    }
}
