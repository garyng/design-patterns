using System;

namespace MiniDuckSimulator
{
	public abstract class Duck
	{
		protected IFlyBehavior _flyBehavior;
		protected IQuackBehavior _quackBehavior;

		public abstract void Display();

		public IFlyBehavior FlyBehavior
		{
			get { return _flyBehavior; }
			set { _flyBehavior = value; }
		}

		public IQuackBehavior QuackBehavior
		{
			get { return _quackBehavior; }
			set { _quackBehavior = value; }
		}

		public void Fly()
		{
			_flyBehavior.Fly();
		}

		public void Quack()
		{
			_quackBehavior.Quack();
		}

		public void Swim()
		{
			Console.WriteLine("All duck floats!");
		}
	}
}