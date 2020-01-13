using System;
namespace tasks1_2
{
	public class Validate
	{
		

		public double ValidateValue(string lenght)
		{
			double lenghtDouble;
			Random rand = new Random();
			double randomValue = Math.Round(Convert.ToDouble(rand.Next(50, 500) / 100),1);//this generates random values instead of broken size

			for (int i = 1; i < 3; i++)
			{
				var enteredValue = lenght;
				bool isValid = double.TryParse(enteredValue, out lenghtDouble);
				if (isValid && lenghtDouble > 0)
				{
					return Math.Round(lenghtDouble, 2);
				}

				if (!isValid)
				{
					Console.WriteLine("Please try again");
				}

				if (isValid && lenghtDouble <= 0)
				{
					Console.WriteLine("Please try again");
				}
			}
			return Math.Round(randomValue);
		}

	}
}

