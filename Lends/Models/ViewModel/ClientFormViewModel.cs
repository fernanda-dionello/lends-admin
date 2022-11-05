using System.Collections.Generic;

namespace Lends.Models.ViewModel
{
    public class ClientFormViewModel
    {
        public Client Client { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
