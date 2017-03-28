namespace RemoteControl
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
	}
}