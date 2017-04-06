using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
	class Program
	{
		static void Main(string[] args)
		{
			new DuckSimulator().Run();
			Console.ReadKey();
		}
	}

	public class DuckSimulator
	{
		public void Run()
		{
			CountingDuckFactory duckFactory = new CountingDuckFactory();
			IQuackable redHeadDuck = duckFactory.CreateRedHeadDuck();
			IQuackable duckCall = duckFactory.CreateDuckCall();
			IQuackable rubberDuck = duckFactory.CreateRubberDuck();
			IQuackable gooseAdapter = new GooseAdapter(new Goose());

			Flock flockOfMallards = new Flock();
			flockOfMallards.Add(duckFactory.CreateMallardDuck());
			flockOfMallards.Add(duckFactory.CreateMallardDuck());
			flockOfMallards.Add(duckFactory.CreateMallardDuck());
			flockOfMallards.Add(duckFactory.CreateMallardDuck());

			Flock flockOfDucks = new Flock();
			flockOfDucks.Add(redHeadDuck);
			flockOfDucks.Add(duckCall);
			flockOfDucks.Add(rubberDuck);
			flockOfDucks.Add(gooseAdapter);
			flockOfDucks.Add(flockOfMallards);


			flockOfDucks.RegisterObserver(new Quackologist());

			Console.WriteLine("--- Duck Simulator ---");
			Simulate(flockOfDucks);
			Console.WriteLine($"{QuackCounterDecorator.NumberOfQuacks} quacks recorded");
		}

		private void Simulate(IQuackable quackable)
		{
			quackable.Quack();
		}
	}

	public interface IQuackable : IQuackableObservable
	{
		void Quack();
	}

	public class MallardDuck : IQuackable
	{
		private readonly Observable _observable;

		public MallardDuck()
		{
			_observable = new Observable(this);
		}

		public void NotifyObservers()
		{
			_observable.NotifyObservers();
		}

		public void RegisterObserver(IObserver observer)
		{
			_observable.RegisterObserver(observer);
		}

		public void Quack()
		{
			Console.WriteLine("Quack");
			NotifyObservers();
		}

		public override string ToString()
		{
			return "Mallard Duck";
		}
	}

	public class RedHeadDuck : IQuackable
	{
		private readonly Observable _observable;

		public RedHeadDuck()
		{
			_observable = new Observable(this);
		}

		public void NotifyObservers()
		{
			_observable.NotifyObservers();
		}

		public void RegisterObserver(IObserver observer)
		{
			_observable.RegisterObserver(observer);
		}

		public void Quack()
		{
			Console.WriteLine("Quack");
			NotifyObservers();
		}

		public override string ToString()
		{
			return "Red Head Duck";
		}
	}

	public class DuckCall : IQuackable
	{
		private readonly Observable _observable;

		public DuckCall()
		{
			_observable = new Observable(this);
		}

		public void NotifyObservers()
		{
			_observable.NotifyObservers();
		}

		public void RegisterObserver(IObserver observer)
		{
			_observable.RegisterObserver(observer);
		}

		public void Quack()
		{
			Console.WriteLine("Kwak");
			NotifyObservers();
		}

		public override string ToString()
		{
			return "Duck Call";
		}
	}

	public class RubberDuck : IQuackable
	{
		private readonly Observable _observable;

		public RubberDuck()
		{
			_observable = new Observable(this);
		}

		public void NotifyObservers()
		{
			_observable.NotifyObservers();
		}

		public void RegisterObserver(IObserver observer)
		{
			_observable.RegisterObserver(observer);
		}


		public void Quack()
		{
			Console.WriteLine("Squeak");
			NotifyObservers();
		}

		public override string ToString()
		{
			return "Rubber Duck";
		}
	}

	public class Goose
	{
		public void Honk()
		{
			Console.WriteLine("Honk");
		}
	}

	public class GooseAdapter : IQuackable
	{
		private readonly Goose _goose;

		private readonly Observable _observable;


		public void NotifyObservers()
		{
			_observable.NotifyObservers();
		}

		public void RegisterObserver(IObserver observer)
		{
			_observable.RegisterObserver(observer);
		}


		public GooseAdapter(Goose goose)
		{
			_goose = goose;
			_observable = new Observable(this);
		}

		public void Quack()
		{
			_goose.Honk();
			NotifyObservers();
		}

		public override string ToString()
		{
			return "Goose Duck";
		}
	}

	public class QuackCounterDecorator : IQuackable
	{
		private readonly IQuackable _quackable;
		private readonly Observable _observable;

		public static int NumberOfQuacks { get; private set; } = 0;


		public QuackCounterDecorator(IQuackable quackable)
		{
			_quackable = quackable;
			_observable = new Observable(this);
		}

		public void NotifyObservers()
		{
			_observable.NotifyObservers();
		}

		public void RegisterObserver(IObserver observer)
		{
			_observable.RegisterObserver(observer);
		}

		public void Quack()
		{
			_quackable.Quack();
			NotifyObservers();
			NumberOfQuacks++;
		}

		public override string ToString()
		{
			return _quackable.ToString();
		}
	}

	public abstract class AbstractDuckFactory
	{
		public abstract IQuackable CreateMallardDuck();
		public abstract IQuackable CreateRedHeadDuck();
		public abstract IQuackable CreateDuckCall();
		public abstract IQuackable CreateRubberDuck();
	}

	public class DuckFactory : AbstractDuckFactory
	{
		public override IQuackable CreateMallardDuck()
		{
			return new MallardDuck();
		}

		public override IQuackable CreateRedHeadDuck()
		{
			return new RedHeadDuck();
		}

		public override IQuackable CreateDuckCall()
		{
			return new DuckCall();
		}

		public override IQuackable CreateRubberDuck()
		{
			return new RubberDuck();
		}
	}

	public class CountingDuckFactory : AbstractDuckFactory
	{
		public override IQuackable CreateMallardDuck()
		{
			return new QuackCounterDecorator(new MallardDuck());
		}

		public override IQuackable CreateRedHeadDuck()
		{
			return new QuackCounterDecorator(new RedHeadDuck());
		}

		public override IQuackable CreateDuckCall()
		{
			return new QuackCounterDecorator(new DuckCall());
		}

		public override IQuackable CreateRubberDuck()
		{
			return new QuackCounterDecorator(new RubberDuck());
		}
	}

	public class Flock : IQuackable
	{
		// Composite Pattern

		private List<IQuackable> _quackables = new List<IQuackable>();

		public void Add(IQuackable quackable)
		{
			_quackables.Add(quackable);
		}

		public void Quack()
		{
			foreach (IQuackable quackable in _quackables)
			{
				quackable.Quack();
			}
		}

		public void NotifyObservers()
		{
		}

		public void RegisterObserver(IObserver observer)
		{
			foreach (IQuackable quackable in _quackables)
			{
				quackable.RegisterObserver(observer);
			}
		}
	}

	public interface IQuackableObservable
	{
		void RegisterObserver(IObserver observer);
		void NotifyObservers();
	}

	public class Observable : IQuackableObservable
	{
		private readonly IQuackableObservable _observable;
		private List<IObserver> _observers = new List<IObserver>();

		public Observable(IQuackableObservable observable)
		{
			_observable = observable;
		}

		public void RegisterObserver(IObserver observer)
		{
			_observers.Add(observer);
		}

		public void NotifyObservers()
		{
			foreach (IObserver observer in _observers)
			{
				observer.Update(_observable);
			}
		}
	}

	public interface IObserver
	{
		void Update(IQuackableObservable observable);
	}

	public class Quackologist : IObserver
	{
		public void Update(IQuackableObservable observable)
		{
			Console.WriteLine($" {observable} quacked.");
		}
	}
}