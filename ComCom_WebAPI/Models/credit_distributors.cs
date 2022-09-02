using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_distributors
    {
        public credit_distributors()
        {
            closure_closures_entries = new HashSet<closure_closures_entries>();
            collection_assignments = new HashSet<collection_assignments>();
            collection_managements = new HashSet<collection_managements>();
            collection_receipts = new HashSet<collection_receipts>();
            collection_tasks = new HashSet<collection_tasks>();
            coupon_books = new HashSet<coupon_books>();
            coupon_coupons = new HashSet<coupon_coupons>();
            credit_activities = new HashSet<credit_activities>();
            credit_beneficiaries = new HashSet<credit_beneficiaries>();
            credit_charges = new HashSet<credit_charges>();
            credit_contracts = new HashSet<credit_contracts>();
            credit_credit_notes = new HashSet<credit_credit_notes>();
            credit_credits = new HashSet<credit_credits>();
            credit_distributors_extra_fields = new HashSet<credit_distributors_extra_fields>();
            credit_distributors_files = new HashSet<credit_distributors_files>();
            credit_distributors_logs = new HashSet<credit_distributors_logs>();
            credit_distributors_rivalries = new HashSet<credit_distributors_rivalries>();
            credit_distributors_signatures_logs = new HashSet<credit_distributors_signatures_logs>();
            credit_expenses = new HashSet<credit_expenses>();
            credit_guarantees = new HashSet<credit_guarantees>();
            credit_payments = new HashSet<credit_payments>();
            credit_payments_traffic_light = new HashSet<credit_payments_traffic_light>();
            credit_personal_references = new HashSet<credit_personal_references>();
            credit_printables = new HashSet<credit_printables>();
            credit_promissory_notes = new HashSet<credit_promissory_notes>();
            credit_properties = new HashSet<credit_properties>();
            credit_puchases = new HashSet<credit_puchases>();
            credit_requests = new HashSet<credit_requests>();
            credit_spouses = new HashSet<credit_spouses>();
            piorpi_alerts_entries = new HashSet<piorpi_alerts_entries>();
            treasury_boxes_payments = new HashSet<treasury_boxes_payments>();
            id_customer = new HashSet<credit_customers>();
            id_group = new HashSet<collection_groups>();
        }

        public uint id_distributor { get; set; }
        public uint id_person { get; set; }
        public uint? id_application { get; set; }
        public uint id_branch { get; set; }
        public uint? id_category { get; set; }
        public byte status { get; set; }
        public uint number { get; set; }
        public DateOnly created { get; set; }
        public byte[]? signature { get; set; }
        public string? token { get; set; }
        public string? code { get; set; }
        public string? google_token { get; set; }
        public string? reference { get; set; }
        public int? pin { get; set; }
        public sbyte is_active { get; set; }
        public string? device_registered { get; set; }
        public string auth_phone { get; set; } = null!;

        public virtual core_branches id_branchNavigation { get; set; } = null!;
        public virtual credit_categories? id_categoryNavigation { get; set; }
        public virtual credit_persons id_personNavigation { get; set; } = null!;
        public virtual ICollection<closure_closures_entries> closure_closures_entries { get; set; }
        public virtual ICollection<collection_assignments> collection_assignments { get; set; }
        public virtual ICollection<collection_managements> collection_managements { get; set; }
        public virtual ICollection<collection_receipts> collection_receipts { get; set; }
        public virtual ICollection<collection_tasks> collection_tasks { get; set; }
        public virtual ICollection<coupon_books> coupon_books { get; set; }
        public virtual ICollection<coupon_coupons> coupon_coupons { get; set; }
        public virtual ICollection<credit_activities> credit_activities { get; set; }
        public virtual ICollection<credit_beneficiaries> credit_beneficiaries { get; set; }
        public virtual ICollection<credit_charges> credit_charges { get; set; }
        public virtual ICollection<credit_contracts> credit_contracts { get; set; }
        public virtual ICollection<credit_credit_notes> credit_credit_notes { get; set; }
        public virtual ICollection<credit_credits> credit_credits { get; set; }
        public virtual ICollection<credit_distributors_extra_fields> credit_distributors_extra_fields { get; set; }
        public virtual ICollection<credit_distributors_files> credit_distributors_files { get; set; }
        public virtual ICollection<credit_distributors_logs> credit_distributors_logs { get; set; }
        public virtual ICollection<credit_distributors_rivalries> credit_distributors_rivalries { get; set; }
        public virtual ICollection<credit_distributors_signatures_logs> credit_distributors_signatures_logs { get; set; }
        public virtual ICollection<credit_expenses> credit_expenses { get; set; }
        public virtual ICollection<credit_guarantees> credit_guarantees { get; set; }
        public virtual ICollection<credit_payments> credit_payments { get; set; }
        public virtual ICollection<credit_payments_traffic_light> credit_payments_traffic_light { get; set; }
        public virtual ICollection<credit_personal_references> credit_personal_references { get; set; }
        public virtual ICollection<credit_printables> credit_printables { get; set; }
        public virtual ICollection<credit_promissory_notes> credit_promissory_notes { get; set; }
        public virtual ICollection<credit_properties> credit_properties { get; set; }
        public virtual ICollection<credit_puchases> credit_puchases { get; set; }
        public virtual ICollection<credit_requests> credit_requests { get; set; }
        public virtual ICollection<credit_spouses> credit_spouses { get; set; }
        public virtual ICollection<piorpi_alerts_entries> piorpi_alerts_entries { get; set; }
        public virtual ICollection<treasury_boxes_payments> treasury_boxes_payments { get; set; }

        public virtual ICollection<credit_customers> id_customer { get; set; }
        public virtual ICollection<collection_groups> id_group { get; set; }
    }
}
