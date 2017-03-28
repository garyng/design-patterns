namespace RemoteControlWithUndo
{
	public class CeilingFanHighCommand : ICommand
	{
		private readonly CeilingFan _ceilingFan;
		private CeilingFan.Level _prevSpeed;

		public CeilingFanHighCommand(CeilingFan ceilingFan)
		{
			_ceilingFan = ceilingFan;
		}

		public void Execute()
		{
			_prevSpeed = _ceilingFan.Speed;
			_ceilingFan.High();
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