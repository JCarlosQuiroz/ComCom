using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_beneficiaries
    {
        public credit_beneficiaries()
        {
            credit_purchases_beneficiaries = new HashSet<credit_purchases_beneficiaries>();
        }

        public uint id_beneficiary { get; set; }
        public uint id_user { get; set; }
        public uint? id_distributor { get; set; }
        public uint? id_customer { get; set; }
        public byte status { get; set; }
        public DateTime create_date { get; set; }
        public string name { get; set; } = null!;
        public string? middle_name { get; set; }
        public string? last_name { get; set; }
        public string? second_last_name { get; set; }
        public DateOnly? birthdate { get; set; }
        public byte? gender { get; set; }
        public string? relationship { get; set; }
        public string? phone { get; set; }
        public sbyte? beneficiary_type { get; set; }

        public virtual credit_customers? id_customerNavigation { get; set; }
        public virtual credit_distributors? id_distributorNavigation { get; set; }
        public virtual core_users id_userNavigation { get; set; } = null!;
        public virtual ICollection<credit_purchases_beneficiaries> credit_purchases_beneficiaries { get; set; }
    }
}
