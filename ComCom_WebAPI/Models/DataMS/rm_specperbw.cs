using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_specperbw
    {
        public int id { get; set; }
        public int srvid { get; set; }
        public TimeSpan starttime { get; set; }
        public TimeSpan endtime { get; set; }
        public int dlrate { get; set; }
        public int ulrate { get; set; }
        public int dlburstlimit { get; set; }
        public int ulburstlimit { get; set; }
        public int dlburstthreshold { get; set; }
        public int ulburstthreshold { get; set; }
        public int dlbursttime { get; set; }
        public int ulbursttime { get; set; }
        public bool enableburst { get; set; }
        public int priority { get; set; }
        public bool mon { get; set; }
        public bool tue { get; set; }
        public bool wed { get; set; }
        public bool thu { get; set; }
        public bool fri { get; set; }
        public bool sat { get; set; }
        public bool sun { get; set; }
    }
}
