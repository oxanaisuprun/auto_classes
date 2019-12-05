using System;
namespace tasks1_2
{
	public class Validate
	{
		

		public double ValidateValue(string lenght)
		{
			double temp_val = 0.00;
			int temp_count = 0;
			double lenghtDouble;
			Random rand = new Random();
			double randomValue = Math.Round(Convert.ToDouble(rand.Next(50, 500) / 100),1);//this generates random values instead of broken size

			if (!double.TryParse(lenght, out temp_val))//this verifies value input
			{
				while (temp_count < 3 && (!double.TryParse(lenght, out temp_val))||(double.TryParse(lenght, out temp_val) && Convert.ToDouble(lenght)<0))
				{
					Console.WriteLine("Your input radius is invalid. Please try again");
					Console.ReadLine();
					temp_count++;
				}
				lenghtDouble = randomValue;

			}
			else 
			{ 
				lenghtDouble = Convert.ToDouble(lenght);

			}
			return lenghtDouble;
		}

	}
}

