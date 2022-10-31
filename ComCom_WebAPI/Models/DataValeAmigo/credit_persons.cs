using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_persons
    {
        public credit_persons()
        {
            credit_customers = new HashSet<credit_customers>();
            credit_distributors = new HashSet<credit_distributors>();
            credit_distributors_files = new HashSet<credit_distributors_files>();
            credit_guarantees = new HashSet<credit_guarantees>();
            credit_personal_references = new HashSet<credit_personal_references>();
            credit_phones = new HashSet<credit_phones>();
            credit_spouses = new HashSet<credit_spouses>();
        }

        public uint id_person { get; set; }
        public uint? id_address { get; set; }
        public uint? id_economict_activity { get; set; }
        public string name { get; set; } = null!;
        public string? middle_name { get; set; }
        public string? last_name { get; set; }
        public string? second_last_name { get; set; }
        public byte? gender { get; set; }
        public byte? marital_status { get; set; }
        public DateOnly? birthdate { get; set; }
        public string? rfc { get; set; }
        public string? curp { get; set; }
        public string? email { get; set; }
        public uint? birthplace { get; set; }
        public string? face_filename { get; set; }

        public virtual credit_addresses? id_addressNavigation { get; set; }
        public virtual credit_economics_activities? id_economict_activityNavigation { get; set; }
        public virtual ICollection<credit_customers> credit_customers { get; set; }
        public virtual ICollection<credit_distributors> credit_distributors { get; set; }
        public virtual ICollection<credit_distributors_files> credit_distributors_files { get; set; }
        public virtual ICollection<credit_guarantees> credit_guarantees { get; set; }
        public virtual ICollection<credit_personal_references> credit_personal_references { get; set; }
        public virtual ICollection<credit_phones> credit_phones { get; set; }
        public virtual ICollection<credit_spouses> credit_spouses { get; set; }
    }
}
