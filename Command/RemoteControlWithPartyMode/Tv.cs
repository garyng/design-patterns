using System;

namespace RemoteControlWithPartyMode
{
	public class Tv
	{
		private string _location;

		public Tv(string location)
		{
			_location = location;
		}

		public void On()
		{
			Console.WriteLine($"[{_location}] TV on.");
		}

		public void Off()
		{
			Console.WriteLine($"[{_location}] Tv off.");
		}

		public void SetDvd()
		{
			Console.WriteLine($"{_location} Tv set for DVD.");
		}
	}
}