﻿using System.ComponentModel.DataAnnotations;

namespace WebService.Models
{
    public class Categorie_Produs
    {
        [Key]
        public int id { get; set; }
        public string Categorie { get; set; }
    }
}
