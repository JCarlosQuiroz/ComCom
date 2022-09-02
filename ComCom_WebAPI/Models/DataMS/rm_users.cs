using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_users
    {
        public string username { get; set; } = null!;
        public string password { get; set; } = null!;
        public int groupid { get; set; }
        public bool enableuser { get; set; }
        public long uplimit { get; set; }
        public long downlimit { get; set; }
        public long comblimit { get; set; }
        public string firstname { get; set; } = null!;
        public string lastname { get; set; } = null!;
        public string company { get; set; } = null!;
        public string phone { get; set; } = null!;
        public string mobile { get; set; } = null!;
        public string address { get; set; } = null!;
        public string city { get; set; } = null!;
        public string zip { get; set; } = null!;
        public string country { get; set; } = null!;
        public string state { get; set; } = null!;
        public string comment { get; set; } = null!;
        public decimal gpslat { get; set; }
        public decimal gpslong { get; set; }
        public string mac { get; set; } = null!;
        public bool usemacauth { get; set; }
        public DateTime expiration { get; set; }
        public long uptimelimit { get; set; }
        public int srvid { get; set; }
        public string staticipcm { get; set; } = null!;
        public string staticipcpe { get; set; } = null!;
        public bool ipmodecm { get; set; }
        public bool ipmodecpe { get; set; }
        public int poolidcm { get; set; }
        public int poolidcpe { get; set; }
        public string createdon { get; set; } = null!;
        public bool acctype { get; set; }
        public decimal credits { get; set; }
        public sbyte cardfails { get; set; }
        public string createdby { get; set; } = null!;
        public string owner { get; set; } = null!;
        public string taxid { get; set; } = null!;
        public string cnic { get; set; } = null!;
        public string email { get; set; } = null!;
        public string maccm { get; set; } = null!;
        public string custattr { get; set; } = null!;
        public bool warningsent { get; set; }
        public string verifycode { get; set; } = null!;
        public bool verified { get; set; }
        public bool selfreg { get; set; }
        public sbyte verifyfails { get; set; }
        public sbyte verifysentnum { get; set; }
        public string verifymobile { get; set; } = null!;
        public string contractid { get; set; } = null!;
        public string contractvalid { get; set; } = null!;
        public string actcode { get; set; } = null!;
        public sbyte pswactsmsnum { get; set; }
        public bool alertemail { get; set; }
        public bool alertsms { get; set; }
        public string lang { get; set; } = null!;
        public DateTime? lastlogoff { get; set; }
    }
}
