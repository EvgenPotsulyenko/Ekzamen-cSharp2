using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using DBFirstApp;

namespace ekzamen_cSharp
{
    class Program
    {    
        static void Main(string[] args)
            {
            Menu me = new Menu();
            me.men1();

            Console.Read();
        }
    }
}
