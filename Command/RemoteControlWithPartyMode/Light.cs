using System;

namespace RemoteControlWithPartyMode
{
	public class Light
	{
		private string _location;
		private int _brightness;

		public int Brightness
		{
			get { return _brightness; }
			set
			{
				_brightness = value;
				if (value == 0)
				{
					Off();
				}
				else
				{
					Console.WriteLine($"Light set to {Brightness}% brightness");
				}
			}
		}

		public Light(string location)
		{
			_location = location;
		}

		public void On()
		{
			Brightness = 100;
			Console.WriteLine($"[{_location}] Light on.");
		}

		public void Off()
		{
			Console.WriteLine($"[{_location}] Light off.");
		}
	}
}