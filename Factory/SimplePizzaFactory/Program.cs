using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePizzaFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			new PizzaStore(new SimplePizzaFactory()).OrderPizza("cheese");
			Console.WriteLine("Done!");
			Console.ReadKey();
		}
	}
}