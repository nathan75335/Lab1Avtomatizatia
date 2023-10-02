﻿namespace Lab1.Data.Models
{
    public class Category
    {
        public int Id { get; set; }    
        public string Name { get; set; }    
        public string Description { get; set; }
        List<SubCategory>? SubCategories { get; set; }   

    }
}
