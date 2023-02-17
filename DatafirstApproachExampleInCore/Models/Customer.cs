using System;
using System.Collections.Generic;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class Customer
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public int? Age { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public int? CreatedOn { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
