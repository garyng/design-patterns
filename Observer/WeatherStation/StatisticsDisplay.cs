using System;

namespace WeatherStation
{
	public class StatisticsDisplay : IDisplayElement, IObserver
	{
		private readonly WeatherData _weatherData;
		private float _tempSum = 0.0f;
		private int _tempReadingsNum = 0;
		private float _maxTemp = float.MinValue;
		private float _minTemp = float.MaxValue;

		public StatisticsDisplay(WeatherData weatherData)
		{
			_weatherData = weatherData;
			_weatherData.Register(this);
		}

		public void Update(float temp, float humidity, float pressure)
		{
			_tempSum += temp;
			_tempReadingsNum++;
			_maxTemp = Math.Max(temp, _maxTemp);
			_minTemp = Math.Min(temp, _minTemp);

			Display();
		}

		public void Display()
		{
			Console.WriteLine($"Avg/Min/Max Temperature: {_tempSum / _tempReadingsNum}/{_minTemp}/{_maxTemp}");
		}
	}
}