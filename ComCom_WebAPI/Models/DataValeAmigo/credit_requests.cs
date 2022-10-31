using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_requests
    {
        public credit_requests()
        {
            credit_requests_files = new HashSet<credit_requests_files>();
        }

        public uint id_request { get; set; }
        public uint id_distributor { get; set; }
        public uint id_credit { get; set; }
        public uint id_requested { get; set; }
        public uint? id_validated { get; set; }
        public uint? id_authorized { get; set; }
        public uint? id_purchase { get; set; }
        public uint? id_charge { get; set; }
        public uint id_request_type { get; set; }
        public byte status { get; set; }
        public byte? type { get; set; }
        public DateOnly request_date { get; set; }
        public DateOnly? authorize_date { get; set; }
        public DateOnly? validate_date { get; set; }
        public decimal? to { get; set; }
        public decimal limit { get; set; }
        public decimal due_balance { get; set; }
        public decimal payable_balance { get; set; }
        public decimal current_balance { get; set; }
        public decimal total_balance { get; set; }
        public decimal? percent { get; set; }
        public uint? fortnights { get; set; }
        public DateOnly? first_due_date { get; set; }
        public uint? days { get; set; }
        public DateOnly? cancellation_date { get; set; }
        public uint? id_cancellation_reason { get; set; }
        public uint? id_cancelled { get; set; }
        public uint? id_coupon { get; set; }
        public decimal? interest { get; set; }
        public byte has_insurance { get; set; }
        public sbyte? has_covid_insurance { get; set; }
        public string? note { get; set; }
        public uint? id_payment_credit_note_type { get; set; }
        public uint? id_customer { get; set; }
        public byte? last_purchase_amortization_charge { get; set; }

        public virtual core_users? id_authorizedNavigation { get; set; }
        public virtual credit_cancellation_reasons? id_cancellation_reasonNavigation { get; set; }
        public virtual core_users? id_cancelledNavigation { get; set; }
        public virtual credit_charges? id_chargeNavigation { get; set; }
        public virtual coupon_coupons? id_couponNavigation { get; set; }
        public virtual credit_credits id_creditNavigation { get; set; } = null!;
        public virtual credit_customers? id_customerNavigation { get; set; }
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual credit_payment_credits_notes_types? id_payment_credit_note_typeNavigation { get; set; }
        public virtual credit_puchases? id_purchaseNavigation { get; set; }
        public virtual credit_requests_types id_request_typeNavigation { get; set; } = null!;
        public virtual core_users id_requestedNavigation { get; set; } = null!;
        public virtual core_users? id_validatedNavigation { get; set; }
        public virtual ICollection<credit_requests_files> credit_requests_files { get; set; }
    }
}
