using System;

namespace DuckAdapter
{
	public class DuckTester
	{
		public void Run()
		{
			MallardDuck mallardDuck = new MallardDuck();
			WildTurkey wildTurkey = new WildTurkey();

			IDuck turkeyDuck = new TurkeyAdapter(wildTurkey);

			Console.WriteLine("Testing turkey...");
			wildTurkey.Gobble();
			wildTurkey.Fly();

			Console.WriteLine();
			Console.WriteLine("Testing duck...");
			testDuck(mallardDuck);

			Console.WriteLine();
			Console.WriteLine("Testing turkey duck...");
			testDuck(turkeyDuck);
		}

		private void testDuck(IDuck duck)
		{
			duck.Quack();
			duck.Fly();
		}
	}
}