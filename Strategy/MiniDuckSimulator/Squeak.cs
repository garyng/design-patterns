using System;

namespace MiniDuckSimulator
{
	public class Squeak : IQuackBehavior
	{
		public void Quack()
		{
			Console.WriteLine("Squeak");
		}
	}
}