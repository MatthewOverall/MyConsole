using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyConsole.Domain;


namespace MyConsole.Runner
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Latitude:");
			var keyword = Console.ReadLine();

			var searcher = new LocationSearcher();
			
			Console.ReadLine();
		}
	}
}
