using DBFirstApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekzamen_cSharp
{
    public class Modification
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string vendorcode { get; set; }

        public Modification()
        {
        }
        public void create()
        {
            Console.Write("Введите имя модификации ");
            name = Console.ReadLine();
            Console.Write("Введите код машины которой доступна данная модификация ");
            vendorcode = Console.ReadLine();           
        }
            public void print()
            {
            Console.WriteLine($"Id - {id} name - {name} vendorcode - {vendorcode}");
            }
    }
}
