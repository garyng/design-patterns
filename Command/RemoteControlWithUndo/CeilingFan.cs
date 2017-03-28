using System;

namespace RemoteControlWithUndo
{
	public class CeilingFan
	{
		public enum Level
		{
			Off,
			Low,
			Medium,
			High
		}

		private string _location;
		public Level Speed { get; private set; } = Level.Off;

		public CeilingFan(string location)
		{
			_location = location;
		}

		public void High()
		{
			Speed = Level.High;
			Console.WriteLine($"[{_location}] Ceiling fan is on high");
		}

		public void Medium()
		{
			Speed = Level.Medium;
			Console.WriteLine($"[{_location}] Ceiling fan is on medium");
		}

		public void Low()
		{
			Speed = Level.Low;
			Console.WriteLine($"[{_location}] Ceiling fan is on low");
		}

		public void Off()
		{
			Speed = Level.Off;
			Console.WriteLine($"[{_location}] Ceiling fan is off");
		}
	}
}