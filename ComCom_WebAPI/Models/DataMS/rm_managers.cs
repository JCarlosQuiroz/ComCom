using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_managers
    {
        public string managername { get; set; } = null!;
        public string password { get; set; } = null!;
        public string firstname { get; set; } = null!;
        public string lastname { get; set; } = null!;
        public string phone { get; set; } = null!;
        public string mobile { get; set; } = null!;
        public string address { get; set; } = null!;
        public string city { get; set; } = null!;
        public string zip { get; set; } = null!;
        public string country { get; set; } = null!;
        public string state { get; set; } = null!;
        public string comment { get; set; } = null!;
        public string company { get; set; } = null!;
        public string vatid { get; set; } = null!;
        public string email { get; set; } = null!;
        public decimal balance { get; set; }
        public bool perm_listusers { get; set; }
        public bool perm_createusers { get; set; }
        public bool perm_editusers { get; set; }
        public bool perm_edituserspriv { get; set; }
        public bool perm_deleteusers { get; set; }
        public bool perm_listmanagers { get; set; }
        public bool perm_createmanagers { get; set; }
        public bool perm_editmanagers { get; set; }
        public bool perm_deletemanagers { get; set; }
        public bool perm_listservices { get; set; }
        public bool perm_createservices { get; set; }
        public bool perm_editservices { get; set; }
        public bool perm_deleteservices { get; set; }
        public bool perm_listonlineusers { get; set; }
        public bool perm_listinvoices { get; set; }
        public bool perm_trafficreport { get; set; }
        public bool perm_addcredits { get; set; }
        public bool perm_negbalance { get; set; }
        public bool perm_listallinvoices { get; set; }
        public bool perm_showinvtotals { get; set; }
        public bool perm_logout { get; set; }
        public bool perm_cardsys { get; set; }
        public bool perm_editinvoice { get; set; }
        public bool perm_allusers { get; set; }
        public bool perm_allowdiscount { get; set; }
        public bool perm_enwriteoff { get; set; }
        public bool perm_accessap { get; set; }
        public bool perm_cts { get; set; }
        public bool perm_email { get; set; }
        public bool perm_sms { get; set; }
        public bool enablemanager { get; set; }
        public string lang { get; set; } = null!;
    }
}
