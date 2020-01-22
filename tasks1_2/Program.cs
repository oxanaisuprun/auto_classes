using System;

namespace tasks1_2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Validate validLenght = new Validate();

			Console.WriteLine("Enter a radius value: ");
			Circle circle = new Circle(validLenght.ValidateValue());

			Console.WriteLine("Enter a side lenght: ");
			Quadrate quadrate = new Quadrate(validLenght.ValidateValue());

			Console.WriteLine($"Circle area with radius {circle.Radius} is {circle.RoundArea}");
			Console.WriteLine($"Square area with side {quadrate.Side} is {quadrate.QuadrateArea}");

			Compare compareAreas = new Compare ();
			Console.WriteLine(compareAreas.Comparing(circle.RoundArea, quadrate.QuadrateArea));
		}
	}
}
