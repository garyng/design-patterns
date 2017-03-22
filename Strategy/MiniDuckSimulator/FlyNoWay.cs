using System;

namespace MiniDuckSimulator
{
	public class FlyNoWay : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("I can't fly...");
		}
	}
}