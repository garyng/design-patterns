namespace Starbuzz
{
	public abstract class Beverage
	{
		public virtual string Description { get; } = "Unknown Beverage";
		public abstract double Cost();
	}
}