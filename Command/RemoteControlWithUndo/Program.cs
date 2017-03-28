using System;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlWithUndo
{
	class Program
	{
		static void Main(string[] args)
		{
			new RemoteControlTest().Run();
			Console.ReadKey();
		}
	}
}