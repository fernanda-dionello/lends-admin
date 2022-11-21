using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
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
        public double Price { get; set; }

        public Rent(int id, DateTime rentalDate, DateTime returnDate, double price)
        {
            Id = id;
            RentalDate = rentalDate;
            ReturnDate = returnDate;
            Price = price;
        }

        public Rent()
        {

        }
    }
}
