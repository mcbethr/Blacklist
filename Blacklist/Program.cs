using System;
using System.Collections.Generic;

namespace Blacklist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


	public class IPAddressOperations
	{

		private List<string> _Blacklist;

		public IPAddressOperations()
		{

			_Blacklist = new List<string>();

		}

		public void AddIPAddressToBlacklist(string IPAddress)
        {
			_Blacklist.Add(IPAddress);

        }
		public bool SearchForIPAddress(string IPAddress)
		{
			return _Blacklist.Contains(IPAddress);

		}
	}


	
}
