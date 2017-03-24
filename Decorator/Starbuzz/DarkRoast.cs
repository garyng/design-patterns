namespace Starbuzz
{
	public class DarkRoast : Beverage
	{
		public override string Description { get; } = "Dark Roast";

		public override double Cost()
		{
			return 0.99;
		}
	}
}