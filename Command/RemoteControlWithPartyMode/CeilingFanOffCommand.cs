namespace RemoteControlWithPartyMode
{
	public class CeilingFanOffCommand : ICommand
	{
		private readonly CeilingFan _ceilingFan;
		private CeilingFan.Level _prevSpeed;

		public CeilingFanOffCommand(CeilingFan ceilingFan)
		{
			_ceilingFan = ceilingFan;
		}

		public void Execute()
		{
			_prevSpeed = _ceilingFan.Speed;
			_ceilingFan.Off();
		}

		public void Undo()
		{
			switch (_prevSpeed)
			{
				case CeilingFan.Level.High:
					_ceilingFan.High();
					break;
				case CeilingFan.Level.Medium:
					_ceilingFan.Medium();
					break;
				case CeilingFan.Level.Low:
					_ceilingFan.Low();
					break;
				case CeilingFan.Level.Off:
					_ceilingFan.Off();
					break;
			}
		}
	}
}