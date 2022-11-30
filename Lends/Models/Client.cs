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
        [Required(ErrorMessage = "Nome é um campo obrigatório!")]
        [RegularExpression(@"^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$", ErrorMessage = "Válido apenas caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email é um campo obrigatório!")]
        [RegularExpression(@"\S+@\S+\.\S+", ErrorMessage ="Formato de email inválido.")]
        public string Email { get; set; }
        
        [Display(Name = "Celular")]
        [Required(ErrorMessage = "Celular é um campo obrigatório!")]
        [RegularExpression(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$", ErrorMessage = "Válido apenas no formato (xx) xxxxx-xxxx")]
        public string Cellphone { get; set; }

        [Required(ErrorMessage = "Cpf é um campo obrigatório!")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$", ErrorMessage = "Válido apenas 11 dígitos no formato xxx.xxx.xxx-xx")]
        public string Cpf { get; set; }

        [Display(Name = "Data de Registro")]
        [Required(ErrorMessage = "Data de Registro é um campo obrigatório!")]
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
