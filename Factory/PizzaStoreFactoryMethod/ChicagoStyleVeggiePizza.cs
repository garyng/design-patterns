using System;
using System.Collections.Generic;

namespace PizzaStoreFactoryMethod
{
	public class ChicagoStyleVeggiePizza : Pizza
	{
		public override string Description => "Chicago Deep Dish Veggie Pizza";
		protected override string Dough => "Extra Thick Crust Dough";
		protected override string Sauce => "Plum Tomato Sauce";

		protected override List<string> Toppings
			=> new List<string>() {"Black Olives", "Spinach", "Eggplant", "Shredded Mozzarella Cheese"};

		public override void Cut()
		{
			Console.WriteLine("Cutting the pizza into square slices");
		}
	}
}