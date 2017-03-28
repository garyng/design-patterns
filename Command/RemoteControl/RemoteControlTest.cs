using System;

namespace RemoteControl
{
	public class RemoteControlTest
	{
		public void Run()
		{
			RemoteControl rc = new RemoteControl();
			Light livingRoomLight = new Light("Living Room");
			Light kitchenLight = new Light("Kitchen");
			CeilingFan kitchenCeilingFan = new CeilingFan("Kitchen");
			GarageDoor garageDoor = new GarageDoor();
			Stereo stereo = new Stereo("Living room");

			rc.SetCommand(0, new LightOnCommand(livingRoomLight), new LightOffCommand(livingRoomLight));
			rc.SetCommand(1, new LightOnCommand(kitchenLight), new LightOffCommand(kitchenLight));
			rc.SetCommand(2, new CeilingFanOnCommand(kitchenCeilingFan), new CeilingFanOffCommand(kitchenCeilingFan));
			rc.SetCommand(3, new StereoOnWithCDCommand(stereo), new StereoOffCommand(stereo));
			rc.SetCommand(4, new GarageDoorUpCommand(garageDoor), new GarageDoorDownCommand(garageDoor));

			Console.WriteLine(rc);
			Console.WriteLine();

			rc.OnButtonPushed(0);
			rc.OffButtonPushed(0);
			rc.OnButtonPushed(1);
			rc.OffButtonPushed(1);
			rc.OnButtonPushed(2);
			rc.OffButtonPushed(2);
			rc.OnButtonPushed(3);
			rc.OffButtonPushed(3);
			rc.OnButtonPushed(4);
			rc.OffButtonPushed(4);

		}
	}
}