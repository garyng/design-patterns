using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LazyThreadSafeChocolateBuilder
{
	class Program
	{
		static void Main(string[] args)
		{
			new ChocolateBoilerTest().Run();
			Console.ReadKey();
		}
	}

	public class ChocolateBoilerTest
	{
		public void Run()
		{
			Enumerable.Range(1, 100)
				.ToList()
				.ForEach(i =>
				{
					new Thread(() =>
					{
						ChocolateBoiler boiler = ChocolateBoiler.Instance;
						boiler.Fill();
						boiler.Boil();
						boiler.Drain();
						Console.WriteLine("Done.");
					}).Start();
				});
		}
	}

	public class ChocolateBoiler
	{
		public bool IsEmpty { get; private set; }
		public bool IsBoiled { get; private set; }

		public int Id { get; private set; }

		private ChocolateBoiler()
		{
			IsEmpty = true;
			IsBoiled = false;

			Id = new Random(BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0)).Next(100000);
			Console.WriteLine($"Created boiler #{Id}");
		}

		private static readonly Lazy<ChocolateBoiler> _instance = new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());

		public static ChocolateBoiler Instance => _instance.Value;


		public void Fill()
		{
			if (!IsEmpty) return;
			IsEmpty = false;
			IsBoiled = false;

			Console.WriteLine($"Filled #{Id}.");
		}

		public void Drain()
		{
			if (IsEmpty) return;
			if (!IsBoiled) return;

			IsEmpty = true;

			Console.WriteLine($"Drained #{Id}.");
		}

		public void Boil()
		{
			if (IsEmpty) return;
			if (IsBoiled) return;

			IsBoiled = true;

			Console.WriteLine($"Boiled #{Id}.");
		}
	}
}
