using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_persons
    {
        public origination_persons()
        {
            origination_applications = new HashSet<origination_applications>();
            origination_applications_extra_fields = new HashSet<origination_applications_extra_fields>();
            origination_applications_files = new HashSet<origination_applications_files>();
            origination_applications_inquiries = new HashSet<origination_applications_inquiries>();
            origination_domiciliary_inquiries = new HashSet<origination_domiciliary_inquiries>();
            origination_guarantees = new HashSet<origination_guarantees>();
            origination_personal_references = new HashSet<origination_personal_references>();
            origination_persons_phones = new HashSet<origination_persons_phones>();
            origination_properties = new HashSet<origination_properties>();
            origination_spouses = new HashSet<origination_spouses>();
            origination_telephone_inquiries = new HashSet<origination_telephone_inquiries>();
        }

        public uint id_person { get; set; }
        public uint? id_address { get; set; }
        public uint? id_economict_activity { get; set; }
        public uint? id_spouse { get; set; }
        public string name { get; set; } = null!;
        public string? middle_name { get; set; }
        public string last_name { get; set; } = null!;
        public string? second_last_name { get; set; }
        public byte? gender { get; set; }
        public byte? marital_status { get; set; }
        public DateOnly? birthdate { get; set; }
        public string? rfc { get; set; }
        public string? curp { get; set; }

        public virtual origination_addresses? id_addressNavigation { get; set; }
        public virtual origination_economics_activities? id_economict_activityNavigation { get; set; }
        public virtual origination_spouses? id_spouseNavigation { get; set; }
        public virtual ICollection<origination_applications> origination_applications { get; set; }
        public virtual ICollection<origination_applications_extra_fields> origination_applications_extra_fields { get; set; }
        public virtual ICollection<origination_applications_files> origination_applications_files { get; set; }
        public virtual ICollection<origination_applications_inquiries> origination_applications_inquiries { get; set; }
        public virtual ICollection<origination_domiciliary_inquiries> origination_domiciliary_inquiries { get; set; }
        public virtual ICollection<origination_guarantees> origination_guarantees { get; set; }
        public virtual ICollection<origination_personal_references> origination_personal_references { get; set; }
        public virtual ICollection<origination_persons_phones> origination_persons_phones { get; set; }
        public virtual ICollection<origination_properties> origination_properties { get; set; }
        public virtual ICollection<origination_spouses> origination_spouses { get; set; }
        public virtual ICollection<origination_telephone_inquiries> origination_telephone_inquiries { get; set; }
    }
}
