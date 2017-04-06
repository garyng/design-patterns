using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachineWithWinner
{
	class Program
	{
		static void Main(string[] args)
		{
			new GumballMachineTest().Run();
			Console.ReadKey();
		}
	}

	public class GumballMachineTest
	{
		public void Run()
		{
			GumballMachine machine = new GumballMachine(5);
			Console.WriteLine(machine);

			machine.InsertQuarter();
			machine.TurnCrank();

			Console.WriteLine(machine);

			machine.InsertQuarter();
			machine.EjectQuarter();
			machine.TurnCrank();

			Console.WriteLine(machine);

			machine.InsertQuarter();
			machine.TurnCrank();
			machine.InsertQuarter();
			machine.TurnCrank();
			machine.EjectQuarter();

			Console.WriteLine(machine);

			machine.InsertQuarter();
			machine.InsertQuarter();
			machine.TurnCrank();
			machine.InsertQuarter();
			machine.TurnCrank();
			machine.InsertQuarter();
			machine.TurnCrank();

			Console.WriteLine(machine);

			machine.Refill(100);

			Console.WriteLine(machine);

			machine.InsertQuarter();
			machine.TurnCrank();
			machine.InsertQuarter();
			machine.TurnCrank();
			machine.InsertQuarter();
			machine.TurnCrank();

			Console.WriteLine(machine);


		}
	}

	public enum GumballMachineState
	{
		SoldOut,
		NoQuarter,
		HasQuarter,
		Sold
	}

	public class GumballMachine
	{
		public GumballMachineStateBase CurrentState { get; set; }
		public GumballMachineStateBase SoldOutState { get; }
		public HasQuarterState HasQuarterState { get; }
		public NoQuarterState NoQuarterState { get; }
		public WinnerState WinnerState { get; }


		public SoldState SoldState { get; }

		public int Count { get; private set; }


		public GumballMachine(int totalBalls)
		{
			SoldOutState = new SoldOutState(this);
			SoldState = new SoldState(this);
			NoQuarterState = new NoQuarterState(this);
			HasQuarterState = new HasQuarterState(this);
			WinnerState = new WinnerState(this);

			Count = totalBalls;

			CurrentState = Count > 0 ? NoQuarterState : SoldOutState;
		}

		public void InsertQuarter()
		{
			CurrentState.InsertQuarter();
		}

		public void EjectQuarter()
		{
			CurrentState.EjectQuarter();
		}

		public void TurnCrank()
		{
			CurrentState.TurnCrank();
			CurrentState.Dispense();
		}

		public void Refill(int count)
		{
			Console.WriteLine($"Refilling {count} gumballs...");
			Count += count;
			Console.WriteLine($"New count: {count}");
			CurrentState.Refill();
		}

		internal void ReleaseGumball()
		{
			Console.WriteLine("Releasing gumball...");
			if (Count > 0)
			{
				Count--;
			}
		}

		public override string ToString()
		{
			return $"\nCount: {Count}" +
			       $"\nState: {CurrentState}\n";
		}
	}

	public class NoQuarterState : GumballMachineStateBase
	{
		public NoQuarterState(GumballMachine machine) : base(machine)
		{
		}

		public override void InsertQuarter()
		{
			Console.WriteLine("You inserted a quarter");
			_machine.CurrentState = _machine.HasQuarterState;
		}

		public override void EjectQuarter()
		{
			Console.WriteLine("You haven't inserted a quarter");
		}

		public override void TurnCrank()
		{
			Console.WriteLine("You turned, but there's no quarter");
		}

		public override void Dispense()
		{
			Console.WriteLine("You need to insert a quarter first");
		}

		public override void Refill()
		{
		}

		public override string ToString()
		{
			return "Waiting for a quarter...";
		}
	}

	public class SoldOutState : GumballMachineStateBase
	{
		public SoldOutState(GumballMachine machine) : base(machine)
		{
		}

		public override void InsertQuarter()
		{
			Console.WriteLine("Machine sold out");
		}

		public override void EjectQuarter()
		{
			Console.WriteLine("No quarter to eject");
		}

		public override void TurnCrank()
		{
			Console.WriteLine("You turned, but the is no gumball...");
		}

		public override void Dispense()
		{
			Console.WriteLine("No gumball dispensed");
		}

		public override void Refill()
		{
			_machine.CurrentState = _machine.NoQuarterState;
		}

		public override string ToString()
		{
			return "Sold out";
		}
	}

	public class SoldState : GumballMachineStateBase
	{
		public SoldState(GumballMachine machine) : base(machine)
		{
		}

		public override void InsertQuarter()
		{
			Console.WriteLine("Please wait...Giving you your gumball...");
		}

		public override void EjectQuarter()
		{
			Console.WriteLine("Sorry, you already turned the crank");
		}

		public override void TurnCrank()
		{
			Console.WriteLine("You can't turn the crank twice...");
		}

		public override void Dispense()
		{
			_machine.ReleaseGumball();
			if (_machine.Count > 0)
			{
				_machine.CurrentState = _machine.NoQuarterState;
			}
			else
			{
				Console.WriteLine("Out of gumballs!");
				_machine.CurrentState = _machine.SoldOutState;
			}
		}

		public override void Refill()
		{
		}

		public override string ToString()
		{
			return "Delivering a gumball";
		}
	}

	public class HasQuarterState : GumballMachineStateBase
	{
		public HasQuarterState(GumballMachine machine) : base(machine)
		{
		}

		public override void InsertQuarter()
		{
			Console.WriteLine("You can't insert another quarter");
		}

		public override void EjectQuarter()
		{
			Console.WriteLine("Quarter returned");
			_machine.CurrentState = _machine.NoQuarterState;
		}

		public override void TurnCrank()
		{
			Console.WriteLine("You turned...");
			if (_machine.Count >= 2 && new Random().Next(2) == 0)
			{
				_machine.CurrentState = _machine.WinnerState;
			}
			else
			{
				_machine.CurrentState = _machine.SoldState;
			}
		}

		public override void Dispense()
		{
			Console.WriteLine("No gumball dispensed");
		}

		public override void Refill()
		{
		}

		public override string ToString()
		{
			return "Waiting for turn of crank";
		}
	}

	public class WinnerState : GumballMachineStateBase
	{
		public WinnerState(GumballMachine machine) : base(machine)
		{
		}

		public override void InsertQuarter()
		{
			Console.WriteLine("Please wait...Giving you your gumball...");
		}

		public override void EjectQuarter()
		{
			Console.WriteLine("Sorry, you already turned the crank");
		}

		public override void TurnCrank()
		{
			Console.WriteLine("You can't turn the crank twice...");
		}

		public override void Dispense()
		{
			_machine.ReleaseGumball();
			if (_machine.Count == 0)
			{
				Console.WriteLine("Out of gumballs!");
				_machine.CurrentState = _machine.SoldOutState;
			}
			else
			{
				Console.WriteLine("You are the WINNER!");
				_machine.ReleaseGumball();
				if (_machine.Count > 0)
				{
					_machine.CurrentState = _machine.NoQuarterState;
				}
				else
				{
					Console.WriteLine("Out of gumballs!");
					_machine.CurrentState = _machine.SoldOutState;
				}
			}
		}

		public override void Refill()
		{
		}

		public override string ToString()
		{
			return "Delivering 2 gumballs";
		}
	}

	public abstract class GumballMachineStateBase
	{
		protected readonly GumballMachine _machine;

		public GumballMachineStateBase(GumballMachine machine)
		{
			_machine = machine;
		}

		public abstract void Refill();
		public abstract void InsertQuarter();
		public abstract void EjectQuarter();
		public abstract void TurnCrank();
		public abstract void Dispense();
	}
}