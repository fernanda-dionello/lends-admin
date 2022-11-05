using System.Collections.Generic;

namespace Lends.Models.ViewModel
{
    public class GameFormViewModel
    {
        public Game Game { get; set; }
        public ICollection<Producer> Producers { get; set; }
    }
}
