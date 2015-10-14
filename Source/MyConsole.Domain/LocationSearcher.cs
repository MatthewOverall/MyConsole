using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole.Domain
{
	public class LocationSearcher
	{
		private VendorRepository _repo;

		public LocationSearcher(VendorRepository repository)
		{
			_repo = repository;		
		}
																  
		public Vendor LocateVendors(decimal latitude, decimal longitude, List<string> keywords)
		{
			var vendor = new Vendor();
			vendor.Name = "Taco Truck Man";
			vendor.Latitude = latitude;
			vendor.Longitude = longitude;

			return vendor;
		}

		public Vendor LocateVendor(string name)
		{
			var vendors = _repo.Get();
			//loop through the vendors...
			//find the first one matching the name;
			return vendors[0];
		}
	}
}
