using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
	class Program
	{
		static void Main(string[] args)
		{
			new MiniDuckSimulator().Run();
			Console.ReadKey();
		}
	}


	public class MiniDuckSimulator
	{
		public void Run()
		{
			Duck mallardDuck = new MallardDuck();
			mallardDuck.Quack();
			mallardDuck.Fly();

			Duck modelDuck = new ModelDuck();
			modelDuck.Quack();
			modelDuck.Fly();
			Console.WriteLine("Changing model duck's flying behavior...");
			modelDuck.FlyBehavior = new FlyRocketPowered();
			modelDuck.Fly();

		}
	}
}