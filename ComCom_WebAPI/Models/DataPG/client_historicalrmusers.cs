using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class client_historicalrmusers
    {
        public string username { get; set; } = null!;
        public string password { get; set; } = null!;
        public int groupid { get; set; }
        public int enableuser { get; set; }
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
        public int usemacauth { get; set; }
        public DateTime expiration { get; set; }
        public long uptimelimit { get; set; }
        public int srvid { get; set; }
        public string staticipcm { get; set; } = null!;
        public string staticipcpe { get; set; } = null!;
        public int ipmodecm { get; set; }
        public int ipmodecpe { get; set; }
        public int poolidcm { get; set; }
        public int poolidcpe { get; set; }
        public DateOnly createdon { get; set; }
        public int acctype { get; set; }
        public decimal credits { get; set; }
        public int cardfails { get; set; }
        public string createdby { get; set; } = null!;
        public string owner { get; set; } = null!;
        public string taxid { get; set; } = null!;
        public string cnic { get; set; } = null!;
        public string email { get; set; } = null!;
        public string maccm { get; set; } = null!;
        public string custattr { get; set; } = null!;
        public int warningsent { get; set; }
        public string verifycode { get; set; } = null!;
        public int verified { get; set; }
        public int selfreg { get; set; }
        public int verifyfails { get; set; }
        public int verifysentnum { get; set; }
        public string verifymobile { get; set; } = null!;
        public string contractid { get; set; } = null!;
        public DateOnly? contractvalid { get; set; }
        public string actcode { get; set; } = null!;
        public int pswactsmsnum { get; set; }
        public int alertemail { get; set; }
        public int alertsms { get; set; }
        public string lang { get; set; } = null!;
        public DateTime? lastlogoff { get; set; }
        public int history_id { get; set; }
        public DateTime history_date { get; set; }
        public string? history_change_reason { get; set; }
        public string history_type { get; set; } = null!;
        public int? history_user_id { get; set; }

        public virtual auth_user? history_user { get; set; }
    }
}
