using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_703.Models
{
    public class Clients
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string City { get; set; }



        public Clients() { }

        public Clients(int id, string name, string lastname, string phone, string location, string city)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            PhoneNumber = phone;
            Location = location;
            City = city;
        }


        public override string ToString()
        {
            return string.Format($"Nombre: {Name}\n" +
                $"Apellidos: {LastName}\n" +
                $"City: {City}\n" +
                $"Dirección: {Location}\n" +
                $"Telefono: {PhoneNumber}\n");
        }


    }
}
