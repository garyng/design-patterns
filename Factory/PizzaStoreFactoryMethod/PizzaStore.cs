namespace PizzaStoreFactoryMethod
{
	public abstract class PizzaStore
	{
		protected abstract Pizza CreatePizza(string type);

		public Pizza OrderPizza(string type)
		{
			Pizza pizza = CreatePizza(type);

			pizza.Prepare();
			pizza.Bake();
			pizza.Cut();
			pizza.Box();

			return pizza;
		}
	}
}