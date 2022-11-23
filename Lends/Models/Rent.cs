using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using System.ComponentModel.DataAnnotations.Schema;

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

        [DataType(DataType.Currency)]
        [Range(0.01, 100000, ErrorMessage ="O valor deve estar entre 0.01 e 100000")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Display(Name = "Ativo")]
        public bool IsActive { get; set; } = true;
        public Rent(int id, DateTime rentalDate, DateTime returnDate, decimal price)
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
