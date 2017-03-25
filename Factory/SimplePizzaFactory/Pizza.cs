using System;

namespace SimplePizzaFactory
{
	public class Pizza
	{
		public void Prepare()
		{
			Console.WriteLine("Preparing...");
		}

		public void Bake()
		{
			Console.WriteLine("Baking...");
		}

		public void Cut()
		{
			Console.WriteLine("Cutting...");
		}

		public void Box()
		{
			Console.WriteLine("Boxing...");
		}
	}
}