using ComCom_WebAPI.Models.DataValeAmigo;
using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_users
    {
        public core_users()
        {
            closure_closures = new HashSet<closure_closures>();
            collection_coordinations = new HashSet<collection_coordinations>();
            collection_logs = new HashSet<collection_logs>();
            collection_managements = new HashSet<collection_managements>();
            collection_managers = new HashSet<collection_managers>();
            collection_receipt_books = new HashSet<collection_receipt_books>();
            collection_receipt_requests = new HashSet<collection_receipt_requests>();
            collection_receipts = new HashSet<collection_receipts>();
            collection_teams = new HashSet<collection_teams>();
            collection_teams_members = new HashSet<collection_teams_members>();
            core_logs = new HashSet<core_logs>();
            core_notificationsid_fromNavigation = new HashSet<core_notifications>();
            core_notificationsid_userNavigation = new HashSet<core_notifications>();
            core_users_logs = new HashSet<core_users_logs>();
            coupon_books = new HashSet<coupon_books>();
            coupon_configurations = new HashSet<coupon_configurations>();
            coupon_configurations_books = new HashSet<coupon_configurations_books>();
            coupon_configurations_vouchers = new HashSet<coupon_configurations_vouchers>();
            coupon_coupons = new HashSet<coupon_coupons>();
            coupon_coupons_logs = new HashSet<coupon_coupons_logs>();
            credinet_configuration = new HashSet<credinet_configuration>();
            credit_beneficiaries = new HashSet<credit_beneficiaries>();
            credit_configurations_interests_logs = new HashSet<credit_configurations_interests_logs>();
            credit_configurations_receipts = new HashSet<credit_configurations_receipts>();
            credit_credit_notes = new HashSet<credit_credit_notes>();
            credit_credits_types_logs = new HashSet<credit_credits_types_logs>();
            credit_customers_logs = new HashSet<credit_customers_logs>();
            credit_distributors_logs = new HashSet<credit_distributors_logs>();
            credit_distributors_signatures_logs = new HashSet<credit_distributors_signatures_logs>();
            credit_payment_clearences = new HashSet<credit_payment_clearences>();
            credit_personal_loan_requeriments = new HashSet<credit_personal_loan_requeriments>();
            credit_printables_logs = new HashSet<credit_printables_logs>();
            credit_protections_requests_alerts = new HashSet<credit_protections_requests_alerts>();
            credit_purchases_logs = new HashSet<credit_purchases_logs>();
            credit_requestsid_authorizedNavigation = new HashSet<credit_requests>();
            credit_requestsid_cancelledNavigation = new HashSet<credit_requests>();
            credit_requestsid_requestedNavigation = new HashSet<credit_requests>();
            credit_requestsid_validatedNavigation = new HashSet<credit_requests>();
            credit_supervisors = new HashSet<credit_supervisors>();
            origination_alerts = new HashSet<origination_alerts>();
            origination_applications_inquiries = new HashSet<origination_applications_inquiries>();
            origination_applicationsid_userNavigation = new HashSet<origination_applications>();
            origination_applicationsid_user_cancellationNavigation = new HashSet<origination_applications>();
            origination_domiciliary_inquiries = new HashSet<origination_domiciliary_inquiries>();
            origination_scoring_approval_conditions = new HashSet<origination_scoring_approval_conditions>();
            origination_scoring_field_answers = new HashSet<origination_scoring_field_answers>();
            origination_scoring_fields = new HashSet<origination_scoring_fields>();
            origination_scorings = new HashSet<origination_scorings>();
            origination_telephone_inquiries = new HashSet<origination_telephone_inquiries>();
            piorpi_alerts = new HashSet<piorpi_alerts>();
            treasury_box_closures = new HashSet<treasury_box_closures>();
            treasury_boxes = new HashSet<treasury_boxes>();
            treasury_boxes_injections = new HashSet<treasury_boxes_injections>();
            treasury_boxes_payments = new HashSet<treasury_boxes_payments>();
            treasury_providers_requests = new HashSet<treasury_providers_requests>();
            treasury_shift_closings = new HashSet<treasury_shift_closings>();
            id_box = new HashSet<treasury_boxes>();
            id_branch = new HashSet<core_branches>();
            id_role = new HashSet<core_roles>();
        }

        public uint id_user { get; set; }
        public uint id_person { get; set; }
        public string status { get; set; } = null!;
        public string username { get; set; } = null!;
        public string password { get; set; } = null!;
        public string email { get; set; } = null!;
        public DateTime? last_login { get; set; }
        public string? code { get; set; }
        public byte is_corporate { get; set; }
        public byte is_s2next { get; set; }
        public DateTime? update_password_at { get; set; }

        public virtual core_persons id_personNavigation { get; set; } = null!;
        public virtual ICollection<closure_closures> closure_closures { get; set; }
        public virtual ICollection<collection_coordinations> collection_coordinations { get; set; }
        public virtual ICollection<collection_logs> collection_logs { get; set; }
        public virtual ICollection<collection_managements> collection_managements { get; set; }
        public virtual ICollection<collection_managers> collection_managers { get; set; }
        public virtual ICollection<collection_receipt_books> collection_receipt_books { get; set; }
        public virtual ICollection<collection_receipt_requests> collection_receipt_requests { get; set; }
        public virtual ICollection<collection_receipts> collection_receipts { get; set; }
        public virtual ICollection<collection_teams> collection_teams { get; set; }
        public virtual ICollection<collection_teams_members> collection_teams_members { get; set; }
        public virtual ICollection<core_logs> core_logs { get; set; }
        public virtual ICollection<core_notifications> core_notificationsid_fromNavigation { get; set; }
        public virtual ICollection<core_notifications> core_notificationsid_userNavigation { get; set; }
        public virtual ICollection<core_users_logs> core_users_logs { get; set; }
        public virtual ICollection<coupon_books> coupon_books { get; set; }
        public virtual ICollection<coupon_configurations> coupon_configurations { get; set; }
        public virtual ICollection<coupon_configurations_books> coupon_configurations_books { get; set; }
        public virtual ICollection<coupon_configurations_vouchers> coupon_configurations_vouchers { get; set; }
        public virtual ICollection<coupon_coupons> coupon_coupons { get; set; }
        public virtual ICollection<coupon_coupons_logs> coupon_coupons_logs { get; set; }
        public virtual ICollection<credinet_configuration> credinet_configuration { get; set; }
        public virtual ICollection<credit_beneficiaries> credit_beneficiaries { get; set; }
        public virtual ICollection<credit_configurations_interests_logs> credit_configurations_interests_logs { get; set; }
        public virtual ICollection<credit_configurations_receipts> credit_configurations_receipts { get; set; }
        public virtual ICollection<credit_credit_notes> credit_credit_notes { get; set; }
        public virtual ICollection<credit_credits_types_logs> credit_credits_types_logs { get; set; }
        public virtual ICollection<credit_customers_logs> credit_customers_logs { get; set; }
        public virtual ICollection<credit_distributors_logs> credit_distributors_logs { get; set; }
        public virtual ICollection<credit_distributors_signatures_logs> credit_distributors_signatures_logs { get; set; }
        public virtual ICollection<credit_payment_clearences> credit_payment_clearences { get; set; }
        public virtual ICollection<credit_personal_loan_requeriments> credit_personal_loan_requeriments { get; set; }
        public virtual ICollection<credit_printables_logs> credit_printables_logs { get; set; }
        public virtual ICollection<credit_protections_requests_alerts> credit_protections_requests_alerts { get; set; }
        public virtual ICollection<credit_purchases_logs> credit_purchases_logs { get; set; }
        public virtual ICollection<credit_requests> credit_requestsid_authorizedNavigation { get; set; }
        public virtual ICollection<credit_requests> credit_requestsid_cancelledNavigation { get; set; }
        public virtual ICollection<credit_requests> credit_requestsid_requestedNavigation { get; set; }
        public virtual ICollection<credit_requests> credit_requestsid_validatedNavigation { get; set; }
        public virtual ICollection<credit_supervisors> credit_supervisors { get; set; }
        public virtual ICollection<origination_alerts> origination_alerts { get; set; }
        public virtual ICollection<origination_applications_inquiries> origination_applications_inquiries { get; set; }
        public virtual ICollection<origination_applications> origination_applicationsid_userNavigation { get; set; }
        public virtual ICollection<origination_applications> origination_applicationsid_user_cancellationNavigation { get; set; }
        public virtual ICollection<origination_domiciliary_inquiries> origination_domiciliary_inquiries { get; set; }
        public virtual ICollection<origination_scoring_approval_conditions> origination_scoring_approval_conditions { get; set; }
        public virtual ICollection<origination_scoring_field_answers> origination_scoring_field_answers { get; set; }
        public virtual ICollection<origination_scoring_fields> origination_scoring_fields { get; set; }
        public virtual ICollection<origination_scorings> origination_scorings { get; set; }
        public virtual ICollection<origination_telephone_inquiries> origination_telephone_inquiries { get; set; }
        public virtual ICollection<piorpi_alerts> piorpi_alerts { get; set; }
        public virtual ICollection<treasury_box_closures> treasury_box_closures { get; set; }
        public virtual ICollection<treasury_boxes> treasury_boxes { get; set; }
        public virtual ICollection<treasury_boxes_injections> treasury_boxes_injections { get; set; }
        public virtual ICollection<treasury_boxes_payments> treasury_boxes_payments { get; set; }
        public virtual ICollection<treasury_providers_requests> treasury_providers_requests { get; set; }
        public virtual ICollection<treasury_shift_closings> treasury_shift_closings { get; set; }

        public virtual ICollection<treasury_boxes> id_box { get; set; }
        public virtual ICollection<core_branches> id_branch { get; set; }
        public virtual ICollection<core_roles> id_role { get; set; }
    }
}
