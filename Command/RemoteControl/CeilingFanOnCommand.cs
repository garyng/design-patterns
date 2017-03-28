namespace RemoteControl
{
	public class CeilingFanOnCommand : ICommand
	{
		private readonly CeilingFan _ceilingFan;

		public CeilingFanOnCommand(CeilingFan ceilingFan)
		{
			_ceilingFan = ceilingFan;
		}

		public void Execute()
		{
			_ceilingFan.High();
		}
	}
}