using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OALI
    {
        public string OrigItem { get; set; } = null!;
        public string AltItem { get; set; } = null!;
        public decimal? Match { get; set; }
        public string? Remarks { get; set; }
    }
}
