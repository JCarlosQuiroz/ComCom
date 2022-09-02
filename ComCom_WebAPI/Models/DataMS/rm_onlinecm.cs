using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_onlinecm
    {
        public string username { get; set; } = null!;
        public string? maccm { get; set; }
        public bool? enableuser { get; set; }
        public string? staticipcm { get; set; }
        public string? maccpe { get; set; }
        public string? ipcpe { get; set; }
        public bool? ipmodecpe { get; set; }
        public int? cmtsid { get; set; }
        public int? groupid { get; set; }
        public string? groupname { get; set; }
        public decimal? snrds { get; set; }
        public decimal? snrus { get; set; }
        public decimal? txpwr { get; set; }
        public decimal? rxpwr { get; set; }
        public decimal? pingtime { get; set; }
        public string? upstreamname { get; set; }
        public int? ifidx { get; set; }
        public DateTime timestamp { get; set; }
    }
}
