using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class coupon_coupons
    {
        public coupon_coupons()
        {
            coupon_coupons_logs = new HashSet<coupon_coupons_logs>();
            credit_puchases = new HashSet<credit_puchases>();
            credit_requests = new HashSet<credit_requests>();
        }

        public uint id_coupon { get; set; }
        public uint? id_book { get; set; }
        public uint id_distributor { get; set; }
        public uint? id_user { get; set; }
        public uint? id_customer { get; set; }
        public uint? id_charge_type { get; set; }
        public uint? id_store { get; set; }
        public uint? id_branch { get; set; }
        public byte status { get; set; }
        public DateOnly created { get; set; }
        public DateOnly? delivered { get; set; }
        public DateOnly? canceled { get; set; }
        public DateOnly? exchanged { get; set; }
        public DateOnly expiration_date { get; set; }
        public decimal amount { get; set; }
        public decimal interest { get; set; }
        public uint? fortnights { get; set; }
        public byte type { get; set; }
        public string? folio { get; set; }
        public string? cancellation_note { get; set; }
        public uint? id_amount { get; set; }
        public uint? id_fortnight { get; set; }
        public uint? id_cancellation_reason { get; set; }

        public virtual credit_amounts? id_amountNavigation { get; set; }
        public virtual coupon_books? id_bookNavigation { get; set; }
        public virtual credit_charge_type? id_charge_typeNavigation { get; set; }
        public virtual credit_customers? id_customerNavigation { get; set; }
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual core_stores? id_storeNavigation { get; set; }
        public virtual core_users? id_userNavigation { get; set; }
        public virtual ICollection<coupon_coupons_logs> coupon_coupons_logs { get; set; }
        public virtual ICollection<credit_puchases> credit_puchases { get; set; }
        public virtual ICollection<credit_requests> credit_requests { get; set; }
    }
}
