using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_wlan
    {
        public string? maccpe { get; set; }
        public short? signal { get; set; }
        public short? ccq { get; set; }
        public short? snr { get; set; }
        public string? apip { get; set; }
        public DateTime timestamp { get; set; }
    }
}
