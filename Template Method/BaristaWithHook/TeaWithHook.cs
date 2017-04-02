using System;

namespace BaristaWithHook
{
	public class TeaWithHook : CaffeineBeverage
	{
		protected override void Brew()
		{
			Console.WriteLine("Steeping the tea...");
		}

		protected override void AddCondiments()
		{
			Console.WriteLine("Adding lemon...");
		}

		public override bool IsCustomerWantsCondiments()
		{
			Console.WriteLine("Would you like lemon with your tea? [y/n]");
			return Console.ReadLine() == "y";
		}
	}
}