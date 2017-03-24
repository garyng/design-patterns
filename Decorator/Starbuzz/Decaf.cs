namespace Starbuzz
{
	public class Decaf : Beverage
	{
		public override string Description { get; } = "Decaf";

		public override double Cost()
		{
			return 1.05;
		}
	}
}