using System;

namespace MiniDuckSimulator
{
	public class Quacks : IQuackBehavior
	{
		public void Quack()
		{
			Console.WriteLine("Quack");
		}
	}
}