namespace RemoteControlWithPartyMode
{
	public class HottubOffCommand : ICommand
	{
		private Hottub _hottub;

		public HottubOffCommand(Hottub hottub)
		{
			_hottub = hottub;
		}

		public void Execute()
		{
			_hottub.SetTemperature(98);
			_hottub.Off();
		}

		public void Undo()
		{
			_hottub.On();
		}
	}
}