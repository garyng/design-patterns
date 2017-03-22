using System;

namespace MiniDuckSimulator
{
	public class ModelDuck : Duck
	{
		public ModelDuck()
		{
			_flyBehavior = new FlyNoWay();
			_quackBehavior = new Quacks();
		}
		public override void Display()
		{
			Console.WriteLine("I'm a model duck");
		}
	}
}