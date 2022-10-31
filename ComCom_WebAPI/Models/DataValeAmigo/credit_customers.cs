using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_customers
    {
        public credit_customers()
        {
            coupon_coupons = new HashSet<coupon_coupons>();
            credit_beneficiaries = new HashSet<credit_beneficiaries>();
            credit_customers_files = new HashSet<credit_customers_files>();
            credit_customers_logs = new HashSet<credit_customers_logs>();
            credit_payments = new HashSet<credit_payments>();
            credit_puchases = new HashSet<credit_puchases>();
            credit_requests = new HashSet<credit_requests>();
            treasury_boxes_payments = new HashSet<treasury_boxes_payments>();
            id_distributor = new HashSet<credit_distributors>();
        }

        public uint id_customer { get; set; }
        public uint id_person { get; set; }
        public uint id_branch { get; set; }
        public byte status { get; set; }
        public DateOnly created { get; set; }

        public virtual core_branches id_branchNavigation { get; set; } = null!;
        public virtual credit_persons id_personNavigation { get; set; } = null!;
        public virtual ICollection<coupon_coupons> coupon_coupons { get; set; }
        public virtual ICollection<credit_beneficiaries> credit_beneficiaries { get; set; }
        public virtual ICollection<credit_customers_files> credit_customers_files { get; set; }
        public virtual ICollection<credit_customers_logs> credit_customers_logs { get; set; }
        public virtual ICollection<credit_payments> credit_payments { get; set; }
        public virtual ICollection<credit_puchases> credit_puchases { get; set; }
        public virtual ICollection<credit_requests> credit_requests { get; set; }
        public virtual ICollection<treasury_boxes_payments> treasury_boxes_payments { get; set; }

        public virtual ICollection<credit_distributors> id_distributor { get; set; }
    }
}
