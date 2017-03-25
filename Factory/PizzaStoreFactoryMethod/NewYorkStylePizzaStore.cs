namespace PizzaStoreFactoryMethod
{
	public class NewYorkStylePizzaStore : PizzaStore
	{
		protected override Pizza CreatePizza(string type)
		{
			Pizza pizza = null;
			switch (type.ToLower())
			{
				case "cheese":
					pizza = new NewYorkStyleCheesePizza();
					break;
				case "pepperoni":
					pizza = new NewYorkStylePepperoniPizza();
					break;
				case "clam":
					pizza = new NewYorkStyleClamPizza();
					break;
				case "veggie":
					pizza = new NewYorkStyleVeggiePizza();
					break;
			}

			return pizza;
		}
	}
}