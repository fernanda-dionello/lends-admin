using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using Lends.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lends.Models
{
    public class Game
    {

        public int Id { get; set; }
        
        [Display(Name = "Jogo")]
        [Required(ErrorMessage = "Jogo é um campo obrigatório!")]
        public string Name { get; set; }
        
        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Categoria é um campo obrigatório!")]
        public CategoryType Category { get; set; }

        [Required(ErrorMessage = "Fabricante é um campo obrigatório!")]
        public int ProducerId { get; set; }

        [Display(Name = "Fabricante")]
        public Producer Producer { get; set; }
        
        [Display(Name = "Min Jogadores")]
        [Range(1, 100)]
        public int MinPlayers { get; set; }
        [Display(Name = "Max Jogadores")]
        [Range(1, 100)]
        public int MaxPlayers { get; set; }
        
        [Display(Name = "Duração")]
        public string Duration { get; set; }
        
        [Display(Name = "Idade")]
        public string Age { get; set; }
        
        [Display(Name = "Aluguel Semanal")]
        [Required(ErrorMessage = "Aluguel Semanal é um campo obrigatório!")]
        [RegularExpression(@"^\d{0,8}(\,\d{1,2})?", ErrorMessage = "Somente valores decimais separados por vírgula serão aceitos.")]
        public string RentPrice { get; set; }

        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "Status é um campo obrigatório!")]
        public GameStatus Status { get; set; }

        public ICollection<Rent> Rents = new List<Rent>();

        public Game(int id, string name, CategoryType category, int minPlayers, int maxPlayers, string duration, string age, string rentPrice, string image, GameStatus status)
        {
            Id = id;
            Name = name;
            Category = category;
            MinPlayers = minPlayers;
            MaxPlayers = maxPlayers;
            Duration = duration;
            Age = age;
            RentPrice = rentPrice;
            Image = image;
            Status = status;
        }

        public Game()
        {

        }
    }
}
