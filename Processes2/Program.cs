using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Processes2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Process[] allProcesses = Process.GetProcesses();
			for (int i = 0; i < allProcesses.Length; i++) 
			{
				Console.WriteLine(allProcesses[i].Id + "\t" + allProcesses[i].ProcessName);
            }
		}
	}
}
