using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater
{
	class Program
	{
		static void Main(string[] args)
		{
			new HomeTheaterTest().Run();
			Console.ReadKey();
		}
	}
}