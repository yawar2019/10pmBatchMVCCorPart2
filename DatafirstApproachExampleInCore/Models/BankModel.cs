using System;
using System.Collections.Generic;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class BankModel
    {
        public int BankId { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string Location { get; set; }
        public string Ifsc { get; set; }
    }
}
