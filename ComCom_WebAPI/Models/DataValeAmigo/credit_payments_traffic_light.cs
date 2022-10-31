using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_payments_traffic_light
    {
        public int id_payment_traffic_light { get; set; }
        public uint id_distributor { get; set; }
        public DateOnly charge_date { get; set; }
        public DateOnly due_date { get; set; }
        public DateOnly? payment_date { get; set; }
        public decimal amount_to_pay { get; set; }
        public decimal? amount_payed { get; set; }
        public int due_days { get; set; }
        public int sundays { get; set; }
        public int hollidays { get; set; }
        public int status { get; set; }
        public string? trending { get; set; }

        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
    }
}
