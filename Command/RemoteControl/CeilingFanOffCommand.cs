namespace RemoteControl
{
	public class CeilingFanOffCommand : ICommand
	{
		private readonly CeilingFan _ceilingFan;

		public CeilingFanOffCommand(CeilingFan ceilingFan)
		{
			_ceilingFan = ceilingFan;
		}

		public void Execute()
		{
			_ceilingFan.Off();
		}
	}
}