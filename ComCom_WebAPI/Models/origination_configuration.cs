using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_configuration
    {
        public uint id_configuration { get; set; }
        public byte status { get; set; }
        public byte application_address { get; set; }
        public byte application_phones { get; set; }
        public byte application_economic_activity { get; set; }
        public byte application_properties { get; set; }
        public byte application_spouse { get; set; }
        public byte application_expenses { get; set; }
        public byte application_personal_reference { get; set; }
        public byte application_extra_field { get; set; }
        public byte application_guarantees { get; set; }
        public byte spouse_status { get; set; }
        public byte spouse_address { get; set; }
        public byte spouse_phones { get; set; }
        public byte spouse_economic_activity { get; set; }
        public byte spouse_properties { get; set; }
        public byte personal_reference_status { get; set; }
        public byte personal_reference_address { get; set; }
        public byte personal_reference_phones { get; set; }
        public byte personal_reference_economic_activity { get; set; }
        public byte personal_reference_properties { get; set; }
        public byte guarantee_status { get; set; }
        public byte guarantee_address { get; set; }
        public byte guarantee_phones { get; set; }
        public byte guarantee_economic_activity { get; set; }
        public byte guarantee_properties { get; set; }
        public byte application_stage { get; set; }
        public byte application_order { get; set; }
        public byte application_curp { get; set; }
    }
}
