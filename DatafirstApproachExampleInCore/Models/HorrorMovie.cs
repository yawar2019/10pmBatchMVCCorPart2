using System;
using System.Collections.Generic;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class HorrorMovie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string MovieType { get; set; }
        public int Ranking { get; set; }
        public string Description { get; set; }
        public int? Budget { get; set; }
    }
}
