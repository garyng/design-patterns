using System.Collections.Generic;

namespace PizzaStoreFactoryMethod
{
	public class NewYorkStyleVeggiePizza : Pizza
	{
		public override string Description => "New York Style Veggie Pizza";
		protected override string Dough => "Thin Crust Dough";
		protected override string Sauce => "Marinara Sauce";

		protected override List<string> Toppings
			=> new List<string>() {"Grated Reggiano Cheese", "Garlic", "Onion", "Mushrooms", "Red Pepper"};
	}
}