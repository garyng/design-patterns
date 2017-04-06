using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGumballMachine
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
		private int _totalBalls;
		private GumballMachineState _state = GumballMachineState.SoldOut;

		public GumballMachine(int totalBalls)
		{
			_totalBalls = totalBalls;
			if (_totalBalls > 0)
			{
				_state = GumballMachineState.NoQuarter;
			}
		}

		public void InsertQuarter()
		{
			switch (_state)
			{
				case GumballMachineState.HasQuarter:
					Console.WriteLine("You can't insert another quarter");
					break;
				case GumballMachineState.NoQuarter:
					_state = GumballMachineState.HasQuarter;
					Console.WriteLine("You inserted a quarter");
					break;
				case GumballMachineState.Sold:
					Console.WriteLine("Please wait... gumball is coming...");
					break;
				case GumballMachineState.SoldOut:
					Console.WriteLine("You can't insert a quarter, the machine is sold out");
					break;
			}
		}

		public void EjectQuarter()
		{
			switch (_state)
			{
				case GumballMachineState.HasQuarter:
					_state = GumballMachineState.NoQuarter;
					Console.WriteLine("Quarter returned");
					break;
				case GumballMachineState.NoQuarter:
					Console.WriteLine("You haven't inserted a quarter");
					break;
				case GumballMachineState.Sold:
					Console.WriteLine("You already turned the crank");
					break;
				case GumballMachineState.SoldOut:
					Console.WriteLine("You haven't inserted a quarter");
					break;
			}
		}

		public void TurnCrank()
		{
			switch (_state)
			{
				case GumballMachineState.HasQuarter:
					Console.WriteLine("You turned...");
					_state = GumballMachineState.Sold;
					Dispense();
					break;
				case GumballMachineState.NoQuarter:
					Console.WriteLine("You turned, but no quarter");
					break;
				case GumballMachineState.Sold:
					Console.WriteLine("Turning twice doesn't get you another gumball...");
					break;
				case GumballMachineState.SoldOut:
					Console.WriteLine("You turned, but there are no gumballs...");
					break;
			}
		}

		public void Dispense()
		{
			switch (_state)
			{
				case GumballMachineState.HasQuarter:
					Console.WriteLine("No gumball dispensed");
					break;
				case GumballMachineState.NoQuarter:
					Console.WriteLine("You need to pay first");
					break;
				case GumballMachineState.Sold:
					Console.WriteLine("Dispensing gumball...");
					if (--_totalBalls == 0)
					{
						Console.WriteLine("Out of gumballs");
						_state = GumballMachineState.SoldOut;
					}
					else
					{
						_state = GumballMachineState.NoQuarter;
					}
					break;
				case GumballMachineState.SoldOut:
					Console.WriteLine("No gumball dispensed");
					break;
			}
		}

		public override string ToString()
		{
			string state = "No state";
			switch (_state)
			{
				case GumballMachineState.HasQuarter:
					state = "Waiting for turn of crank";
					break;
				case GumballMachineState.NoQuarter:
					state = "Waiting for a quarter";
					break;
				case GumballMachineState.Sold:
					state = "Delivering a gumball";
					break;
				case GumballMachineState.SoldOut:
					state = "Sold out";
					break;
			}

			return $"\nInventory: {_totalBalls} gumball(s)" +
			       $"\nMachine State: {state}\n";
		}
	}
}