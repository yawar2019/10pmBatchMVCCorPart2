using System;
using System.Collections.Generic;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class AnuragMotelGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
    }
}
