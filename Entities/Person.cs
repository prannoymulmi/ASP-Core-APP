using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Entities
{
    public class Person
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string sex { get; set; }

        //[NotMapped]
        public List<Address> Address { get; set; }

    }
}