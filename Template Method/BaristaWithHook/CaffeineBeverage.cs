using System;

namespace BaristaWithHook
{
	public abstract class CaffeineBeverage
	{
		public void PrepareRecipe()
		{
			BoilWater();
			Brew();
			PourInCup();
			if (IsCustomerWantsCondiments())
			{
				AddCondiments();
			}
		}

		private void BoilWater()
		{
			Console.WriteLine("Boiling water...");
		}

		private void PourInCup()
		{
			Console.WriteLine("Pouring into cup...");
		}

		/// <summary>
		/// A hook
		/// </summary>
		/// <returns></returns>
		public virtual bool IsCustomerWantsCondiments()
		{
			return true;
		}

		protected abstract void Brew();

		protected abstract void AddCondiments();
	}
}