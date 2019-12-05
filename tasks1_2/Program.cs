using System;

namespace tasks1_2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Validate validRadius = new Validate();
			Console.WriteLine("Please enter a radius below:");
			string radius = Console.ReadLine();
			Circle circle = new Circle(validRadius.ValidateValue(radius));
			Console.WriteLine("Please enter a side  below:");
			Validate validSide = new Validate();
			string side = Console.ReadLine();
			Quadrate quadrate = new Quadrate(validSide.ValidateValue(side));

			Console.WriteLine($"The area of circle with radius {radius} is {circle.roundArea}");
			Console.WriteLine($"The area of quadrate with the side {side} is {quadrate.quadrateArea}");
            
			//Compare compareAreas = new Compare (circle.roundArea, quadrate.quadrateArea);
			//compareAreas.comparingResult();

		}
	}
}
