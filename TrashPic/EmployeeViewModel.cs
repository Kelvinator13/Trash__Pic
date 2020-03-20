using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrashPic.Models;

namespace TrashPic
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public List<Customer> Customers { get; set; }
        public Address Address  { get; set; }
        public MaintenanceInfo MaintenanceInfo { get; set; }

    }
}
