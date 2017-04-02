using System;

namespace Barista
{
	public abstract class CaffeineBeverage
	{
		public void PrepareRecipe()
		{
			BoilWater();
			Brew();
			PourInCup();
			AddCondiments();
		}

		private void BoilWater()
		{
			Console.WriteLine("Boiling water...");
		}

		private void PourInCup()
		{
			Console.WriteLine("Pouring into cup...");
		}

		protected abstract void Brew();

		protected abstract void AddCondiments();

	}
}