using System;
using System.Collections.Generic;

namespace PizzaStoreFactoryMethod
{
	public class ChicagoStyleCheesePizza : Pizza
	{
		public override string Description => "Chicago Style Deep Dish Cheese Pizza";
		protected override string Dough => "Extra Thick Crust Dough";
		protected override string Sauce => "Plum Tomato Sauce";
		protected override List<string> Toppings => new List<string>() {"Shredded Mozzarella Cheese"};

		public override void Cut()
		{
			Console.WriteLine("Cutting the pizza into square slices");
		}
	}
}