using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_invoices
    {
        public int id { get; set; }
        public bool invgroup { get; set; }
        public string invnum { get; set; } = null!;
        public string managername { get; set; } = null!;
        public string username { get; set; } = null!;
        public string date { get; set; } = null!;
        public long bytesdl { get; set; }
        public long bytesul { get; set; }
        public long bytescomb { get; set; }
        public long downlimit { get; set; }
        public long uplimit { get; set; }
        public long comblimit { get; set; }
        public int time { get; set; }
        public long uptimelimit { get; set; }
        public int days { get; set; }
        public string expiration { get; set; } = null!;
        public bool capdl { get; set; }
        public bool capul { get; set; }
        public bool captotal { get; set; }
        public bool captime { get; set; }
        public bool capdate { get; set; }
        public string service { get; set; } = null!;
        public string comment { get; set; } = null!;
        public string transid { get; set; } = null!;
        public decimal amount { get; set; }
        public string address { get; set; } = null!;
        public string city { get; set; } = null!;
        public string zip { get; set; } = null!;
        public string country { get; set; } = null!;
        public string state { get; set; } = null!;
        public string fullname { get; set; } = null!;
        public string taxid { get; set; } = null!;
        public string paymentopt { get; set; } = null!;
        public bool invtype { get; set; }
        public sbyte paymode { get; set; }
        public string paid { get; set; } = null!;
        public decimal price { get; set; }
        public decimal tax { get; set; }
        public decimal advtax { get; set; }
        public decimal vatpercent { get; set; }
        public decimal advtaxpercent { get; set; }
        public string remark { get; set; } = null!;
        public decimal balance { get; set; }
        public string gwtransid { get; set; } = null!;
        public string phone { get; set; } = null!;
        public string mobile { get; set; } = null!;
    }
}
