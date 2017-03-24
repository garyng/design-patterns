namespace Starbuzz
{
	public class Espresso : Beverage
	{
		public override string Description { get; } = "Espresso";

		public override double Cost()
		{
			return 1.99;
		}
	}
}