using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class closure_closures_entries_test
    {
        public uint id_closure_entry { get; set; }
        public uint id_closure { get; set; }
        public uint id_distributor { get; set; }
        public uint id_credit { get; set; }
        public uint? id_coordination { get; set; }
        public uint? id_branch { get; set; }
        public uint charges { get; set; }
        public uint payments { get; set; }
        public uint purchases { get; set; }
        public decimal due_balance { get; set; }
        public decimal payable_balance { get; set; }
        public decimal current_balance { get; set; }
        public decimal total_balance { get; set; }
        public decimal limit { get; set; }
        public uint due_days { get; set; }
        public uint max_due_days { get; set; }
        public decimal purchased { get; set; }
        public decimal available { get; set; }
        public byte age { get; set; }
        public decimal placed { get; set; }
        public decimal total_payed { get; set; }
        public decimal total_credit_note { get; set; }
        public decimal total_restructure { get; set; }
        public DateOnly? punish_date { get; set; }
        public decimal placed_personal_loan { get; set; }
        public decimal discount_balance { get; set; }
        public decimal positive_balance { get; set; }
        public decimal total_balance_without_discount { get; set; }
        public uint? id_category { get; set; }
        public int total_customers { get; set; }
        public int customers_with_pending_purchases { get; set; }
        public decimal? preauthorized { get; set; }
        public decimal? placed_personal_loan_special { get; set; }
        public DateOnly? thrift_activation_date { get; set; }
        public decimal? total_thrift_amount { get; set; }
        public DateOnly? activation_date { get; set; }
        public DateOnly? inactivation_date { get; set; }
        public DateOnly? last_payment_date { get; set; }
        public sbyte? status { get; set; }
    }
}
