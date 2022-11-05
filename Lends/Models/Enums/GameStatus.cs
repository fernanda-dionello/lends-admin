using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lends.Models.Enums
{
    public enum GameStatus : int
    {
        [Display(Name = "Rented")]
        RENTED = 0,
        [Display(Name = "Available")]
        AVAILABLE = 1,
        [Display(Name = "Booked")]
        BOOKED = 2
    }
}
