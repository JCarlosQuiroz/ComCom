using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_specperacnt
    {
        public int id { get; set; }
        public int srvid { get; set; }
        public TimeSpan starttime { get; set; }
        public TimeSpan endtime { get; set; }
        public decimal timeratio { get; set; }
        public decimal dlratio { get; set; }
        public decimal ulratio { get; set; }
        public bool connallowed { get; set; }
        public bool mon { get; set; }
        public bool tue { get; set; }
        public bool wed { get; set; }
        public bool thu { get; set; }
        public bool fri { get; set; }
        public bool sat { get; set; }
        public bool sun { get; set; }
    }
}
