namespace Starbuzz
{
	public class Whip : CondimentDecorator
	{
		private readonly Beverage _beverage;

		public Whip(Beverage beverage)
		{
			_beverage = beverage;
		}

		public override string Description => _beverage.Description + ", Whip";

		public override double Cost()
		{
			return _beverage.Cost() + 0.10;
		}
	}
}