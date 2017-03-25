namespace SimplePizzaFactory
{
	public class PizzaStore
	{
		private readonly SimplePizzaFactory _simplePizzaFactory;

		public PizzaStore(SimplePizzaFactory simplePizzaFactory)
		{
			_simplePizzaFactory = simplePizzaFactory;
		}

		public Pizza OrderPizza(string type)
		{
			Pizza pizza = _simplePizzaFactory.CreatePizza(type);

			pizza.Prepare();
			pizza.Bake();
			pizza.Cut();
			pizza.Box();

			return pizza;
		}
	}
}