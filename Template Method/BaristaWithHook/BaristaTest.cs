using System;

namespace BaristaWithHook
{
	public class BaristaTest
	{
		public void Run()
		{
			TeaWithHook teaWithHook = new TeaWithHook();
			CoffeeWithHook coffee = new CoffeeWithHook();

			Console.WriteLine("Preparing tea...");
			teaWithHook.PrepareRecipe();

			Console.WriteLine();

			Console.WriteLine("Preparing coffee...");
			coffee.PrepareRecipe();
		}
	}
}