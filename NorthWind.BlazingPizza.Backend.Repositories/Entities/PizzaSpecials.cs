﻿namespace NorthWind.BlazingPizza.Backend.Repositories.Entities
{
    public class PizzaSpecials
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

    }
}
