using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp {
	class Program {
		static int Main(string[] args) {
			// Display message to the user
			Console.WriteLine("First C# App");
			Console.WriteLine("Hello World!");
			Console.WriteLine();

			// Process incoming args
			for(int i = 0; i < args.Length; i++) {
				Console.WriteLine("Arg: {0}", args[i]);
			}

			// Call env details
			ShowEnvironmentDetails();

			// Wait for enter key press before terminating
			Console.ReadLine();

			// Return error code
			return -1;
		}

		static void ShowEnvironmentDetails() {
			// Print out machine drives etc
			foreach(string drive in Environment.GetLogicalDrives()) {
				Console.WriteLine("Drive: {0}", drive);
				Console.WriteLine("OS: {0}", Environment.OSVersion);
				Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
				Console.WriteLine(".NET Version: {0}", Environment.Version);
			}
		}
	}
}
