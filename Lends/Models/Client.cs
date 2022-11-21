using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using System.Collections.Generic;

namespace Lends.Models
{
    public class Client
    {
        public int Id { get; set; }
        
        [Display(Name = "Nome")]
        public string Name { get; set; }

        public string Email { get; set; }
        
        [Display(Name = "Celular")]
        public string Cellphone { get; set; }
        
        public string Cpf { get; set; }

        [Display(Name = "Data de Registro")]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        [Display(Name = "CEP")]
        public int AddressId { get; set; }

        [Display(Name = "CEP")]
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
