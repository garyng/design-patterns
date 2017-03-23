namespace WeatherStation
{
	public interface ISubject
	{
		void Register(IObserver observer);
		void Unregister(IObserver observer);
		void Notify();
	}
}