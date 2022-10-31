using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_protections_requests
    {
        public credit_protections_requests()
        {
            credit_protections_requests_alerts = new HashSet<credit_protections_requests_alerts>();
            credit_protections_requests_files = new HashSet<credit_protections_requests_files>();
        }

        public uint id_protection_request { get; set; }
        public uint id_distributor { get; set; }
        public uint id_credit { get; set; }
        public uint id_requested { get; set; }
        public uint? id_validated { get; set; }
        public uint? id_authorized { get; set; }
        public uint id_protection_request_type { get; set; }
        public sbyte? status { get; set; }
        public DateTime? request_date { get; set; }
        public DateTime? validate_date { get; set; }
        public DateTime? authorize_date { get; set; }
        public uint? id_customer { get; set; }
        public DateOnly? death_date { get; set; }
        public DateOnly? documentation_delivery_date { get; set; }
        public string? death_cause { get; set; }
        public string? death_certificate_number { get; set; }
        public uint? id_purchase { get; set; }
        public uint? id_beneficiary { get; set; }
        public string? note { get; set; }
        public decimal? amount_discount { get; set; }
        public decimal? amount { get; set; }
        public uint? id_coupon { get; set; }
        public uint? covered_payments { get; set; }
        public uint? payments_to_forgive { get; set; }
        public byte? death_type { get; set; }
        public byte? car_accident { get; set; }
        public string? derivated_death { get; set; }
        public decimal? payment_amount { get; set; }
        public decimal? forgiven_credit { get; set; }
        public byte? has_insurance { get; set; }
        public byte? beneficiary_interest { get; set; }
        public byte? claim_option { get; set; }
        public byte? previous_status { get; set; }
        public DateTime? assault_date { get; set; }
        public decimal? distributor_payment_amount { get; set; }
        public DateTime? hospital_admission_date { get; set; }
        public DateTime? hospital_discharge_date { get; set; }
        public byte? has_covid { get; set; }
        public uint? hospitalization_days { get; set; }
        public string? insured_familiar { get; set; }
        public DateTime? cancel_date { get; set; }
        public uint? id_cancelled { get; set; }
        public uint? id_delivered { get; set; }
        public DateTime? delivery_date { get; set; }

        public virtual ICollection<credit_protections_requests_alerts> credit_protections_requests_alerts { get; set; }
        public virtual ICollection<credit_protections_requests_files> credit_protections_requests_files { get; set; }
    }
}
