namespace SimpleRemoteControl
{
	public class SimpleRemoteControl
	{
		public ICommand Slot { get; set; }

		public void ButtonPressed()
		{
			Slot.Execute();
		}
	}
}