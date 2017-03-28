namespace RemoteControl
{
	public class StereoOnWithCDCommand : ICommand
	{
		private Stereo _stereo;

		public StereoOnWithCDCommand(Stereo stereo)
		{
			_stereo = stereo;
		}

		public void Execute()
		{
			_stereo.On();
			_stereo.SetCD();
			_stereo.SetVolume(11);
		}
	}
}