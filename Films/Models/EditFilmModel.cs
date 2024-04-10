﻿using Films.Data.Db.Entities;

namespace Films.Models
{
    public class EditFilmModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Category> AllCategories { get; set; } = new List<Category>();   
    }
}
