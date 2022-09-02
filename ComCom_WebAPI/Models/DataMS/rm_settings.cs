using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_settings
    {
        public string currency { get; set; } = null!;
        public bool unixacc { get; set; }
        public bool diskquota { get; set; }
        public string quotatpl { get; set; } = null!;
        public int paymentopt { get; set; }
        public bool changesrv { get; set; }
        public decimal vatpercent { get; set; }
        public decimal advtaxpercent { get; set; }
        public bool disablenotpaid { get; set; }
        public bool disableexpcont { get; set; }
        public bool resetctr { get; set; }
        public bool newnasallsrv { get; set; }
        public bool newmanallsrv { get; set; }
        public bool disconnmethod { get; set; }
        public long warndl { get; set; }
        public int warndlpercent { get; set; }
        public long warnul { get; set; }
        public int warnulpercent { get; set; }
        public long warncomb { get; set; }
        public int warncombpercent { get; set; }
        public long warnuptime { get; set; }
        public int warnuptimepercent { get; set; }
        public int warnexpiry { get; set; }
        public bool expalertmode { get; set; }
        public bool emailselfregman { get; set; }
        public bool emailwelcome { get; set; }
        public bool emailnewsrv { get; set; }
        public bool emailrenew { get; set; }
        public bool smsrenew { get; set; }
        public bool emailexpiry { get; set; }
        public bool smswelcome { get; set; }
        public bool smsexpiry { get; set; }
        public bool warnmode { get; set; }
        public bool selfreg { get; set; }
        public bool edituserdata { get; set; }
        public bool hidelimits { get; set; }
        public bool pm_internal { get; set; }
        public bool pm_paypalstd { get; set; }
        public bool pm_paypalpro { get; set; }
        public bool pm_paypalexp { get; set; }
        public bool pm_sagepay { get; set; }
        public bool pm_authorizenet { get; set; }
        public bool pm_dps { get; set; }
        public bool pm_2co { get; set; }
        public bool pm_payfast { get; set; }
        public bool pm_citrus { get; set; }
        public bool pm_paytm { get; set; }
        public bool unixhost { get; set; }
        public string remotehostname { get; set; } = null!;
        public bool maclock { get; set; }
        public sbyte billingstart { get; set; }
        public bool disconnpostpaid { get; set; }
        public sbyte renewday { get; set; }
        public bool changepswucp { get; set; }
        public bool redeemucp { get; set; }
        public bool buycreditsucp { get; set; }
        public bool selfreg_firstname { get; set; }
        public bool selfreg_lastname { get; set; }
        public bool selfreg_address { get; set; }
        public bool selfreg_city { get; set; }
        public bool selfreg_zip { get; set; }
        public bool selfreg_country { get; set; }
        public bool selfreg_state { get; set; }
        public bool selfreg_phone { get; set; }
        public bool selfreg_mobile { get; set; }
        public bool selfreg_email { get; set; }
        public bool selfreg_mobactsms { get; set; }
        public bool selfreg_nameactemail { get; set; }
        public bool selfreg_nameactsms { get; set; }
        public bool selfreg_endupemail { get; set; }
        public bool selfreg_endupmobile { get; set; }
        public bool selfreg_vatid { get; set; }
        public bool ias_email { get; set; }
        public bool ias_mobile { get; set; }
        public bool ias_verify { get; set; }
        public bool ias_endupemail { get; set; }
        public bool ias_endupmobile { get; set; }
        public int simuseselfreg { get; set; }
        public int defgrpid { get; set; }
        public bool captcha { get; set; }
    }
}
