using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lends.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Display(Name = "CEP")]
        public string ZipCode { get; set; }
        
        [Display(Name = "Número")]
        public int Number { get; set; }

        [Display(Name = "Complemento")]
        public string AdditionalInformation { get; set; }

        public ICollection<Client> Clients = new List<Client>();

        public Address(int id, string zipCode, int number, string additionalInformation)
        {
            Id = id;
            ZipCode = zipCode;
            Number = number;
            AdditionalInformation = additionalInformation;
        }

        public Address()
        {

        }
    }
}
