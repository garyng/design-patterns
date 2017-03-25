using System.Collections.Generic;

namespace PizzaStoreFactoryMethod
{
	public class NewYorkStyleCheesePizza : Pizza
	{
		public override string Description => "New York Style Sauce and Cheese Pizza";
		protected override string Dough => "Thin Crust Dough";
		protected override string Sauce => "Marinara Sauce";
		protected override List<string> Toppings => new List<string>() {"Grated Reggiano Cheese"};
	}
}