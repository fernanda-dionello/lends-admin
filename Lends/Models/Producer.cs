using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lends.Models
{
    public class Producer
    {
        public int Id { get; set; }

        [Display(Name = "Fabricante")]
        [Required(ErrorMessage = "Nome é um campo obrigatório!")]
        public string Name { get; set; }

        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$", ErrorMessage = "Válido apenas 14 dígitos no formato xx.xxx.xxx/xxxx-xx")]
        [Required(ErrorMessage = "CNPJ é um campo obrigatório!")]
        public string Cnpj { get; set; }

        public ICollection<Game> Games = new List<Game>();

        public Producer(int id, string name, string cnpj)
        {
            Id = id;
            Name = name;
            Cnpj = cnpj;
        }

        public Producer()
        {

        }
    }
}
