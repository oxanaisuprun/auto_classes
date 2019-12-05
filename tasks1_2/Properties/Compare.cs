using System;
namespace tasks1_2
{
	public class Compare
	{
		public  string Comparing (double roundArea, double quadrateArea)
		{
			string comparingResult;
			if (roundArea > Math.PI / 2 * quadrateArea)
			{
				comparingResult = "The quadrate fits in the circle";
				Console.ReadKey();
			}
			else if (roundArea < Math.PI / 4 * quadrateArea)
			{
				comparingResult = "The circle fits in the quadrate";
				Console.ReadKey();
			}
			else { 
				comparingResult = "The quadrate and the circle are crossed";
				Console.ReadKey();
			}
			return comparingResult;
		}
	}
}

