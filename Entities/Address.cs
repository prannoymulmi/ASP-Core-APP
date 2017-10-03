using System.ComponentModel.DataAnnotations.Schema;

namespace App.Entities
{
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AddressId { get; set; }

        public string StreetName { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public int PersonId { get; set; }

        [NotMapped]
        public Person MyPerson { get; set; }
    }
}