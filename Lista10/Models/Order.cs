using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace Lista10.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Expiration date")]
        [HiddenInput]
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public IdentityUser User
    }
}
