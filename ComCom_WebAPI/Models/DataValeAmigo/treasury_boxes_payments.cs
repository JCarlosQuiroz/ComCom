using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class treasury_boxes_payments
    {
        public treasury_boxes_payments()
        {
            id_box_closure = new HashSet<treasury_box_closures>();
        }

        public uint id_box_payment { get; set; }
        public uint id_box { get; set; }
        public uint? id_distributor { get; set; }
        public uint? id_customer { get; set; }
        public uint? id_provider { get; set; }
        public uint? id_payment { get; set; }
        public uint? id_purchase { get; set; }
        public uint id_user { get; set; }
        public byte status { get; set; }
        public byte type { get; set; }
        public DateTime datetime { get; set; }
        public decimal amount { get; set; }
        public DateTime? cancellation_date { get; set; }

        public virtual treasury_boxes id_boxNavigation { get; set; } = null!;
        public virtual credit_customers? id_customerNavigation { get; set; }
        public virtual credit_distributors? id_distributorNavigation { get; set; }
        public virtual credit_payments? id_paymentNavigation { get; set; }
        public virtual treasury_providers? id_providerNavigation { get; set; }
        public virtual credit_puchases? id_purchaseNavigation { get; set; }
        public virtual core_users id_userNavigation { get; set; } = null!;

        public virtual ICollection<treasury_box_closures> id_box_closure { get; set; }
    }
}
