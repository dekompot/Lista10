using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace Lista10.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Expiration date")]
        [HiddenInput]
        public DateTime Timestamp { get; set; } = DateTime.Now;
        [Required]
        public string UserId { get; set; }
        [Required]
        public IdentityUser User { get; set; }
        [Required]
        public string Destination { get; set; }
        [Required]
        public string Name {  get; set; }
        [Required]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
