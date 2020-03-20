using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashPic
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Street with Number")]
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }


    }
}
