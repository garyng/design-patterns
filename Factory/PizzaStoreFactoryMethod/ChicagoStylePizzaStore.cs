namespace PizzaStoreFactoryMethod
{
	public class ChicagoStylePizzaStore : PizzaStore
	{
		protected override Pizza CreatePizza(string type)
		{
			Pizza pizza = null;
			switch (type.ToLower())
			{
				case "cheese":
					pizza = new ChicagoStyleCheesePizza();
					break;
				case "pepperoni":
					pizza = new ChicagoStylePepperoniPizza();
					break;
				case "clam":
					pizza = new ChicagoStyleClamPizza();
					break;
				case "veggie":
					pizza = new ChicagoStyleVeggiePizza();
					break;
			}

			return pizza;
		}
	}
}