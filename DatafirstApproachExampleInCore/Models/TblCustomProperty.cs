using System;
using System.Collections.Generic;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class TblCustomProperty
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
        public int? FieldLength { get; set; }
        public bool? IsActive { get; set; }
        public string FieldType { get; set; }
        public int? OrderId { get; set; }
        public string ReadOnlyProp { get; set; }
    }
}
