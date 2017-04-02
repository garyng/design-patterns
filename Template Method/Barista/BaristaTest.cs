using System;

namespace Barista
{
	public class BaristaTest
	{
		public void Run()
		{
			Tea tea = new Tea();
			Coffee coffee = new Coffee();

			Console.WriteLine("Preparing tea...");
			tea.PrepareRecipe();

			Console.WriteLine();

			Console.WriteLine("Preparing coffee...");
			coffee.PrepareRecipe();
		}
	}
}