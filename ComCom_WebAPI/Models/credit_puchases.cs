using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_puchases
    {
        public credit_puchases()
        {
            Inverseid_parentNavigation = new HashSet<credit_puchases>();
            credit_payments = new HashSet<credit_payments>();
            credit_payments_entries = new HashSet<credit_payments_entries>();
            credit_purchases_amortizations = new HashSet<credit_purchases_amortizations>();
            credit_purchases_beneficiaries = new HashSet<credit_purchases_beneficiaries>();
            credit_purchases_logs = new HashSet<credit_purchases_logs>();
            credit_requests = new HashSet<credit_requests>();
            treasury_boxes_payments = new HashSet<treasury_boxes_payments>();
            id_alert_entry = new HashSet<piorpi_alerts_entries>();
        }

        public uint id_purchase { get; set; }
        public uint id_distributor { get; set; }
        public uint id_credit { get; set; }
        public uint? id_customer { get; set; }
        public uint id_charge_type { get; set; }
        public uint? id_coupon { get; set; }
        public uint? id_zone { get; set; }
        public uint id_branch { get; set; }
        public uint? id_parent { get; set; }
        public byte status { get; set; }
        public uint fortnights { get; set; }
        public decimal amount { get; set; }
        public decimal interest { get; set; }
        public DateOnly date { get; set; }
        public DateOnly first_due_date { get; set; }
        public decimal? insurance { get; set; }
        public DateOnly? dispersion_date { get; set; }
        public DateOnly? cancellation_date { get; set; }
        public byte is_paid { get; set; }
        public DateTime? registered { get; set; }
        public string? cancellation_note { get; set; }
        public sbyte? is_renovation { get; set; }

        public virtual core_branches id_branchNavigation { get; set; } = null!;
        public virtual credit_charge_type id_charge_typeNavigation { get; set; } = null!;
        public virtual coupon_coupons? id_couponNavigation { get; set; }
        public virtual credit_credits id_creditNavigation { get; set; } = null!;
        public virtual credit_customers? id_customerNavigation { get; set; }
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual credit_puchases? id_parentNavigation { get; set; }
        public virtual core_zones? id_zoneNavigation { get; set; }
        public virtual ICollection<credit_puchases> Inverseid_parentNavigation { get; set; }
        public virtual ICollection<credit_payments> credit_payments { get; set; }
        public virtual ICollection<credit_payments_entries> credit_payments_entries { get; set; }
        public virtual ICollection<credit_purchases_amortizations> credit_purchases_amortizations { get; set; }
        public virtual ICollection<credit_purchases_beneficiaries> credit_purchases_beneficiaries { get; set; }
        public virtual ICollection<credit_purchases_logs> credit_purchases_logs { get; set; }
        public virtual ICollection<credit_requests> credit_requests { get; set; }
        public virtual ICollection<treasury_boxes_payments> treasury_boxes_payments { get; set; }

        public virtual ICollection<piorpi_alerts_entries> id_alert_entry { get; set; }
    }
}
