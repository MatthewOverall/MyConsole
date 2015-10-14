using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole.Domain
{
	
	public class VendorRepository
	{
		public List<Vendor> Get()
		{
			var names = new[] { "Taco Truck Man", "Pizza Guy", "The Good but Sketchy hot dogs." };
			var vendors = new List<Vendor>();
			for (int i = 0; i < names.Length; i++)
			{
				vendors.Add(new Vendor()
				{
					Name = names[i],
					Latitude = i + 10,
					Longitude = i + 12
				});
			}

			return vendors;
		}
	}
}
