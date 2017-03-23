using System;
using System.CodeDom;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
	class Program
	{
		static void Main(string[] args)
		{
			new WeatherStation().Run();
			Console.ReadKey();
		}
	}

	public class WeatherStation
	{
		public void Run()
		{
			WeatherData wd = new WeatherData();

			CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(wd);
			StatisticsDisplay statisticsDisplay = new StatisticsDisplay(wd);
			ForecastDisplay forecastDisplay = new ForecastDisplay(wd);
			HeatIndexDisplay heheatDisplay = new HeatIndexDisplay(wd);

			wd.UpdateMeasurements(80, 65, 30.4f);
			wd.UpdateMeasurements(82, 70, 29.2f);
			wd.UpdateMeasurements(78, 90, 29.2f);
		}
	}
	
}