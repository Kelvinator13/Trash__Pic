using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashPic.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name ="FirstName")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        [ForeignKey("MaintenanceInfo")]
        public int MaintenanceInfo { get; set; }
    

        [ForeignKey("IdentityUser")]
        public string UserId { get; set; }

        public string IdentityUser { get; set; }
        public IdentityUser IdentityUsers { get; set; }
    }
}
