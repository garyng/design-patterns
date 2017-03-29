using System;

namespace HomeTheater
{
	public class PopcornPopper
	{
		private readonly string _description;

		public PopcornPopper(String description)
		{
			this._description = description;
		}

		public void On()
		{
			Console.WriteLine($"[{_description}] on.");
		}

		public void Off()
		{
			Console.WriteLine($"[{_description}] off.");
		}

		public void Pop()
		{
			Console.WriteLine($"[{_description}] popping popcorn!");
		}


		public override string ToString()
		{
			return _description;
		}
	}
}