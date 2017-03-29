using System;

namespace HomeTheater
{
	public class Tuner
	{
		private readonly string _description;
		private Amplifier _amplifier;
		private double _frequency;

		public Tuner(string description, Amplifier amplifier)
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

		public void SetFrequency(double frequency)
		{
			Console.WriteLine($"[{_description}] setting frequency to {frequency}");
			_frequency = frequency;
		}

		public void SetAm()
		{
			Console.WriteLine($"[{_description}] setting AM mode.");
		}

		public void SetFm()
		{
			Console.WriteLine($"[{_description}] setting FM mode.");
		}

		public override string ToString()
		{
			return _description;
		}
	}
}