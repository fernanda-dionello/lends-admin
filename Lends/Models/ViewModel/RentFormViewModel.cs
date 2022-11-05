using System.Collections.Generic;

namespace Lends.Models.ViewModel
{
    public class RentFormViewModel
    {
        public Rent Rent { get; set; }
        public ICollection<Game> Games { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}
