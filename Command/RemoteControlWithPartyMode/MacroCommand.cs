using System.Linq;

namespace RemoteControlWithPartyMode
{
	public class MacroCommand : ICommand
	{
		private readonly ICommand[] _commands;

		public MacroCommand(ICommand[] commands)
		{
			_commands = commands;
		}

		public void Execute()
		{
			_commands
				.ToList()
				.ForEach(command => { command.Execute(); });
		}

		public void Undo()
		{
			_commands
				.Reverse()
				.ToList()
				.ForEach(command => { command.Undo(); });
		}
	}
}