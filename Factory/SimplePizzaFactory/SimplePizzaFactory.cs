namespace SimplePizzaFactory
{
	public class SimplePizzaFactory
	{
		public Pizza CreatePizza(string type)
		{
			Pizza pizza = null;
			switch (type.ToLower())
			{
				case "cheese":
					pizza = new CheesePizza();
					break;
				case "pepperoni":
					pizza = new PepperoniPizza();
					break;
				case "clam":
					pizza = new ClamPizza();
					break;
				case "veggie":
					pizza = new VeggiePizza();
					break;
			}

			return pizza;
		}
	}
}