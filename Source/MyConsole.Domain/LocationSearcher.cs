using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole.Domain
{
	public class LocationSearcher
	{
		public Vendor LocateVendors(decimal latitude, decimal longitude, List<string> keywords)
		{
			var vendor =  new Vendor();
			vendor.Name = "Taco Truck Man";
			vendor.Latitude = latitude;
			vendor.Longitude = longitude;

			return vendor;
		}

		public Vendor LocateVendor(string name)
		{
			var vendor = new Vendor();
			vendor.Name = "Taco Truck Man";
			vendor.Latitude = 10;
			vendor.Longitude = 12;
			return vendor;
		}
	}
}
