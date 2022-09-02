using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_applications_inquiries
    {
        public uint id_application_inquiry { get; set; }
        public uint id_application { get; set; }
        public uint id_inquiry { get; set; }
        public uint? id_person { get; set; }
        public uint id_user { get; set; }
        public byte type { get; set; }
        public byte? approved { get; set; }
        public string researcher { get; set; } = null!;
        public DateTime timestamp { get; set; }
        public uint id_stage_process { get; set; }
        public uint? id_personal_reference { get; set; }
        public uint? id_guarantee { get; set; }
        public string? comments { get; set; }
        public uint? id_address { get; set; }
        public uint? id_property { get; set; }
        public uint? id_phone { get; set; }
        public uint? id_economic_activity { get; set; }
        public byte person_type { get; set; }

        public virtual origination_addresses? id_addressNavigation { get; set; }
        public virtual origination_applications id_applicationNavigation { get; set; } = null!;
        public virtual origination_economics_activities? id_economic_activityNavigation { get; set; }
        public virtual origination_guarantees? id_guaranteeNavigation { get; set; }
        public virtual origination_inquiries id_inquiryNavigation { get; set; } = null!;
        public virtual origination_persons? id_personNavigation { get; set; }
        public virtual origination_personal_references? id_personal_referenceNavigation { get; set; }
        public virtual origination_persons_phones? id_phoneNavigation { get; set; }
        public virtual origination_properties? id_propertyNavigation { get; set; }
        public virtual origination_stages_processes id_stage_processNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}
