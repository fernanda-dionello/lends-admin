using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using Lends.Models.Enums;
using System.Collections.Generic;

namespace Lends.Models
{
    public class Game
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryType Category { get; set; }

        [Display(Name = "Producer Code")]
        public int ProducerId { get; set; }

        public Producer Producer { get; set; }
        [Display(Name = "Min Players")]
        public int MinPlayers { get; set; }
        [Display(Name = "Max Players")]
        public int MaxPlayers { get; set; }
        public string Duration { get; set; }
        public string Age { get; set; }
        [Display(Name = "Rent Price")]
        public double RentPrice { get; set; }
        public string Image { get; set; }

        public GameStatus Status { get; set; }

        public ICollection<Rent> Rents = new List<Rent>();

        public Game(int id, string name, CategoryType category, int minPlayers, int maxPlayers, string duration, string age, double rentPrice, string image, GameStatus status)
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
