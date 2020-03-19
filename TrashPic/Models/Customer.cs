using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashPic.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
