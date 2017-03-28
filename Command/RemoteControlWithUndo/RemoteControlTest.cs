using System;

namespace RemoteControlWithUndo
{
	public class RemoteControlTest
	{
		public void Run()
		{
			RemoteControl rc = new RemoteControl();
			Light livingRoomLight = new Light("Living Room");
			Light kitchenLight = new Light("Kitchen");
			CeilingFan livingRoomFan = new CeilingFan("Living Room");


			rc.SetCommand(0, new LightOnCommand(livingRoomLight), new LightOffCommand(livingRoomLight));
			rc.SetCommand(1, new LightOnCommand(kitchenLight), new LightOffCommand(kitchenLight));
			rc.SetCommand(2, new CeilingFanHighCommand(livingRoomFan), new CeilingFanOffCommand(livingRoomFan));
			rc.SetCommand(3, new CeilingFanMediumCommand(livingRoomFan), new CeilingFanOffCommand(livingRoomFan));
			rc.SetCommand(4, new CeilingFanLowCommand(livingRoomFan), new CeilingFanOffCommand(livingRoomFan));

			Console.WriteLine(rc);
			Console.WriteLine();

			rc.OnButtonPushed(0);
			rc.OffButtonPushed(0);
			Console.WriteLine(rc);

			rc.UndoButtonPushed();
			Console.WriteLine();

			rc.OnButtonPushed(1);
			rc.OffButtonPushed(1);
			Console.WriteLine(rc);
			rc.UndoButtonPushed();
			Console.WriteLine();

			rc.OnButtonPushed(2);
			rc.OffButtonPushed(2);
			Console.WriteLine(rc);

			rc.UndoButtonPushed();
			Console.WriteLine();

			rc.OnButtonPushed(3);
			rc.OffButtonPushed(3);
			rc.UndoButtonPushed();
			Console.WriteLine();

			rc.OnButtonPushed(4);
			rc.OffButtonPushed(4);
			rc.UndoButtonPushed();
		}
	}
}