﻿using System.Text.Json.Serialization;

namespace DrinksInfo.Models
{
    public class DrinksListing
    {
        [JsonPropertyName("drinks")]

        public List<Drink> DrinksList { get; set; }
    }

    public class Drink
    {
        public string idDrink { get; set; }

        public string strDrink { get; set; }
    }

}
