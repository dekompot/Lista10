using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Lista10.ViewModels
{
    public class OrderViewModel
    {
        public string UserName { get; set; }
        public string Destination { get; set; }
        public string Name { get; set; }
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
