using System.ComponentModel.DataAnnotations;
using System;

namespace Lends.Models
{
    public class Rent
    {
        public int Id { get; set; }

        [Display(Name = "Jogo")]
        public int GameId { get; set; }

        public Game Game { get; set; }

        [Display(Name = "Cliente")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [Display(Name = "Data de Retirada")]
        [DataType(DataType.Date)]
        public DateTime RentalDate { get; set; }

        [Display(Name = "Data de Retorno")]
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }

        [Display(Name = "Valor")]
        [RegularExpression(@"^\d{0,8}(\,\d{1,2})?", ErrorMessage = "Somente valores decimais separados por vírgula serão aceitos.")]
        public string Price { get; set; }

        [Display(Name = "Ativo")]
        public bool IsActive { get; set; } = true;
        public Rent(int id, DateTime rentalDate, DateTime returnDate, string price)
        {
            Id = id;
            RentalDate = rentalDate;
            ReturnDate = returnDate;
            Price = price;
            IsActive = true;
        }

        public Rent()
        {

        }
    }
}
