using System.Collections.Generic;

namespace WeatherStation
{
	public class WeatherData : ISubject
	{
		private List<IObserver> _observers = new List<IObserver>();
		private float _temperature;
		private float _humidity;
		private float _pressure;

		public void Register(IObserver observer)
		{
			_observers.Add(observer);
		}

		public void Unregister(IObserver observer)
		{
			_observers.Remove(observer);
		}

		public void Notify()
		{
			foreach (IObserver observer in _observers)
			{
				observer.Update(_temperature, _humidity, _pressure);
			}
		}

		public void UpdateMeasurements(float temperature, float humidity, float pressure)
		{
			_temperature = temperature;
			_humidity = humidity;
			_pressure = pressure;
			measurementsChanged();
		}

		private void measurementsChanged()
		{
			Notify();
		}
	}
}