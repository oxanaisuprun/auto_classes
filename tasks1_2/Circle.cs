using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks1_2
{
	class Circle
    {
		public double Radius;
		public double RoundArea;

		public Circle(double enterRadius)
		{
			Radius = enterRadius;
			RoundArea = Math.Round(Math.PI * Math.Pow(Radius, 2),2);
		}
    }
}
