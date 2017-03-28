namespace SimpleRemoteControl
{
	public class SimpleRemoteControlTest
	{
		public void Run()
		{
			SimpleRemoteControl remote = new SimpleRemoteControl();

			remote.Slot = new LightOnCommand(new Light());
			remote.ButtonPressed();

			remote.Slot = new GarageDoorOpenCommand(new Garage());
			remote.ButtonPressed();
		}
	}
}