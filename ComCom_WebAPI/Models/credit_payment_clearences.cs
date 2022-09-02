using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_payment_clearences
    {
        public uint id_payment_clearence { get; set; }
        public decimal amount { get; set; }
        public uint id_user { get; set; }
        public DateTime creation_date { get; set; }

        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}
