using System;
using System.Collections.Generic;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class Cricket
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public string AgaintsTeam { get; set; }
    }
}
