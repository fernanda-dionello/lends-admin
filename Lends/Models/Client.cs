using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using System.Collections.Generic;

namespace Lends.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public string Cpf { get; set; }

        [Display(Name = "Registration Date")]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        [Display(Name = "Address")]
        public int AddressId { get; set; }

        public Address Address { get; set; }

        public ICollection<Rent> Rents = new List<Rent>();
        public Client(int id, string name, string email, string cellphone, string cpf, DateTime registrationDate)
        {
            Id = id;
            Name = name;
            Email = email;
            Cellphone = cellphone;
            Cpf = cpf;
            RegistrationDate = registrationDate;
        }

        public Client()
        {

        }
    }
}
