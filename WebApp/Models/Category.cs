﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
