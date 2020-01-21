using System;

namespace tasks1_2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Validate validLenght = new Validate();

			Console.Write("Enter a radius value: ");
			Circle circle = new Circle(validLenght.ValidateValue());

			Console.Write("Enter a side lenght: ");
			Quadrate quadrate = new Quadrate(validLenght.ValidateValue());

			Console.WriteLine($"Circle area is {circle.RoundArea}");
			Console.WriteLine($"Square area is {quadrate.QuadrateArea}");

			Compare compareAreas = new Compare ();
			Console.WriteLine(compareAreas.Comparing(circle.RoundArea, quadrate.QuadrateArea));
		}
	}
}
