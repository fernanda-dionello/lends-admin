using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lends.Models.Enums
{
    public enum CategoryType : int
    {
        [Display(Name = "Cards")]
        CARDS = 0,
        [Display(Name = "Boardgame")]
        BOARDGAME = 1,
        [Display(Name = "RPG")]
        RPG = 2,
        [Display(Name = "Other")]
        OTHER = 3,
    }
}
