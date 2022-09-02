using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class closure_cutoff_date
    {
        public int id_cutoff_date { get; set; }
        public DateOnly date { get; set; }
        public DateOnly due_date { get; set; }
    }
}
