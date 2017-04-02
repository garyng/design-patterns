using System;

namespace BaristaWithHook
{
	public class CoffeeWithHook : CaffeineBeverage
	{
		protected override void Brew()
		{
			Console.WriteLine("Dripping coffee through filter...");
		}

		protected override void AddCondiments()
		{
			Console.WriteLine("Adding sugar and milk...");
		}

		public override bool IsCustomerWantsCondiments()
		{
			Console.WriteLine("Would you like milk and sugar with your coffee? [y/n]");
			return Console.ReadLine() == "y";
		}
	}
}