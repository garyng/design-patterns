using System;

namespace RemoteControl
{
	public class Stereo
	{
		private string _location;

		public Stereo(string location)
		{
			_location = location;
		}


		public void On()
		{
			Console.WriteLine($"[{_location}] Stereo is on.");
		}

		public void Off()
		{
			Console.WriteLine($"[{_location}] Stereo is off.");
		}

		public void SetCD()
		{
			Console.WriteLine($"[{_location}] Stereo is set for CD input.");
		}

		public void SetDVD()
		{
			Console.WriteLine($"[{_location}] Stereo is set for DVD input.");
		}

		public void SetRadio()
		{
			Console.WriteLine($"[{_location}] Stereo is set to radio mode.");
		}

		public void SetVolume(int volume)
		{
			Console.WriteLine($"[{_location}] Stereo volume set to {volume}");
		}
	}
}