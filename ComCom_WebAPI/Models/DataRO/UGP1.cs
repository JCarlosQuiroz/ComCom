using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class UGP1
    {
        public int UgpEntry { get; set; }
        public int UomEntry { get; set; }
        public decimal? AltQty { get; set; }
        public decimal? BaseQty { get; set; }
        public int? LogInstanc { get; set; }
        public int LineNum { get; set; }
        public short? WghtFactor { get; set; }
        public int? UdfFactor { get; set; }
    }
}
