using System;

namespace MiniDuckSimulator
{
	public class MuteQuack : IQuackBehavior
	{
		public void Quack()
		{
			Console.WriteLine("<< Silence >>");
		}
	}
}