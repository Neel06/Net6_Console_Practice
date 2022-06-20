using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdaptersServiceTest.InterfaceInsideClassExample;

namespace AdaptersServiceTest
{
    public class InterfaceInsideClassExample : IUserData
    {
        public string Name { get; set; }
        public string Address { get ; set ; }

        public void GetUserDetails()
        {
            Console.WriteLine("Name:{0}, \nAddress:{1}",Name,Address);
        }

        public void SetUserDetails(string name, string address)
        {
            if (name != null && name.Contains("") && address != null && address.Contains(""))
            {
                Name = name;
                Address = address;
            }
            else
            {
                Console.WriteLine("Enter Valid Details:");
                return;
            }
            
        }   

        public interface IUserData
        {
            public string Name { get; set; }
            public string Address { get; set; }

            public abstract void GetUserDetails();
            public abstract void SetUserDetails(string name, string address);
        }

    }
}
