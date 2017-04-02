using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBarista
{
	class Program
	{
		static void Main(string[] args)
		{
			new Barista().Run();
			Console.ReadKey();
		}
	}

	public class Barista
	{
		public void Run()
		{
			Tea tea = new Tea();
			Coffee coffee = new Coffee();

			Console.WriteLine("Preparing tea...");
			tea.PrepareRecipe();

			Console.WriteLine();

			Console.WriteLine("Preparing coffee...");
			coffee.PrepareRecipe();
		}
	}

	public class Tea
	{
		public void PrepareRecipe()
		{
			boilWater();
			steepTeaBag();
			addLemon();
			pourInCup();
		}

		private void pourInCup()
		{
			Console.WriteLine("Pouring into cup...");
		}

		private void addLemon()
		{
			Console.WriteLine("Adding lemon...");
		}

		private void steepTeaBag()
		{
			Console.WriteLine("Steeping the tea...");
		}

		private void boilWater()
		{
			Console.WriteLine("Boiling water...");
		}
	}

	public class Coffee
	{
		public void PrepareRecipe()
		{
			boilWater();
			brewCoffeeGrinds();
			pourInCup();
			addSugarAndMilk();
		}

		private void boilWater()
		{
			Console.WriteLine("Boiling water...");
		}

		private void brewCoffeeGrinds()
		{
			Console.WriteLine("Dripping Coffee through filter...");
		}

		private void pourInCup()
		{
			Console.WriteLine("Pouring into cup...");
		}

		private void addSugarAndMilk()
		{
			Console.WriteLine("Adding sugar and milk...");
		}
	}

}