using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OOST
    {
        public int Num { get; set; }
        public string? Descript { get; set; }
        public short StepId { get; set; }
        public decimal? CloPrcnt { get; set; }
        public string? Canceled { get; set; }
        public short? UserSign { get; set; }
        public string? SalesStage { get; set; }
        public string? PurStage { get; set; }
    }
}
