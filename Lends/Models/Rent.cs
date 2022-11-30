using System.ComponentModel.DataAnnotations;
using System;

namespace Lends.Models
{
    public class Rent
    {
        public int Id { get; set; }

        [Display(Name = "Jogo")]
        [Required(ErrorMessage = "Jogo é um campo obrigatório!")]
        public int GameId { get; set; }

        public Game Game { get; set; }

        [Display(Name = "Cliente")]
        [Required(ErrorMessage = "Cliente é um campo obrigatório!")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [Display(Name = "Data de Retirada")]
        [Required(ErrorMessage = "Data de Retirada é um campo obrigatório!")]
        [DataType(DataType.Date)]
        public DateTime RentalDate { get; set; }

        [Display(Name = "Data de Retorno")]
        [Required(ErrorMessage = "Data de Retorno é um campo obrigatório!")]
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "Valor é um campo obrigatório!")]
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
