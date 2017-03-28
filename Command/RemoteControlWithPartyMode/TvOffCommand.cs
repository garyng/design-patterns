namespace RemoteControlWithPartyMode
{
	public class TvOffCommand : ICommand
	{
		private Tv _tv;

		public TvOffCommand(Tv tv)
		{
			_tv = tv;
		}

		public void Execute()
		{
			_tv.Off();
		}

		public void Undo()
		{
			_tv.On();
		}
	}
}