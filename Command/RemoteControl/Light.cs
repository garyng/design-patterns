using System;

namespace RemoteControl
{
	public class Light
	{
		private string _location;

		public Light(string location)
		{
			_location = location;
		}

		public void On()
		{
			Console.WriteLine($"[{_location}] Light on.");
		}

		public void Off()
		{
			Console.WriteLine($"[{_location}] Light off.");
		}
	}
}