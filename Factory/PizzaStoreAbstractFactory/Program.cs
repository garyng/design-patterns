using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(new NewYorkPizzaStore().OrderPizza("clam"));
			Console.WriteLine();
			Console.WriteLine(new NewYorkPizzaStore().OrderPizza("cheese"));
			Console.WriteLine();
			Console.WriteLine(new ChicagoPizzaStore().OrderPizza("veggie"));
			Console.WriteLine();
			Console.WriteLine(new ChicagoPizzaStore().OrderPizza("pepperoni"));
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}