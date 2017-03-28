using System;
using System.Threading;

namespace RemoteControlWithPartyMode
{
	public class RemoteControlTest
	{
		public void Run()
		{
			RemoteControl rc = new RemoteControl();
			Light livingRoomLight = new Light("Living Room");
			CeilingFan livingRoomFan = new CeilingFan("Living Room");
			Tv livingRoomTv = new Tv("Living Room");
			Stereo livingRoomStereo = new Stereo("Living Room");
			Hottub hottub = new Hottub();

			MacroCommand onCommands = new MacroCommand(new ICommand[]
			{
				new LightOnCommand(livingRoomLight), new CeilingFanMediumCommand(livingRoomFan), new TvOnCommand(livingRoomTv),
				new StereoOnWithCDCommand(livingRoomStereo), new HottubOnCommand(hottub)
			});

			MacroCommand offCommands = new MacroCommand(new ICommand[]
			{
				new LightOffCommand(livingRoomLight), new CeilingFanOffCommand(livingRoomFan), new TvOffCommand(livingRoomTv),
				new StereoOffCommand(livingRoomStereo), new HottubOffCommand(hottub)
			});

			RelayCommand lightOnCommand = new RelayCommand(() => livingRoomLight.On(), () => livingRoomLight.Off());
			RelayCommand lightOffCommand = new RelayCommand(() => livingRoomLight.Off(), () => livingRoomLight.On());

			rc.SetCommand(0, onCommands, offCommands);
			rc.OnButtonPushed(0);
			Console.WriteLine();
			rc.OffButtonPushed(0);
			Console.WriteLine(rc);
			rc.UndoButtonPushed();

			Console.WriteLine();
			Console.WriteLine();
			rc.SetCommand(1, lightOnCommand, lightOffCommand);
			Console.WriteLine(rc);
			rc.OnButtonPushed(1);
			rc.OffButtonPushed(1);
			Console.WriteLine();
			rc.UndoButtonPushed();

		}
	}

	public class RelayCommand : ICommand
	{
		private readonly Action _executeAction;
		private readonly Action _undoAction;

		public RelayCommand(Action executeAction, Action undoAction)
		{
			_executeAction = executeAction;
			_undoAction = undoAction;
		}

		public void Execute()
		{
			_executeAction();
		}

		public void Undo()
		{
			_undoAction();
		}
	}
}