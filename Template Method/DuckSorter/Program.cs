using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DuckSorter
{
	class Program
	{
		static void Main(string[] args)
		{
			new DuckSorterTest().Run();
			Console.ReadKey();
		}
	}

	public class DuckSorterTest
	{
		public void Run()
		{
			List<Duck> ducks = new List<Duck>()
			{
				new Duck("Daffy", 8),
				new Duck("Dewey", 1),
				new Duck("Howard", 4),
				new Duck("Loulie", 6),
				new Duck("Donald", 10),
				new Duck("Huey", 2),
			};

			Console.WriteLine("Before sorting...");
			Console.WriteLine(string.Join("\n", ducks));
			Console.WriteLine();
			Console.WriteLine("After sorting...");
			ducks.Sort();
			Console.WriteLine(String.Join("\n", ducks));
		}
	}

	public class Duck : IComparable<Duck>
	{
		private string _name;
		private int _weight;

		public Duck(string name, int weight)
		{
			_name = name;
			_weight = weight;
		}

		public override string ToString()
		{
			return $"{_name} weighs {_weight}";
		}


		public int CompareTo(Duck other)
		{
			if (_weight < other._weight)
			{
				return -1;
			}
			else if (_weight == other._weight)
			{
				return 0;
			}
			else
			{
				return 1;
			}
		}
	}
}