using System.Collections.Generic;
using System.Linq;

namespace RemoteControlWithUndo
{
	public class RemoteControl
	{
		private List<ICommand> _onCommands;
		private List<ICommand> _offCommands;
		private ICommand _undoCommand;

		public RemoteControl()
		{
			_onCommands = Enumerable.Repeat<ICommand>(new NoCommand(), 7).ToList();
			_offCommands = Enumerable.Repeat<ICommand>(new NoCommand(), 7).ToList();
			_undoCommand = new NoCommand();
		}

		public void SetCommand(int slot, ICommand onSlot, ICommand offSlot)
		{
			_onCommands[slot] = onSlot;
			_offCommands[slot] = offSlot;
		}

		public void OnButtonPushed(int slot)
		{
			_onCommands[slot].Execute();
			_undoCommand = _onCommands[slot];
		}

		public void OffButtonPushed(int slot)
		{
			_offCommands[slot].Execute();
			_undoCommand = _offCommands[slot];
		}

		public void UndoButtonPushed()
		{
			_undoCommand.Undo();
		}

		public override string ToString()
		{
			return "\n--- Remote Control ---\n" +
			       string.Join("\n",
				       _onCommands
					       .Zip(_offCommands,
						       (on, off) =>
							       $"On: {on.GetType().Name}\tOff: {off.GetType().Name}")
					       .Select((item, index) =>
						       $"[Slot #{index}] {item}")
			       ) + "\n" +
			       $"[Undo] {_undoCommand.GetType().Name}" + "\n" +
			       "--- Remote Control ---\n";
		}
	}
}