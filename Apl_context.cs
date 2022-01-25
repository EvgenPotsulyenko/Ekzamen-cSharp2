using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;
using System.IO;

namespace ekzamen_cSharp
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Model> Model { get; set; }
        public DbSet<Modification> Modification { get; set; }
        public DbSet<Colour> Colour { get; set; }


        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JCH9SA9\\SQLEXPRESS;Database=car;Trusted_Connection=True;");
        }
    }
}
