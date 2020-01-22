using System;
namespace tasks1_2
{
	public class Validate
	{
		//this verifies if input value is valid or not
		public double ValidateValue()
		{
			double inputValue;
			Random rand = new Random();
			// this generates random values instead of broken ones
			double randomValue = Math.Round(Convert.ToDouble(rand.Next(50, 500) / 100),1);

			for (int i = 0; i < 3; i++)
			{
				bool isValid = double.TryParse(Console.ReadLine(), out inputValue);
				if (isValid && inputValue > 0)
				{
					return  Math.Round(inputValue, 2);
				}
				else
				{
					if (i == 2)
					{
						break;
					}
					Console.WriteLine("Please try again: ");
				}

			}return  Math.Round(randomValue);
		}

	}
}


