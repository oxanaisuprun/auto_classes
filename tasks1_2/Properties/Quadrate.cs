using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks1_2
{
	public class Quadrate
	{
		private double side;
		public double quadrateArea;

		public Quadrate(double enterSide)
			{
				side = enterSide;
				quadrateArea = Math.Round(Math.Pow(side, 2),2);
			}
		}
	}

