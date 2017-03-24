namespace Starbuzz
{
	public class SteamMilk : CondimentDecorator
	{
		private readonly Beverage _beverage;

		public SteamMilk(Beverage beverage)
		{
			_beverage = beverage;
		}

		public override string Description => _beverage.Description + ", Steam Milk";

		public override double Cost()
		{
			return _beverage.Cost() + 0.10;
		}
	}
}