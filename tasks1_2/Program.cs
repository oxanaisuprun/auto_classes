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
			double random_value = Math.Round(Convert.ToDouble(rand.Next(50, 500) / 100),1);//this generates random values instead of broken size
			double temp_val = 0.00;
            int temp_count = 0;
            if (!double.TryParse(radius, out temp_val))//this verifies radius input
            {
                while (temp_count < 3 && !double.TryParse(radius, out temp_val))
                {
                    Console.WriteLine("Your input radius is invalid. Please try again");
                    Console.ReadLine();
                    temp_count++;
                }
                radiusDouble = random_value;
            }
            else { radiusDouble = Convert.ToDouble(radius); }
            if (!double.TryParse(side, out temp_val))//this verifies side input
            {
                while (temp_count < 3 && !double.TryParse(side, out temp_val))
                {
                    Console.WriteLine("Your input side is invalid. Please try again");
                    Console.ReadLine();
                    temp_count++;
                }
                sideDouble = random_value;
            }
            else { sideDouble = Convert.ToDouble(side); }
           
            double roundArea = Math.Round(Math.PI * Math.Pow(radiusDouble, 2), 2);//this returns square of round
			double quadrateArea = Math.Round(Math.Pow(sideDouble, 2), 2);//this returns square of quadrate
			Console.WriteLine("Area of the circle with radius {0} is {1}", radiusDouble, roundArea);
			Console.WriteLine("Area of the quadrate with side {0} is {1}", sideDouble, quadrateArea);

			if (roundArea > Math.PI / 2 * quadrateArea)
			{
				Console.WriteLine("The quadrate fits in the circle");
                Console.ReadKey();
            }
			else if (roundArea < Math.PI / 4 * quadrateArea)
			{
				Console.WriteLine("The circle fits in the quadrate");
                Console.ReadKey();
            }
			else { 
                Console.WriteLine("The quadrate and the circle are crossed");
                Console.ReadKey();
            }
		}
	}
}
