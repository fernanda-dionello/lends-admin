using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lends.Models.Enums
{
    public enum GameStatus : int
    {
        [Display(Name = "Alugado")]
        RENTED = 0,
        [Display(Name = "Disponível")]
        AVAILABLE = 1
    }
}
