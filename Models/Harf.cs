using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diwaan.Models
{
    public class Harf
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Bait> Abyaats { get; set; }
        public int FaslId { get; set; }
    }





    // This will be serialized into a JSON Address object
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode = "99999"; // initialize properties to generate sample data

        public Address()
        {
            // or set properties in default constructor to generate sample data
            this.Street = "4627 Sunset Ave"; this.City = "San Diego"; this.State = "CA"; this.PostalCode = "92115";
        }
    }

    // This will be serialized into a JSON Contact object
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }

        public Contact()
        {
            this.Id = 7113; this.Name = "James Norris"; this.BirthDate = new DateTime(1977, 5, 13); this.Phone = "488-555-1212";
            this.Address = new Address();
        }
    }

    // This will be serialized into a JSON array of Contact objects
    public class ContactsCollection
    {
        public ICollection<Contact> Contacts { get; set; }

        public ContactsCollection()
        {
            // initialize array of objects in default constructor to generate sample data
            this.Contacts = new List<Contact>
        {
            new Contact { Id = 7113, Name = "James Norris", BirthDate = new DateTime(1977, 5, 13), Phone = "488-555-1212",
                          Address = new Address { Street = "4627 Sunset Ave", City = "San Diego", State = "CA", PostalCode = "92115" } },
            new Contact { Id = 7114, Name = "Mary Lamb", BirthDate =  new DateTime(1974, 10, 21), Phone = "337-555-1212",
                          Address = new Address { Street = "1111 Industrial Way", City = "Dallas", State = "TX", PostalCode = "49245" } },
            new Contact { Id = 7115, Name = "Robert Shoemaker", BirthDate = new DateTime(1968, 2, 8), Phone ="643-555-1212",
                          Address = null }
        };
        }
    }

}
