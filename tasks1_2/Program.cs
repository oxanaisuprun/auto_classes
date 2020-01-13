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
			double newRadius = validRadius.ValidateValue(radius);
			Console.WriteLine("Please enter a side  below:");
			Validate validSide = new Validate();
			string side = Console.ReadLine();
			Quadrate quadrate = new Quadrate(validSide.ValidateValue(side));
			double newSide = validSide.ValidateValue(side);

			Console.WriteLine($"The area of circle with radius {newRadius} is {circle.roundArea}");
			Console.WriteLine($"The area of quadrate with the side {newSide} is {quadrate.quadrateArea}");
            
			Compare compareAreas = new Compare ();
			Console.WriteLine(compareAreas.Comparing(circle.roundArea, quadrate.quadrateArea));

		}
	}
}
