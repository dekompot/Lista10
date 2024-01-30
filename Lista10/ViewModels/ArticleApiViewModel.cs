using Lista10.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System;

namespace Lista10.ViewModels
{
    public class ArticleApiViewModel
    {
        [Required]
        [MinLength(2, ErrorMessage = "Too short name")]
        [MaxLength(20, ErrorMessage = "Too long name, do not exceed {1}")]
        public string Name { get; set; }

        [Range(0.0, Double.MaxValue, ErrorMessage = "The price must be a positive number")]
        public double? Price { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ExpirationDate { get; set; }

        [Required(ErrorMessage = "Product category is required.")]
        public string CategoryName { get; set; }
    }
}
