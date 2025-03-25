using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCodeFirstDatabaseLibrary.Models
{
    internal class Addres
    {
        public int Id { get; set; }

        [MaxLength(150)]
        public string Street { get; set; }
    }
}
