using System;

namespace tasks1_2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter a radius below:");
			string radius = Console.ReadLine();
            double radiusDouble = 0.00;
			Console.WriteLine("Please enter a side  below:");
			string side = Console.ReadLine();
            double sideDouble = 0.00;
            Random rand = new Random();
			double random_value = Convert.ToDouble(rand.Next(5, 50) / 10);//this generates random values instead of broken size
			double temp_val = 0.00;
            int temp_count = 0;
            if (temp_count < 3 && !double.TryParse(radius, out temp_val))
                {
                Console.WriteLine("Your radius is invalid");
                radiusDouble = random_value;
            }
            else { radiusDouble = Convert.ToDouble(radius); }
            if (temp_count < 3 && !double.TryParse(side, out temp_val))
            {
                Console.WriteLine("Your side is invalid");
                sideDouble = random_value;
            }
            else { sideDouble = Convert.ToDouble(side); }
            //bool isvalid = false;
            ////
            //for(int i=0; i<3 && !isvalid; i++)
            //{
            //	Console.Write("Input radius ");
            //	String StrTmp = Console.ReadLine();
            //	isvalid = Double.TryParse(StrTmp, out temp_val);
            //	if((temp_val > 5) || (temp_val < 0.5))
            //		isvalid = false;
            //	else if(!isvalid)
            //		Console.Write("Radius is not valid");
            //}
            //if(!isvalid)
            //{
            //	radius = Convert.ToString(random_value);
            //}

            //if (a == false)
            //{
            //	Console.WriteLine("Your entered value is invalid. Please try again:");
            //}
            //else { }

            //                int temp = 0;
            //if (temp < 3 &&)
            //{ }
            //else { radius = random_value; }

            double roundSquare = Math.Round(Math.PI * Math.Pow(radiusDouble, 2), 2);//this returns square of round
			double quadrateSquare = Math.Round(Math.Pow(sideDouble, 2), 2);//this returns square of quadrate
			Console.WriteLine("Square of the circle with radius {0} is {1}", radiusDouble, roundSquare);
			Console.WriteLine("Square of the quadrate with side {0} is {1}", sideDouble, quadrateSquare);

			if (roundSquare > Math.PI / 2 * quadrateSquare)
			{
				Console.WriteLine("The quadrate fits in the circle");
			}
			else if (roundSquare < Math.PI / 4 * quadrateSquare)
			{
				Console.WriteLine("The circle fits in the quadrate");
			}
			else { Console.WriteLine("The quadrate and the circle are crossed");}
		}
	}
}
