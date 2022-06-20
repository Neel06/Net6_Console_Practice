using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptersServiceTest
{
    public class DemoClass
    {
        string Description { get; set; }
        int Id { get; set; }
        string Name { get; set; }

        public DemoClass(string name, string description, int id)
        {
            Name = name;
            Description = description;
            Id = id;
        }

        public DemoClass(string description, int id)
        {
            Description = description;
            Id = id;
            Name = "Neel";
        }

        public void GreetUser()
        {
            Console.WriteLine("{0} {1} your Id is {2}",Description,Name,Id);
        }
        
    }
}
