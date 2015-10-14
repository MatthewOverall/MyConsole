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
			Console.WriteLine("Enter Name:");
			var name = Console.ReadLine();
			var vendorRepo = new VendorRepository();
			var searcher = new LocationSearcher(vendorRepo);
			var vendor = searcher.LocateVendor(name);
			
			Console.ReadLine();
		}
	}
}
