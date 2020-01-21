using System;
namespace tasks1_2
{
	public class Validate
	{
		

		public double ValidateValue()
		{
			double inputValue;
			Random rand = new Random();
			// this generates random values instead of broken size
			double randomValue = Math.Round(Convert.ToDouble(rand.Next(50, 500) / 100),1);

			for (int i = 0; i <= 3;)
			{
				//var enteredValue  = Console.ReadLine();
				bool isValid = double.TryParse(Console.ReadLine(), out inputValue);
				if (isValid && inputValue > 0)
				{
					return  Math.Round(inputValue, 2);
				}
				else
				{
					
					Console.WriteLine("Please try again: ");
					++i;
						
				}

			}return  Math.Round(randomValue);
		}

	}
}


