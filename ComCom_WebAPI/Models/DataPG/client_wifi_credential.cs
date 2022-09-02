using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class client_wifi_credential
    {
        public client_wifi_credential()
        {
            coupon = new HashSet<coupon>();
            oxxo_code = new HashSet<oxxo_code>();
        }

        public int id { get; set; }
        public string username { get; set; } = null!;
        public string password { get; set; } = null!;
        public string client_token { get; set; } = null!;
        public string status { get; set; } = null!;
        public DateTime last_updated_date { get; set; }

        public virtual ICollection<coupon> coupon { get; set; }
        public virtual ICollection<oxxo_code> oxxo_code { get; set; }
    }
}
