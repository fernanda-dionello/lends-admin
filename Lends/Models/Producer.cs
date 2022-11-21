using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lends.Models
{
    public class Producer
    {

        public int Id { get; set; }

        [Display(Name = "Fabricante")]
        public string Name { get; set; }
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
