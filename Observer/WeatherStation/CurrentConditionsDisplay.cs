using System;

namespace WeatherStation
{
	public class CurrentConditionsDisplay : IDisplayElement, IObserver
	{
		private readonly WeatherData _weatherData;
		private float _temp;
		private float _humidity;
		private float _pressure;

		public CurrentConditionsDisplay(WeatherData weatherData)
		{
			_weatherData = weatherData;
			_weatherData.Register(this);
		}

		public void Update(float temp, float humidity, float pressure)
		{
			_pressure = pressure;
			_humidity = humidity;
			_temp = temp;
			Display();
		}

		public void Display()
		{
			Console.WriteLine($"Current Conditions: {_temp}F {_humidity}% humidity");
		}
	}
}