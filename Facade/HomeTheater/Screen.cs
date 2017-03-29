using System;

namespace HomeTheater
{
	public class Screen
	{
		readonly string _description;

		public Screen(String description)
		{
			this._description = description;
		}

		public void Up()
		{
			Console.WriteLine($"[{_description}] going up.");
		}

		public void Down()
		{
			Console.WriteLine($"[{_description}] going down.");
		}

		public override string ToString()
		{
			return _description;
		}
	}
}