using Microsoft.EntityFrameworkCore;
using PeopleCodeFirstDatabaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCodeFirstDatabaseLibrary
{
    internal class PeopleDBContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Addres> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseMySql("server=localhost;database=people4BProd;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));
    }
}
