namespace SimpleRemoteControl
{
	public class GarageDoorOpenCommand : ICommand
	{
		private Garage _garage;

		public GarageDoorOpenCommand(Garage garage)
		{
			_garage = garage;
		}

		public void Execute()
		{
			_garage.Up();
		}
	}
}