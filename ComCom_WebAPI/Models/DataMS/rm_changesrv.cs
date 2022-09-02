using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_changesrv
    {
        public int id { get; set; }
        public string username { get; set; } = null!;
        public int newsrvid { get; set; }
        public string newsrvname { get; set; } = null!;
        public string scheduledate { get; set; } = null!;
        public string requestdate { get; set; } = null!;
        public bool status { get; set; }
        public string transid { get; set; } = null!;
        public string requested { get; set; } = null!;
    }
}
