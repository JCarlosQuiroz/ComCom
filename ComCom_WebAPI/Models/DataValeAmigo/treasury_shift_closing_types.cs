using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class treasury_shift_closing_types
    {
        public treasury_shift_closing_types()
        {
            treasury_shift_closings = new HashSet<treasury_shift_closings>();
        }

        public int id_shift_closing_type { get; set; }
        public string description { get; set; } = null!;
        public int status { get; set; }

        public virtual ICollection<treasury_shift_closings> treasury_shift_closings { get; set; }
    }
}
