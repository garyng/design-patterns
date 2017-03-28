namespace RemoteControlWithPartyMode
{
	public class StereoOffCommand : ICommand
	{
		private Stereo _stereo;

		public StereoOffCommand(Stereo stereo)
		{
			_stereo = stereo;
		}

		public void Execute()
		{
			_stereo.Off();
		}

		public void Undo()
		{
			_stereo.On();
		}
	}
}