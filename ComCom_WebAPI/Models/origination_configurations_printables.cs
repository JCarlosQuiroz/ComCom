using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_configurations_printables
    {
        public origination_configurations_printables()
        {
            credit_printables = new HashSet<credit_printables>();
        }

        public uint id_configuration_printable { get; set; }
        public string name { get; set; } = null!;
        public string? header { get; set; }
        public byte[] content { get; set; } = null!;
        public string? footer { get; set; }
        public byte status { get; set; }
        public string? image_header { get; set; }
        public string? image_footer { get; set; }
        public byte font { get; set; }
        public uint font_size { get; set; }
        public string color { get; set; } = null!;
        public byte is_promissory_note { get; set; }

        public virtual ICollection<credit_printables> credit_printables { get; set; }
    }
}
