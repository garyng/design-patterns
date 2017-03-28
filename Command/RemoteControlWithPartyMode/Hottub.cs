using System;

namespace RemoteControlWithPartyMode
{
	public class Hottub
	{
		private bool _on = false;
		private int _temperature = int.MinValue;

		public void On()
		{
			_on = true;
			Console.WriteLine("Hottub on.");
		}

		public void Off()
		{
			_on = false;
			Console.WriteLine("Hottub off.");
		}

		public void Circulate()
		{
			if (_on)
			{
				Console.WriteLine("Hottub bubbling...");
			}
		}

		public void JetsOn()
		{
			if (_on)
			{
				Console.WriteLine("Hottub jets on.");
			}
		}

		public void JetsOff()
		{
			Console.WriteLine("Hottub jets off.");
		}

		public void SetTemperature(int temperature)
		{
			if (temperature > _temperature)
			{
				Console.WriteLine($"Hottub is heating to {temperature} degrees.");
			}
			else
			{
				Console.WriteLine($"Hottub is cooling to {temperature} degrees.");
			}
			_temperature = temperature;
		}
	}
}