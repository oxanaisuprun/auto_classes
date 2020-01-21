using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks1_2
{
	public class Quadrate
	{
		private double Side;
		public double QuadrateArea;

		public Quadrate(double enterSide)
			{
				Side = enterSide;
				QuadrateArea = Math.Round(Math.Pow(Side, 2),2);
			}
		}
	}

