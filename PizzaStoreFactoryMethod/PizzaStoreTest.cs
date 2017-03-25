using System;

namespace PizzaStoreFactoryMethod
{
	public class PizzaStoreTest
	{
		public void Run()
		{
			PizzaStore ny = new NewYorkStylePizzaStore();
			PizzaStore c = new ChicagoStylePizzaStore();


			Console.WriteLine($"Ordered a {ny.OrderPizza("cheese").Description}");
			Console.WriteLine($"Ordered a {c.OrderPizza("clam").Description}");
		}
	}
}