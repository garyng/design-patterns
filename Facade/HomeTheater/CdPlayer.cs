using System;

namespace HomeTheater
{
	public class CdPlayer
	{
		private string _description;
		private int _currentTrack;
		private Amplifier _amplifier;
		private string _title;

		public CdPlayer(string description, Amplifier amplifier)
		{
			_description = description;
			_amplifier = amplifier;
		}

		public void On()
		{
			Console.WriteLine($"[{_description}] on.");
		}

		public void Off()
		{
			Console.WriteLine($"[{_description}] off.");
		}

		public void Eject()
		{
			Console.WriteLine($"[{_description}] ejected.");
		}

		public void Play(string title)
		{
			_title = title;
			Console.WriteLine($"[{_description}] playing \"{title}\".");
		}

		public void Play(int track)
		{
			if (string.IsNullOrWhiteSpace(_title))
			{
				Console.WriteLine($"[{_description}] can't play track {_currentTrack}, no CD inserted.");
			}
			else
			{
				_currentTrack = track;
				Console.WriteLine($"[{_description}] playing track {_currentTrack}.");
			}
		}

		public void Stop()
		{
			_currentTrack = 0;
			Console.WriteLine($"[{_description}] stopped.");
		}

		public void Pause()
		{
			Console.WriteLine($"[{_description}] paused {_title}.");
		}

		public override string ToString()
		{
			return _description;
		}
	}
}