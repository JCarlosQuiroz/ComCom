using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_stages
    {
        public origination_stages()
        {
            credinet_configuration = new HashSet<credinet_configuration>();
            origination_applications = new HashSet<origination_applications>();
            origination_stages_processes = new HashSet<origination_stages_processes>();
            id_file_type = new HashSet<origination_files_types>();
            id_role = new HashSet<core_roles>();
        }

        public uint id_stage { get; set; }
        public byte status { get; set; }
        public byte order { get; set; }
        public string name { get; set; } = null!;
        public byte application_edit_person { get; set; }
        public byte application_edit_address { get; set; }
        public byte application_edit_economic_activity { get; set; }
        public byte application_edit_phones { get; set; }
        public byte application_edit_properties { get; set; }
        public byte application_edit_expenses { get; set; }
        public byte application_edit_personal_references { get; set; }
        public byte application_edit_guarantees { get; set; }
        public byte application_edit_spouse { get; set; }
        public byte? application_phone_quantity { get; set; }
        public byte? application_property_quantity { get; set; }
        public byte? application_expense_quantity { get; set; }
        public byte? application_personal_reference_quantity { get; set; }
        public byte? application_guarantee_quantity { get; set; }
        public byte spouse_edit_person { get; set; }
        public byte spouse_edit_address { get; set; }
        public byte spouse_edit_economic_activity { get; set; }
        public byte spouse_edit_phones { get; set; }
        public byte spouse_edit_properties { get; set; }
        public byte? spouse_phone_quantity { get; set; }
        public byte? spouse_property_quantity { get; set; }
        public byte personal_reference_edit_person { get; set; }
        public byte personal_reference_edit_address { get; set; }
        public byte personal_reference_edit_economic_activity { get; set; }
        public byte personal_reference_edit_phones { get; set; }
        public byte personal_reference_edit_properties { get; set; }
        public byte? personal_reference_phone_quantity { get; set; }
        public byte? personal_reference_property_quantity { get; set; }
        public byte guarantee_edit_person { get; set; }
        public byte guarantee_edit_address { get; set; }
        public byte guarantee_edit_economic_activity { get; set; }
        public byte guarantee_edit_phones { get; set; }
        public byte guarantee_edit_properties { get; set; }
        public byte? guarantee_phone_quantity { get; set; }
        public byte? guarantee_property_quantity { get; set; }
        public byte application_require_address { get; set; }
        public byte application_require_economic_activity { get; set; }
        public byte application_require_spouse { get; set; }
        public byte personal_reference_require_address { get; set; }
        public byte personal_reference_require_economic_activity { get; set; }
        public byte guarantee_require_address { get; set; }
        public byte guarantee_require_economic_activity { get; set; }
        public byte application_active_address { get; set; }
        public byte application_active_economic_activity { get; set; }
        public byte application_active_phones { get; set; }
        public byte application_active_properties { get; set; }
        public byte application_active_expenses { get; set; }
        public byte application_active_personal_references { get; set; }
        public byte application_active_guarantees { get; set; }
        public byte application_active_rivalries { get; set; }
        public byte application_active_extra_fields { get; set; }
        public byte application_active_spouse { get; set; }
        public byte spouse_require_address { get; set; }
        public byte spouse_require_economic_activity { get; set; }

        public virtual ICollection<credinet_configuration> credinet_configuration { get; set; }
        public virtual ICollection<origination_applications> origination_applications { get; set; }
        public virtual ICollection<origination_stages_processes> origination_stages_processes { get; set; }

        public virtual ICollection<origination_files_types> id_file_type { get; set; }
        public virtual ICollection<core_roles> id_role { get; set; }
    }
}
