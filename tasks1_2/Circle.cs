using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks1_2
{
	class Circle
    {
		private double radius;
		public double roundArea;

		public Circle(double enterRadius)
		{
			radius = enterRadius;
			roundArea = Math.Round(Math.PI * Math.Pow(radius, 2),2);
			//Console.WriteLine($"The area of circle with radius {radius} is {roundArea}");
		}
    }
}
