using System;

namespace SimpleRemoteControl
{
	public class Garage
	{
		public void Up()
		{
			Console.WriteLine("Garage door up.");
		}

		public void Down()
		{
			Console.WriteLine("Garage door down.");
		}

		public void Stop()
		{
			Console.WriteLine("Garage door stop.");
		}

		public void LightOn()
		{
			Console.WriteLine("Garage door light on.");
		}

		public void LightOff()
		{
			Console.WriteLine("Garage door light off.");
		}


	}
}