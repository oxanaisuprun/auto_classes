using System;

namespace tasks1_2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter a radius below:");
			double radius = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Please enter a side  below:");
			double side = Convert.ToDouble(Console.ReadLine());
			//Random rand = new Random();
			//double random_value;
			//random_value = Convert.ToDouble(rand.Next(5, 50) / 10);//this generates random values instead of broken size
			//double temp_val = 0.00;
			//bool isvalid = false;
			////int temp_count = 0;
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

			double round_square = Math.Round(Math.PI * Math.Pow(radius, 2), 2);//this returns square of round
			double quadrate_square = Math.Round(Math.Pow(side, 2), 2);//this returns square of quadrate
			Console.WriteLine("Square of the circle with radius {0} is {1}", radius, round_square);
			Console.WriteLine("Square of the quadrate with side {0} is {1}", side, quadrate_square);

			if (round_square > Math.PI / 2 * quadrate_square)
			{
				Console.WriteLine("The quadrate fits in the circle");
			}
			else if (round_square < Math.PI / 4 * quadrate_square)
			{
				Console.WriteLine("The circle fits in the quadrate");
			}
			else { Console.WriteLine("The quadrate and the circle are crossed");}
		}
	}
}
