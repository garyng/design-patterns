using System;

namespace MiniDuckSimulator
{
	public class MallardDuck : Duck
	{
		public MallardDuck()
		{
			_flyBehavior = new FlyWithWings();
			_quackBehavior = new Quacks();
		}

		public override void Display()
		{
			Console.WriteLine("I'm a real Mallard Duck");
		}
	}
}