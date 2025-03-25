using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCodeFirstDatabaseLibrary.Models
{
    internal class Person
    {
        public int Id { get; set; }

        [MaxLength(40)]
        [Required]
        public string Name { get; set; }

        [MaxLength(60)]
        [Required]
        public string Surname { get; set; }

        [Range(0, 150)]
        public string Age { get; set; }

        [MaxLength(80)]
        public string Country { get; set; }

        public int MainAddressId { get; set; }

        [MaxLength(120)]
        public int MainAddress { get; set; }

        [MaxLength(120)]
        public int SecondAddressId { get; set; }


    }
}
