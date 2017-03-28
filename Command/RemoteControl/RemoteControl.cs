using System.Collections.Generic;
using System.Linq;

namespace RemoteControl
{
	public class RemoteControl
	{
		private List<ICommand> _onCommands;
		private List<ICommand> _offCommands;

		public RemoteControl()
		{
			_onCommands = Enumerable.Repeat<ICommand>(new NoCommand(), 7).ToList();
			_offCommands = Enumerable.Repeat<ICommand>(new NoCommand(), 7).ToList();
		}

		public void SetCommand(int slot, ICommand onSlot, ICommand offSlot)
		{
			_onCommands[slot] = onSlot;
			_offCommands[slot] = offSlot;
		}

		public void OnButtonPushed(int slot)
		{
			_onCommands[slot].Execute();
		}

		public void OffButtonPushed(int slot)
		{
			_offCommands[slot].Execute();
		}

		public override string ToString()
		{
			return $"--- Remote Control ---\n" +
			       string.Join("\n",
				       _onCommands
					       .Zip(_offCommands,
						       (on, off) =>
							       $"On: {on.GetType().Name}\tOff: {off.GetType().Name}")
					       .Select((item, index) =>
						       $"[Slot #{index}] {item}")
			       );
		}
	}
}