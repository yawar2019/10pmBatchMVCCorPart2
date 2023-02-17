using System;
using System.Collections.Generic;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class Patient
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string Department { get; set; }
    }
}
