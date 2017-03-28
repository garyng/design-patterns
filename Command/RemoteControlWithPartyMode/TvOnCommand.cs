namespace RemoteControlWithPartyMode
{
	public class TvOnCommand : ICommand
	{
		private Tv _tv;

		public TvOnCommand(Tv tv)
		{
			_tv = tv;
		}

		public void Execute()
		{
			_tv.On();
			_tv.SetDvd();
		}

		public void Undo()
		{
			_tv.Off();
		}
	}
}