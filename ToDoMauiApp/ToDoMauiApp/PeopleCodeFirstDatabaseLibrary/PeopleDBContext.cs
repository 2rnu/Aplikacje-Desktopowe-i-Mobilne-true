using Microsoft.EntityFrameworkCore;
using ToDoCodeFirstDatabaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoCodeFirstDatabaseLibrary
{
    internal class ToDoDBContext : DbContext
    {
        public DbSet<Models.Task> Tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseMySql("server=localhost;database=ToDo;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));
    }
}
