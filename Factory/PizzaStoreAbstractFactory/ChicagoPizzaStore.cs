namespace PizzaStoreAbstractFactory
{
	public class ChicagoPizzaStore : PizzaStore
	{
		private IPizzaIngredientFactory _ingredientFactory = new NewYorkIngredientFactory();

		protected override Pizza CreatePizza(string type)
		{
			Pizza pizza = null;
			switch (type.ToLower())
			{
				case "cheese":
					pizza = new CheesePizza(_ingredientFactory);
					pizza.Name = "Chicago Style Cheese Pizza";
					break;
				case "pepperoni":
					pizza = new PepperoniPizza(_ingredientFactory);
					pizza.Name = "Chicago Style Pepperoni Pizza";
					break;
				case "clam":
					pizza = new ClamPizza(_ingredientFactory);
					pizza.Name = "Chicago Style Clam Pizza";
					break;
				case "veggie":
					pizza = new VeggiePizza(_ingredientFactory);
					pizza.Name = "Chicago Style Veggie Pizza";
					break;
			}

			return pizza;
		}
	}
}