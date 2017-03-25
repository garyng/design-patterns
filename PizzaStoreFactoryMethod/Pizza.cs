using System;
using System.Collections.Generic;

namespace PizzaStoreFactoryMethod
{
	public class Pizza
	{
		public virtual string Description => "Unknown Pizza";
		protected virtual string Dough => "Unknown Dough";
		protected virtual string Sauce => "Unknown Sauce";
		protected virtual List<string> Toppings => new List<string>();

		public virtual void Prepare()
		{
			Console.WriteLine($"Preparing {Description}...");
			Console.WriteLine($"Adding toppings: {string.Join(", ", Toppings)}");
		}

		public virtual void Bake()
		{
			Console.WriteLine("Baking...");
		}

		public virtual void Cut()
		{
			Console.WriteLine("Cutting...");
		}

		public virtual void Box()
		{
			Console.WriteLine("Boxing...");
		}
	}
}