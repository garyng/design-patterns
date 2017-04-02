using System;

namespace Barista
{
	public class Tea : CaffeineBeverage
	{
		protected override void Brew()
		{
			Console.WriteLine("Steeping the tea...");
		}

		protected override void AddCondiments()
		{
			Console.WriteLine("Adding lemon...");
		}
	}
}