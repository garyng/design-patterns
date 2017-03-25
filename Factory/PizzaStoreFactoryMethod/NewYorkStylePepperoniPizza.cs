using System.Collections.Generic;

namespace PizzaStoreFactoryMethod
{
	public class NewYorkStylePepperoniPizza : Pizza
	{
		public override string Description => "New York Style Pepperoni Pizza";
		protected override string Dough => "Thin Crust Dough";
		protected override string Sauce => "Marinara Sauce";

		protected override List<string> Toppings
			=> new List<string>() {"Grated Reggiano Cheese", "Sliced Pepperoni", "Garlic", "Onion", "Mushrooms", "Red Pepper"};
	}
}