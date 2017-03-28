namespace RemoteControlWithPartyMode
{
	public class LightOffCommand : ICommand
	{
		private readonly Light _light;
		private int _prevBrightness;

		public LightOffCommand(Light light)
		{
			_light = light;
		}

		public void Execute()
		{
			_prevBrightness = _light.Brightness;
			_light.Off();
		}

		public void Undo()
		{
			_light.On();
			_light.Brightness = _prevBrightness;
		}
	}
}