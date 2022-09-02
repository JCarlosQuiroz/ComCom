using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_credits
    {
        public credit_credits()
        {
            closure_closures_entries = new HashSet<closure_closures_entries>();
            collection_assignments = new HashSet<collection_assignments>();
            collection_managements = new HashSet<collection_managements>();
            credit_activities = new HashSet<credit_activities>();
            credit_charges = new HashSet<credit_charges>();
            credit_contracts = new HashSet<credit_contracts>();
            credit_credit_notes = new HashSet<credit_credit_notes>();
            credit_credits_automatic_locks = new HashSet<credit_credits_automatic_locks>();
            credit_distributors_extra_fields = new HashSet<credit_distributors_extra_fields>();
            credit_distributors_rivalries = new HashSet<credit_distributors_rivalries>();
            credit_distributors_thrift_configuration = new HashSet<credit_distributors_thrift_configuration>();
            credit_payments = new HashSet<credit_payments>();
            credit_printables = new HashSet<credit_printables>();
            credit_promissory_notes = new HashSet<credit_promissory_notes>();
            credit_puchases = new HashSet<credit_puchases>();
            credit_requests = new HashSet<credit_requests>();
        }

        public uint id_credit { get; set; }
        public uint id_distributor { get; set; }
        public uint id_credit_type { get; set; }
        public uint id_configuration { get; set; }
        public uint? id_locking_reason { get; set; }
        public uint? id_automatic_lock { get; set; }
        public byte status { get; set; }
        public DateOnly created { get; set; }
        public DateOnly? authorized { get; set; }
        public decimal initial { get; set; }
        public decimal current { get; set; }
        public decimal preauthorized { get; set; }
        public decimal promissory_note { get; set; }
        public decimal maximum { get; set; }
        public byte automatic_increase_decrement { get; set; }
        public DateOnly? due_locking_date { get; set; }
        public byte has_insurance_death { get; set; }
        public byte has_insurance_assault { get; set; }
        public DateOnly? punish_date { get; set; }
        public int? id_thrift_percentage { get; set; }
        public sbyte? has_thrift { get; set; }

        public virtual credit_automatic_locks? id_automatic_lockNavigation { get; set; }
        public virtual credit_configurations id_configurationNavigation { get; set; } = null!;
        public virtual credit_credits_types id_credit_typeNavigation { get; set; } = null!;
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual credit_locking_reasons? id_locking_reasonNavigation { get; set; }
        public virtual ICollection<closure_closures_entries> closure_closures_entries { get; set; }
        public virtual ICollection<collection_assignments> collection_assignments { get; set; }
        public virtual ICollection<collection_managements> collection_managements { get; set; }
        public virtual ICollection<credit_activities> credit_activities { get; set; }
        public virtual ICollection<credit_charges> credit_charges { get; set; }
        public virtual ICollection<credit_contracts> credit_contracts { get; set; }
        public virtual ICollection<credit_credit_notes> credit_credit_notes { get; set; }
        public virtual ICollection<credit_credits_automatic_locks> credit_credits_automatic_locks { get; set; }
        public virtual ICollection<credit_distributors_extra_fields> credit_distributors_extra_fields { get; set; }
        public virtual ICollection<credit_distributors_rivalries> credit_distributors_rivalries { get; set; }
        public virtual ICollection<credit_distributors_thrift_configuration> credit_distributors_thrift_configuration { get; set; }
        public virtual ICollection<credit_payments> credit_payments { get; set; }
        public virtual ICollection<credit_printables> credit_printables { get; set; }
        public virtual ICollection<credit_promissory_notes> credit_promissory_notes { get; set; }
        public virtual ICollection<credit_puchases> credit_puchases { get; set; }
        public virtual ICollection<credit_requests> credit_requests { get; set; }
    }
}
