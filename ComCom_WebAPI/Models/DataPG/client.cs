using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class client
    {
        public client()
        {
            contact = new HashSet<contact>();
            voucher = new HashSet<voucher>();
        }

        public int id { get; set; }
        public string username { get; set; } = null!;
        public DateOnly? installation_date { get; set; }
        public DateOnly? contract_date { get; set; }
        public string? contract_file { get; set; }
        public string street { get; set; } = null!;
        public string? outdoor_number { get; set; }
        public string? indoor_number { get; set; }
        public string colony_fraction { get; set; } = null!;
        public string type { get; set; } = null!;
        public double? installation_price { get; set; }
        public bool debited_service_installation { get; set; }
        public string monitoring_status { get; set; } = null!;
        public bool need_review { get; set; }
        public int? fk_deposit_id { get; set; }
        public int? fk_digital_tax_receipt_online_id { get; set; }
        public int? fk_price_list_id { get; set; }
        public int? fk_service_status_id { get; set; }
        public int? fk_way_pay_id { get; set; }
        public int? fk_zone_id { get; set; }
        public int? created_by_id { get; set; }
        public DateOnly? created_date { get; set; }
        public DateOnly? retired_date { get; set; }

        public virtual auth_user? created_by { get; set; }
        public virtual deposit? fk_deposit { get; set; }
        public virtual digital_tax_receipt_online? fk_digital_tax_receipt_online { get; set; }
        public virtual price_list? fk_price_list { get; set; }
        public virtual service_status? fk_service_status { get; set; }
        public virtual way_pay? fk_way_pay { get; set; }
        public virtual zone? fk_zone { get; set; }
        public virtual business_client business_client { get; set; } = null!;
        public virtual client_localization client_localization { get; set; } = null!;
        public virtual employee_client employee_client { get; set; } = null!;
        public virtual residential_client residential_client { get; set; } = null!;
        public virtual temp_client temp_client { get; set; } = null!;
        public virtual tower_client tower_client { get; set; } = null!;
        public virtual vip_client vip_client { get; set; } = null!;
        public virtual ICollection<contact> contact { get; set; }
        public virtual ICollection<voucher> voucher { get; set; }
    }
}
