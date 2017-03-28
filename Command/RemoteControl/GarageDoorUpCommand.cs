namespace RemoteControl
{
	public class GarageDoorUpCommand : ICommand
	{
		private GarageDoor _garageDoor;

		public GarageDoorUpCommand(GarageDoor garageDoor)
		{
			_garageDoor = garageDoor;
		}

		public void Execute()
		{
			_garageDoor.Up();
		}
	}
}