using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_applications
    {
        public origination_applications()
        {
            origination_alerts = new HashSet<origination_alerts>();
            origination_applications_extra_fields = new HashSet<origination_applications_extra_fields>();
            origination_applications_files = new HashSet<origination_applications_files>();
            origination_applications_inquiries = new HashSet<origination_applications_inquiries>();
            origination_applications_rivalries = new HashSet<origination_applications_rivalries>();
            origination_circulo_credito = new HashSet<origination_circulo_credito>();
            origination_domiciliary_inquiries = new HashSet<origination_domiciliary_inquiries>();
            origination_expenses = new HashSet<origination_expenses>();
            origination_guarantees = new HashSet<origination_guarantees>();
            origination_personal_references = new HashSet<origination_personal_references>();
            origination_spouses = new HashSet<origination_spouses>();
            origination_telephone_inquiries = new HashSet<origination_telephone_inquiries>();
        }

        public uint id_application { get; set; }
        public uint id_person { get; set; }
        public uint id_branch { get; set; }
        public uint id_user { get; set; }
        public uint id_stage { get; set; }
        public uint? id_profession { get; set; }
        public byte status { get; set; }
        public DateOnly date { get; set; }
        public decimal? salary { get; set; }
        public decimal? income { get; set; }
        public byte? house_type { get; set; }
        public byte? house_time { get; set; }
        public string? cancellation_reason { get; set; }
        public uint? id_user_cancellation { get; set; }
        public DateOnly? date_cancellation { get; set; }
        public uint cancellation_fix_stage { get; set; }
        public DateTime? date_register { get; set; }
        public DateTime? date_change_stage { get; set; }

        public virtual core_branches id_branchNavigation { get; set; } = null!;
        public virtual origination_persons id_personNavigation { get; set; } = null!;
        public virtual origination_professions? id_professionNavigation { get; set; }
        public virtual origination_stages id_stageNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
        public virtual core_users? id_user_cancellationNavigation { get; set; }
        public virtual ICollection<origination_alerts> origination_alerts { get; set; }
        public virtual ICollection<origination_applications_extra_fields> origination_applications_extra_fields { get; set; }
        public virtual ICollection<origination_applications_files> origination_applications_files { get; set; }
        public virtual ICollection<origination_applications_inquiries> origination_applications_inquiries { get; set; }
        public virtual ICollection<origination_applications_rivalries> origination_applications_rivalries { get; set; }
        public virtual ICollection<origination_circulo_credito> origination_circulo_credito { get; set; }
        public virtual ICollection<origination_domiciliary_inquiries> origination_domiciliary_inquiries { get; set; }
        public virtual ICollection<origination_expenses> origination_expenses { get; set; }
        public virtual ICollection<origination_guarantees> origination_guarantees { get; set; }
        public virtual ICollection<origination_personal_references> origination_personal_references { get; set; }
        public virtual ICollection<origination_spouses> origination_spouses { get; set; }
        public virtual ICollection<origination_telephone_inquiries> origination_telephone_inquiries { get; set; }
    }
}
