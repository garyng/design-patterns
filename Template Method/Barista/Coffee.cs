using System;

namespace Barista
{
	public class Coffee : CaffeineBeverage
	{
		protected override void Brew()
		{
			Console.WriteLine("Dripping coffee through filter...");
		}

		protected override void AddCondiments()
		{
			Console.WriteLine("Adding sugar and milk...");
		}
	}
}