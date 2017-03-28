namespace RemoteControlWithUndo
{
	public interface ICommand
	{
		void Execute();
		void Undo();
	}
}