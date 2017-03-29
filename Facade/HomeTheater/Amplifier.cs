using System;

namespace HomeTheater
{
	public class Amplifier
	{
		private readonly string _description;

		public Amplifier(string description)
		{
			_description = description;
		}

		public void On()
		{
			Console.WriteLine($"[{_description}] on.");
		}

		public void Off()
		{
			Console.WriteLine($"[{_description}] off.");
		}

		public void SetStereoSound()
		{
			Console.WriteLine($"[{_description}] stereo mode on.");
		}

		public void SetSurroundSound()
		{
			Console.WriteLine($"[{_description}] surround sound on (5 speakers, 1 subwoofer).");
		}

		public void SetVolume(int level)
		{
			Console.WriteLine($"[{_description}] setting volume to {level}");
		}

		public void SetTuner(Tuner tuner)
		{
			Console.WriteLine($"[{_description}] setting tuner to {tuner}");
		}

		public void SetDvd(DvdPlayer dvdPlayer)
		{
			Console.WriteLine($"[{_description}] setting DVD player to {dvdPlayer}");
		}

		public void SetCd(CdPlayer cdPlayer)
		{
			Console.WriteLine($"[{_description}] settings CD player to {cdPlayer}");
		}

		public override string ToString()
		{
			return _description;
		}
	}
}