using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry.Shapes;

namespace Geometry
{
	class Program
	{
		static void Main(string[] args)
		{
			//Creating a list and appending a bunch of different shapes
			List<Shape> Shapes = new List<Shape>();
			Shapes.Add(new Parallelogram(30, 5, 50));
			Shapes.Add(new Rectangle(8, 7));
			Shapes.Add(new Square(24));
			Shapes.Add(new Trapezoid(12, 7, 23));
			Shapes.Add(new Triangle(1, 2, 50));

			//Loop through the list and show the area and perimiter of the object.
            foreach (var i in Shapes)
            {
				Console.WriteLine(i.Area()+" - "+i.Perimeter());
            }

			Console.ReadKey();
		}
	}
}
