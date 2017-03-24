using System;

namespace Starbuzz
{
	public class StarbuzzCoffee
	{
		public void Run()
		{
			Beverage espresso = new Espresso();
			espresso = new Whip(new Mocha(new Mocha(espresso)));
			Console.WriteLine($"{espresso.Description} ${espresso.Cost()}");
		}
	}
}