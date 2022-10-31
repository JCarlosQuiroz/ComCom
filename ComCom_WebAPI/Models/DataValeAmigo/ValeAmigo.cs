using System;
using System.Collections.Generic;
using ComCom_WebAPI.Models.DataValeAmigo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ComCom_WebAPI.Models
{
    public partial class ValeAmigo : DbContext
    {
        public ValeAmigo()
        {
        }

        public ValeAmigo(DbContextOptions<ValeAmigo> options)
            : base(options)
        {
        }

        public virtual DbSet<app_logs> app_logs { get; set; } = null!;
        public virtual DbSet<cat_clientes> cat_clientes { get; set; } = null!;
        public virtual DbSet<cat_montos> cat_montos { get; set; } = null!;
        public virtual DbSet<cat_plazos> cat_plazos { get; set; } = null!;
        public virtual DbSet<clientes> clientes { get; set; } = null!;
        public virtual DbSet<closure_closures> closure_closures { get; set; } = null!;
        public virtual DbSet<closure_closures_entries> closure_closures_entries { get; set; } = null!;
        public virtual DbSet<closure_closures_entries_test> closure_closures_entries_test { get; set; } = null!;
        public virtual DbSet<closure_closures_test> closure_closures_test { get; set; } = null!;
        public virtual DbSet<closure_cutoff_date> closure_cutoff_date { get; set; } = null!;
        public virtual DbSet<collection_activations> collection_activations { get; set; } = null!;
        public virtual DbSet<collection_amounts_configurations> collection_amounts_configurations { get; set; } = null!;
        public virtual DbSet<collection_assignments> collection_assignments { get; set; } = null!;
        public virtual DbSet<collection_books> collection_books { get; set; } = null!;
        public virtual DbSet<collection_call_managements> collection_call_managements { get; set; } = null!;
        public virtual DbSet<collection_call_managements_details> collection_call_managements_details { get; set; } = null!;
        public virtual DbSet<collection_call_managements_questions> collection_call_managements_questions { get; set; } = null!;
        public virtual DbSet<collection_call_managements_questions_answers> collection_call_managements_questions_answers { get; set; } = null!;
        public virtual DbSet<collection_call_types> collection_call_types { get; set; } = null!;
        public virtual DbSet<collection_cancellation_reasons> collection_cancellation_reasons { get; set; } = null!;
        public virtual DbSet<collection_concepts> collection_concepts { get; set; } = null!;
        public virtual DbSet<collection_contact_types> collection_contact_types { get; set; } = null!;
        public virtual DbSet<collection_contacts> collection_contacts { get; set; } = null!;
        public virtual DbSet<collection_coordinations> collection_coordinations { get; set; } = null!;
        public virtual DbSet<collection_employments> collection_employments { get; set; } = null!;
        public virtual DbSet<collection_group_zipcodes> collection_group_zipcodes { get; set; } = null!;
        public virtual DbSet<collection_groups> collection_groups { get; set; } = null!;
        public virtual DbSet<collection_logs> collection_logs { get; set; } = null!;
        public virtual DbSet<collection_managements> collection_managements { get; set; } = null!;
        public virtual DbSet<collection_managers> collection_managers { get; set; } = null!;
        public virtual DbSet<collection_mangements> collection_mangements { get; set; } = null!;
        public virtual DbSet<collection_receipt_book_relations> collection_receipt_book_relations { get; set; } = null!;
        public virtual DbSet<collection_receipt_books> collection_receipt_books { get; set; } = null!;
        public virtual DbSet<collection_receipt_requests> collection_receipt_requests { get; set; } = null!;
        public virtual DbSet<collection_receipts> collection_receipts { get; set; } = null!;
        public virtual DbSet<collection_receipts_logs> collection_receipts_logs { get; set; } = null!;
        public virtual DbSet<collection_receipts_notifications> collection_receipts_notifications { get; set; } = null!;
        public virtual DbSet<collection_receipts_notifications_types> collection_receipts_notifications_types { get; set; } = null!;
        public virtual DbSet<collection_requests> collection_requests { get; set; } = null!;
        public virtual DbSet<collection_result_types> collection_result_types { get; set; } = null!;
        public virtual DbSet<collection_results> collection_results { get; set; } = null!;
        public virtual DbSet<collection_tasks> collection_tasks { get; set; } = null!;
        public virtual DbSet<collection_teams> collection_teams { get; set; } = null!;
        public virtual DbSet<collection_teams_members> collection_teams_members { get; set; } = null!;
        public virtual DbSet<collection_types> collection_types { get; set; } = null!;
        public virtual DbSet<consulta_purchases> consulta_purchases { get; set; } = null!;
        public virtual DbSet<core_action_groups> core_action_groups { get; set; } = null!;
        public virtual DbSet<core_actions> core_actions { get; set; } = null!;
        public virtual DbSet<core_apps_versions> core_apps_versions { get; set; } = null!;
        public virtual DbSet<core_branches> core_branches { get; set; } = null!;
        public virtual DbSet<core_branches_branches> core_branches_branches { get; set; } = null!;
        public virtual DbSet<core_controllers> core_controllers { get; set; } = null!;
        public virtual DbSet<core_customer_configurations> core_customer_configurations { get; set; } = null!;
        public virtual DbSet<core_logs> core_logs { get; set; } = null!;
        public virtual DbSet<core_management> core_management { get; set; } = null!;
        public virtual DbSet<core_menu_sections> core_menu_sections { get; set; } = null!;
        public virtual DbSet<core_menus> core_menus { get; set; } = null!;
        public virtual DbSet<core_modules> core_modules { get; set; } = null!;
        public virtual DbSet<core_notifications> core_notifications { get; set; } = null!;
        public virtual DbSet<core_persons> core_persons { get; set; } = null!;
        public virtual DbSet<core_persons_curp_validation_> core_persons_curp_validation_ { get; set; } = null!;
        public virtual DbSet<core_persons_curp_validations_> core_persons_curp_validations_ { get; set; } = null!;
        public virtual DbSet<core_role_menu_action_group> core_role_menu_action_group { get; set; } = null!;
        public virtual DbSet<core_roles> core_roles { get; set; } = null!;
        public virtual DbSet<core_roles_menus> core_roles_menus { get; set; } = null!;
        public virtual DbSet<core_sepomex> core_sepomex { get; set; } = null!;
        public virtual DbSet<core_stores> core_stores { get; set; } = null!;
        public virtual DbSet<core_users> core_users { get; set; } = null!;
        public virtual DbSet<core_users_logs> core_users_logs { get; set; } = null!;
        public virtual DbSet<core_zones> core_zones { get; set; } = null!;
        public virtual DbSet<corte1> corte1 { get; set; } = null!;
        public virtual DbSet<corte2> corte2 { get; set; } = null!;
        public virtual DbSet<corte3> corte3 { get; set; } = null!;
        public virtual DbSet<coupon_books> coupon_books { get; set; } = null!;
        public virtual DbSet<coupon_cancellation_reasons> coupon_cancellation_reasons { get; set; } = null!;
        public virtual DbSet<coupon_configurations> coupon_configurations { get; set; } = null!;
        public virtual DbSet<coupon_configurations_books> coupon_configurations_books { get; set; } = null!;
        public virtual DbSet<coupon_configurations_fields> coupon_configurations_fields { get; set; } = null!;
        public virtual DbSet<coupon_configurations_vouchers> coupon_configurations_vouchers { get; set; } = null!;
        public virtual DbSet<coupon_configurations_vouchers_fields> coupon_configurations_vouchers_fields { get; set; } = null!;
        public virtual DbSet<coupon_coupons> coupon_coupons { get; set; } = null!;
        public virtual DbSet<coupon_coupons_logs> coupon_coupons_logs { get; set; } = null!;
        public virtual DbSet<credinet_configuration> credinet_configuration { get; set; } = null!;
        public virtual DbSet<credit_activities> credit_activities { get; set; } = null!;
        public virtual DbSet<credit_addresses> credit_addresses { get; set; } = null!;
        public virtual DbSet<credit_amount_branches> credit_amount_branches { get; set; } = null!;
        public virtual DbSet<credit_amounts> credit_amounts { get; set; } = null!;
        public virtual DbSet<credit_automatic_locks> credit_automatic_locks { get; set; } = null!;
        public virtual DbSet<credit_beneficiaries> credit_beneficiaries { get; set; } = null!;
        public virtual DbSet<credit_cancellation_reasons> credit_cancellation_reasons { get; set; } = null!;
        public virtual DbSet<credit_categories> credit_categories { get; set; } = null!;
        public virtual DbSet<credit_charge_type> credit_charge_type { get; set; } = null!;
        public virtual DbSet<credit_charge_type_extra_fields> credit_charge_type_extra_fields { get; set; } = null!;
        public virtual DbSet<credit_charges> credit_charges { get; set; } = null!;
        public virtual DbSet<credit_configurations> credit_configurations { get; set; } = null!;
        public virtual DbSet<credit_configurations_charge_type> credit_configurations_charge_type { get; set; } = null!;
        public virtual DbSet<credit_configurations_discounts> credit_configurations_discounts { get; set; } = null!;
        public virtual DbSet<credit_configurations_interests> credit_configurations_interests { get; set; } = null!;
        public virtual DbSet<credit_configurations_interests_logs> credit_configurations_interests_logs { get; set; } = null!;
        public virtual DbSet<credit_configurations_multiple_coupon> credit_configurations_multiple_coupon { get; set; } = null!;
        public virtual DbSet<credit_configurations_receipts> credit_configurations_receipts { get; set; } = null!;
        public virtual DbSet<credit_configurations_receipts_fields> credit_configurations_receipts_fields { get; set; } = null!;
        public virtual DbSet<credit_contracts> credit_contracts { get; set; } = null!;
        public virtual DbSet<credit_credit_notes> credit_credit_notes { get; set; } = null!;
        public virtual DbSet<credit_credit_types_amount_configuration> credit_credit_types_amount_configuration { get; set; } = null!;
        public virtual DbSet<credit_credit_types_discounts> credit_credit_types_discounts { get; set; } = null!;
        public virtual DbSet<credit_credit_types_increases_decrements> credit_credit_types_increases_decrements { get; set; } = null!;
        public virtual DbSet<credit_credits> credit_credits { get; set; } = null!;
        public virtual DbSet<credit_credits_automatic_locks> credit_credits_automatic_locks { get; set; } = null!;
        public virtual DbSet<credit_credits_types> credit_credits_types { get; set; } = null!;
        public virtual DbSet<credit_credits_types_limits> credit_credits_types_limits { get; set; } = null!;
        public virtual DbSet<credit_credits_types_logs> credit_credits_types_logs { get; set; } = null!;
        public virtual DbSet<credit_customer_file_types> credit_customer_file_types { get; set; } = null!;
        public virtual DbSet<credit_customers> credit_customers { get; set; } = null!;
        public virtual DbSet<credit_customers_files> credit_customers_files { get; set; } = null!;
        public virtual DbSet<credit_customers_logs> credit_customers_logs { get; set; } = null!;
        public virtual DbSet<credit_distributors> credit_distributors { get; set; } = null!;
        public virtual DbSet<credit_distributors_extra_fields> credit_distributors_extra_fields { get; set; } = null!;
        public virtual DbSet<credit_distributors_files> credit_distributors_files { get; set; } = null!;
        public virtual DbSet<credit_distributors_logs> credit_distributors_logs { get; set; } = null!;
        public virtual DbSet<credit_distributors_rivalries> credit_distributors_rivalries { get; set; } = null!;
        public virtual DbSet<credit_distributors_signatures_logs> credit_distributors_signatures_logs { get; set; } = null!;
        public virtual DbSet<credit_distributors_thrift> credit_distributors_thrift { get; set; } = null!;
        public virtual DbSet<credit_distributors_thrift_configuration> credit_distributors_thrift_configuration { get; set; } = null!;
        public virtual DbSet<credit_due_days> credit_due_days { get; set; } = null!;
        public virtual DbSet<credit_economics_activities> credit_economics_activities { get; set; } = null!;
        public virtual DbSet<credit_expenses> credit_expenses { get; set; } = null!;
        public virtual DbSet<credit_fortnights> credit_fortnights { get; set; } = null!;
        public virtual DbSet<credit_guarantees> credit_guarantees { get; set; } = null!;
        public virtual DbSet<credit_holidays> credit_holidays { get; set; } = null!;
        public virtual DbSet<credit_interests> credit_interests { get; set; } = null!;
        public virtual DbSet<credit_locking_reasons> credit_locking_reasons { get; set; } = null!;
        public virtual DbSet<credit_payment_clearences> credit_payment_clearences { get; set; } = null!;
        public virtual DbSet<credit_payment_credits_notes_types> credit_payment_credits_notes_types { get; set; } = null!;
        public virtual DbSet<credit_payments> credit_payments { get; set; } = null!;
        public virtual DbSet<credit_payments_entries> credit_payments_entries { get; set; } = null!;
        public virtual DbSet<credit_payments_entries_details> credit_payments_entries_details { get; set; } = null!;
        public virtual DbSet<credit_payments_traffic_light> credit_payments_traffic_light { get; set; } = null!;
        public virtual DbSet<credit_personal_loan_requeriments> credit_personal_loan_requeriments { get; set; } = null!;
        public virtual DbSet<credit_personal_references> credit_personal_references { get; set; } = null!;
        public virtual DbSet<credit_persons> credit_persons { get; set; } = null!;
        public virtual DbSet<credit_phones> credit_phones { get; set; } = null!;
        public virtual DbSet<credit_printables> credit_printables { get; set; } = null!;
        public virtual DbSet<credit_printables_logs> credit_printables_logs { get; set; } = null!;
        public virtual DbSet<credit_product_brands> credit_product_brands { get; set; } = null!;
        public virtual DbSet<credit_product_types> credit_product_types { get; set; } = null!;
        public virtual DbSet<credit_products> credit_products { get; set; } = null!;
        public virtual DbSet<credit_promissory_notes> credit_promissory_notes { get; set; } = null!;
        public virtual DbSet<credit_properties> credit_properties { get; set; } = null!;
        public virtual DbSet<credit_protections_requests> credit_protections_requests { get; set; } = null!;
        public virtual DbSet<credit_protections_requests_alerts> credit_protections_requests_alerts { get; set; } = null!;
        public virtual DbSet<credit_protections_requests_files> credit_protections_requests_files { get; set; } = null!;
        public virtual DbSet<credit_protections_requests_files_types> credit_protections_requests_files_types { get; set; } = null!;
        public virtual DbSet<credit_protections_requests_types> credit_protections_requests_types { get; set; } = null!;
        public virtual DbSet<credit_puchases> credit_puchases { get; set; } = null!;
        public virtual DbSet<credit_purchases_amortizations> credit_purchases_amortizations { get; set; } = null!;
        public virtual DbSet<credit_purchases_beneficiaries> credit_purchases_beneficiaries { get; set; } = null!;
        public virtual DbSet<credit_purchases_logs> credit_purchases_logs { get; set; } = null!;
        public virtual DbSet<credit_references> credit_references { get; set; } = null!;
        public virtual DbSet<credit_requests> credit_requests { get; set; } = null!;
        public virtual DbSet<credit_requests_files> credit_requests_files { get; set; } = null!;
        public virtual DbSet<credit_requests_types> credit_requests_types { get; set; } = null!;
        public virtual DbSet<credit_spouses> credit_spouses { get; set; } = null!;
        public virtual DbSet<credit_supervisors> credit_supervisors { get; set; } = null!;
        public virtual DbSet<credit_thrift_percentages> credit_thrift_percentages { get; set; } = null!;
        public virtual DbSet<data_predict_afiliation> data_predict_afiliation { get; set; } = null!;
        public virtual DbSet<load_balances> load_balances { get; set; } = null!;
        public virtual DbSet<load_coupons> load_coupons { get; set; } = null!;
        public virtual DbSet<load_credits> load_credits { get; set; } = null!;
        public virtual DbSet<load_customers> load_customers { get; set; } = null!;
        public virtual DbSet<load_distributors> load_distributors { get; set; } = null!;
        public virtual DbSet<load_due_balances> load_due_balances { get; set; } = null!;
        public virtual DbSet<load_errors> load_errors { get; set; } = null!;
        public virtual DbSet<load_payments> load_payments { get; set; } = null!;
        public virtual DbSet<load_purchases> load_purchases { get; set; } = null!;
        public virtual DbSet<marca> marca { get; set; } = null!;
        public virtual DbSet<montos> montos { get; set; } = null!;
        public virtual DbSet<origination_addresses> origination_addresses { get; set; } = null!;
        public virtual DbSet<origination_alerts> origination_alerts { get; set; } = null!;
        public virtual DbSet<origination_applications> origination_applications { get; set; } = null!;
        public virtual DbSet<origination_applications_extra_fields> origination_applications_extra_fields { get; set; } = null!;
        public virtual DbSet<origination_applications_files> origination_applications_files { get; set; } = null!;
        public virtual DbSet<origination_applications_inquiries> origination_applications_inquiries { get; set; } = null!;
        public virtual DbSet<origination_applications_rivalries> origination_applications_rivalries { get; set; } = null!;
        public virtual DbSet<origination_cc_amounts> origination_cc_amounts { get; set; } = null!;
        public virtual DbSet<origination_cc_matrix> origination_cc_matrix { get; set; } = null!;
        public virtual DbSet<origination_cc_statuses> origination_cc_statuses { get; set; } = null!;
        public virtual DbSet<origination_circulo_credito> origination_circulo_credito { get; set; } = null!;
        public virtual DbSet<origination_configuration> origination_configuration { get; set; } = null!;
        public virtual DbSet<origination_configurations_printables> origination_configurations_printables { get; set; } = null!;
        public virtual DbSet<origination_domiciliary_inquiries> origination_domiciliary_inquiries { get; set; } = null!;
        public virtual DbSet<origination_domiciliary_inquiries_fields> origination_domiciliary_inquiries_fields { get; set; } = null!;
        public virtual DbSet<origination_economics_activities> origination_economics_activities { get; set; } = null!;
        public virtual DbSet<origination_expenses> origination_expenses { get; set; } = null!;
        public virtual DbSet<origination_expenses_types> origination_expenses_types { get; set; } = null!;
        public virtual DbSet<origination_extra_fields> origination_extra_fields { get; set; } = null!;
        public virtual DbSet<origination_files_types> origination_files_types { get; set; } = null!;
        public virtual DbSet<origination_guarantees> origination_guarantees { get; set; } = null!;
        public virtual DbSet<origination_inquiries> origination_inquiries { get; set; } = null!;
        public virtual DbSet<origination_inquiry_fields> origination_inquiry_fields { get; set; } = null!;
        public virtual DbSet<origination_logs> origination_logs { get; set; } = null!;
        public virtual DbSet<origination_personal_references> origination_personal_references { get; set; } = null!;
        public virtual DbSet<origination_persons> origination_persons { get; set; } = null!;
        public virtual DbSet<origination_persons_phones> origination_persons_phones { get; set; } = null!;
        public virtual DbSet<origination_phones_types> origination_phones_types { get; set; } = null!;
        public virtual DbSet<origination_processes> origination_processes { get; set; } = null!;
        public virtual DbSet<origination_processes_fields> origination_processes_fields { get; set; } = null!;
        public virtual DbSet<origination_professions> origination_professions { get; set; } = null!;
        public virtual DbSet<origination_properties> origination_properties { get; set; } = null!;
        public virtual DbSet<origination_properties_types> origination_properties_types { get; set; } = null!;
        public virtual DbSet<origination_relationships> origination_relationships { get; set; } = null!;
        public virtual DbSet<origination_rivalries> origination_rivalries { get; set; } = null!;
        public virtual DbSet<origination_scoring_approval_conditions> origination_scoring_approval_conditions { get; set; } = null!;
        public virtual DbSet<origination_scoring_field_answers> origination_scoring_field_answers { get; set; } = null!;
        public virtual DbSet<origination_scoring_fields> origination_scoring_fields { get; set; } = null!;
        public virtual DbSet<origination_scorings> origination_scorings { get; set; } = null!;
        public virtual DbSet<origination_spouses> origination_spouses { get; set; } = null!;
        public virtual DbSet<origination_stages> origination_stages { get; set; } = null!;
        public virtual DbSet<origination_stages_processes> origination_stages_processes { get; set; } = null!;
        public virtual DbSet<origination_telephone_inquiries> origination_telephone_inquiries { get; set; } = null!;
        public virtual DbSet<origination_telephone_inquiries_fields> origination_telephone_inquiries_fields { get; set; } = null!;
        public virtual DbSet<origination_users_applications> origination_users_applications { get; set; } = null!;
        public virtual DbSet<origination_validations> origination_validations { get; set; } = null!;
        public virtual DbSet<origination_validations_files> origination_validations_files { get; set; } = null!;
        public virtual DbSet<payed_purchases> payed_purchases { get; set; } = null!;
        public virtual DbSet<piorpi_alerts> piorpi_alerts { get; set; } = null!;
        public virtual DbSet<piorpi_alerts_entries> piorpi_alerts_entries { get; set; } = null!;
        public virtual DbSet<piorpi_black_lists> piorpi_black_lists { get; set; } = null!;
        public virtual DbSet<piorpi_black_lists_entries> piorpi_black_lists_entries { get; set; } = null!;
        public virtual DbSet<piorpi_salaries> piorpi_salaries { get; set; } = null!;
        public virtual DbSet<session> session { get; set; } = null!;
        public virtual DbSet<tempo> tempo { get; set; } = null!;
        public virtual DbSet<treasury_box_closures> treasury_box_closures { get; set; } = null!;
        public virtual DbSet<treasury_box_drags> treasury_box_drags { get; set; } = null!;
        public virtual DbSet<treasury_boxes> treasury_boxes { get; set; } = null!;
        public virtual DbSet<treasury_boxes_injections> treasury_boxes_injections { get; set; } = null!;
        public virtual DbSet<treasury_boxes_payments> treasury_boxes_payments { get; set; } = null!;
        public virtual DbSet<treasury_providers> treasury_providers { get; set; } = null!;
        public virtual DbSet<treasury_providers_requests> treasury_providers_requests { get; set; } = null!;
        public virtual DbSet<treasury_requests> treasury_requests { get; set; } = null!;
        public virtual DbSet<treasury_shift_closing_types> treasury_shift_closing_types { get; set; } = null!;
        public virtual DbSet<treasury_shift_closings> treasury_shift_closings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;port=3306;database=valeamigo;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.24-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<app_logs>(entity =>
            {
                entity.HasKey(e => e.id_log)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_log).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(11)");

                entity.Property(e => e.ip).HasMaxLength(15);

                entity.Property(e => e.message).HasMaxLength(100);

                entity.Property(e => e.priority).HasMaxLength(45);

                entity.Property(e => e.timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<cat_clientes>(entity =>
            {
                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id).HasColumnType("int(11)");

                entity.Property(e => e.edad).HasMaxLength(3);

                entity.Property(e => e.nombre).HasMaxLength(100);

                entity.Property(e => e.status).HasColumnType("int(2)");

                entity.Property(e => e.telefono).HasMaxLength(10);
            });

            modelBuilder.Entity<cat_montos>(entity =>
            {
                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id).HasColumnType("int(11)");

                entity.Property(e => e.monto).HasPrecision(8, 2);
            });

            modelBuilder.Entity<cat_plazos>(entity =>
            {
                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id).HasColumnType("int(11)");

                entity.Property(e => e.plazo).HasMaxLength(2);
            });

            modelBuilder.Entity<clientes>(entity =>
            {
                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id).HasColumnType("int(11) unsigned");

                entity.Property(e => e.apellido_materno).HasMaxLength(100);

                entity.Property(e => e.apellido_paterno).HasMaxLength(100);

                entity.Property(e => e.created_at)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.nombre).HasMaxLength(30);

                entity.Property(e => e.status).HasColumnType("int(2)");

                entity.Property(e => e.updated_at).HasColumnType("datetime");
            });

            modelBuilder.Entity<closure_closures>(entity =>
            {
                entity.HasKey(e => e.id_closure)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_closure_closures_1_idx");

                entity.HasIndex(e => e.date, "ix_date");

                entity.Property(e => e.id_closure).HasColumnType("int(10) unsigned");

                entity.Property(e => e.credits).HasColumnType("int(10) unsigned");

                entity.Property(e => e.current_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.due_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.payable_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.percentage).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.total_balance).HasColumnType("decimal(12,2) unsigned");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.closure_closures)
                    .HasForeignKey(d => d.id_user)
                    .HasConstraintName("fk_closure_closures_1");
            });

            modelBuilder.Entity<closure_closures_entries>(entity =>
            {
                entity.HasKey(e => e.id_closure_entry)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_closure, "fk_closure_closures_entries_1_idx");

                entity.HasIndex(e => e.id_distributor, "fk_closure_closures_entries_2_idx");

                entity.HasIndex(e => e.id_credit, "fk_closure_closures_entries_3_idx");

                entity.HasIndex(e => e.id_coordination, "fk_closure_closures_entries_4_idx");

                entity.HasIndex(e => e.id_branch, "fk_closure_closures_entries_5_idx");

                entity.HasIndex(e => e.id_category, "fk_closure_closures_entries_6_idx");

                entity.Property(e => e.id_closure_entry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.age).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.available).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.charges).HasColumnType("int(10) unsigned");

                entity.Property(e => e.current_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.customers_with_pending_purchases).HasColumnType("int(11)");

                entity.Property(e => e.discount_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.due_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.due_days).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_category).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_closure).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_coordination).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.limit).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.max_due_days).HasColumnType("int(10) unsigned");

                entity.Property(e => e.payable_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.payments).HasColumnType("int(10) unsigned");

                entity.Property(e => e.placed).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.placed_personal_loan).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.placed_personal_loan_special)
                    .HasPrecision(12, 2)
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.positive_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.preauthorized)
                    .HasColumnType("decimal(12,2) unsigned")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.purchased).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.purchases).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status).HasColumnType("tinyint(3)");

                entity.Property(e => e.total_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.total_balance_without_discount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.total_credit_note).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.total_customers).HasColumnType("int(11)");

                entity.Property(e => e.total_payed).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.total_restructure).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.total_thrift_amount).HasPrecision(12, 2);

                entity.HasOne(d => d.id_branchNavigation)
                    .WithMany(p => p.closure_closures_entries)
                    .HasForeignKey(d => d.id_branch)
                    .HasConstraintName("fk_closure_closures_entries_5");

                entity.HasOne(d => d.id_categoryNavigation)
                    .WithMany(p => p.closure_closures_entries)
                    .HasForeignKey(d => d.id_category)
                    .HasConstraintName("fk_closure_closures_entries_6");

                entity.HasOne(d => d.id_closureNavigation)
                    .WithMany(p => p.closure_closures_entries)
                    .HasForeignKey(d => d.id_closure)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_closure_closures_entries_1");

                entity.HasOne(d => d.id_coordinationNavigation)
                    .WithMany(p => p.closure_closures_entries)
                    .HasForeignKey(d => d.id_coordination)
                    .HasConstraintName("fk_closure_closures_entries_4");

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.closure_closures_entries)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_closure_closures_entries_3");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.closure_closures_entries)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_closure_closures_entries_2");
            });

            modelBuilder.Entity<closure_closures_entries_test>(entity =>
            {
                entity.HasKey(e => e.id_closure_entry)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_credit, "id_credit");

                entity.Property(e => e.id_closure_entry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.age).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.available).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.charges).HasColumnType("int(10) unsigned");

                entity.Property(e => e.current_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.customers_with_pending_purchases).HasColumnType("int(11)");

                entity.Property(e => e.discount_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.due_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.due_days).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_category).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_closure).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_coordination).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.limit).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.max_due_days).HasColumnType("int(10) unsigned");

                entity.Property(e => e.payable_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.payments).HasColumnType("int(10) unsigned");

                entity.Property(e => e.placed).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.placed_personal_loan).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.placed_personal_loan_special)
                    .HasPrecision(12, 2)
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.positive_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.preauthorized)
                    .HasColumnType("decimal(12,2) unsigned")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.purchased).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.purchases).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status).HasColumnType("tinyint(3)");

                entity.Property(e => e.total_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.total_balance_without_discount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.total_credit_note).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.total_customers).HasColumnType("int(11)");

                entity.Property(e => e.total_payed).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.total_restructure).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.total_thrift_amount).HasPrecision(12, 2);
            });

            modelBuilder.Entity<closure_closures_test>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.credits).HasColumnType("int(10) unsigned");

                entity.Property(e => e.current_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.due_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.id_closure).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.payable_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.percentage).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.total_balance).HasColumnType("decimal(12,2) unsigned");
            });

            modelBuilder.Entity<closure_cutoff_date>(entity =>
            {
                entity.HasKey(e => e.id_cutoff_date)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_cutoff_date).HasColumnType("int(11)");
            });

            modelBuilder.Entity<collection_activations>(entity =>
            {
                entity.HasKey(e => e.id_activations)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_activations).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.coordination).HasColumnType("int(10) unsigned");

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.guarantee).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_promoter).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.level).HasMaxLength(10);
            });

            modelBuilder.Entity<collection_amounts_configurations>(entity =>
            {
                entity.HasKey(e => e.id_amount_configuration)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_amount_configuration).HasColumnType("int(10) unsigned");

                entity.Property(e => e.alert_percentage).HasColumnType("decimal(4,2) unsigned");

                entity.Property(e => e.max_amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<collection_assignments>(entity =>
            {
                entity.HasKey(e => e.id_assignment)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_distributor, "fk_collection_assignments_1_idx");

                entity.HasIndex(e => e.id_credit, "fk_collection_assignments_2_idx");

                entity.HasIndex(e => e.id_coordination, "fk_collection_assignments_3_idx");

                entity.HasIndex(e => e.id_type, "fk_collection_assignments_4_idx");

                entity.Property(e => e.id_assignment).HasColumnType("int(10) unsigned");

                entity.Property(e => e.assigned_available).HasPrecision(12, 2);

                entity.Property(e => e.assigned_current_balance).HasPrecision(12, 2);

                entity.Property(e => e.assigned_due_balance).HasPrecision(12, 2);

                entity.Property(e => e.assigned_limit).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.assigned_mora).HasColumnType("int(10) unsigned");

                entity.Property(e => e.assigned_payable_balance).HasPrecision(12, 2);

                entity.Property(e => e.assigned_total_balance).HasPrecision(12, 2);

                entity.Property(e => e.id_coordination).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.released_available).HasPrecision(12, 2);

                entity.Property(e => e.released_current_balance).HasPrecision(12, 2);

                entity.Property(e => e.released_due_balance).HasPrecision(12, 2);

                entity.Property(e => e.released_limit).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.released_mora).HasColumnType("int(10) unsigned");

                entity.Property(e => e.released_payable_balance).HasPrecision(12, 2);

                entity.Property(e => e.released_total_balance).HasPrecision(12, 2);

                entity.HasOne(d => d.id_coordinationNavigation)
                    .WithMany(p => p.collection_assignments)
                    .HasForeignKey(d => d.id_coordination)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_assignments_3");

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.collection_assignments)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_assignments_2");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.collection_assignments)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_assignments_1");

                entity.HasOne(d => d.id_typeNavigation)
                    .WithMany(p => p.collection_assignments)
                    .HasForeignKey(d => d.id_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_assignments_4");
            });

            modelBuilder.Entity<collection_books>(entity =>
            {
                entity.HasKey(e => e.id_book)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_type, "fk_collection_books_collection_types1_idx");

                entity.HasIndex(e => e.id_branch, "index3");

                entity.Property(e => e.id_book).HasColumnType("int(10) unsigned");

                entity.Property(e => e.final_folio).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.initial_folio).HasColumnType("int(10) unsigned");

                entity.Property(e => e.quantity).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");

                entity.HasOne(d => d.id_branchNavigation)
                    .WithMany(p => p.collection_books)
                    .HasForeignKey(d => d.id_branch)
                    .HasConstraintName("fk_collection_books_1");

                entity.HasOne(d => d.id_typeNavigation)
                    .WithMany(p => p.collection_books)
                    .HasForeignKey(d => d.id_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_books_collection_types1");
            });

            modelBuilder.Entity<collection_call_managements>(entity =>
            {
                entity.HasKey(e => e.id_call_management)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_call_management).HasColumnType("int(10) unsigned");

                entity.Property(e => e.accept_pp).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.apply_pp).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.call_date_end).HasColumnType("datetime");

                entity.Property(e => e.call_date_start).HasColumnType("datetime");

                entity.Property(e => e.call_result).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.id_amount).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_call_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_coordination).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_phone).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.incidence).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.protection).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.service).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<collection_call_managements_details>(entity =>
            {
                entity.HasKey(e => e.id_call_management_detail)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_call_management_detail).HasColumnType("int(10) unsigned");

                entity.Property(e => e.answered).HasColumnType("datetime");

                entity.Property(e => e.id_call_management).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_call_management_question).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_call_management_question_answer).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<collection_call_managements_questions>(entity =>
            {
                entity.HasKey(e => e.id_call_management_question)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_call_management_question).HasColumnType("int(10) unsigned");

                entity.Property(e => e.description).HasMaxLength(200);

                entity.Property(e => e.id_call_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.order).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<collection_call_managements_questions_answers>(entity =>
            {
                entity.HasKey(e => e.id_call_management_question_answer)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_call_management_question_answer).HasColumnType("int(10) unsigned");

                entity.Property(e => e.description).HasMaxLength(200);

                entity.Property(e => e.id_call_management_question).HasColumnType("int(10) unsigned");

                entity.Property(e => e.order).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<collection_call_types>(entity =>
            {
                entity.HasKey(e => e.id_call_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_call_type)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<collection_cancellation_reasons>(entity =>
            {
                entity.HasKey(e => e.id_cancellation_reason)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_cancellation_reason).HasColumnType("int(10) unsigned");

                entity.Property(e => e.description).HasMaxLength(150);

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");
            });

            modelBuilder.Entity<collection_concepts>(entity =>
            {
                entity.HasKey(e => e.id_concept)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_concept).HasColumnType("int(11)");

                entity.Property(e => e.description).HasMaxLength(40);

                entity.Property(e => e.status).HasColumnType("tinyint(3)");
            });

            modelBuilder.Entity<collection_contact_types>(entity =>
            {
                entity.HasKey(e => e.id_contact_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_contact_type)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<collection_contacts>(entity =>
            {
                entity.HasKey(e => e.id_contact)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_contact).HasColumnType("int(11)");

                entity.Property(e => e.description).HasMaxLength(40);

                entity.Property(e => e.status).HasColumnType("tinyint(3)");
            });

            modelBuilder.Entity<collection_coordinations>(entity =>
            {
                entity.HasKey(e => e.id_coordination)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_branch, "fk_collection_coordinations_1_idx");

                entity.HasIndex(e => e.id_type, "fk_collection_coordinations_2_idx");

                entity.HasIndex(e => e.id_team, "fk_collection_coordinations_3_idx");

                entity.HasIndex(e => e.id_user, "fk_collection_coordinations_4_idx");

                entity.Property(e => e.id_coordination).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_team).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.max)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'120'");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_branchNavigation)
                    .WithMany(p => p.collection_coordinations)
                    .HasForeignKey(d => d.id_branch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_coordinations_1");

                entity.HasOne(d => d.id_teamNavigation)
                    .WithMany(p => p.collection_coordinations)
                    .HasForeignKey(d => d.id_team)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_coordinations_3");

                entity.HasOne(d => d.id_typeNavigation)
                    .WithMany(p => p.collection_coordinations)
                    .HasForeignKey(d => d.id_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_coordinations_2");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.collection_coordinations)
                    .HasForeignKey(d => d.id_user)
                    .HasConstraintName("fk_collection_coordinations_4");
            });

            modelBuilder.Entity<collection_employments>(entity =>
            {
                entity.HasKey(e => e.id_employment)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_employment).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<collection_group_zipcodes>(entity =>
            {
                entity.HasKey(e => e.id_group_zipcode)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_group, "fk_collection_group_zipcodes_1_idx");

                entity.Property(e => e.id_group_zipcode).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_group).HasColumnType("int(10) unsigned");

                entity.Property(e => e.neighborhood).HasMaxLength(100);

                entity.Property(e => e.zipcode).HasMaxLength(10);

                entity.HasOne(d => d.id_groupNavigation)
                    .WithMany(p => p.collection_group_zipcodes)
                    .HasForeignKey(d => d.id_group)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_group_zipcodes_1");
            });

            modelBuilder.Entity<collection_groups>(entity =>
            {
                entity.HasKey(e => e.id_group)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_branch, "fk_collection_groups_1_idx");

                entity.HasIndex(e => e.id_type, "fk_collection_groups_collection_types1_idx");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_group).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_branchNavigation)
                    .WithMany(p => p.collection_groups)
                    .HasForeignKey(d => d.id_branch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_groups_1");

                entity.HasOne(d => d.id_typeNavigation)
                    .WithMany(p => p.collection_groups)
                    .HasForeignKey(d => d.id_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_groups_collection_types1");

                entity.HasMany(d => d.id_distributor)
                    .WithMany(p => p.id_group)
                    .UsingEntity<Dictionary<string, object>>(
                        "collection_groups_distributors",
                        l => l.HasOne<credit_distributors>().WithMany().HasForeignKey("id_distributor").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_groups_distributors_credit_distributors1"),
                        r => r.HasOne<collection_groups>().WithMany().HasForeignKey("id_group").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_credit_distributor_has_collection_groups_collection_groups1"),
                        j =>
                        {
                            j.HasKey("id_group", "id_distributor").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("collection_groups_distributors").HasCharSet("utf8").UseCollation("utf8_general_ci");

                            j.HasIndex(new[] { "id_group" }, "fk_credit_distributor_has_collection_groups_collection_grou_idx");

                            j.HasIndex(new[] { "id_distributor" }, "fk_groups_distributors_credit_distributors1_idx");

                            j.IndexerProperty<uint>("id_group").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_distributor").HasColumnType("int(10) unsigned");
                        });

                entity.HasMany(d => d.id_manager)
                    .WithMany(p => p.id_groupNavigation)
                    .UsingEntity<Dictionary<string, object>>(
                        "collection_groups_managers",
                        l => l.HasOne<collection_managers>().WithMany().HasForeignKey("id_manager").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_collection_groups_managers_collection_managers1"),
                        r => r.HasOne<collection_groups>().WithMany().HasForeignKey("id_group").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_collection_groups_managers_collection_groups1"),
                        j =>
                        {
                            j.HasKey("id_group", "id_manager").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("collection_groups_managers").HasCharSet("utf8").UseCollation("utf8_general_ci");

                            j.HasIndex(new[] { "id_group" }, "fk_collection_groups_managers_collection_groups1_idx");

                            j.HasIndex(new[] { "id_manager" }, "fk_collection_groups_managers_collection_managers1");

                            j.IndexerProperty<uint>("id_group").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_manager").HasColumnType("int(10) unsigned");
                        });
            });

            modelBuilder.Entity<collection_logs>(entity =>
            {
                entity.HasKey(e => e.id_log)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "index2");

                entity.Property(e => e.id_log).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e._event)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasColumnType("text");

                entity.Property(e => e.timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.collection_logs)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_logs_1");
            });

            modelBuilder.Entity<collection_managements>(entity =>
            {
                entity.HasKey(e => e.id_management)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_distributor, "fk_collection_managements_1_idx");

                entity.HasIndex(e => e.id_credit, "fk_collection_managements_2_idx");

                entity.HasIndex(e => e.id_assignment, "fk_collection_managements_3_idx");

                entity.HasIndex(e => e.id_user, "fk_collection_managements_4_idx");

                entity.HasIndex(e => e.id_coordination, "fk_collection_managements_5_idx");

                entity.HasIndex(e => e.id_result_type, "fk_collection_managements_6_idx");

                entity.HasIndex(e => e.id_receipt, "id_receipt_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_management).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.id_assignment).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_coordination).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_receipt).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_result_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasColumnType("text");

                entity.HasOne(d => d.id_assignmentNavigation)
                    .WithMany(p => p.collection_managements)
                    .HasForeignKey(d => d.id_assignment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_managements_3");

                entity.HasOne(d => d.id_coordinationNavigation)
                    .WithMany(p => p.collection_managements)
                    .HasForeignKey(d => d.id_coordination)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_managements_5");

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.collection_managements)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_managements_2");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.collection_managements)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_managements_1");

                entity.HasOne(d => d.id_receiptNavigation)
                    .WithOne(p => p.collection_managements)
                    .HasForeignKey<collection_managements>(d => d.id_receipt)
                    .HasConstraintName("fk_collection_managements_7");

                entity.HasOne(d => d.id_result_typeNavigation)
                    .WithMany(p => p.collection_managements)
                    .HasForeignKey(d => d.id_result_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_managements_6");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.collection_managements)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_managements_4");
            });

            modelBuilder.Entity<collection_managers>(entity =>
            {
                entity.HasKey(e => e.id_manager)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_collection_managers_2_idx");

                entity.HasIndex(e => e.id_group, "fk_collection_managers_3_idx");

                entity.HasIndex(e => e.id_employment, "fk_collection_managers_collection_employments1_idx");

                entity.Property(e => e.id_manager).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_employment).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_group).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_employmentNavigation)
                    .WithMany(p => p.collection_managers)
                    .HasForeignKey(d => d.id_employment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_managers_1");

                entity.HasOne(d => d.id_group1)
                    .WithMany(p => p.collection_managers)
                    .HasForeignKey(d => d.id_group)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_managers_3");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.collection_managers)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_managers_2");
            });

            modelBuilder.Entity<collection_mangements>(entity =>
            {
                entity.HasKey(e => e.id_management)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_manager, "fk_collection_mangements_collection_managers_idx");

                entity.HasIndex(e => e.id_result, "fk_collection_mangements_collection_results1_idx");

                entity.Property(e => e.id_management).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasPrecision(8, 2);

                entity.Property(e => e.description).HasColumnType("text");

                entity.Property(e => e.id_manager).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_result).HasColumnType("int(10) unsigned");

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");

                entity.HasOne(d => d.id_managerNavigation)
                    .WithMany(p => p.collection_mangements)
                    .HasForeignKey(d => d.id_manager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_mangements_collection_managers");

                entity.HasOne(d => d.id_resultNavigation)
                    .WithMany(p => p.collection_mangements)
                    .HasForeignKey(d => d.id_result)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_mangements_collection_results1");
            });

            modelBuilder.Entity<collection_receipt_book_relations>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_parent, "index2");

                entity.HasIndex(e => e.id_receipt_book, "index3");

                entity.Property(e => e.id_parent).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_receipt_book).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_parentNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.id_parent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_receipt_book_relations_1");

                entity.HasOne(d => d.id_receipt_bookNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.id_receipt_book)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_receipt_book_relations_2");
            });

            modelBuilder.Entity<collection_receipt_books>(entity =>
            {
                entity.HasKey(e => e.id_receipt_book)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_branch, "index4");

                entity.HasIndex(e => e.id_manager, "index5");

                entity.Property(e => e.id_receipt_book).HasColumnType("int(10) unsigned");

                entity.Property(e => e.end_folio).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_manager).HasColumnType("int(10) unsigned");

                entity.Property(e => e.quantity).HasColumnType("int(10) unsigned");

                entity.Property(e => e.start_folio).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_branchNavigation)
                    .WithMany(p => p.collection_receipt_books)
                    .HasForeignKey(d => d.id_branch)
                    .HasConstraintName("fk_collection_receipt_books_1");

                entity.HasOne(d => d.id_managerNavigation)
                    .WithMany(p => p.collection_receipt_books)
                    .HasForeignKey(d => d.id_manager)
                    .HasConstraintName("fk_collection_receipt_books_2");
            });

            modelBuilder.Entity<collection_receipt_requests>(entity =>
            {
                entity.HasKey(e => e.id_receipt_request)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_branch, "index2");

                entity.HasIndex(e => e.id_user, "index3");

                entity.Property(e => e.id_receipt_request).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.quantity).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");

                entity.HasOne(d => d.id_branchNavigation)
                    .WithMany(p => p.collection_receipt_requests)
                    .HasForeignKey(d => d.id_branch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_receipt_requests_1");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.collection_receipt_requests)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_receipt_requests_2");
            });

            modelBuilder.Entity<collection_receipts>(entity =>
            {
                entity.HasKey(e => e.id_receipt)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_corp_receipt_book, "index2");

                entity.HasIndex(e => e.id_branch_receipt_book, "index3");

                entity.HasIndex(e => e.id_manager_receipt_book, "index4");

                entity.HasIndex(e => e.id_manager, "index6");

                entity.HasIndex(e => e.id_distributor, "index7");

                entity.HasIndex(e => e.id_box, "index8");

                entity.Property(e => e.id_receipt).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.id_box).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_branch_receipt_book).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_corp_receipt_book).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_manager).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_manager_receipt_book).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");

                entity.HasOne(d => d.id_boxNavigation)
                    .WithMany(p => p.collection_receipts)
                    .HasForeignKey(d => d.id_box)
                    .HasConstraintName("fk_collection_receipts_7");

                entity.HasOne(d => d.id_branch_receipt_bookNavigation)
                    .WithMany(p => p.collection_receiptsid_branch_receipt_bookNavigation)
                    .HasForeignKey(d => d.id_branch_receipt_book)
                    .HasConstraintName("fk_collection_receipts_2");

                entity.HasOne(d => d.id_corp_receipt_bookNavigation)
                    .WithMany(p => p.collection_receiptsid_corp_receipt_bookNavigation)
                    .HasForeignKey(d => d.id_corp_receipt_book)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_receipts_1");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.collection_receipts)
                    .HasForeignKey(d => d.id_distributor)
                    .HasConstraintName("fk_collection_receipts_6");

                entity.HasOne(d => d.id_managerNavigation)
                    .WithMany(p => p.collection_receipts)
                    .HasForeignKey(d => d.id_manager)
                    .HasConstraintName("fk_collection_receipts_5");

                entity.HasOne(d => d.id_manager_receipt_bookNavigation)
                    .WithMany(p => p.collection_receiptsid_manager_receipt_bookNavigation)
                    .HasForeignKey(d => d.id_manager_receipt_book)
                    .HasConstraintName("fk_collection_receipts_3");
            });

            modelBuilder.Entity<collection_receipts_logs>(entity =>
            {
                entity.HasKey(e => e.id_receipt_log)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_receipt, "index2");

                entity.HasIndex(e => e.id_log, "index3");

                entity.Property(e => e.id_receipt_log).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_log).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.id_receipt).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_logNavigation)
                    .WithMany(p => p.collection_receipts_logs)
                    .HasForeignKey(d => d.id_log)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_receipts_logs_2");

                entity.HasOne(d => d.id_receiptNavigation)
                    .WithMany(p => p.collection_receipts_logs)
                    .HasForeignKey(d => d.id_receipt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_receipts_logs_1");
            });

            modelBuilder.Entity<collection_receipts_notifications>(entity =>
            {
                entity.HasKey(e => e.id_receipt_notification)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_receipt_notification).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_receipt).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_receipt_notification_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.seen)
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<collection_receipts_notifications_types>(entity =>
            {
                entity.HasKey(e => e.id_receipt_notification_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_receipt_notification_type)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.message).HasMaxLength(100);

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<collection_requests>(entity =>
            {
                entity.HasKey(e => e.id_request)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_request).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_cancellation_reason).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_receipt).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasColumnType("text");

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.validation_date).HasColumnType("timestamp");
            });

            modelBuilder.Entity<collection_result_types>(entity =>
            {
                entity.HasKey(e => e.id_result_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "description_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_result_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount_label).HasMaxLength(45);

                entity.Property(e => e.date_label).HasMaxLength(45);

                entity.Property(e => e.has_amount).HasColumnType("tinyint(4) unsigned");

                entity.Property(e => e.has_date).HasColumnType("tinyint(4) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.require_receipt)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.result)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<collection_results>(entity =>
            {
                entity.HasKey(e => e.id_result)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.description, "description_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_result).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount_label).HasMaxLength(45);

                entity.Property(e => e.clasification)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.date_label).HasMaxLength(45);

                entity.Property(e => e.description).HasMaxLength(45);

                entity.Property(e => e.has_amount).HasColumnType("tinyint(4)");

                entity.Property(e => e.has_date).HasColumnType("tinyint(4)");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");
            });

            modelBuilder.Entity<collection_tasks>(entity =>
            {
                entity.HasKey(e => e.id_task)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_manager, "fk_collection_tasks_collection_managers1_idx");

                entity.HasIndex(e => e.id_distributor, "fk_collection_tasks_credit_distributors1_idx");

                entity.Property(e => e.id_task).HasColumnType("int(10) unsigned");

                entity.Property(e => e.description).HasColumnType("text");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_manager).HasColumnType("int(10) unsigned");

                entity.Property(e => e.schedule).HasColumnType("datetime");

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.collection_tasks)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_tasks_credit_distributors1");

                entity.HasOne(d => d.id_managerNavigation)
                    .WithMany(p => p.collection_tasks)
                    .HasForeignKey(d => d.id_manager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_tasks_collection_managers1");
            });

            modelBuilder.Entity<collection_teams>(entity =>
            {
                entity.HasKey(e => e.id_team)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_collection_teams_1_idx");

                entity.Property(e => e.id_team).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.collection_teams)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_teams_1");
            });

            modelBuilder.Entity<collection_teams_members>(entity =>
            {
                entity.HasKey(e => e.id_team_member)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_team, "fk_collection_teams_members_1_idx");

                entity.HasIndex(e => e.id_user, "fk_collection_teams_members_2_idx");

                entity.Property(e => e.id_team_member).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_team).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_teamNavigation)
                    .WithMany(p => p.collection_teams_members)
                    .HasForeignKey(d => d.id_team)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_teams_members_1");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.collection_teams_members)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_collection_teams_members_2");
            });

            modelBuilder.Entity<collection_types>(entity =>
            {
                entity.HasKey(e => e.id_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.can_punish).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.end_due_days).HasColumnType("int(4) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.start_due_days).HasColumnType("int(4) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<consulta_purchases>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.purchases).HasColumnType("int(11)");
            });

            modelBuilder.Entity<core_action_groups>(entity =>
            {
                entity.HasKey(e => e.id_action_group)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_menu, "index2");

                entity.Property(e => e.id_action_group).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_menu).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.HasOne(d => d.id_menuNavigation)
                    .WithMany(p => p.core_action_groups)
                    .HasForeignKey(d => d.id_menu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_core_action_groups_1");

                entity.HasMany(d => d.id_action)
                    .WithMany(p => p.id_action_group)
                    .UsingEntity<Dictionary<string, object>>(
                        "core_action_groups_actions",
                        l => l.HasOne<core_actions>().WithMany().HasForeignKey("id_action").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_core_action_groups_actions_2"),
                        r => r.HasOne<core_action_groups>().WithMany().HasForeignKey("id_action_group").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_core_action_groups_actions_1"),
                        j =>
                        {
                            j.HasKey("id_action_group", "id_action").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("core_action_groups_actions").HasCharSet("utf8").UseCollation("utf8_general_ci");

                            j.HasIndex(new[] { "id_action" }, "fk_core_action_groups_actions_2_idx");

                            j.IndexerProperty<uint>("id_action_group").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_action").HasColumnType("int(10) unsigned");
                        });
            });

            modelBuilder.Entity<core_actions>(entity =>
            {
                entity.HasKey(e => e.id_action)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_controller, "fk_core_actions_1_idx");

                entity.Property(e => e.id_action).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_controller).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(50);

                entity.HasOne(d => d.id_controllerNavigation)
                    .WithMany(p => p.core_actions)
                    .HasForeignKey(d => d.id_controller)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_core_actions_1");

                entity.HasMany(d => d.id_role)
                    .WithMany(p => p.id_action)
                    .UsingEntity<Dictionary<string, object>>(
                        "core_actions_roles",
                        l => l.HasOne<core_roles>().WithMany().HasForeignKey("id_role").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_core_actions_roles_2"),
                        r => r.HasOne<core_actions>().WithMany().HasForeignKey("id_action").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_core_actions_roles_1"),
                        j =>
                        {
                            j.HasKey("id_action", "id_role").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("core_actions_roles").HasCharSet("utf8").UseCollation("utf8_general_ci");

                            j.HasIndex(new[] { "id_role" }, "fk_core_actions_roles_2_idx");

                            j.IndexerProperty<uint>("id_action").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_role").HasColumnType("int(10) unsigned");
                        });
            });

            modelBuilder.Entity<core_apps_versions>(entity =>
            {
                entity.HasKey(e => e.id_app_version)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_app_version).HasColumnType("int(11)");

                entity.Property(e => e.name).HasMaxLength(40);

                entity.Property(e => e.status).HasColumnType("tinyint(3)");

                entity.Property(e => e.version).HasMaxLength(20);
            });

            modelBuilder.Entity<core_branches>(entity =>
            {
                entity.HasKey(e => e.id_branch)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_configuration_interest, "core_branches_credit_configurations_interests_FK");

                entity.HasIndex(e => e.id_zone, "index3");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.alias).HasMaxLength(3);

                entity.Property(e => e.has_thrift)
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.id_configuration_charge_type)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.id_configuration_discount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.id_configuration_interest).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_configuration_multiple_coupon)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.id_configuration_thrift_day).HasColumnType("int(11)");

                entity.Property(e => e.id_management)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.id_zone).HasColumnType("int(10) unsigned");

                entity.Property(e => e.is_curp_active).HasDefaultValueSql("'1'");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.zipcode).HasColumnType("int(5) unsigned");

                entity.HasOne(d => d.id_configuration_interestNavigation)
                    .WithMany(p => p.core_branches)
                    .HasForeignKey(d => d.id_configuration_interest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("core_branches_credit_configurations_interests_FK");

                entity.HasOne(d => d.id_zoneNavigation)
                    .WithMany(p => p.core_branches)
                    .HasForeignKey(d => d.id_zone)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_core_branches_1");
            });

            modelBuilder.Entity<core_branches_branches>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_branch).HasColumnType("int(11)");

                entity.Property(e => e.id_parent).HasColumnType("int(11)");
            });

            modelBuilder.Entity<core_controllers>(entity =>
            {
                entity.HasKey(e => e.id_controller)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_module, "fk_core_controllers_1_idx");

                entity.Property(e => e.id_controller).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_module).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(100);

                entity.HasOne(d => d.id_moduleNavigation)
                    .WithMany(p => p.core_controllers)
                    .HasForeignKey(d => d.id_module)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_core_controllers_1");
            });

            modelBuilder.Entity<core_customer_configurations>(entity =>
            {
                entity.HasKey(e => e.id_customer_configuration)
                    .HasName("PRIMARY");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.id_customer_configuration).HasColumnType("int(10) unsigned");

                entity.Property(e => e.contracted_logo)
                    .HasMaxLength(255)
                    .HasComment("Ruta del logo cuando esta contraido el menu");

                entity.Property(e => e.created)
                    .HasColumnType("datetime")
                    .HasComment("Fecha en que se dio de alta");

                entity.Property(e => e.expanded_logo)
                    .HasMaxLength(255)
                    .HasComment("Ruta del logo cuando el menu esta expandido");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .HasComment("Nombre de la empresa");

                entity.Property(e => e.style)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'1'")
                    .HasComment("Estilo a emplear para el sitio");
            });

            modelBuilder.Entity<core_logs>(entity =>
            {
                entity.HasKey(e => e.id_log)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_core_logs_1_idx");

                entity.Property(e => e.id_log).HasColumnType("int(10) unsigned");

                entity.Property(e => e._event)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasColumnType("text");

                entity.Property(e => e.timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.core_logs)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_core_logs_1");
            });

            modelBuilder.Entity<core_management>(entity =>
            {
                entity.HasKey(e => e.id_management)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_spanish_ci");

                entity.Property(e => e.id_management).HasColumnType("int(10)");

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.status).HasColumnType("tinyint(3)");
            });

            modelBuilder.Entity<core_menu_sections>(entity =>
            {
                entity.HasKey(e => e.id_menu_section)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_menu_section).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.order).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<core_menus>(entity =>
            {
                entity.HasKey(e => e.id_menu)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_parent, "fk_core_menus_1_idx");

                entity.HasIndex(e => e.id_menu_section, "fk_core_menus_2_idx");

                entity.HasIndex(e => e.id_action, "fk_core_menus_3_idx");

                entity.Property(e => e.id_menu).HasColumnType("int(10) unsigned");

                entity.Property(e => e.icon).HasMaxLength(45);

                entity.Property(e => e.id_action).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_menu_section).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_parent).HasColumnType("int(10) unsigned");

                entity.Property(e => e.is_s2next)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.order).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.url).HasMaxLength(100);

                entity.HasOne(d => d.id_actionNavigation)
                    .WithMany(p => p.core_menus)
                    .HasForeignKey(d => d.id_action)
                    .HasConstraintName("fk_core_menus_3");

                entity.HasOne(d => d.id_menu_sectionNavigation)
                    .WithMany(p => p.core_menus)
                    .HasForeignKey(d => d.id_menu_section)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_core_menus_2");

                entity.HasOne(d => d.id_parentNavigation)
                    .WithMany(p => p.Inverseid_parentNavigation)
                    .HasForeignKey(d => d.id_parent)
                    .HasConstraintName("fk_core_menus_1");

                entity.HasMany(d => d.id_action1)
                    .WithMany(p => p.id_menu)
                    .UsingEntity<Dictionary<string, object>>(
                        "core_menus_actions",
                        l => l.HasOne<core_actions>().WithMany().HasForeignKey("id_action").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_core_menus_actions_2"),
                        r => r.HasOne<core_menus>().WithMany().HasForeignKey("id_menu").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_core_menus_actions_1"),
                        j =>
                        {
                            j.HasKey("id_menu", "id_action").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("core_menus_actions").HasCharSet("utf8").UseCollation("utf8_general_ci");

                            j.HasIndex(new[] { "id_action" }, "fk_core_menus_actions_2_idx");

                            j.IndexerProperty<uint>("id_menu").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_action").HasColumnType("int(10) unsigned");
                        });
            });

            modelBuilder.Entity<core_modules>(entity =>
            {
                entity.HasKey(e => e.id_module)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_module).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(100);
            });

            modelBuilder.Entity<core_notifications>(entity =>
            {
                entity.HasKey(e => e.id_notification)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_core_notifications_1_idx");

                entity.HasIndex(e => e.id_from, "fk_core_notifications_2_idx");

                entity.Property(e => e.id_notification).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_from).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.message).HasMaxLength(200);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.timestamp).HasColumnType("datetime");

                entity.Property(e => e.title).HasMaxLength(45);

                entity.Property(e => e.type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.url).HasMaxLength(150);

                entity.HasOne(d => d.id_fromNavigation)
                    .WithMany(p => p.core_notificationsid_fromNavigation)
                    .HasForeignKey(d => d.id_from)
                    .HasConstraintName("fk_core_notifications_2");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.core_notificationsid_userNavigation)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_core_notifications_1");
            });

            modelBuilder.Entity<core_persons>(entity =>
            {
                entity.HasKey(e => e.id_person)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.last_name).HasMaxLength(45);

                entity.Property(e => e.middle_name).HasMaxLength(45);

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.second_last_name).HasMaxLength(45);
            });

            modelBuilder.Entity<core_persons_curp_validation_>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.apellido_materno).HasMaxLength(255);

                entity.Property(e => e.apellido_paterno).HasMaxLength(255);

                entity.Property(e => e.curp).HasMaxLength(255);

                entity.Property(e => e.primer_nombre).HasMaxLength(255);

                entity.Property(e => e.segundo_nombre).HasMaxLength(255);
            });

            modelBuilder.Entity<core_persons_curp_validations_>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.apellido_materno).HasMaxLength(255);

                entity.Property(e => e.apellido_paterno).HasMaxLength(255);

                entity.Property(e => e.curp).HasMaxLength(255);

                entity.Property(e => e.departamento).HasMaxLength(255);

                entity.Property(e => e.fechaIngreso).HasColumnType("timestamp");

                entity.Property(e => e.primer_nombre).HasMaxLength(255);

                entity.Property(e => e.puesto).HasMaxLength(255);

                entity.Property(e => e.segundo_nombre).HasMaxLength(255);

                entity.Property(e => e.sucursal).HasMaxLength(255);
            });

            modelBuilder.Entity<core_role_menu_action_group>(entity =>
            {
                entity.HasKey(e => new { e.id_role_menu, e.id_action_group })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.id_role_menu).HasColumnType("int(11)");

                entity.Property(e => e.id_action_group).HasColumnType("int(11)");
            });

            modelBuilder.Entity<core_roles>(entity =>
            {
                entity.HasKey(e => e.id_role)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_role).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<core_roles_menus>(entity =>
            {
                entity.HasKey(e => e.id_role_menu)
                    .HasName("PRIMARY");

                entity.Property(e => e.id_role_menu).HasColumnType("int(11)");

                entity.Property(e => e.id_menu).HasColumnType("int(11)");

                entity.Property(e => e.id_role).HasColumnType("int(11)");
            });

            modelBuilder.Entity<core_sepomex>(entity =>
            {
                entity.HasKey(e => e.id_sepomex)
                    .HasName("PRIMARY");

                entity.HasComment("Actualizado a 18 Mayo\nIsdarkA")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_sepomex).HasColumnType("int(10) unsigned");

                entity.Property(e => e.D_mnpio)
                    .HasMaxLength(255)
                    .HasComment("Nombre Municipio (INEGI, Marzo 2013)");

                entity.Property(e => e.c_CP)
                    .HasMaxLength(255)
                    .HasComment("Campo Vacio");

                entity.Property(e => e.c_cve_ciudad)
                    .HasColumnType("int(11)")
                    .HasComment("Clave Ciudad (Catálogo SEPOMEX)");

                entity.Property(e => e.c_estado)
                    .HasColumnType("int(11)")
                    .HasComment("Clave Entidad (INEGI, Marzo 2013)");

                entity.Property(e => e.c_mnpio)
                    .HasColumnType("int(11)")
                    .HasComment("Clave Municipio (INEGI, Marzo 2013)");

                entity.Property(e => e.c_oficina)
                    .HasColumnType("int(11)")
                    .HasComment("Código Postal de la Administración Postal que reparte al asentamiento");

                entity.Property(e => e.c_tipo_asenta)
                    .HasColumnType("int(11)")
                    .HasComment("Clave Tipo de asentamiento (Catálogo SEPOMEX)");

                entity.Property(e => e.d_CP)
                    .HasColumnType("int(11)")
                    .HasComment("Código Postal de la Administración Postal que reparte al asentamiento");

                entity.Property(e => e.d_asenta)
                    .HasMaxLength(255)
                    .HasComment("Nombre asentamiento");

                entity.Property(e => e.d_ciudad)
                    .HasMaxLength(255)
                    .HasComment("Nombre Ciudad (Catálogo SEPOMEX)");

                entity.Property(e => e.d_codigo)
                    .HasColumnType("int(5) unsigned zerofill")
                    .HasComment("Código Postal asentamiento");

                entity.Property(e => e.d_estado)
                    .HasMaxLength(255)
                    .HasComment("Nombre Entidad (INEGI, Marzo 2013)");

                entity.Property(e => e.d_tipo_asenta)
                    .HasMaxLength(255)
                    .HasComment("Tipo de asentamiento (Catálogo SEPOMEX)");

                entity.Property(e => e.d_zona)
                    .HasMaxLength(255)
                    .HasComment("Zona en la que se ubica el asentamiento (Urbano/Rural)");

                entity.Property(e => e.id_asenta_cpcons)
                    .HasColumnType("int(11)")
                    .HasComment("Identificador Único del asentamiento (nivel municipal)\n");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<core_stores>(entity =>
            {
                entity.HasKey(e => e.id_store)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_branch, "fk_core_stores_1_idx");

                entity.Property(e => e.id_store).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_branchNavigation)
                    .WithMany(p => p.core_stores)
                    .HasForeignKey(d => d.id_branch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_core_stores_1");
            });

            modelBuilder.Entity<core_users>(entity =>
            {
                entity.HasKey(e => e.id_user)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_person, "fk_core_users_1_idx");

                entity.HasIndex(e => e.username, "username_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.code).HasMaxLength(45);

                entity.Property(e => e.email).HasMaxLength(100);

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.is_corporate)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.is_s2next)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.last_login).HasColumnType("datetime");

                entity.Property(e => e.password).HasMaxLength(100);

                entity.Property(e => e.status)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.update_password_at).HasColumnType("datetime");

                entity.Property(e => e.username).HasMaxLength(100);

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.core_users)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_core_users_1");

                entity.HasMany(d => d.id_branch)
                    .WithMany(p => p.id_user)
                    .UsingEntity<Dictionary<string, object>>(
                        "core_users_branches",
                        l => l.HasOne<core_branches>().WithMany().HasForeignKey("id_branch").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_core_users_branches_2"),
                        r => r.HasOne<core_users>().WithMany().HasForeignKey("id_user").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_core_users_branches_1"),
                        j =>
                        {
                            j.HasKey("id_user", "id_branch").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("core_users_branches").HasCharSet("latin1").UseCollation("latin1_swedish_ci");

                            j.HasIndex(new[] { "id_branch" }, "fk_core_users_branches_2_idx");

                            j.IndexerProperty<uint>("id_user").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_branch").HasColumnType("int(10) unsigned");
                        });

                entity.HasMany(d => d.id_role)
                    .WithMany(p => p.id_user)
                    .UsingEntity<Dictionary<string, object>>(
                        "core_users_roles",
                        l => l.HasOne<core_roles>().WithMany().HasForeignKey("id_role").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_core_users_roles_2"),
                        r => r.HasOne<core_users>().WithMany().HasForeignKey("id_user").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_core_users_roles_1"),
                        j =>
                        {
                            j.HasKey("id_user", "id_role").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("core_users_roles").HasCharSet("utf8").UseCollation("utf8_general_ci");

                            j.HasIndex(new[] { "id_role" }, "fk_core_users_roles_2_idx");

                            j.IndexerProperty<uint>("id_user").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_role").HasColumnType("int(10) unsigned");
                        });
            });

            modelBuilder.Entity<core_users_logs>(entity =>
            {
                entity.HasKey(e => e.id_user_log)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_core_users_logs_1_idx");

                entity.HasIndex(e => e.id_log, "fk_core_users_logs_2_idx");

                entity.Property(e => e.id_user_log).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_log).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_logNavigation)
                    .WithMany(p => p.core_users_logs)
                    .HasForeignKey(d => d.id_log)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_core_users_logs_2");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.core_users_logs)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_core_users_logs_1");
            });

            modelBuilder.Entity<core_zones>(entity =>
            {
                entity.HasKey(e => e.id_zone)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_zone).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<corte1>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.FECHA_COMPRA).HasColumnName("FECHA COMPRA");

                entity.Property(e => e.ID_CLIENTE).HasColumnType("int(10) unsigned");

                entity.Property(e => e.NOMBRE)
                    .HasMaxLength(183)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SUCURSAL)
                    .HasMaxLength(45)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e._VALE)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("#VALE");

                entity.Property(e => e.fortnights).HasColumnType("int(10) unsigned");

                entity.Property(e => e.number).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ultimo_pago)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<corte2>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.FECHA_COMPRA).HasColumnName("FECHA COMPRA");

                entity.Property(e => e.ID_CLIENTE).HasColumnType("int(10) unsigned");

                entity.Property(e => e.NOMBRE)
                    .HasMaxLength(183)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SUCURSAL)
                    .HasMaxLength(45)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e._VALE)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("#VALE");

                entity.Property(e => e.fortnights).HasColumnType("int(10) unsigned");

                entity.Property(e => e.number).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ultimo_pago)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<corte3>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.FECHA_COMPRA).HasColumnName("FECHA COMPRA");

                entity.Property(e => e.ID_CLIENTE).HasColumnType("int(10) unsigned");

                entity.Property(e => e.NOMBRE)
                    .HasMaxLength(183)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SUCURSAL)
                    .HasMaxLength(45)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e._VALE)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("#VALE");

                entity.Property(e => e.fortnights).HasColumnType("int(10) unsigned");

                entity.Property(e => e.number).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ultimo_pago)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<coupon_books>(entity =>
            {
                entity.HasKey(e => e.id_book)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_distributor, "fk_coupon_books_1_idx");

                entity.HasIndex(e => e.id_user, "fk_coupon_books_2_idx");

                entity.Property(e => e.id_book).HasColumnType("int(10) unsigned");

                entity.Property(e => e.folio_start)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Este indica el folio con el que debe iniciar el libro de vouchers");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.quantity).HasColumnType("int(11)");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.coupon_books)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coupon_books_1");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.coupon_books)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coupon_books_2");
            });

            modelBuilder.Entity<coupon_cancellation_reasons>(entity =>
            {
                entity.HasKey(e => e.id_cancellation_reason)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_cancellation_reason).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<coupon_configurations>(entity =>
            {
                entity.HasKey(e => e.id_configuration)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_coupon_configurations_1_idx");

                entity.Property(e => e.id_configuration).HasColumnType("int(10) unsigned");

                entity.Property(e => e.coupons_per_page)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'4'");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.jump_between_coupons).HasColumnType("int(10) unsigned");

                entity.Property(e => e.layout).HasMaxLength(300);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.coupon_configurations)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coupon_configurations_1");
            });

            modelBuilder.Entity<coupon_configurations_books>(entity =>
            {
                entity.HasKey(e => e.id_configuration_book)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_coupon_configurations_books_1");

                entity.Property(e => e.id_configuration_book).HasColumnType("int(10) unsigned");

                entity.Property(e => e.folio_type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Este campo define el tipo de folio para el voucher, 1 por sistema, 2 por usuario");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.layout_status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Este campo tiene el estado del layout, 1 activado, 2 desactivado");

                entity.Property(e => e.limit_amount)
                    .HasColumnType("int(15) unsigned")
                    .HasComment("Este campo define el limite de cupones para generar");

                entity.Property(e => e.limit_status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Este campo tiene el estado del limit, 1 con limite, 2 sin limite");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.coupon_configurations_books)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coupon_configurations_books_1");
            });

            modelBuilder.Entity<coupon_configurations_fields>(entity =>
            {
                entity.HasKey(e => e.id_configuration_field)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_configuration, "fk_coupon_configurations_fields_1_idx");

                entity.Property(e => e.id_configuration_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.field_type).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.id_configuration).HasColumnType("int(10) unsigned");

                entity.Property(e => e.position_x).HasPrecision(5, 2);

                entity.Property(e => e.position_y).HasPrecision(5, 2);

                entity.HasOne(d => d.id_configurationNavigation)
                    .WithMany(p => p.coupon_configurations_fields)
                    .HasForeignKey(d => d.id_configuration)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coupon_configurations_fields_1");
            });

            modelBuilder.Entity<coupon_configurations_vouchers>(entity =>
            {
                entity.HasKey(e => e.id_configuration_voucher)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_coupon_configurations_vouchers_1_idx");

                entity.HasIndex(e => e.identifier, "identifier_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_configuration_voucher).HasColumnType("int(10) unsigned");

                entity.Property(e => e.column_space).HasColumnType("decimal(5,2) unsigned");

                entity.Property(e => e.columns).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.identifier).HasMaxLength(45);

                entity.Property(e => e.layout).HasMaxLength(200);

                entity.Property(e => e.register_date).HasColumnType("datetime");

                entity.Property(e => e.row_space).HasColumnType("decimal(5,2) unsigned");

                entity.Property(e => e.rows).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.typography).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.use_as)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.coupon_configurations_vouchers)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coupon_configurations_vouchers_1");
            });

            modelBuilder.Entity<coupon_configurations_vouchers_fields>(entity =>
            {
                entity.HasKey(e => e.id_configuration_voucher_field)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_configuration_voucher, "fk_coupon_configurations_vouchers_fields_1_idx");

                entity.Property(e => e.id_configuration_voucher_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_configuration_voucher).HasColumnType("int(10) unsigned");

                entity.Property(e => e.position_x).HasColumnType("decimal(5,2) unsigned");

                entity.Property(e => e.position_y).HasColumnType("decimal(5,2) unsigned");

                entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.typography).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_configuration_voucherNavigation)
                    .WithMany(p => p.coupon_configurations_vouchers_fields)
                    .HasForeignKey(d => d.id_configuration_voucher)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coupon_configurations_vouchers_fields_1");
            });

            modelBuilder.Entity<coupon_coupons>(entity =>
            {
                entity.HasKey(e => e.id_coupon)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_amount, "coupon_coupons_FK");

                entity.HasIndex(e => e.id_book, "fk_coupon_coupons_1_idx");

                entity.HasIndex(e => e.id_distributor, "fk_coupon_coupons_2_idx");

                entity.HasIndex(e => e.id_user, "fk_coupon_coupons_3_idx");

                entity.HasIndex(e => e.id_customer, "fk_coupon_coupons_4_idx");

                entity.HasIndex(e => e.id_charge_type, "fk_coupon_coupons_5_idx");

                entity.HasIndex(e => e.id_store, "index7");

                entity.HasIndex(e => e.id_branch, "index8");

                entity.Property(e => e.id_coupon).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.cancellation_note).HasColumnType("text");

                entity.Property(e => e.folio).HasMaxLength(100);

                entity.Property(e => e.fortnights).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_amount).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_book).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_cancellation_reason).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_charge_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_customer).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_fortnight).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_store).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.interest).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_amountNavigation)
                    .WithMany(p => p.coupon_coupons)
                    .HasForeignKey(d => d.id_amount)
                    .HasConstraintName("coupon_coupons_FK");

                entity.HasOne(d => d.id_bookNavigation)
                    .WithMany(p => p.coupon_coupons)
                    .HasForeignKey(d => d.id_book)
                    .HasConstraintName("fk_coupon_coupons_1");

                entity.HasOne(d => d.id_charge_typeNavigation)
                    .WithMany(p => p.coupon_coupons)
                    .HasForeignKey(d => d.id_charge_type)
                    .HasConstraintName("fk_coupon_coupons_5");

                entity.HasOne(d => d.id_customerNavigation)
                    .WithMany(p => p.coupon_coupons)
                    .HasForeignKey(d => d.id_customer)
                    .HasConstraintName("fk_coupon_coupons_4");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.coupon_coupons)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coupon_coupons_2");

                entity.HasOne(d => d.id_storeNavigation)
                    .WithMany(p => p.coupon_coupons)
                    .HasForeignKey(d => d.id_store)
                    .HasConstraintName("fk_coupon_coupons_6");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.coupon_coupons)
                    .HasForeignKey(d => d.id_user)
                    .HasConstraintName("fk_coupon_coupons_3");
            });

            modelBuilder.Entity<coupon_coupons_logs>(entity =>
            {
                entity.HasKey(e => e.id_coupon_log)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_coupon, "fk_coupon_coupons_logs_1_idx");

                entity.HasIndex(e => e.id_user, "fk_coupon_coupons_logs_2_idx");

                entity.Property(e => e.id_coupon_log).HasColumnType("int(10) unsigned");

                entity.Property(e => e._event)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event");

                entity.Property(e => e.id_coupon).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasColumnType("text");

                entity.Property(e => e.registered).HasColumnType("datetime");

                entity.HasOne(d => d.id_couponNavigation)
                    .WithMany(p => p.coupon_coupons_logs)
                    .HasForeignKey(d => d.id_coupon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coupon_coupons_logs_1");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.coupon_coupons_logs)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coupon_coupons_logs_2");
            });

            modelBuilder.Entity<credinet_configuration>(entity =>
            {
                entity.HasKey(e => e.id_configuration)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.id_user, "credinet_configuration_FK");

                entity.HasIndex(e => e.id_stage, "credinet_configuration_FK_1");

                entity.Property(e => e.id_configuration).HasColumnType("int(10) unsigned");

                entity.Property(e => e.created).HasColumnType("datetime");

                entity.Property(e => e.id_stage).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.token).HasMaxLength(100);

                entity.HasOne(d => d.id_stageNavigation)
                    .WithMany(p => p.credinet_configuration)
                    .HasForeignKey(d => d.id_stage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credinet_configuration_FK_1");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.credinet_configuration)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credinet_configuration_FK");
            });

            modelBuilder.Entity<credit_activities>(entity =>
            {
                entity.HasKey(e => e.id_activity)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_credit, "fk_credit_activities_1_idx");

                entity.HasIndex(e => e.id_distributor, "fk_credit_activities_2_idx");

                entity.Property(e => e.id_activity).HasColumnType("int(10) unsigned");

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasColumnType("text");

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.credit_activities)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_activities_1");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_activities)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_activities_2");
            });

            modelBuilder.Entity<credit_addresses>(entity =>
            {
                entity.HasKey(e => e.id_address)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_address).HasColumnType("int(10) unsigned");

                entity.Property(e => e.apartment_number).HasMaxLength(45);

                entity.Property(e => e.city).HasMaxLength(45);

                entity.Property(e => e.house_number).HasMaxLength(45);

                entity.Property(e => e.latitude).HasMaxLength(100);

                entity.Property(e => e.longitude).HasMaxLength(100);

                entity.Property(e => e.neighborhood).HasMaxLength(45);

                entity.Property(e => e.settlement).HasMaxLength(45);

                entity.Property(e => e.state).HasMaxLength(45);

                entity.Property(e => e.street).HasMaxLength(45);

                entity.Property(e => e.zipcode).HasMaxLength(5);
            });

            modelBuilder.Entity<credit_amount_branches>(entity =>
            {
                entity.HasKey(e => e.id_amount_branch)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.limit_id_amount, "limit_id_amount");

                entity.HasIndex(e => e.limit_id_amount_first, "limit_id_amount_first");

                entity.Property(e => e.id_amount_branch).HasColumnType("int(11)");

                entity.Property(e => e.id_branch).HasColumnType("int(11)");

                entity.Property(e => e.limit_id_amount).HasColumnType("int(10) unsigned");

                entity.Property(e => e.limit_id_amount_first).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.limit_id_amountNavigation)
                    .WithMany(p => p.credit_amount_brancheslimit_id_amountNavigation)
                    .HasForeignKey(d => d.limit_id_amount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_amount_branches_ibfk_1");

                entity.HasOne(d => d.limit_id_amount_firstNavigation)
                    .WithMany(p => p.credit_amount_brancheslimit_id_amount_firstNavigation)
                    .HasForeignKey(d => d.limit_id_amount_first)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_amount_branches_ibfk_2");
            });

            modelBuilder.Entity<credit_amounts>(entity =>
            {
                entity.HasKey(e => e.id_amount)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_charge_type, "fk_credit_amounts_1_idx");

                entity.Property(e => e.id_amount).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.id_charge_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_charge_typeNavigation)
                    .WithMany(p => p.credit_amounts)
                    .HasForeignKey(d => d.id_charge_type)
                    .HasConstraintName("fk_credit_amounts_1");
            });

            modelBuilder.Entity<credit_automatic_locks>(entity =>
            {
                entity.HasKey(e => e.id_automatic_lock)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_automatic_lock).HasColumnType("int(10) unsigned");

                entity.Property(e => e.apply_type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.days).HasColumnType("int(10) unsigned");

                entity.Property(e => e.end).HasColumnType("int(10) unsigned");

                entity.Property(e => e.start).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<credit_beneficiaries>(entity =>
            {
                entity.HasKey(e => e.id_beneficiary)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_user, "fk_credit_beneficiaries_1_idx");

                entity.HasIndex(e => e.id_distributor, "fk_credit_beneficiaries_2_idx");

                entity.HasIndex(e => e.id_customer, "fk_credit_beneficiaries_3_idx");

                entity.Property(e => e.id_beneficiary).HasColumnType("int(10) unsigned");

                entity.Property(e => e.beneficiary_type).HasColumnType("tinyint(3)");

                entity.Property(e => e.create_date).HasColumnType("datetime");

                entity.Property(e => e.gender).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.id_customer).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.last_name).HasMaxLength(50);

                entity.Property(e => e.middle_name).HasMaxLength(50);

                entity.Property(e => e.name).HasMaxLength(50);

                entity.Property(e => e.phone).HasMaxLength(10);

                entity.Property(e => e.relationship).HasMaxLength(80);

                entity.Property(e => e.second_last_name).HasMaxLength(50);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_customerNavigation)
                    .WithMany(p => p.credit_beneficiaries)
                    .HasForeignKey(d => d.id_customer)
                    .HasConstraintName("fk_credit_beneficiaries_3");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_beneficiaries)
                    .HasForeignKey(d => d.id_distributor)
                    .HasConstraintName("fk_credit_beneficiaries_2");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.credit_beneficiaries)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_beneficiaries_1");
            });

            modelBuilder.Entity<credit_cancellation_reasons>(entity =>
            {
                entity.HasKey(e => e.id_cancellation_reason)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_cancellation_reason).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<credit_categories>(entity =>
            {
                entity.HasKey(e => e.id_category)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_category).HasColumnType("int(10) unsigned");

                entity.Property(e => e.calculated_by).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.end_amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.filename).HasMaxLength(200);

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.start_amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<credit_charge_type>(entity =>
            {
                entity.HasKey(e => e.id_charge_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_charge_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.affects_credit_line)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.amount).HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.amount_from)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.is_simultaneous)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.requires_confirmation)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<credit_charge_type_extra_fields>(entity =>
            {
                entity.HasKey(e => e.id_charge_type_extra_field)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_charge_type_extra_field).HasColumnType("int(11)");

                entity.Property(e => e.affects_credit_line).HasColumnType("tinyint(3)");

                entity.Property(e => e.amount).HasPrecision(10, 2);

                entity.Property(e => e.amount_from).HasColumnType("tinyint(3)");

                entity.Property(e => e.id_charge_type).HasColumnType("int(11)");

                entity.Property(e => e.id_configuration_charge_type).HasColumnType("int(11)");

                entity.Property(e => e.is_simultaneous).HasColumnType("tinyint(3)");

                entity.Property(e => e.requires_confirmation).HasColumnType("tinyint(3)");
            });

            modelBuilder.Entity<credit_charges>(entity =>
            {
                entity.HasKey(e => e.id_charge)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_distributor, "fk_credit_charges_1_idx");

                entity.HasIndex(e => e.id_credit, "fk_credit_charges_2_idx");

                entity.HasIndex(e => e.id_charge_type, "fk_credit_charges_3_idx");

                entity.HasIndex(e => e.id_category, "fk_credit_charges_4_idx");

                entity.Property(e => e.id_charge).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.applied_discount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.applied_discount_percentage).HasColumnType("decimal(5,2) unsigned");

                entity.Property(e => e.id_category).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_charge_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.interest).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.principal).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_charge_typeNavigation)
                    .WithMany(p => p.credit_charges)
                    .HasForeignKey(d => d.id_charge_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_charges_3");

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.credit_charges)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_charges_2");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_charges)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_charges_1");

                entity.HasMany(d => d.id_purchase_amortization)
                    .WithMany(p => p.id_charge)
                    .UsingEntity<Dictionary<string, object>>(
                        "credit_charges_purchases_amortizations",
                        l => l.HasOne<credit_purchases_amortizations>().WithMany().HasForeignKey("id_purchase_amortization").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_credit_charges_purchases_amortizations_2"),
                        r => r.HasOne<credit_charges>().WithMany().HasForeignKey("id_charge").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_credit_charges_purchases_amortizations_1"),
                        j =>
                        {
                            j.HasKey("id_charge", "id_purchase_amortization").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("credit_charges_purchases_amortizations").HasCharSet("utf8").UseCollation("utf8_general_ci");

                            j.HasIndex(new[] { "id_purchase_amortization" }, "fk_credit_charges_purchases_amortizations_2_idx");

                            j.IndexerProperty<uint>("id_charge").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_purchase_amortization").HasColumnType("int(10) unsigned");
                        });
            });

            modelBuilder.Entity<credit_configurations>(entity =>
            {
                entity.HasKey(e => e.id_configuration)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_configuration).HasColumnType("int(10) unsigned");

                entity.Property(e => e.created).HasColumnType("datetime");

                entity.Property(e => e.first_cutoff_date).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.first_due_date).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.next_or_previous).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.saturday_business).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.second_cutoff_date).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.second_due_date).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.show_holidays)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.show_inactive_weekend)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.show_without_discounts)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.sunday_bussiness).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<credit_configurations_charge_type>(entity =>
            {
                entity.HasKey(e => e.id_configuration_charge_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_configuration_charge_type).HasColumnType("int(11)");

                entity.Property(e => e.name).HasMaxLength(50);

                entity.Property(e => e.registered).HasColumnType("datetime");

                entity.Property(e => e.status).HasColumnType("tinyint(3)");
            });

            modelBuilder.Entity<credit_configurations_discounts>(entity =>
            {
                entity.HasKey(e => e.id_configuration_discount)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_configuration_discount).HasColumnType("int(11)");

                entity.Property(e => e.name).HasMaxLength(40);

                entity.Property(e => e.status).HasColumnType("tinyint(3)");
            });

            modelBuilder.Entity<credit_configurations_interests>(entity =>
            {
                entity.HasKey(e => e.id_configuration_interest)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_configuration_interest).HasColumnType("int(10) unsigned");

                entity.Property(e => e.date_register).HasColumnType("datetime");

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.status).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<credit_configurations_interests_logs>(entity =>
            {
                entity.HasKey(e => e.id_configuration_interest_log)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_configuration_interest, "credit_configurations_interests_FK");

                entity.HasIndex(e => e.id_user, "credit_configurations_interests_logs_core_users_FK");

                entity.Property(e => e.id_configuration_interest_log).HasColumnType("int(10) unsigned");

                entity.Property(e => e._event)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("event");

                entity.Property(e => e.created).HasColumnType("datetime");

                entity.Property(e => e.id_configuration_interest).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasMaxLength(100);

                entity.HasOne(d => d.id_configuration_interestNavigation)
                    .WithMany(p => p.credit_configurations_interests_logs)
                    .HasForeignKey(d => d.id_configuration_interest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_configurations_interests_FK");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.credit_configurations_interests_logs)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_configurations_interests_logs_core_users_FK");
            });

            modelBuilder.Entity<credit_configurations_multiple_coupon>(entity =>
            {
                entity.HasKey(e => e.id_multiple_coupon)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_multiple_coupon).HasColumnType("int(10) unsigned");

                entity.Property(e => e.credit_line).HasPrecision(12, 2);

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.number_renewals).HasColumnType("int(11)");

                entity.Property(e => e.payment_percentage).HasColumnType("int(11)");

                entity.Property(e => e.status).HasColumnType("int(11)");
            });

            modelBuilder.Entity<credit_configurations_receipts>(entity =>
            {
                entity.HasKey(e => e.id_configuration_receipt)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_user, "fk_credit_configurations_receipts_1_idx");

                entity.Property(e => e.id_configuration_receipt).HasColumnType("int(10) unsigned");

                entity.Property(e => e.column_space).HasColumnType("decimal(5,2) unsigned");

                entity.Property(e => e.columns).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.layout).HasMaxLength(200);

                entity.Property(e => e.register_date).HasColumnType("datetime");

                entity.Property(e => e.row_space).HasColumnType("decimal(5,2) unsigned");

                entity.Property(e => e.rows).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.credit_configurations_receipts)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_configurations_receipts_1");
            });

            modelBuilder.Entity<credit_configurations_receipts_fields>(entity =>
            {
                entity.HasKey(e => e.id_configuration_receipt_field)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_configuration_receipt, "fk_credit_configurations_receipts_fields_1_idx");

                entity.Property(e => e.id_configuration_receipt_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_configuration_receipt).HasColumnType("int(10) unsigned");

                entity.Property(e => e.position_x).HasColumnType("decimal(5,2) unsigned");

                entity.Property(e => e.position_y).HasColumnType("decimal(5,2) unsigned");

                entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_configuration_receiptNavigation)
                    .WithMany(p => p.credit_configurations_receipts_fields)
                    .HasForeignKey(d => d.id_configuration_receipt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_configurations_receipts_fields_1");
            });

            modelBuilder.Entity<credit_contracts>(entity =>
            {
                entity.HasKey(e => e.id_contract)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_distributor, "fk_credit_contracts_1_idx");

                entity.HasIndex(e => e.id_credit, "fk_credit_contracts_2_idx");

                entity.Property(e => e.id_contract).HasColumnType("int(10) unsigned");

                entity.Property(e => e.create_date).HasColumnType("datetime");

                entity.Property(e => e.filename).HasMaxLength(500);

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(150);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.credit_contracts)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_contracts_2");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_contracts)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_contracts_1");
            });

            modelBuilder.Entity<credit_credit_notes>(entity =>
            {
                entity.HasKey(e => e.id_credit_note)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_credit_credit_notes_1_idx");

                entity.HasIndex(e => e.id_distributor, "fk_credit_credit_notes_2_idx");

                entity.HasIndex(e => e.id_credit, "fk_credit_credit_notes_3_idx");

                entity.HasIndex(e => e.id_payment, "fk_credit_credit_notes_4_idx");

                entity.Property(e => e.id_credit_note).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.cancellation_date).HasColumnType("datetime");

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_payment).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user_cancellation).HasColumnType("int(11)");

                entity.Property(e => e.note).HasColumnType("text");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.credit_credit_notes)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_credit_notes_3");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_credit_notes)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_credit_notes_2");

                entity.HasOne(d => d.id_paymentNavigation)
                    .WithMany(p => p.credit_credit_notes)
                    .HasForeignKey(d => d.id_payment)
                    .HasConstraintName("fk_credit_credit_notes_4");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.credit_credit_notes)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_credit_notes_1");
            });

            modelBuilder.Entity<credit_credit_types_amount_configuration>(entity =>
            {
                entity.HasKey(e => e.id_amount_configuration)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_spanish_ci");

                entity.HasIndex(e => e.id_credit_type, "id_credit_type");

                entity.Property(e => e.id_amount_configuration).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_credit_type).HasColumnType("int(11) unsigned");

                entity.Property(e => e.limit_amount).HasPrecision(12, 2);

                entity.Property(e => e.limit_amount_first).HasPrecision(12, 2);

                entity.Property(e => e.status).HasColumnType("tinyint(3)");

                entity.HasOne(d => d.id_credit_typeNavigation)
                    .WithMany(p => p.credit_credit_types_amount_configuration)
                    .HasForeignKey(d => d.id_credit_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_credit_types_amount_configuration_ibfk_1");
            });

            modelBuilder.Entity<credit_credit_types_discounts>(entity =>
            {
                entity.HasKey(e => e.id_credit_type_discount)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_credit_type, "fk_credit_credit_types_discounts_1_idx");

                entity.HasIndex(e => e.id_charge_type, "fk_credit_credit_types_discounts_2_idx");

                entity.HasIndex(e => e.id_category, "fk_credit_credit_types_discounts_3_idx");

                entity.Property(e => e.id_credit_type_discount).HasColumnType("int(10) unsigned");

                entity.Property(e => e.discount).HasColumnType("decimal(4,2) unsigned");

                entity.Property(e => e.due_days).HasColumnType("int(11)");

                entity.Property(e => e.id_category).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_charge_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_configuration_discount).HasColumnType("int(11)");

                entity.Property(e => e.id_credit_type).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_categoryNavigation)
                    .WithMany(p => p.credit_credit_types_discounts)
                    .HasForeignKey(d => d.id_category)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_credit_types_discounts_3");

                entity.HasOne(d => d.id_charge_typeNavigation)
                    .WithMany(p => p.credit_credit_types_discounts)
                    .HasForeignKey(d => d.id_charge_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_credit_types_discounts_2");

                entity.HasOne(d => d.id_credit_typeNavigation)
                    .WithMany(p => p.credit_credit_types_discounts)
                    .HasForeignKey(d => d.id_credit_type)
                    .HasConstraintName("fk_credit_credit_types_discounts_1");
            });

            modelBuilder.Entity<credit_credit_types_increases_decrements>(entity =>
            {
                entity.HasKey(e => e.id_credit_type_increment_decrement)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_credit_type_increment_decrement).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.available).HasColumnType("decimal(4,2) unsigned");

                entity.Property(e => e.discount).HasColumnType("decimal(4,2) unsigned");

                entity.Property(e => e.id_credit_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.months_old).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.periods).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<credit_credits>(entity =>
            {
                entity.HasKey(e => e.id_credit)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_distributor, "fk_credit_credits_1_idx");

                entity.HasIndex(e => e.id_credit_type, "fk_credit_credits_2_idx");

                entity.HasIndex(e => e.id_configuration, "fk_credit_credits_3_idx");

                entity.HasIndex(e => e.id_locking_reason, "fk_credit_credits_4_idx");

                entity.HasIndex(e => e.id_automatic_lock, "fk_credit_credits_5_idx");

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.automatic_increase_decrement)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.current).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.has_insurance_assault)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.has_insurance_death)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.has_thrift).HasColumnType("tinyint(3)");

                entity.Property(e => e.id_automatic_lock).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_configuration).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_credit_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_locking_reason).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_thrift_percentage).HasColumnType("int(11)");

                entity.Property(e => e.initial).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.maximum).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.preauthorized).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.promissory_note).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_automatic_lockNavigation)
                    .WithMany(p => p.credit_credits)
                    .HasForeignKey(d => d.id_automatic_lock)
                    .HasConstraintName("fk_credit_credits_5");

                entity.HasOne(d => d.id_configurationNavigation)
                    .WithMany(p => p.credit_credits)
                    .HasForeignKey(d => d.id_configuration)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_credits_3");

                entity.HasOne(d => d.id_credit_typeNavigation)
                    .WithMany(p => p.credit_credits)
                    .HasForeignKey(d => d.id_credit_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_credits_2");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_credits)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_credits_1");

                entity.HasOne(d => d.id_locking_reasonNavigation)
                    .WithMany(p => p.credit_credits)
                    .HasForeignKey(d => d.id_locking_reason)
                    .HasConstraintName("fk_credit_credits_4");
            });

            modelBuilder.Entity<credit_credits_automatic_locks>(entity =>
            {
                entity.HasKey(e => e.id_credit_automatic_lock)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_credit, "fk_credit_credits_automatic_locks_1_idx");

                entity.HasIndex(e => e.id_automatic_lock, "fk_credit_credits_automatic_locks_2_idx");

                entity.Property(e => e.id_credit_automatic_lock).HasColumnType("int(10) unsigned");

                entity.Property(e => e.balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.due_days).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_automatic_lock).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_automatic_lockNavigation)
                    .WithMany(p => p.credit_credits_automatic_locks)
                    .HasForeignKey(d => d.id_automatic_lock)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_credits_automatic_locks_2");

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.credit_credits_automatic_locks)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_credits_automatic_locks_1");
            });

            modelBuilder.Entity<credit_credits_types>(entity =>
            {
                entity.HasKey(e => e.id_credit_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_credit_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.automatic_increase_decrement)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.experience).HasColumnType("int(10) unsigned");

                entity.Property(e => e.inital).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.minimum_fortnightly).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.minimum_scoring).HasColumnType("int(10) unsigned");

                entity.Property(e => e.minimum_sold).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.promissory_note)
                    .HasColumnType("double(12,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<credit_credits_types_limits>(entity =>
            {
                entity.HasKey(e => e.id_credit_type_limit)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_credit_type, "fk_credit_credits_types_limits_1_idx");

                entity.Property(e => e.id_credit_type_limit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.guarantees).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_credit_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.limit).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.property).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_credit_typeNavigation)
                    .WithMany(p => p.credit_credits_types_limits)
                    .HasForeignKey(d => d.id_credit_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_credits_types_limits_1");
            });

            modelBuilder.Entity<credit_credits_types_logs>(entity =>
            {
                entity.HasKey(e => e.id_credit_type_log)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_credit_type, "fk_credit_credits_types_logs_1_idx");

                entity.HasIndex(e => e.id_user, "fk_credit_credits_types_logs_2_idx");

                entity.Property(e => e.id_credit_type_log).HasColumnType("int(10) unsigned");

                entity.Property(e => e._event)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event");

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.id_credit_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasColumnType("text");

                entity.HasOne(d => d.id_credit_typeNavigation)
                    .WithMany(p => p.credit_credits_types_logs)
                    .HasForeignKey(d => d.id_credit_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_credits_types_logs_1");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.credit_credits_types_logs)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_credits_types_logs_2");
            });

            modelBuilder.Entity<credit_customer_file_types>(entity =>
            {
                entity.HasKey(e => e.id_customer_file_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_customer_file_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.required).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<credit_customers>(entity =>
            {
                entity.HasKey(e => e.id_customer)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_person, "fk_credit_customers_1_idx");

                entity.HasIndex(e => e.id_branch, "index3");

                entity.Property(e => e.id_customer).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_branchNavigation)
                    .WithMany(p => p.credit_customers)
                    .HasForeignKey(d => d.id_branch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_customers_2");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.credit_customers)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_customers_1");

                entity.HasMany(d => d.id_distributor)
                    .WithMany(p => p.id_customer)
                    .UsingEntity<Dictionary<string, object>>(
                        "credit_customers_distributors",
                        l => l.HasOne<credit_distributors>().WithMany().HasForeignKey("id_distributor").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_credit_customers_distributors_2"),
                        r => r.HasOne<credit_customers>().WithMany().HasForeignKey("id_customer").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_credit_customers_distributors_1"),
                        j =>
                        {
                            j.HasKey("id_customer", "id_distributor").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("credit_customers_distributors").HasCharSet("utf8").UseCollation("utf8_general_ci");

                            j.HasIndex(new[] { "id_distributor" }, "fk_credit_customers_distributors_2_idx");

                            j.IndexerProperty<uint>("id_customer").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_distributor").HasColumnType("int(10) unsigned");
                        });
            });

            modelBuilder.Entity<credit_customers_files>(entity =>
            {
                entity.HasKey(e => e.id_customer_file)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_customer, "fk_credit_customers_files_1_idx");

                entity.HasIndex(e => e.id_customer_file_type, "fk_credit_customers_files_2_idx");

                entity.Property(e => e.id_customer_file).HasColumnType("int(10) unsigned");

                entity.Property(e => e.filename).HasColumnType("text");

                entity.Property(e => e.id_customer).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_customer_file_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.mimetype).HasMaxLength(45);

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.size).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.uploaded).HasColumnType("datetime");

                entity.HasOne(d => d.id_customerNavigation)
                    .WithMany(p => p.credit_customers_files)
                    .HasForeignKey(d => d.id_customer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_customers_files_1");

                entity.HasOne(d => d.id_customer_file_typeNavigation)
                    .WithMany(p => p.credit_customers_files)
                    .HasForeignKey(d => d.id_customer_file_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_customers_files_2");
            });

            modelBuilder.Entity<credit_customers_logs>(entity =>
            {
                entity.HasKey(e => e.id_customer_log)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_customer, "fk_credit_customers_logs_1_idx");

                entity.HasIndex(e => e.id_user, "fk_credit_customers_logs_2_idx");

                entity.Property(e => e.id_customer_log).HasColumnType("int(10) unsigned");

                entity.Property(e => e._event)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event");

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.id_customer).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasColumnType("text");

                entity.HasOne(d => d.id_customerNavigation)
                    .WithMany(p => p.credit_customers_logs)
                    .HasForeignKey(d => d.id_customer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_customers_logs_1");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.credit_customers_logs)
                    .HasForeignKey(d => d.id_user)
                    .HasConstraintName("fk_credit_customers_logs_2");
            });

            modelBuilder.Entity<credit_distributors>(entity =>
            {
                entity.HasKey(e => e.id_distributor)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_person, "fk_credit_distributors_1_idx");

                entity.HasIndex(e => e.id_branch, "fk_credit_distributors_2_idx");

                entity.HasIndex(e => e.id_category, "fk_credit_distributors_3_idx");

                entity.HasIndex(e => e.id_application, "fk_credit_distributors_4_idx");

                entity.HasIndex(e => e.number, "ix_number")
                    .IsUnique();

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.auth_phone)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.code).HasMaxLength(200);

                entity.Property(e => e.device_registered).HasMaxLength(45);

                entity.Property(e => e.google_token).HasMaxLength(200);

                entity.Property(e => e.id_application).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_category).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.is_active).HasColumnType("tinyint(4)");

                entity.Property(e => e.number).HasColumnType("int(10) unsigned zerofill");

                entity.Property(e => e.pin).HasColumnType("int(11)");

                entity.Property(e => e.reference).HasMaxLength(100);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.token).HasMaxLength(200);

                entity.HasOne(d => d.id_branchNavigation)
                    .WithMany(p => p.credit_distributors)
                    .HasForeignKey(d => d.id_branch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_distributors_2");

                entity.HasOne(d => d.id_categoryNavigation)
                    .WithMany(p => p.credit_distributors)
                    .HasForeignKey(d => d.id_category)
                    .HasConstraintName("fk_credit_distributors_3");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.credit_distributors)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_distributors_1");
            });

            modelBuilder.Entity<credit_distributors_extra_fields>(entity =>
            {
                entity.HasKey(e => e.id_distributor_extra_field)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_credit, "credit_distributors_extra_fields_credit_credits_FK");

                entity.HasIndex(e => e.id_distributor, "credit_distributors_extra_fields_credit_distributors_FK");

                entity.HasIndex(e => e.id_extra_field, "credit_distributors_extra_fields_origination_extra_fields_FK");

                entity.Property(e => e.id_distributor_extra_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.entity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_extra_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.value).HasMaxLength(45);

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.credit_distributors_extra_fields)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_distributors_extra_fields_credit_credits_FK");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_distributors_extra_fields)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_distributors_extra_fields_credit_distributors_FK");

                entity.HasOne(d => d.id_extra_fieldNavigation)
                    .WithMany(p => p.credit_distributors_extra_fields)
                    .HasForeignKey(d => d.id_extra_field)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_distributors_extra_fields_origination_extra_fields_FK");
            });

            modelBuilder.Entity<credit_distributors_files>(entity =>
            {
                entity.HasKey(e => e.id_distributor_file)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_distributor, "fk_credit_distributors_files_1_idx");

                entity.HasIndex(e => e.id_file_type, "fk_credit_distributors_files_2_idx");

                entity.HasIndex(e => e.id_person, "fk_credit_distributors_files_3_idx");

                entity.Property(e => e.id_distributor_file).HasColumnType("int(10) unsigned");

                entity.Property(e => e.filename).HasColumnType("text");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_file_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.mimetype).HasMaxLength(45);

                entity.Property(e => e.name).HasMaxLength(255);

                entity.Property(e => e.size).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.uploaded).HasColumnType("datetime");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_distributors_files)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_distributors_files_1");

                entity.HasOne(d => d.id_file_typeNavigation)
                    .WithMany(p => p.credit_distributors_files)
                    .HasForeignKey(d => d.id_file_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_distributors_files_2");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.credit_distributors_files)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_distributors_files_3");
            });

            modelBuilder.Entity<credit_distributors_logs>(entity =>
            {
                entity.HasKey(e => e.id_distributor_log)
                    .HasName("PRIMARY");

                entity.HasComment("Bitacora de Eventos del Distribuidor")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_distributor, "fk_credit_distributors_logs_1_idx");

                entity.HasIndex(e => e.id_user, "fk_credit_distributors_logs_2_idx");

                entity.Property(e => e.id_distributor_log)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Identificador de la bitacora");

                entity.Property(e => e._event)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event")
                    .HasComment("Evento");

                entity.Property(e => e.id_distributor)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Identificador del distribuidor");

                entity.Property(e => e.id_user)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Identificador del Usuario");

                entity.Property(e => e.note)
                    .HasMaxLength(1000)
                    .HasComment("Nota del evento");

                entity.Property(e => e.registered)
                    .HasColumnType("datetime")
                    .HasComment("Fecha y Hora del registro");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_distributors_logs)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_distributors_logs_1");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.credit_distributors_logs)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_distributors_logs_2");
            });

            modelBuilder.Entity<credit_distributors_rivalries>(entity =>
            {
                entity.HasKey(e => e.id_distributor_rivalry)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_credit, "credit_distributors_rivalries_credit_credits_FK");

                entity.HasIndex(e => e.id_distributor, "credit_distributors_rivalries_credit_distributors_FK");

                entity.HasIndex(e => e.id_rivalry, "credit_distributors_rivalries_origination_rivalries_FK");

                entity.Property(e => e.id_distributor_rivalry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.antiquity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.credit_line).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_rivalry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.sold).HasPrecision(12, 2);

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.credit_distributors_rivalries)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_distributors_rivalries_credit_credits_FK");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_distributors_rivalries)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_distributors_rivalries_credit_distributors_FK");

                entity.HasOne(d => d.id_rivalryNavigation)
                    .WithMany(p => p.credit_distributors_rivalries)
                    .HasForeignKey(d => d.id_rivalry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_distributors_rivalries_origination_rivalries_FK");
            });

            modelBuilder.Entity<credit_distributors_signatures_logs>(entity =>
            {
                entity.HasKey(e => e.id_signature_log)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_distributor, "fk_credit_distributors_signatures_logs_1_idx");

                entity.HasIndex(e => e.id_user, "fk_credit_distributors_signatures_logs_2_idx");

                entity.Property(e => e.id_signature_log).HasColumnType("int(10)");

                entity.Property(e => e.created).HasColumnType("datetime");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasMaxLength(200);

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_distributors_signatures_logs)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_distributors_signatures_logs_1");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.credit_distributors_signatures_logs)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_distributors_signatures_logs_2");
            });

            modelBuilder.Entity<credit_distributors_thrift>(entity =>
            {
                entity.HasKey(e => e.id_thrift)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_credit, "id_credit");

                entity.Property(e => e.id_thrift).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasPrecision(14, 2);

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.id_credit).HasColumnType("int(11)");

                entity.Property(e => e.id_distributor).HasColumnType("int(11)");

                entity.Property(e => e.id_thrift_configuration).HasColumnType("int(11)");

                entity.Property(e => e.status).HasColumnType("tinyint(3)");
            });

            modelBuilder.Entity<credit_distributors_thrift_configuration>(entity =>
            {
                entity.HasKey(e => e.id_thrift_configuration)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.date, "date_idx");

                entity.HasIndex(e => e.id_credit, "fk_id_credit_idx");

                entity.HasIndex(e => e.id_distributor, "fk_id_distributor_idx");

                entity.HasIndex(e => e.status, "fk_status_idx");

                entity.Property(e => e.id_thrift_configuration).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_credit).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(11)");

                entity.Property(e => e.id_thrift_percentage).HasColumnType("int(11)");

                entity.Property(e => e.status).HasColumnType("tinyint(4)");

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.credit_distributors_thrift_configuration)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_id_credit");
            });

            modelBuilder.Entity<credit_due_days>(entity =>
            {
                entity.HasKey(e => e.id_due_day)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_due_day).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(55);

                entity.Property(e => e.of).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.up).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<credit_economics_activities>(entity =>
            {
                entity.HasKey(e => e.id_economic_activity)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_economic_activity).HasColumnType("int(10) unsigned");

                entity.Property(e => e.antiquity).HasMaxLength(45);

                entity.Property(e => e.apartment_number).HasMaxLength(45);

                entity.Property(e => e.city).HasMaxLength(45);

                entity.Property(e => e.company).HasMaxLength(45);

                entity.Property(e => e.house_number).HasMaxLength(45);

                entity.Property(e => e.neighborhood).HasMaxLength(45);

                entity.Property(e => e.phone).HasMaxLength(10);

                entity.Property(e => e.position).HasMaxLength(45);

                entity.Property(e => e.salary).HasMaxLength(45);

                entity.Property(e => e.settlement).HasMaxLength(45);

                entity.Property(e => e.state).HasMaxLength(45);

                entity.Property(e => e.street).HasMaxLength(45);

                entity.Property(e => e.zipcode).HasMaxLength(5);
            });

            modelBuilder.Entity<credit_expenses>(entity =>
            {
                entity.HasKey(e => e.id_expense)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_distributor, "fk_credit_expenses_1_idx");

                entity.HasIndex(e => e.id_expense_type, "fk_credit_expenses_2_idx");

                entity.Property(e => e.id_expense).HasColumnType("int(11) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_expense_type).HasColumnType("int(11) unsigned");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_expenses)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_expenses_1");

                entity.HasOne(d => d.id_expense_typeNavigation)
                    .WithMany(p => p.credit_expenses)
                    .HasForeignKey(d => d.id_expense_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_expenses_2");
            });

            modelBuilder.Entity<credit_fortnights>(entity =>
            {
                entity.HasKey(e => e.id_fortnight)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_charge_type, "fk_credit_fortnights_1_idx");

                entity.Property(e => e.id_fortnight).HasColumnType("int(10) unsigned");

                entity.Property(e => e.fortnight).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_charge_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_charge_typeNavigation)
                    .WithMany(p => p.credit_fortnights)
                    .HasForeignKey(d => d.id_charge_type)
                    .HasConstraintName("fk_credit_fortnights_1");
            });

            modelBuilder.Entity<credit_guarantees>(entity =>
            {
                entity.HasKey(e => e.id_guarantee)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_person, "fk_credit_guarantees_1_idx");

                entity.HasIndex(e => e.id_distributor, "fk_credit_guarantees_2_idx");

                entity.HasIndex(e => e.id_relationship, "fk_credit_guarantees_3_idx");

                entity.Property(e => e.id_guarantee).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_relationship).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_guarantees)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_guarantees_2");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.credit_guarantees)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_guarantees_1");

                entity.HasOne(d => d.id_relationshipNavigation)
                    .WithMany(p => p.credit_guarantees)
                    .HasForeignKey(d => d.id_relationship)
                    .HasConstraintName("fk_credit_guarantees_3");
            });

            modelBuilder.Entity<credit_holidays>(entity =>
            {
                entity.HasKey(e => e.id_holiday)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.date, "date_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_holiday).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<credit_interests>(entity =>
            {
                entity.HasKey(e => e.id_interest)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_configuration_interest, "credit_interests_credit_configurations_interests_FK");

                entity.HasIndex(e => e.id_fortnight, "fk_credit_interests_1_idx");

                entity.HasIndex(e => e.id_amount, "fk_credit_interests_2_idx");

                entity.HasIndex(e => e.id_charge_type, "fk_credit_interests_3_idx");

                entity.Property(e => e.id_interest).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_amount).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_category).HasColumnType("int(11)");

                entity.Property(e => e.id_charge_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_configuration_interest).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_fortnight).HasColumnType("int(10) unsigned");

                entity.Property(e => e.interest).HasColumnType("decimal(5,2) unsigned");

                entity.HasOne(d => d.id_amountNavigation)
                    .WithMany(p => p.credit_interests)
                    .HasForeignKey(d => d.id_amount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_interests_2");

                entity.HasOne(d => d.id_charge_typeNavigation)
                    .WithMany(p => p.credit_interests)
                    .HasForeignKey(d => d.id_charge_type)
                    .HasConstraintName("fk_credit_interests_3");

                entity.HasOne(d => d.id_configuration_interestNavigation)
                    .WithMany(p => p.credit_interests)
                    .HasForeignKey(d => d.id_configuration_interest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_interests_credit_configurations_interests_FK");

                entity.HasOne(d => d.id_fortnightNavigation)
                    .WithMany(p => p.credit_interests)
                    .HasForeignKey(d => d.id_fortnight)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_interests_1");
            });

            modelBuilder.Entity<credit_locking_reasons>(entity =>
            {
                entity.HasKey(e => e.id_locking_reason)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_locking_reason).HasColumnType("int(10) unsigned");

                entity.Property(e => e.description).HasColumnType("text");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<credit_payment_clearences>(entity =>
            {
                entity.HasKey(e => e.id_payment_clearence)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_credit_payment_clearences_1");

                entity.Property(e => e.id_payment_clearence).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasPrecision(12, 2);

                entity.Property(e => e.creation_date).HasColumnType("datetime");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.credit_payment_clearences)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_payment_clearences_1");
            });

            modelBuilder.Entity<credit_payment_credits_notes_types>(entity =>
            {
                entity.HasKey(e => e.id_payment_credit_note_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_payment_credit_note_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.date).HasColumnType("datetime");

                entity.Property(e => e.name).HasMaxLength(255);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<credit_payments>(entity =>
            {
                entity.HasKey(e => e.id_payment)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_distributor, "fk_credit_payments_1_idx");

                entity.HasIndex(e => e.id_credit, "fk_credit_payments_2_idx");

                entity.HasIndex(e => e.id_customer, "fk_credit_payments_3_idx");

                entity.HasIndex(e => e.id_payment_credit_note_type, "fk_credit_payments_8");

                entity.HasIndex(e => e.id_parent, "index5");

                entity.HasIndex(e => e.id_purchase, "index6");

                entity.HasIndex(e => e.id_receipt, "index7");

                entity.HasIndex(e => e.date, "ix_date");

                entity.HasIndex(e => e.status, "ix_status");

                entity.HasIndex(e => e.subtype, "ix_subtype");

                entity.HasIndex(e => e.type, "ix_type");

                entity.Property(e => e.id_payment).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.cancellation_date).HasColumnType("datetime");

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_customer).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_parent).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_payment_credit_note_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_purchase).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_receipt).HasColumnType("int(10) unsigned");

                entity.Property(e => e.interest).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.principal).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.subtype).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.timestamp).HasColumnType("datetime");

                entity.Property(e => e.type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.credit_payments)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_payments_2");

                entity.HasOne(d => d.id_customerNavigation)
                    .WithMany(p => p.credit_payments)
                    .HasForeignKey(d => d.id_customer)
                    .HasConstraintName("fk_credit_payments_3");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_payments)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_payments_1");

                entity.HasOne(d => d.id_parentNavigation)
                    .WithMany(p => p.Inverseid_parentNavigation)
                    .HasForeignKey(d => d.id_parent)
                    .HasConstraintName("fk_credit_payments_4");

                entity.HasOne(d => d.id_payment_credit_note_typeNavigation)
                    .WithMany(p => p.credit_payments)
                    .HasForeignKey(d => d.id_payment_credit_note_type)
                    .HasConstraintName("fk_credit_payments_8");

                entity.HasOne(d => d.id_purchaseNavigation)
                    .WithMany(p => p.credit_payments)
                    .HasForeignKey(d => d.id_purchase)
                    .HasConstraintName("fk_credit_payments_5");

                entity.HasOne(d => d.id_receiptNavigation)
                    .WithMany(p => p.credit_payments)
                    .HasForeignKey(d => d.id_receipt)
                    .HasConstraintName("fk_credit_payments_6");
            });

            modelBuilder.Entity<credit_payments_entries>(entity =>
            {
                entity.HasKey(e => e.id_payment_entry)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_payment, "fk_credit_payments_entries_1_idx");

                entity.HasIndex(e => e.id_charge, "fk_credit_payments_entries_2_idx");

                entity.HasIndex(e => e.id_purchase, "fk_credit_payments_entries_3_idx");

                entity.Property(e => e.id_payment_entry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.id_charge).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_payment).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_purchase).HasColumnType("int(10) unsigned");

                entity.Property(e => e.interest).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.principal).HasColumnType("decimal(12,2) unsigned");

                entity.HasOne(d => d.id_chargeNavigation)
                    .WithMany(p => p.credit_payments_entries)
                    .HasForeignKey(d => d.id_charge)
                    .HasConstraintName("fk_credit_payments_entries_2");

                entity.HasOne(d => d.id_paymentNavigation)
                    .WithMany(p => p.credit_payments_entries)
                    .HasForeignKey(d => d.id_payment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_payments_entries_1");

                entity.HasOne(d => d.id_purchaseNavigation)
                    .WithMany(p => p.credit_payments_entries)
                    .HasForeignKey(d => d.id_purchase)
                    .HasConstraintName("fk_credit_payments_entries_3");
            });

            modelBuilder.Entity<credit_payments_entries_details>(entity =>
            {
                entity.HasKey(e => e.id_payment_entry_detail)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_purchase_amortization, "fk_credit_payments_entries_details_1_idx");

                entity.HasIndex(e => e.id_payment_entry, "fk_credit_payments_entries_details_2_idx");

                entity.Property(e => e.id_payment_entry_detail).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.id_payment_entry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_purchase_amortization).HasColumnType("int(10) unsigned");

                entity.Property(e => e.interest).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.principal).HasColumnType("decimal(12,2) unsigned");

                entity.HasOne(d => d.id_payment_entryNavigation)
                    .WithMany(p => p.credit_payments_entries_details)
                    .HasForeignKey(d => d.id_payment_entry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_payments_entries_details_2");

                entity.HasOne(d => d.id_purchase_amortizationNavigation)
                    .WithMany(p => p.credit_payments_entries_details)
                    .HasForeignKey(d => d.id_purchase_amortization)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_payments_entries_details_1");
            });

            modelBuilder.Entity<credit_payments_traffic_light>(entity =>
            {
                entity.HasKey(e => e.id_payment_traffic_light)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_distributor, "id_distributor");

                entity.Property(e => e.id_payment_traffic_light).HasColumnType("int(11)");

                entity.Property(e => e.amount_payed).HasPrecision(12, 2);

                entity.Property(e => e.amount_to_pay).HasPrecision(12, 2);

                entity.Property(e => e.due_days).HasColumnType("int(11)");

                entity.Property(e => e.hollidays).HasColumnType("int(11)");

                entity.Property(e => e.id_distributor).HasColumnType("int(11) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.sundays).HasColumnType("int(11)");

                entity.Property(e => e.trending).HasMaxLength(3);

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_payments_traffic_light)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_payments_traffic_light_ibfk_1");
            });

            modelBuilder.Entity<credit_personal_loan_requeriments>(entity =>
            {
                entity.HasKey(e => e.id_personal_requeriment)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_category, "credit_personal_loan_requeriments_credit_categories_FK");

                entity.HasIndex(e => e.id_user, "fk_credit_personal_loan_requeriments_1_idx");

                entity.Property(e => e.id_personal_requeriment).HasColumnType("int(10) unsigned");

                entity.Property(e => e.cutoffs).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.id_category).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.limit_amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.limit_amount_new).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.max_due_day).HasColumnType("int(10) unsigned");

                entity.Property(e => e.max_payment).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.max_placed).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.min_due_day).HasColumnType("int(10) unsigned");

                entity.Property(e => e.min_payment).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.min_placed).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.months).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_categoryNavigation)
                    .WithMany(p => p.credit_personal_loan_requeriments)
                    .HasForeignKey(d => d.id_category)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_personal_loan_requeriments_credit_categories_FK");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.credit_personal_loan_requeriments)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_personal_loan_requeriments_1");
            });

            modelBuilder.Entity<credit_personal_references>(entity =>
            {
                entity.HasKey(e => e.id_personal_reference)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_distributor, "fk_credit_personal_references_1_idx");

                entity.HasIndex(e => e.id_relationship, "fk_credit_personal_references_2_idx");

                entity.HasIndex(e => e.id_person, "fk_credit_personal_references_3_idx");

                entity.Property(e => e.id_personal_reference).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_relationship).HasColumnType("int(10) unsigned");

                entity.Property(e => e.time).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_personal_references)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_personal_references_1");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.credit_personal_references)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_personal_references_3");

                entity.HasOne(d => d.id_relationshipNavigation)
                    .WithMany(p => p.credit_personal_references)
                    .HasForeignKey(d => d.id_relationship)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_personal_references_2");
            });

            modelBuilder.Entity<credit_persons>(entity =>
            {
                entity.HasKey(e => e.id_person)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.curp, "credit_persons_curp_IDX");

                entity.HasIndex(e => e.rfc, "credit_persons_rfc_IDX");

                entity.HasIndex(e => e.id_address, "fk_credit_persons_1_idx");

                entity.HasIndex(e => e.id_economict_activity, "fk_credit_persons_2_idx");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.birthplace).HasColumnType("int(10) unsigned");

                entity.Property(e => e.curp).HasMaxLength(18);

                entity.Property(e => e.email).HasMaxLength(45);

                entity.Property(e => e.face_filename).HasColumnType("text");

                entity.Property(e => e.gender).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.id_address).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_economict_activity).HasColumnType("int(10) unsigned");

                entity.Property(e => e.last_name).HasMaxLength(45);

                entity.Property(e => e.marital_status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.middle_name).HasMaxLength(45);

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.rfc).HasMaxLength(13);

                entity.Property(e => e.second_last_name).HasMaxLength(45);

                entity.HasOne(d => d.id_addressNavigation)
                    .WithMany(p => p.credit_persons)
                    .HasForeignKey(d => d.id_address)
                    .HasConstraintName("fk_credit_persons_1");

                entity.HasOne(d => d.id_economict_activityNavigation)
                    .WithMany(p => p.credit_persons)
                    .HasForeignKey(d => d.id_economict_activity)
                    .HasConstraintName("fk_credit_persons_2");
            });

            modelBuilder.Entity<credit_phones>(entity =>
            {
                entity.HasKey(e => e.id_phone)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_phone_type, "fk_credit_phones_1_idx");

                entity.HasIndex(e => e.id_person, "fk_credit_phones_2_idx");

                entity.Property(e => e.id_phone).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_phone_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.number).HasMaxLength(10);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.credit_phones)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_phones_2");

                entity.HasOne(d => d.id_phone_typeNavigation)
                    .WithMany(p => p.credit_phones)
                    .HasForeignKey(d => d.id_phone_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_phones_1");
            });

            modelBuilder.Entity<credit_printables>(entity =>
            {
                entity.HasKey(e => e.id_printable)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_distributor, "fk_origination_printables_2_idx");

                entity.HasIndex(e => e.id_credit, "fk_origination_printables_3_idx");

                entity.HasIndex(e => e.id_configuration_printable, "fk_origination_printables_4_idx");

                entity.Property(e => e.id_printable).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.filename).HasMaxLength(500);

                entity.Property(e => e.id_configuration_printable).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(150);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.upload_date).HasColumnType("datetime");

                entity.HasOne(d => d.id_configuration_printableNavigation)
                    .WithMany(p => p.credit_printables)
                    .HasForeignKey(d => d.id_configuration_printable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_printables_4");

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.credit_printables)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_printables_3");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_printables)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_printables_2");
            });

            modelBuilder.Entity<credit_printables_logs>(entity =>
            {
                entity.HasKey(e => e.id_printable_log)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_printable, "fk_credit_printables_logs_1_idx");

                entity.HasIndex(e => e.id_user, "fk_credit_printables_logs_2_idx");

                entity.Property(e => e.id_printable_log).HasColumnType("int(10) unsigned");

                entity.Property(e => e._event)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event");

                entity.Property(e => e.id_printable).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasMaxLength(200);

                entity.Property(e => e.registered).HasColumnType("datetime");

                entity.HasOne(d => d.id_printableNavigation)
                    .WithMany(p => p.credit_printables_logs)
                    .HasForeignKey(d => d.id_printable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_printables_logs_1");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.credit_printables_logs)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_printables_logs_2");
            });

            modelBuilder.Entity<credit_product_brands>(entity =>
            {
                entity.HasKey(e => e.id_product_brand)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_product_brand).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<credit_product_types>(entity =>
            {
                entity.HasKey(e => e.id_product_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_product_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<credit_products>(entity =>
            {
                entity.HasKey(e => e.id_product)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_product).HasColumnType("int(10) unsigned");

                entity.Property(e => e.delivery_date).HasColumnType("datetime");

                entity.Property(e => e.id_box).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_collaborator).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(11)");

                entity.Property(e => e.id_payment).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_product_brand).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_product_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.job_name).HasMaxLength(200);

                entity.Property(e => e.model).HasMaxLength(200);

                entity.Property(e => e.name).HasMaxLength(200);

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<credit_promissory_notes>(entity =>
            {
                entity.HasKey(e => e.id_promissory_note)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_distributor, "fk_credit_promissory_notes_1_idx");

                entity.HasIndex(e => e.id_credit, "fk_credit_promissory_notes_2_idx");

                entity.Property(e => e.id_promissory_note).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.filename).HasMaxLength(500);

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(150);

                entity.Property(e => e.released_date).HasColumnType("datetime");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.upload_date).HasColumnType("datetime");

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.credit_promissory_notes)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_promissory_notes_2");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_promissory_notes)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_promissory_notes_1");
            });

            modelBuilder.Entity<credit_properties>(entity =>
            {
                entity.HasKey(e => e.id_property)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_distributor, "fk_credit_properties_1_idx");

                entity.HasIndex(e => e.id_property_type, "fk_credit_properties_2_idx");

                entity.Property(e => e.id_property).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.apartment_number).HasMaxLength(45);

                entity.Property(e => e.city).HasMaxLength(45);

                entity.Property(e => e.description).HasColumnType("text");

                entity.Property(e => e.house_number).HasMaxLength(45);

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_property_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.neighborhood).HasMaxLength(45);

                entity.Property(e => e.settlement).HasMaxLength(45);

                entity.Property(e => e.state).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.street).HasMaxLength(45);

                entity.Property(e => e.type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.zipcode).HasMaxLength(45);

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_properties)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_properties_1");

                entity.HasOne(d => d.id_property_typeNavigation)
                    .WithMany(p => p.credit_properties)
                    .HasForeignKey(d => d.id_property_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_properties_2");
            });

            modelBuilder.Entity<credit_protections_requests>(entity =>
            {
                entity.HasKey(e => e.id_protection_request)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_beneficiary, "credit_protections_requests_ibfk_8");

                entity.HasIndex(e => e.id_authorized, "id_authorized");

                entity.HasIndex(e => e.id_cancelled, "id_cancelled");

                entity.HasIndex(e => e.id_coupon, "id_coupon");

                entity.HasIndex(e => e.id_credit, "id_credit");

                entity.HasIndex(e => e.id_delivered, "id_delivered");

                entity.HasIndex(e => e.id_distributor, "id_distributor");

                entity.HasIndex(e => e.id_protection_request_type, "id_protection_request_type");

                entity.HasIndex(e => e.id_purchase, "id_purchase");

                entity.HasIndex(e => e.id_requested, "id_requested");

                entity.HasIndex(e => e.id_validated, "id_validated");

                entity.Property(e => e.id_protection_request).HasColumnType("int(11) unsigned");

                entity.Property(e => e.amount).HasPrecision(12, 2);

                entity.Property(e => e.amount_discount).HasPrecision(12, 2);

                entity.Property(e => e.assault_date).HasColumnType("datetime");

                entity.Property(e => e.authorize_date).HasColumnType("datetime");

                entity.Property(e => e.beneficiary_interest).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.cancel_date).HasColumnType("datetime");

                entity.Property(e => e.car_accident).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.claim_option).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.covered_payments).HasColumnType("int(11) unsigned");

                entity.Property(e => e.death_cause).HasMaxLength(40);

                entity.Property(e => e.death_certificate_number).HasMaxLength(12);

                entity.Property(e => e.death_type).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.delivery_date).HasColumnType("datetime");

                entity.Property(e => e.derivated_death).HasMaxLength(40);

                entity.Property(e => e.distributor_payment_amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.forgiven_credit).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.has_covid).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.has_insurance).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.hospital_admission_date).HasColumnType("datetime");

                entity.Property(e => e.hospital_discharge_date).HasColumnType("datetime");

                entity.Property(e => e.hospitalization_days).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_authorized).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_beneficiary).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_cancelled).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_coupon).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_credit).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_customer).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_delivered).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_protection_request_type).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_purchase).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_requested).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_validated).HasColumnType("int(11) unsigned");

                entity.Property(e => e.insured_familiar).HasMaxLength(200);

                entity.Property(e => e.note).HasMaxLength(1000);

                entity.Property(e => e.payment_amount).HasPrecision(12, 2);

                entity.Property(e => e.payments_to_forgive).HasColumnType("int(11) unsigned");

                entity.Property(e => e.previous_status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.request_date).HasColumnType("datetime");

                entity.Property(e => e.status).HasColumnType("tinyint(3)");

                entity.Property(e => e.validate_date).HasColumnType("datetime");
            });

            modelBuilder.Entity<credit_protections_requests_alerts>(entity =>
            {
                entity.HasKey(e => e.id_protection_request_alert)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_protection_request, "fk_credit_protections_requests_alerts_1_idx");

                entity.HasIndex(e => e.id_user, "fk_credit_protections_requests_alerts_2_idx");

                entity.Property(e => e.id_protection_request_alert).HasColumnType("int(10) unsigned");

                entity.Property(e => e.alert).HasColumnType("mediumtext");

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.id_protection_request).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.reject).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_protection_requestNavigation)
                    .WithMany(p => p.credit_protections_requests_alerts)
                    .HasForeignKey(d => d.id_protection_request)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_protections_requests_alerts_1");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.credit_protections_requests_alerts)
                    .HasForeignKey(d => d.id_user)
                    .HasConstraintName("fk_credit_protections_requests_alerts_2");
            });

            modelBuilder.Entity<credit_protections_requests_files>(entity =>
            {
                entity.HasKey(e => e.id_protection_request_file)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_protection_request_file_type, "credit_protections_requests_files_1");

                entity.HasIndex(e => e.id_protection_request, "credit_protections_requests_files_2");

                entity.Property(e => e.id_protection_request_file).HasColumnType("int(11) unsigned");

                entity.Property(e => e.comment).HasColumnType("text");

                entity.Property(e => e.filename).HasColumnType("text");

                entity.Property(e => e.id_protection_request).HasColumnType("int(11) unsigned");

                entity.Property(e => e.id_protection_request_file_type).HasColumnType("int(11) unsigned");

                entity.Property(e => e.mimetype).HasMaxLength(45);

                entity.Property(e => e.name).HasMaxLength(255);

                entity.Property(e => e.size).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.uploaded).HasColumnType("datetime");

                entity.HasOne(d => d.id_protection_requestNavigation)
                    .WithMany(p => p.credit_protections_requests_files)
                    .HasForeignKey(d => d.id_protection_request)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_protections_requests_files_2");

                entity.HasOne(d => d.id_protection_request_file_typeNavigation)
                    .WithMany(p => p.credit_protections_requests_files)
                    .HasForeignKey(d => d.id_protection_request_file_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_protections_requests_files_1");
            });

            modelBuilder.Entity<credit_protections_requests_files_types>(entity =>
            {
                entity.HasKey(e => e.id_protection_request_file_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_protection_request_file_type).HasColumnType("int(11) unsigned");

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.required).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<credit_protections_requests_types>(entity =>
            {
                entity.HasKey(e => e.id_protection_request_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_protection_request_type).HasColumnType("int(11) unsigned");

                entity.Property(e => e.name).HasMaxLength(150);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasMany(d => d.id_protection_request_file_type)
                    .WithMany(p => p.id_protection_request_type)
                    .UsingEntity<Dictionary<string, object>>(
                        "credit_protections_requests_types_files",
                        l => l.HasOne<credit_protections_requests_files_types>().WithMany().HasForeignKey("id_protection_request_file_type").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("credit_protections_requests_types_files_ibfk_2"),
                        r => r.HasOne<credit_protections_requests_types>().WithMany().HasForeignKey("id_protection_request_type").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("credit_protections_requests_types_files_ibfk_1"),
                        j =>
                        {
                            j.HasKey("id_protection_request_type", "id_protection_request_file_type").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("credit_protections_requests_types_files").HasCharSet("latin1").UseCollation("latin1_swedish_ci");

                            j.HasIndex(new[] { "id_protection_request_file_type" }, "id_protection_request_file_type");

                            j.IndexerProperty<uint>("id_protection_request_type").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_protection_request_file_type").HasColumnType("int(11) unsigned");
                        });
            });

            modelBuilder.Entity<credit_puchases>(entity =>
            {
                entity.HasKey(e => e.id_purchase)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_distributor, "fk_credit_puchases_1_idx");

                entity.HasIndex(e => e.id_credit, "fk_credit_puchases_2_idx");

                entity.HasIndex(e => e.id_customer, "fk_credit_puchases_3_idx");

                entity.HasIndex(e => e.id_charge_type, "fk_credit_puchases_4_idx");

                entity.HasIndex(e => e.id_coupon, "fk_credit_puchases_5_idx");

                entity.HasIndex(e => e.id_parent, "fk_credit_puchases_8_idx");

                entity.HasIndex(e => e.status, "index10");

                entity.HasIndex(e => e.dispersion_date, "index12");

                entity.HasIndex(e => e.id_zone, "index7");

                entity.HasIndex(e => e.id_branch, "index8");

                entity.HasIndex(e => e.date, "ix_date");

                entity.Property(e => e.id_purchase).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.cancellation_note).HasColumnType("text");

                entity.Property(e => e.fortnights).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_charge_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_coupon).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_customer).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_parent).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_zone).HasColumnType("int(10) unsigned");

                entity.Property(e => e.insurance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.interest).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.is_paid)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.is_renovation)
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.registered).HasColumnType("datetime");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_branchNavigation)
                    .WithMany(p => p.credit_puchases)
                    .HasForeignKey(d => d.id_branch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_puchases_7");

                entity.HasOne(d => d.id_charge_typeNavigation)
                    .WithMany(p => p.credit_puchases)
                    .HasForeignKey(d => d.id_charge_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_puchases_4");

                entity.HasOne(d => d.id_couponNavigation)
                    .WithMany(p => p.credit_puchases)
                    .HasForeignKey(d => d.id_coupon)
                    .HasConstraintName("fk_credit_puchases_5");

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.credit_puchases)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_puchases_2");

                entity.HasOne(d => d.id_customerNavigation)
                    .WithMany(p => p.credit_puchases)
                    .HasForeignKey(d => d.id_customer)
                    .HasConstraintName("fk_credit_puchases_3");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_puchases)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_puchases_1");

                entity.HasOne(d => d.id_parentNavigation)
                    .WithMany(p => p.Inverseid_parentNavigation)
                    .HasForeignKey(d => d.id_parent)
                    .HasConstraintName("fk_credit_puchases_8");

                entity.HasOne(d => d.id_zoneNavigation)
                    .WithMany(p => p.credit_puchases)
                    .HasForeignKey(d => d.id_zone)
                    .HasConstraintName("fk_credit_puchases_6");
            });

            modelBuilder.Entity<credit_purchases_amortizations>(entity =>
            {
                entity.HasKey(e => e.id_purchase_amortization)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_purchase, "fk_credit_purchases_amortizations_1_idx");

                entity.Property(e => e.id_purchase_amortization).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.id_purchase).HasColumnType("int(10) unsigned");

                entity.Property(e => e.insurance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.interest).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.number).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_purchaseNavigation)
                    .WithMany(p => p.credit_purchases_amortizations)
                    .HasForeignKey(d => d.id_purchase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_purchases_amortizations_1");
            });

            modelBuilder.Entity<credit_purchases_beneficiaries>(entity =>
            {
                entity.HasKey(e => e.id_purchase_beneficiary)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_purchase, "fk_credit_purchases_beneficiaries_1_idx");

                entity.HasIndex(e => e.id_beneficiary, "fk_credit_purchases_beneficiaries_2_idx");

                entity.Property(e => e.id_purchase_beneficiary).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_beneficiary).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_purchase).HasColumnType("int(10) unsigned");

                entity.Property(e => e.percentage).HasColumnType("decimal(5,2) unsigned");

                entity.Property(e => e.register_date).HasColumnType("datetime");

                entity.HasOne(d => d.id_beneficiaryNavigation)
                    .WithMany(p => p.credit_purchases_beneficiaries)
                    .HasForeignKey(d => d.id_beneficiary)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_purchases_beneficiaries_2");

                entity.HasOne(d => d.id_purchaseNavigation)
                    .WithMany(p => p.credit_purchases_beneficiaries)
                    .HasForeignKey(d => d.id_purchase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_purchases_beneficiaries_1");
            });

            modelBuilder.Entity<credit_purchases_logs>(entity =>
            {
                entity.HasKey(e => e.id_purchase_log)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_credit_purchases_logs_1_idx");

                entity.HasIndex(e => e.id_purchase, "fk_credit_purchases_logs_2_idx");

                entity.Property(e => e.id_purchase_log).HasColumnType("int(10) unsigned");

                entity.Property(e => e._event)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event");

                entity.Property(e => e.created).HasColumnType("datetime");

                entity.Property(e => e.id_purchase).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasMaxLength(200);

                entity.HasOne(d => d.id_purchaseNavigation)
                    .WithMany(p => p.credit_purchases_logs)
                    .HasForeignKey(d => d.id_purchase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_purchases_logs_2");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.credit_purchases_logs)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_purchases_logs_1");
            });

            modelBuilder.Entity<credit_references>(entity =>
            {
                entity.HasKey(e => e.id_reference)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_reference).HasColumnType("int(11)");

                entity.Property(e => e.fullname).HasMaxLength(80);

                entity.Property(e => e.id_person).HasColumnType("int(11)");

                entity.Property(e => e.phone).HasMaxLength(10);

                entity.Property(e => e.relationship).HasMaxLength(80);
            });

            modelBuilder.Entity<credit_requests>(entity =>
            {
                entity.HasKey(e => e.id_request)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_request_type, "fk_credit_requests_10_idx");

                entity.HasIndex(e => e.id_coupon, "fk_credit_requests_11_idx");

                entity.HasIndex(e => e.id_payment_credit_note_type, "fk_credit_requests_12");

                entity.HasIndex(e => e.id_customer, "fk_credit_requests_13");

                entity.HasIndex(e => e.id_distributor, "fk_credit_requests_1_idx");

                entity.HasIndex(e => e.id_credit, "fk_credit_requests_2_idx");

                entity.HasIndex(e => e.id_requested, "fk_credit_requests_3_idx");

                entity.HasIndex(e => e.id_authorized, "fk_credit_requests_3_idx1");

                entity.HasIndex(e => e.id_validated, "fk_credit_requests_4_idx");

                entity.HasIndex(e => e.id_purchase, "fk_credit_requests_6_idx");

                entity.HasIndex(e => e.id_charge, "fk_credit_requests_7_idx");

                entity.HasIndex(e => e.id_cancellation_reason, "fk_credit_requests_8_idx");

                entity.HasIndex(e => e.id_cancelled, "fk_credit_requests_9_idx");

                entity.Property(e => e.id_request).HasColumnType("int(10) unsigned");

                entity.Property(e => e.current_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.days).HasColumnType("int(10) unsigned");

                entity.Property(e => e.due_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.fortnights).HasColumnType("int(10) unsigned");

                entity.Property(e => e.has_covid_insurance).HasColumnType("tinyint(3)");

                entity.Property(e => e.has_insurance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.id_authorized).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_cancellation_reason).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_cancelled).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_charge).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_coupon).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_credit).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_customer).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_payment_credit_note_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_purchase).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_request_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_requested).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_validated).HasColumnType("int(10) unsigned");

                entity.Property(e => e.interest).HasPrecision(12, 2);

                entity.Property(e => e.last_purchase_amortization_charge).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.limit).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.note).HasColumnType("text");

                entity.Property(e => e.payable_balance).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.percent).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.to).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.total_balance).HasPrecision(12, 2);

                entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_authorizedNavigation)
                    .WithMany(p => p.credit_requestsid_authorizedNavigation)
                    .HasForeignKey(d => d.id_authorized)
                    .HasConstraintName("fk_credit_requests_3");

                entity.HasOne(d => d.id_cancellation_reasonNavigation)
                    .WithMany(p => p.credit_requests)
                    .HasForeignKey(d => d.id_cancellation_reason)
                    .HasConstraintName("fk_credit_requests_8");

                entity.HasOne(d => d.id_cancelledNavigation)
                    .WithMany(p => p.credit_requestsid_cancelledNavigation)
                    .HasForeignKey(d => d.id_cancelled)
                    .HasConstraintName("fk_credit_requests_9");

                entity.HasOne(d => d.id_chargeNavigation)
                    .WithMany(p => p.credit_requests)
                    .HasForeignKey(d => d.id_charge)
                    .HasConstraintName("fk_credit_requests_7");

                entity.HasOne(d => d.id_couponNavigation)
                    .WithMany(p => p.credit_requests)
                    .HasForeignKey(d => d.id_coupon)
                    .HasConstraintName("fk_credit_requests_11");

                entity.HasOne(d => d.id_creditNavigation)
                    .WithMany(p => p.credit_requests)
                    .HasForeignKey(d => d.id_credit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_requests_2");

                entity.HasOne(d => d.id_customerNavigation)
                    .WithMany(p => p.credit_requests)
                    .HasForeignKey(d => d.id_customer)
                    .HasConstraintName("fk_credit_requests_13");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_requests)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_requests_1");

                entity.HasOne(d => d.id_payment_credit_note_typeNavigation)
                    .WithMany(p => p.credit_requests)
                    .HasForeignKey(d => d.id_payment_credit_note_type)
                    .HasConstraintName("fk_credit_requests_12");

                entity.HasOne(d => d.id_purchaseNavigation)
                    .WithMany(p => p.credit_requests)
                    .HasForeignKey(d => d.id_purchase)
                    .HasConstraintName("fk_credit_requests_6");

                entity.HasOne(d => d.id_request_typeNavigation)
                    .WithMany(p => p.credit_requests)
                    .HasForeignKey(d => d.id_request_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_requests_10");

                entity.HasOne(d => d.id_requestedNavigation)
                    .WithMany(p => p.credit_requestsid_requestedNavigation)
                    .HasForeignKey(d => d.id_requested)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_requests_5");

                entity.HasOne(d => d.id_validatedNavigation)
                    .WithMany(p => p.credit_requestsid_validatedNavigation)
                    .HasForeignKey(d => d.id_validated)
                    .HasConstraintName("fk_credit_requests_4");
            });

            modelBuilder.Entity<credit_requests_files>(entity =>
            {
                entity.HasKey(e => e.id_request_file)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_request, "fk_credit_requests_files_1_idx");

                entity.Property(e => e.id_request_file).HasColumnType("int(10) unsigned");

                entity.Property(e => e.filename).HasColumnType("text");

                entity.Property(e => e.id_request).HasColumnType("int(10) unsigned");

                entity.Property(e => e.mimetype).HasMaxLength(45);

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.size).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.uploaded).HasColumnType("datetime");

                entity.HasOne(d => d.id_requestNavigation)
                    .WithMany(p => p.credit_requests_files)
                    .HasForeignKey(d => d.id_request)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_requests_files_1");
            });

            modelBuilder.Entity<credit_requests_types>(entity =>
            {
                entity.HasKey(e => e.id_request_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_request_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasMany(d => d.id_role)
                    .WithMany(p => p.id_request_type)
                    .UsingEntity<Dictionary<string, object>>(
                        "credit_requests_types_roles",
                        l => l.HasOne<core_roles>().WithMany().HasForeignKey("id_role").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("credit_requests_types_roles_core_roles_FK"),
                        r => r.HasOne<credit_requests_types>().WithMany().HasForeignKey("id_request_type").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("credit_requests_types_roles_credit_requests_types_FK"),
                        j =>
                        {
                            j.HasKey("id_request_type", "id_role").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("credit_requests_types_roles").HasCharSet("utf8").UseCollation("utf8_general_ci");

                            j.HasIndex(new[] { "id_role" }, "credit_requests_types_roles_core_roles_FK");

                            j.IndexerProperty<uint>("id_request_type").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_role").HasColumnType("int(10) unsigned");
                        });
            });

            modelBuilder.Entity<credit_spouses>(entity =>
            {
                entity.HasKey(e => e.id_spouse)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_distributor, "credit_spouses_credit_distributors_FK");

                entity.HasIndex(e => e.id_person, "credit_spouses_credit_persons_FK");

                entity.HasIndex(e => e.id_relationship, "credit_spouses_origination_relationships_FK");

                entity.Property(e => e.id_spouse).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_relationship).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.credit_spouses)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_spouses_credit_distributors_FK");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.credit_spouses)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_spouses_credit_persons_FK");

                entity.HasOne(d => d.id_relationshipNavigation)
                    .WithMany(p => p.credit_spouses)
                    .HasForeignKey(d => d.id_relationship)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("credit_spouses_origination_relationships_FK");
            });

            modelBuilder.Entity<credit_supervisors>(entity =>
            {
                entity.HasKey(e => e.id_supervisor)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_user, "fk_credit_supervisors_1_idx");

                entity.Property(e => e.id_supervisor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.credit_supervisors)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_credit_supervisors_1");
            });

            modelBuilder.Entity<credit_thrift_percentages>(entity =>
            {
                entity.HasKey(e => e.id_thrift_percentage)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_thrift_percentage).HasColumnType("int(11)");

                entity.Property(e => e.annual_percent).HasColumnType("double(4,2)");

                entity.Property(e => e.name).HasMaxLength(40);

                entity.Property(e => e.percentage).HasColumnType("double(4,2)");

                entity.Property(e => e.status).HasColumnType("tinyint(3)");
            });

            modelBuilder.Entity<data_predict_afiliation>(entity =>
            {
                entity.Property(e => e.id).HasColumnType("int(11)");

                entity.Property(e => e.date)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.id_application).HasColumnType("int(10)");

                entity.Property(e => e.id_distributor).HasColumnType("int(10)");

                entity.Property(e => e.risk).HasMaxLength(20);
            });

            modelBuilder.Entity<load_balances>(entity =>
            {
                entity.HasKey(e => e.id_balance)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_balance).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasMaxLength(45);

                entity.Property(e => e.date).HasMaxLength(45);

                entity.Property(e => e.due_date).HasMaxLength(45);

                entity.Property(e => e.id_charge_type).HasMaxLength(45);

                entity.Property(e => e.id_distributor).HasMaxLength(45);
            });

            modelBuilder.Entity<load_coupons>(entity =>
            {
                entity.HasKey(e => e.id_coupon)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.num_coupon, "index2");

                entity.Property(e => e.id_coupon).HasColumnType("int(10) unsigned");

                entity.Property(e => e.emission).HasMaxLength(45);

                entity.Property(e => e.expiration).HasMaxLength(45);

                entity.Property(e => e.id_distributor).HasMaxLength(45);

                entity.Property(e => e.num_coupon).HasMaxLength(45);

                entity.Property(e => e.parent).HasMaxLength(45);
            });

            modelBuilder.Entity<load_credits>(entity =>
            {
                entity.HasKey(e => e.id_distributor)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_distributor)
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.authorized).HasMaxLength(45);

                entity.Property(e => e.current).HasMaxLength(45);

                entity.Property(e => e.id_configuration).HasMaxLength(45);

                entity.Property(e => e.id_credit_type).HasMaxLength(45);

                entity.Property(e => e.initial).HasMaxLength(45);

                entity.Property(e => e.maximum).HasMaxLength(45);

                entity.Property(e => e.preauthorized).HasMaxLength(45);

                entity.Property(e => e.promisory_note).HasMaxLength(45);
            });

            modelBuilder.Entity<load_customers>(entity =>
            {
                entity.HasKey(e => e.id_customer)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_customer)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.apartment_number).HasMaxLength(45);

                entity.Property(e => e.birthdate).HasMaxLength(45);

                entity.Property(e => e.city).HasMaxLength(45);

                entity.Property(e => e.curp).HasMaxLength(45);

                entity.Property(e => e.economic_apartment_number).HasMaxLength(200);

                entity.Property(e => e.economic_city).HasMaxLength(200);

                entity.Property(e => e.economic_company).HasMaxLength(200);

                entity.Property(e => e.economic_department).HasMaxLength(200);

                entity.Property(e => e.economic_hired_date).HasMaxLength(200);

                entity.Property(e => e.economic_house_number).HasMaxLength(200);

                entity.Property(e => e.economic_id_economic_activity_type).HasMaxLength(200);

                entity.Property(e => e.economic_id_line_business).HasMaxLength(200);

                entity.Property(e => e.economic_income).HasMaxLength(200);

                entity.Property(e => e.economic_neighborhood).HasMaxLength(200);

                entity.Property(e => e.economic_phone_number).HasMaxLength(200);

                entity.Property(e => e.economic_phone_type).HasMaxLength(200);

                entity.Property(e => e.economic_position).HasMaxLength(200);

                entity.Property(e => e.economic_settlement).HasMaxLength(200);

                entity.Property(e => e.economic_sindicate).HasMaxLength(200);

                entity.Property(e => e.economic_state).HasMaxLength(200);

                entity.Property(e => e.economic_street).HasMaxLength(200);

                entity.Property(e => e.economic_zipcode).HasMaxLength(200);

                entity.Property(e => e.email).HasMaxLength(45);

                entity.Property(e => e.gender).HasMaxLength(45);

                entity.Property(e => e.house_number).HasMaxLength(45);

                entity.Property(e => e.last_name).HasMaxLength(45);

                entity.Property(e => e.marital_status).HasMaxLength(45);

                entity.Property(e => e.middle_name).HasMaxLength(45);

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.neighborhood).HasMaxLength(45);

                entity.Property(e => e.phone).HasMaxLength(45);

                entity.Property(e => e.rfc).HasMaxLength(45);

                entity.Property(e => e.second_last_name).HasMaxLength(45);

                entity.Property(e => e.settlement).HasMaxLength(45);

                entity.Property(e => e.state).HasMaxLength(45);

                entity.Property(e => e.street).HasMaxLength(45);

                entity.Property(e => e.zipcode).HasMaxLength(45);
            });

            modelBuilder.Entity<load_distributors>(entity =>
            {
                entity.HasKey(e => e.id_distributor)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_distributor)
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.apartment_number).HasMaxLength(45);

                entity.Property(e => e.city).HasMaxLength(45);

                entity.Property(e => e.curp).HasMaxLength(45);

                entity.Property(e => e.economic_apartment_number).HasMaxLength(200);

                entity.Property(e => e.economic_city).HasMaxLength(200);

                entity.Property(e => e.economic_company).HasMaxLength(200);

                entity.Property(e => e.economic_department).HasMaxLength(200);

                entity.Property(e => e.economic_hired_date).HasMaxLength(200);

                entity.Property(e => e.economic_house_number).HasMaxLength(200);

                entity.Property(e => e.economic_id_economic_activity_type).HasMaxLength(200);

                entity.Property(e => e.economic_id_line_business).HasMaxLength(200);

                entity.Property(e => e.economic_income).HasMaxLength(200);

                entity.Property(e => e.economic_neighborhood).HasMaxLength(200);

                entity.Property(e => e.economic_phone_number).HasMaxLength(200);

                entity.Property(e => e.economic_phone_type).HasMaxLength(200);

                entity.Property(e => e.economic_position).HasMaxLength(200);

                entity.Property(e => e.economic_settlement).HasMaxLength(200);

                entity.Property(e => e.economic_sindicate).HasMaxLength(200);

                entity.Property(e => e.economic_state).HasMaxLength(200);

                entity.Property(e => e.economic_street).HasMaxLength(200);

                entity.Property(e => e.economic_zipcode).HasMaxLength(200);

                entity.Property(e => e.gender).HasColumnType("tinyint(4)");

                entity.Property(e => e.guarantee_apartment_number).HasMaxLength(200);

                entity.Property(e => e.guarantee_birthdate).HasMaxLength(200);

                entity.Property(e => e.guarantee_city).HasMaxLength(200);

                entity.Property(e => e.guarantee_curp).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_apartment_number).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_city).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_company).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_department).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_hire_date).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_house_number).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_id_economic_activity).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_id_line_business).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_income).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_neighborhood).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_phone_number).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_phone_type).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_position).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_property_name).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_property_type).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_property_value).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_settlement).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_sindicate).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_state).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_street).HasMaxLength(200);

                entity.Property(e => e.guarantee_economic_zipcode).HasMaxLength(200);

                entity.Property(e => e.guarantee_gender).HasMaxLength(200);

                entity.Property(e => e.guarantee_house_number).HasMaxLength(200);

                entity.Property(e => e.guarantee_last_name).HasMaxLength(200);

                entity.Property(e => e.guarantee_marital_status).HasMaxLength(200);

                entity.Property(e => e.guarantee_middle_name).HasMaxLength(200);

                entity.Property(e => e.guarantee_name).HasMaxLength(200);

                entity.Property(e => e.guarantee_neighborhood).HasMaxLength(200);

                entity.Property(e => e.guarantee_phone_number).HasMaxLength(200);

                entity.Property(e => e.guarantee_phone_type).HasMaxLength(200);

                entity.Property(e => e.guarantee_rfc).HasMaxLength(200);

                entity.Property(e => e.guarantee_second_last_name).HasMaxLength(200);

                entity.Property(e => e.guarantee_settlement).HasMaxLength(200);

                entity.Property(e => e.guarantee_state).HasMaxLength(200);

                entity.Property(e => e.guarantee_street).HasMaxLength(200);

                entity.Property(e => e.guarantee_zipcode).HasMaxLength(200);

                entity.Property(e => e.house_number).HasMaxLength(45);

                entity.Property(e => e.id_branch).HasColumnType("int(11)");

                entity.Property(e => e.last_name).HasMaxLength(45);

                entity.Property(e => e.marital_status).HasColumnType("tinyint(4)");

                entity.Property(e => e.middle_name).HasMaxLength(45);

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.neighborhood).HasMaxLength(45);

                entity.Property(e => e.phone).HasMaxLength(45);

                entity.Property(e => e.rfc).HasMaxLength(45);

                entity.Property(e => e.second_last_name).HasMaxLength(45);

                entity.Property(e => e.settlement).HasMaxLength(45);

                entity.Property(e => e.state).HasMaxLength(45);

                entity.Property(e => e.street).HasMaxLength(45);

                entity.Property(e => e.zipcode).HasMaxLength(45);
            });

            modelBuilder.Entity<load_due_balances>(entity =>
            {
                entity.HasKey(e => e.id_due_balance)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_due_balance).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasMaxLength(45);

                entity.Property(e => e.date).HasMaxLength(45);

                entity.Property(e => e.due_date).HasMaxLength(45);

                entity.Property(e => e.id_charge_type).HasMaxLength(45);

                entity.Property(e => e.id_distributor).HasMaxLength(45);

                entity.Property(e => e.interest).HasMaxLength(45);
            });

            modelBuilder.Entity<load_errors>(entity =>
            {
                entity.HasKey(e => e.id_error)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_error).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id).HasMaxLength(45);

                entity.Property(e => e.line).HasColumnType("int(11)");

                entity.Property(e => e.message).HasMaxLength(45);

                entity.Property(e => e.section).HasColumnType("tinyint(4)");

                entity.Property(e => e.value).HasMaxLength(45);
            });

            modelBuilder.Entity<load_payments>(entity =>
            {
                entity.HasKey(e => e.id_payment)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_payment).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasMaxLength(45);

                entity.Property(e => e.date).HasMaxLength(45);

                entity.Property(e => e.id_distributor).HasMaxLength(45);
            });

            modelBuilder.Entity<load_purchases>(entity =>
            {
                entity.HasKey(e => e.id_purchase)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_coupon, "index2");

                entity.HasIndex(e => e.id_customer, "index3");

                entity.Property(e => e.id_purchase).HasColumnType("int(10) unsigned");

                entity.Property(e => e.date).HasMaxLength(45);

                entity.Property(e => e.first_due_date).HasMaxLength(45);

                entity.Property(e => e.fortnights).HasMaxLength(45);

                entity.Property(e => e.id_branch).HasMaxLength(45);

                entity.Property(e => e.id_charge_type).HasMaxLength(45);

                entity.Property(e => e.id_coupon).HasMaxLength(45);

                entity.Property(e => e.id_customer).HasMaxLength(45);

                entity.Property(e => e.id_distributor).HasMaxLength(45);

                entity.Property(e => e.id_store).HasMaxLength(45);

                entity.Property(e => e.insurance).HasMaxLength(45);

                entity.Property(e => e.interest).HasMaxLength(45);

                entity.Property(e => e.principal).HasMaxLength(45);
            });

            modelBuilder.Entity<marca>(entity =>
            {
                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id).HasColumnType("int(11)");

                entity.Property(e => e.descripcion).HasMaxLength(128);
            });

            modelBuilder.Entity<montos>(entity =>
            {
                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id).HasColumnType("int(11) unsigned");

                entity.Property(e => e.cantidad).HasPrecision(9, 2);

                entity.Property(e => e.created_at)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.status).HasColumnType("int(11)");

                entity.Property(e => e.updated_at).HasColumnType("datetime");
            });

            modelBuilder.Entity<origination_addresses>(entity =>
            {
                entity.HasKey(e => e.id_address)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_address).HasColumnType("int(10) unsigned");

                entity.Property(e => e.apartment_number).HasMaxLength(45);

                entity.Property(e => e.city).HasMaxLength(45);

                entity.Property(e => e.house_number).HasMaxLength(45);

                entity.Property(e => e.neighborhood).HasMaxLength(45);

                entity.Property(e => e.settlement).HasMaxLength(45);

                entity.Property(e => e.state).HasMaxLength(45);

                entity.Property(e => e.street).HasMaxLength(45);

                entity.Property(e => e.zipcode).HasMaxLength(5);
            });

            modelBuilder.Entity<origination_alerts>(entity =>
            {
                entity.HasKey(e => e.id_alert)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_application, "fk_origination_alerts_1_idx");

                entity.HasIndex(e => e.id_user, "fk_origination_alerts_2_idx");

                entity.Property(e => e.id_alert).HasColumnType("int(10) unsigned");

                entity.Property(e => e.alert).HasColumnType("mediumtext");

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.id_application).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.reject).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_applicationNavigation)
                    .WithMany(p => p.origination_alerts)
                    .HasForeignKey(d => d.id_application)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_alerts_1");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.origination_alerts)
                    .HasForeignKey(d => d.id_user)
                    .HasConstraintName("fk_origination_alerts_2");
            });

            modelBuilder.Entity<origination_applications>(entity =>
            {
                entity.HasKey(e => e.id_application)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_person, "fk_origination_applications_1_idx");

                entity.HasIndex(e => e.id_stage, "fk_origination_applications_2_idx");

                entity.HasIndex(e => e.id_branch, "fk_origination_applications_3_idx");

                entity.HasIndex(e => e.id_user, "fk_origination_applications_4_idx");

                entity.HasIndex(e => e.id_profession, "fk_origination_applications_5_idx");

                entity.HasIndex(e => e.id_user_cancellation, "fk_origination_applications_6_idx");

                entity.HasIndex(e => e.date_register, "index8");

                entity.Property(e => e.id_application).HasColumnType("int(10) unsigned");

                entity.Property(e => e.cancellation_fix_stage).HasColumnType("int(10) unsigned");

                entity.Property(e => e.cancellation_reason).HasColumnType("text");

                entity.Property(e => e.date_change_stage).HasColumnType("datetime");

                entity.Property(e => e.date_register).HasColumnType("datetime");

                entity.Property(e => e.house_time).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.house_type).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_profession).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_stage).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user_cancellation).HasColumnType("int(10) unsigned");

                entity.Property(e => e.income).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.salary).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_branchNavigation)
                    .WithMany(p => p.origination_applications)
                    .HasForeignKey(d => d.id_branch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_3");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.origination_applications)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_1");

                entity.HasOne(d => d.id_professionNavigation)
                    .WithMany(p => p.origination_applications)
                    .HasForeignKey(d => d.id_profession)
                    .HasConstraintName("fk_origination_applications_5");

                entity.HasOne(d => d.id_stageNavigation)
                    .WithMany(p => p.origination_applications)
                    .HasForeignKey(d => d.id_stage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_2");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.origination_applicationsid_userNavigation)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_4");

                entity.HasOne(d => d.id_user_cancellationNavigation)
                    .WithMany(p => p.origination_applicationsid_user_cancellationNavigation)
                    .HasForeignKey(d => d.id_user_cancellation)
                    .HasConstraintName("fk_origination_applications_6");
            });

            modelBuilder.Entity<origination_applications_extra_fields>(entity =>
            {
                entity.HasKey(e => e.id_application_extra_field)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_application, "fk_origination_applications_extra_fields_1_idx");

                entity.HasIndex(e => e.id_extra_field, "fk_origination_applications_extra_fields_2_idx");

                entity.HasIndex(e => e.id_person, "fk_origination_applications_extra_fields_3_idx");

                entity.Property(e => e.id_application_extra_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.entity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.id_application).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_extra_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.value).HasMaxLength(45);

                entity.HasOne(d => d.id_applicationNavigation)
                    .WithMany(p => p.origination_applications_extra_fields)
                    .HasForeignKey(d => d.id_application)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_extra_fields_1");

                entity.HasOne(d => d.id_extra_fieldNavigation)
                    .WithMany(p => p.origination_applications_extra_fields)
                    .HasForeignKey(d => d.id_extra_field)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_extra_fields_2");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.origination_applications_extra_fields)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_extra_fields_3");
            });

            modelBuilder.Entity<origination_applications_files>(entity =>
            {
                entity.HasKey(e => e.id_application_file)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_application, "fk_origination_applications_files_1_idx");

                entity.HasIndex(e => e.id_file_type, "fk_origination_applications_files_2_idx");

                entity.HasIndex(e => e.id_person, "fk_origination_applications_files_3_idx");

                entity.Property(e => e.id_application_file).HasColumnType("int(10) unsigned");

                entity.Property(e => e.comment).HasColumnType("text");

                entity.Property(e => e.filename).HasColumnType("text");

                entity.Property(e => e.id_application).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_file_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.mimetype).HasMaxLength(45);

                entity.Property(e => e.name).HasMaxLength(255);

                entity.Property(e => e.size).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.uploaded).HasColumnType("datetime");

                entity.HasOne(d => d.id_applicationNavigation)
                    .WithMany(p => p.origination_applications_files)
                    .HasForeignKey(d => d.id_application)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_files_1");

                entity.HasOne(d => d.id_file_typeNavigation)
                    .WithMany(p => p.origination_applications_files)
                    .HasForeignKey(d => d.id_file_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_files_2");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.origination_applications_files)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_files_3");
            });

            modelBuilder.Entity<origination_applications_inquiries>(entity =>
            {
                entity.HasKey(e => e.id_application_inquiry)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_phone, "fk_origination_applications_inquiries_10_idx");

                entity.HasIndex(e => e.id_economic_activity, "fk_origination_applications_inquiries_11_idx");

                entity.HasIndex(e => e.id_application, "fk_origination_applications_inquiries_1_idx");

                entity.HasIndex(e => e.id_user, "fk_origination_applications_inquiries_2_idx");

                entity.HasIndex(e => e.id_person, "fk_origination_applications_inquiries_3_idx");

                entity.HasIndex(e => e.id_inquiry, "fk_origination_applications_inquiries_4_idx");

                entity.HasIndex(e => e.id_stage_process, "fk_origination_applications_inquiries_5_idx");

                entity.HasIndex(e => e.id_personal_reference, "fk_origination_applications_inquiries_6_idx");

                entity.HasIndex(e => e.id_guarantee, "fk_origination_applications_inquiries_7_idx");

                entity.HasIndex(e => e.id_address, "fk_origination_applications_inquiries_8_idx");

                entity.HasIndex(e => e.id_property, "fk_origination_applications_inquiries_9_idx");

                entity.Property(e => e.id_application_inquiry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.approved)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.comments).HasColumnType("text");

                entity.Property(e => e.id_address).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_application).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_economic_activity).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_guarantee).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_inquiry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_personal_reference).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_phone).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_property).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_stage_process).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.person_type).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.researcher).HasMaxLength(100);

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_addressNavigation)
                    .WithMany(p => p.origination_applications_inquiries)
                    .HasForeignKey(d => d.id_address)
                    .HasConstraintName("fk_origination_applications_inquiries_8");

                entity.HasOne(d => d.id_applicationNavigation)
                    .WithMany(p => p.origination_applications_inquiries)
                    .HasForeignKey(d => d.id_application)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_inquiries_1");

                entity.HasOne(d => d.id_economic_activityNavigation)
                    .WithMany(p => p.origination_applications_inquiries)
                    .HasForeignKey(d => d.id_economic_activity)
                    .HasConstraintName("fk_origination_applications_inquiries_11");

                entity.HasOne(d => d.id_guaranteeNavigation)
                    .WithMany(p => p.origination_applications_inquiries)
                    .HasForeignKey(d => d.id_guarantee)
                    .HasConstraintName("fk_origination_applications_inquiries_7");

                entity.HasOne(d => d.id_inquiryNavigation)
                    .WithMany(p => p.origination_applications_inquiries)
                    .HasForeignKey(d => d.id_inquiry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_inquiries_4");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.origination_applications_inquiries)
                    .HasForeignKey(d => d.id_person)
                    .HasConstraintName("fk_origination_applications_inquiries_3");

                entity.HasOne(d => d.id_personal_referenceNavigation)
                    .WithMany(p => p.origination_applications_inquiries)
                    .HasForeignKey(d => d.id_personal_reference)
                    .HasConstraintName("fk_origination_applications_inquiries_6");

                entity.HasOne(d => d.id_phoneNavigation)
                    .WithMany(p => p.origination_applications_inquiries)
                    .HasForeignKey(d => d.id_phone)
                    .HasConstraintName("fk_origination_applications_inquiries_10");

                entity.HasOne(d => d.id_propertyNavigation)
                    .WithMany(p => p.origination_applications_inquiries)
                    .HasForeignKey(d => d.id_property)
                    .HasConstraintName("fk_origination_applications_inquiries_9");

                entity.HasOne(d => d.id_stage_processNavigation)
                    .WithMany(p => p.origination_applications_inquiries)
                    .HasForeignKey(d => d.id_stage_process)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_inquiries_5");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.origination_applications_inquiries)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_inquiries_2");
            });

            modelBuilder.Entity<origination_applications_rivalries>(entity =>
            {
                entity.HasKey(e => e.id_application_rivalry)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_application, "fk_origination_applications_rivalries_1_idx");

                entity.HasIndex(e => e.id_rivalry, "fk_origination_applications_rivalries_2_idx");

                entity.Property(e => e.id_application_rivalry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.antiquity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.credit_line).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.id_application).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_rivalry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.sold).HasColumnType("decimal(12,2) unsigned");

                entity.HasOne(d => d.id_applicationNavigation)
                    .WithMany(p => p.origination_applications_rivalries)
                    .HasForeignKey(d => d.id_application)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_rivalries_1");

                entity.HasOne(d => d.id_rivalryNavigation)
                    .WithMany(p => p.origination_applications_rivalries)
                    .HasForeignKey(d => d.id_rivalry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_applications_rivalries_2");
            });

            modelBuilder.Entity<origination_cc_amounts>(entity =>
            {
                entity.HasKey(e => e.id_amount)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.code, "code_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_amount).HasColumnType("int(10) unsigned");

                entity.Property(e => e.code).HasMaxLength(3);

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<origination_cc_matrix>(entity =>
            {
                entity.HasKey(e => e.id_matrix)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_amount, "fk_origination_cc_matrix_1_idx");

                entity.HasIndex(e => e.id_status, "fk_origination_cc_matrix_2_idx");

                entity.Property(e => e.id_matrix).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_amount).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_status).HasColumnType("int(10) unsigned");

                entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_amountNavigation)
                    .WithMany(p => p.origination_cc_matrix)
                    .HasForeignKey(d => d.id_amount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_cc_matrix_1");

                entity.HasOne(d => d.id_statusNavigation)
                    .WithMany(p => p.origination_cc_matrix)
                    .HasForeignKey(d => d.id_status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_cc_matrix_2");
            });

            modelBuilder.Entity<origination_cc_statuses>(entity =>
            {
                entity.HasKey(e => e.id_status)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.code, "code_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_status).HasColumnType("int(10) unsigned");

                entity.Property(e => e.code).HasMaxLength(3);

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<origination_circulo_credito>(entity =>
            {
                entity.HasKey(e => e.id_circulo_credito)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_application, "fk_origination_circulo_credito_1_idx");

                entity.Property(e => e.id_circulo_credito).HasColumnType("int(10) unsigned");

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.folio).HasMaxLength(45);

                entity.Property(e => e.id_application).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasColumnType("text");

                entity.Property(e => e.request).HasColumnType("blob");

                entity.Property(e => e.response).HasColumnType("blob");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_applicationNavigation)
                    .WithMany(p => p.origination_circulo_credito)
                    .HasForeignKey(d => d.id_application)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_circulo_credito_1");
            });

            modelBuilder.Entity<origination_configuration>(entity =>
            {
                entity.HasKey(e => e.id_configuration)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_configuration).HasColumnType("int(10) unsigned");

                entity.Property(e => e.application_address).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_curp)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.application_economic_activity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_expenses).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_extra_field).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_guarantees).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_order)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.application_personal_reference).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_phones).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_properties).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_spouse).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_stage)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.guarantee_address).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.guarantee_economic_activity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.guarantee_phones).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.guarantee_properties).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.guarantee_status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.personal_reference_address).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.personal_reference_economic_activity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.personal_reference_phones).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.personal_reference_properties).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.personal_reference_status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.spouse_address).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.spouse_economic_activity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.spouse_phones).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.spouse_properties).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.spouse_status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<origination_configurations_printables>(entity =>
            {
                entity.HasKey(e => e.id_configuration_printable)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_configuration_printable).HasColumnType("int(10) unsigned");

                entity.Property(e => e.color).HasMaxLength(45);

                entity.Property(e => e.content).HasColumnType("blob");

                entity.Property(e => e.font).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.font_size).HasColumnType("int(10) unsigned");

                entity.Property(e => e.footer).HasColumnType("text");

                entity.Property(e => e.header).HasColumnType("text");

                entity.Property(e => e.image_footer).HasMaxLength(100);

                entity.Property(e => e.image_header).HasMaxLength(100);

                entity.Property(e => e.is_promissory_note)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<origination_domiciliary_inquiries>(entity =>
            {
                entity.HasKey(e => e.id_domiciliary_inquiry)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_application, "fk_origination_domiciliary_inquiries_1_idx");

                entity.HasIndex(e => e.id_person, "fk_origination_domiciliary_inquiries_2_idx");

                entity.HasIndex(e => e.id_process, "fk_origination_domiciliary_inquiries_3_idx");

                entity.HasIndex(e => e.id_user, "fk_origination_domiciliary_inquiries_4_idx");

                entity.Property(e => e.id_domiciliary_inquiry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.id_application).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_process).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasColumnType("mediumtext");

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_applicationNavigation)
                    .WithMany(p => p.origination_domiciliary_inquiries)
                    .HasForeignKey(d => d.id_application)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_domiciliary_inquiries_1");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.origination_domiciliary_inquiries)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_domiciliary_inquiries_2");

                entity.HasOne(d => d.id_processNavigation)
                    .WithMany(p => p.origination_domiciliary_inquiries)
                    .HasForeignKey(d => d.id_process)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_domiciliary_inquiries_3");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.origination_domiciliary_inquiries)
                    .HasForeignKey(d => d.id_user)
                    .HasConstraintName("fk_origination_domiciliary_inquiries_4");
            });

            modelBuilder.Entity<origination_domiciliary_inquiries_fields>(entity =>
            {
                entity.HasKey(e => e.id_domiciliary_inquiry_field)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_domiciliary_inquiry, "fk_origination_domiciliary_inquiries_fields_1_idx");

                entity.HasIndex(e => e.id_process_field, "fk_origination_domiciliary_inquiries_fields_2_idx");

                entity.Property(e => e.id_domiciliary_inquiry_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_domiciliary_inquiry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_process_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.value).HasMaxLength(100);

                entity.HasOne(d => d.id_domiciliary_inquiryNavigation)
                    .WithMany(p => p.origination_domiciliary_inquiries_fields)
                    .HasForeignKey(d => d.id_domiciliary_inquiry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_domiciliary_inquiries_fields_1");

                entity.HasOne(d => d.id_process_fieldNavigation)
                    .WithMany(p => p.origination_domiciliary_inquiries_fields)
                    .HasForeignKey(d => d.id_process_field)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_domiciliary_inquiries_fields_2");
            });

            modelBuilder.Entity<origination_economics_activities>(entity =>
            {
                entity.HasKey(e => e.id_economic_activity)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_economic_activity).HasColumnType("int(10) unsigned");

                entity.Property(e => e.antiquity).HasMaxLength(45);

                entity.Property(e => e.apartment_number).HasMaxLength(45);

                entity.Property(e => e.city).HasMaxLength(45);

                entity.Property(e => e.company).HasMaxLength(45);

                entity.Property(e => e.house_number).HasMaxLength(45);

                entity.Property(e => e.neighborhood).HasMaxLength(45);

                entity.Property(e => e.phone).HasMaxLength(10);

                entity.Property(e => e.position).HasMaxLength(45);

                entity.Property(e => e.salary).HasMaxLength(45);

                entity.Property(e => e.settlement).HasMaxLength(45);

                entity.Property(e => e.state).HasMaxLength(45);

                entity.Property(e => e.street).HasMaxLength(45);

                entity.Property(e => e.zipcode).HasMaxLength(5);
            });

            modelBuilder.Entity<origination_expenses>(entity =>
            {
                entity.HasKey(e => e.id_expense)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_application, "fk_origination_expenses_1_idx");

                entity.HasIndex(e => e.id_expense_type, "fk_origination_expenses_2_idx");

                entity.Property(e => e.id_expense).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.id_application).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_expense_type).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_applicationNavigation)
                    .WithMany(p => p.origination_expenses)
                    .HasForeignKey(d => d.id_application)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_expenses_1");

                entity.HasOne(d => d.id_expense_typeNavigation)
                    .WithMany(p => p.origination_expenses)
                    .HasForeignKey(d => d.id_expense_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_expenses_2");
            });

            modelBuilder.Entity<origination_expenses_types>(entity =>
            {
                entity.HasKey(e => e.id_expense_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_expense_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<origination_extra_fields>(entity =>
            {
                entity.HasKey(e => e.id_extra_field)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_extra_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.entity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.name).HasMaxLength(50);

                entity.Property(e => e.required).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.values).HasColumnType("text");
            });

            modelBuilder.Entity<origination_files_types>(entity =>
            {
                entity.HasKey(e => e.id_file_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_file_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.entity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.required).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<origination_guarantees>(entity =>
            {
                entity.HasKey(e => e.id_guarantee)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_application, "fk_origination_guarantees_1_idx");

                entity.HasIndex(e => e.id_person, "fk_origination_guarantees_2_idx");

                entity.HasIndex(e => e.id_relationship, "fk_origination_guarantees_3_idx");

                entity.Property(e => e.id_guarantee).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_application).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_relationship).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.id_applicationNavigation)
                    .WithMany(p => p.origination_guarantees)
                    .HasForeignKey(d => d.id_application)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_guarantees_1");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.origination_guarantees)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_guarantees_2");

                entity.HasOne(d => d.id_relationshipNavigation)
                    .WithMany(p => p.origination_guarantees)
                    .HasForeignKey(d => d.id_relationship)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_guarantees_3");
            });

            modelBuilder.Entity<origination_inquiries>(entity =>
            {
                entity.HasKey(e => e.id_inquiry)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_process, "fk_origination_inquiries_1_idx");

                entity.Property(e => e.id_inquiry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.description).HasColumnType("text");

                entity.Property(e => e.id_process).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.person_type)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.type)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_processNavigation)
                    .WithMany(p => p.origination_inquiries)
                    .HasForeignKey(d => d.id_process)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_inquiries_1");
            });

            modelBuilder.Entity<origination_inquiry_fields>(entity =>
            {
                entity.HasKey(e => e.id_inquiry_field)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_inquiry, "fk_origination_inquiry_fields_1_idx");

                entity.Property(e => e.id_inquiry_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_inquiry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(50);

                entity.Property(e => e.required).HasColumnType("tinyint(4)");

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.values).HasColumnType("text");

                entity.HasOne(d => d.id_inquiryNavigation)
                    .WithMany(p => p.origination_inquiry_fields)
                    .HasForeignKey(d => d.id_inquiry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_inquiry_fields_1");
            });

            modelBuilder.Entity<origination_logs>(entity =>
            {
                entity.HasKey(e => e.id_log)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_log).HasColumnType("int(10) unsigned");

                entity.Property(e => e._event)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasColumnType("text");
            });

            modelBuilder.Entity<origination_personal_references>(entity =>
            {
                entity.HasKey(e => e.id_personal_reference)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_application, "fk_origination_personal_references_1_idx");

                entity.HasIndex(e => e.id_relationship, "fk_origination_personal_references_2_idx");

                entity.HasIndex(e => e.id_person, "fk_origination_personal_references_3_idx");

                entity.Property(e => e.id_personal_reference).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_application).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_relationship).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.time).HasColumnType("int(11) unsigned");

                entity.HasOne(d => d.id_applicationNavigation)
                    .WithMany(p => p.origination_personal_references)
                    .HasForeignKey(d => d.id_application)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_personal_references_1");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.origination_personal_references)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_personal_references_3");

                entity.HasOne(d => d.id_relationshipNavigation)
                    .WithMany(p => p.origination_personal_references)
                    .HasForeignKey(d => d.id_relationship)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_personal_references_2");
            });

            modelBuilder.Entity<origination_persons>(entity =>
            {
                entity.HasKey(e => e.id_person)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_address, "fk_origination_persons_1_idx");

                entity.HasIndex(e => e.id_economict_activity, "fk_origination_persons_2_idx");

                entity.HasIndex(e => e.id_spouse, "fk_origination_persons_3_idx");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.curp).HasMaxLength(18);

                entity.Property(e => e.gender).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.id_address).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_economict_activity).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_spouse).HasColumnType("int(10) unsigned");

                entity.Property(e => e.last_name).HasMaxLength(45);

                entity.Property(e => e.marital_status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.middle_name).HasMaxLength(45);

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.rfc).HasMaxLength(13);

                entity.Property(e => e.second_last_name).HasMaxLength(45);

                entity.HasOne(d => d.id_addressNavigation)
                    .WithMany(p => p.origination_persons)
                    .HasForeignKey(d => d.id_address)
                    .HasConstraintName("fk_origination_persons_1");

                entity.HasOne(d => d.id_economict_activityNavigation)
                    .WithMany(p => p.origination_persons)
                    .HasForeignKey(d => d.id_economict_activity)
                    .HasConstraintName("fk_origination_persons_2");

                entity.HasOne(d => d.id_spouseNavigation)
                    .WithMany(p => p.origination_persons)
                    .HasForeignKey(d => d.id_spouse)
                    .HasConstraintName("fk_origination_persons_3");
            });

            modelBuilder.Entity<origination_persons_phones>(entity =>
            {
                entity.HasKey(e => e.id_person_phone)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_phone_type, "fk_origination_phones_1_idx");

                entity.HasIndex(e => e.id_person, "fk_origination_phones_2_idx");

                entity.Property(e => e.id_person_phone).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_phone_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.number).HasMaxLength(10);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.origination_persons_phones)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_phones_2");

                entity.HasOne(d => d.id_phone_typeNavigation)
                    .WithMany(p => p.origination_persons_phones)
                    .HasForeignKey(d => d.id_phone_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_phones_1");
            });

            modelBuilder.Entity<origination_phones_types>(entity =>
            {
                entity.HasKey(e => e.id_phone_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_phone_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<origination_processes>(entity =>
            {
                entity.HasKey(e => e.id_process)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_process).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<origination_processes_fields>(entity =>
            {
                entity.HasKey(e => e.id_process_field)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_process, "fk_origination_processes_fields_1_idx");

                entity.Property(e => e.id_process_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.comment_name).HasMaxLength(100);

                entity.Property(e => e.entity)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.has_comment)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.id_process).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.required)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.values).HasMaxLength(100);

                entity.HasOne(d => d.id_processNavigation)
                    .WithMany(p => p.origination_processes_fields)
                    .HasForeignKey(d => d.id_process)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_processes_fields_1");
            });

            modelBuilder.Entity<origination_professions>(entity =>
            {
                entity.HasKey(e => e.id_profession)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_profession).HasColumnType("int(10) unsigned");

                entity.Property(e => e.forbidden)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<origination_properties>(entity =>
            {
                entity.HasKey(e => e.id_property)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_person, "fk_origination_properties_1_idx");

                entity.HasIndex(e => e.id_property_type, "fk_origination_properties_2_idx");

                entity.Property(e => e.id_property).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.apartment_number).HasMaxLength(45);

                entity.Property(e => e.city).HasMaxLength(45);

                entity.Property(e => e.description).HasColumnType("text");

                entity.Property(e => e.house_number).HasMaxLength(45);

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_property_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.neighborhood).HasMaxLength(45);

                entity.Property(e => e.settlement).HasMaxLength(45);

                entity.Property(e => e.state).HasMaxLength(45);

                entity.Property(e => e.street).HasMaxLength(45);

                entity.Property(e => e.type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.zipcode).HasMaxLength(45);

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.origination_properties)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_properties_1");

                entity.HasOne(d => d.id_property_typeNavigation)
                    .WithMany(p => p.origination_properties)
                    .HasForeignKey(d => d.id_property_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_properties_2");
            });

            modelBuilder.Entity<origination_properties_types>(entity =>
            {
                entity.HasKey(e => e.id_property_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_property_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.require_address)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<origination_relationships>(entity =>
            {
                entity.HasKey(e => e.id_relationship)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_relationship).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<origination_rivalries>(entity =>
            {
                entity.HasKey(e => e.id_rivalry)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_rivalry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.antique).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<origination_scoring_approval_conditions>(entity =>
            {
                entity.HasKey(e => e.id_scoring_approval_condition)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_origination_scoring_approval_conditions_1_idx");

                entity.HasIndex(e => e.id_scoring, "fk_origination_scoring_approval_conditions_2_idx");

                entity.Property(e => e.id_scoring_approval_condition).HasColumnType("int(10) unsigned");

                entity.Property(e => e.approved).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.id_scoring).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.value).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_scoringNavigation)
                    .WithMany(p => p.origination_scoring_approval_conditions)
                    .HasForeignKey(d => d.id_scoring)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_scoring_approval_conditions_2");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.origination_scoring_approval_conditions)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_scoring_approval_conditions_1");
            });

            modelBuilder.Entity<origination_scoring_field_answers>(entity =>
            {
                entity.HasKey(e => e.id_scoring_field_answer)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_origination_scoring_field_answers_1_idx");

                entity.HasIndex(e => e.id_scoring_field, "fk_origination_scoring_field_answers_2_idx");

                entity.Property(e => e.id_scoring_field_answer).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_scoring_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.value).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_scoring_fieldNavigation)
                    .WithMany(p => p.origination_scoring_field_answers)
                    .HasForeignKey(d => d.id_scoring_field)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_scoring_field_answers_2");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.origination_scoring_field_answers)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_scoring_field_answers_1");
            });

            modelBuilder.Entity<origination_scoring_fields>(entity =>
            {
                entity.HasKey(e => e.id_scoring_field)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_scoring, "fk_origination_scoring_fields_1_idx");

                entity.HasIndex(e => e.id_user, "fk_origination_scoring_fields_2_idx");

                entity.Property(e => e.id_scoring_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_scoring).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");

                entity.HasOne(d => d.id_scoringNavigation)
                    .WithMany(p => p.origination_scoring_fields)
                    .HasForeignKey(d => d.id_scoring)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_scoring_fields_1");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.origination_scoring_fields)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_scoring_fields_2");
            });

            modelBuilder.Entity<origination_scorings>(entity =>
            {
                entity.HasKey(e => e.id_scoring)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_origination_scorings_1_idx");

                entity.HasIndex(e => e.id_process, "fk_origination_scorings_2_idx");

                entity.Property(e => e.id_scoring).HasColumnType("int(10) unsigned");

                entity.Property(e => e.description).HasColumnType("text");

                entity.Property(e => e.id_process)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(50);

                entity.Property(e => e.person_type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");

                entity.HasOne(d => d.id_processNavigation)
                    .WithMany(p => p.origination_scorings)
                    .HasForeignKey(d => d.id_process)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_scorings_2");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.origination_scorings)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_scorings_1");
            });

            modelBuilder.Entity<origination_spouses>(entity =>
            {
                entity.HasKey(e => e.id_spouse)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_person, "fk_origination_sposes_1_idx");

                entity.HasIndex(e => e.id_application, "fk_origination_sposes_2_idx");

                entity.HasIndex(e => e.id_relationship, "index4");

                entity.Property(e => e.id_spouse).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_application).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_relationship).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.id_applicationNavigation)
                    .WithMany(p => p.origination_spouses)
                    .HasForeignKey(d => d.id_application)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_sposes_2");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.origination_spouses)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_sposes_1");

                entity.HasOne(d => d.id_relationshipNavigation)
                    .WithMany(p => p.origination_spouses)
                    .HasForeignKey(d => d.id_relationship)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_spouses_1");
            });

            modelBuilder.Entity<origination_stages>(entity =>
            {
                entity.HasKey(e => e.id_stage)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_stage).HasColumnType("int(10) unsigned");

                entity.Property(e => e.application_active_address).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_active_economic_activity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_active_expenses).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_active_extra_fields).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_active_guarantees).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_active_personal_references).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_active_phones).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_active_properties).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_active_rivalries).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_active_spouse).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_edit_address).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_edit_economic_activity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_edit_expenses).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_edit_guarantees).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_edit_person).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_edit_personal_references).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_edit_phones).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_edit_properties).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_edit_spouse).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_expense_quantity)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.application_guarantee_quantity)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.application_personal_reference_quantity)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.application_phone_quantity)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.application_property_quantity)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.application_require_address).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_require_economic_activity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.application_require_spouse).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.guarantee_edit_address).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.guarantee_edit_economic_activity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.guarantee_edit_person).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.guarantee_edit_phones).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.guarantee_edit_properties).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.guarantee_phone_quantity)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.guarantee_property_quantity)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.guarantee_require_address).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.guarantee_require_economic_activity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.order)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.personal_reference_edit_address).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.personal_reference_edit_economic_activity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.personal_reference_edit_person).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.personal_reference_edit_phones).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.personal_reference_edit_properties).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.personal_reference_phone_quantity)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.personal_reference_property_quantity)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.personal_reference_require_address).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.personal_reference_require_economic_activity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.spouse_edit_address).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.spouse_edit_economic_activity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.spouse_edit_person).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.spouse_edit_phones).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.spouse_edit_properties).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.spouse_phone_quantity)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.spouse_property_quantity)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.spouse_require_address).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.spouse_require_economic_activity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasMany(d => d.id_file_type)
                    .WithMany(p => p.id_stage)
                    .UsingEntity<Dictionary<string, object>>(
                        "origination_stages_files_types",
                        l => l.HasOne<origination_files_types>().WithMany().HasForeignKey("id_file_type").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_origination_stages_files_types_2"),
                        r => r.HasOne<origination_stages>().WithMany().HasForeignKey("id_stage").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_origination_stages_files_types_1"),
                        j =>
                        {
                            j.HasKey("id_stage", "id_file_type").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("origination_stages_files_types").HasCharSet("utf8").UseCollation("utf8_general_ci");

                            j.HasIndex(new[] { "id_file_type" }, "fk_origination_stages_files_types_2_idx");

                            j.IndexerProperty<uint>("id_stage").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_file_type").HasColumnType("int(10) unsigned");
                        });

                entity.HasMany(d => d.id_role)
                    .WithMany(p => p.id_stage)
                    .UsingEntity<Dictionary<string, object>>(
                        "origination_stages_roles",
                        l => l.HasOne<core_roles>().WithMany().HasForeignKey("id_role").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_origination_stages_roles_2"),
                        r => r.HasOne<origination_stages>().WithMany().HasForeignKey("id_stage").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_origination_stages_roles_1"),
                        j =>
                        {
                            j.HasKey("id_stage", "id_role").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("origination_stages_roles").HasCharSet("utf8").UseCollation("utf8_general_ci");

                            j.HasIndex(new[] { "id_role" }, "fk_origination_stages_roles_2_idx");

                            j.IndexerProperty<uint>("id_stage").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_role").HasColumnType("int(10) unsigned");
                        });
            });

            modelBuilder.Entity<origination_stages_processes>(entity =>
            {
                entity.HasKey(e => e.id_stage_process)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_stage, "fk_origination_stages_processes_1_idx");

                entity.HasIndex(e => e.id_process, "fk_origination_stages_processes_2_idx");

                entity.Property(e => e.id_stage_process).HasColumnType("int(10) unsigned");

                entity.Property(e => e.entity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.id_process).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_stage).HasColumnType("int(10) unsigned");

                entity.Property(e => e.required).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_processNavigation)
                    .WithMany(p => p.origination_stages_processes)
                    .HasForeignKey(d => d.id_process)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_stages_processes_2");

                entity.HasOne(d => d.id_stageNavigation)
                    .WithMany(p => p.origination_stages_processes)
                    .HasForeignKey(d => d.id_stage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_stages_processes_1");
            });

            modelBuilder.Entity<origination_telephone_inquiries>(entity =>
            {
                entity.HasKey(e => e.id_telephone_inquiry)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_application, "fk_origination_telephone_inquiries_1_idx");

                entity.HasIndex(e => e.id_person, "fk_origination_telephone_inquiries_2_idx");

                entity.HasIndex(e => e.id_process, "fk_origination_telephone_inquiries_3_idx");

                entity.HasIndex(e => e.id_person_phone, "fk_origination_telephone_inquiries_4_idx");

                entity.HasIndex(e => e.id_user, "fk_origination_telephone_inquiries_5_idx");

                entity.Property(e => e.id_telephone_inquiry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.id_application).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_person_phone).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_process).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.note).HasColumnType("text");

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_applicationNavigation)
                    .WithMany(p => p.origination_telephone_inquiries)
                    .HasForeignKey(d => d.id_application)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_telephone_inquiries_1");

                entity.HasOne(d => d.id_personNavigation)
                    .WithMany(p => p.origination_telephone_inquiries)
                    .HasForeignKey(d => d.id_person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_telephone_inquiries_2");

                entity.HasOne(d => d.id_person_phoneNavigation)
                    .WithMany(p => p.origination_telephone_inquiries)
                    .HasForeignKey(d => d.id_person_phone)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_telephone_inquiries_4");

                entity.HasOne(d => d.id_processNavigation)
                    .WithMany(p => p.origination_telephone_inquiries)
                    .HasForeignKey(d => d.id_process)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_telephone_inquiries_3");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.origination_telephone_inquiries)
                    .HasForeignKey(d => d.id_user)
                    .HasConstraintName("fk_origination_telephone_inquiries_5");
            });

            modelBuilder.Entity<origination_telephone_inquiries_fields>(entity =>
            {
                entity.HasKey(e => e.id_telephone_inquiry_field)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_telephone_inquiry, "fk_origination_telephone_inquiries_fields_1_idx");

                entity.HasIndex(e => e.id_process_field, "fk_origination_telephone_inquiries_fields_2_idx");

                entity.Property(e => e.id_telephone_inquiry_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_process_field).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_telephone_inquiry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.value).HasMaxLength(100);

                entity.HasOne(d => d.id_process_fieldNavigation)
                    .WithMany(p => p.origination_telephone_inquiries_fields)
                    .HasForeignKey(d => d.id_process_field)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_telephone_inquiries_fields_2");

                entity.HasOne(d => d.id_telephone_inquiryNavigation)
                    .WithMany(p => p.origination_telephone_inquiries_fields)
                    .HasForeignKey(d => d.id_telephone_inquiry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_telephone_inquiries_fields_1");
            });

            modelBuilder.Entity<origination_users_applications>(entity =>
            {
                entity.HasKey(e => e.id_application)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_application)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.id_user).HasColumnType("int(11)");
            });

            modelBuilder.Entity<origination_validations>(entity =>
            {
                entity.HasKey(e => e.id_validation)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_process, "fk_origination_validations_1_idx");

                entity.Property(e => e.id_validation).HasColumnType("int(10) unsigned");

                entity.Property(e => e.description).HasColumnType("text");

                entity.Property(e => e.id_process).HasColumnType("int(10) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_processNavigation)
                    .WithMany(p => p.origination_validations)
                    .HasForeignKey(d => d.id_process)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_validations_1");
            });

            modelBuilder.Entity<origination_validations_files>(entity =>
            {
                entity.HasKey(e => e.id_validation_file)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_validation, "fk_origination_validations_files_1_idx");

                entity.HasIndex(e => e.id_file_type, "fk_origination_validations_files_2");

                entity.Property(e => e.id_validation_file).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_file_type).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_validation).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_file_typeNavigation)
                    .WithMany(p => p.origination_validations_files)
                    .HasForeignKey(d => d.id_file_type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_validations_files_2");

                entity.HasOne(d => d.id_validationNavigation)
                    .WithMany(p => p.origination_validations_files)
                    .HasForeignKey(d => d.id_validation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origination_validations_files_1");
            });

            modelBuilder.Entity<payed_purchases>(entity =>
            {
                entity.HasKey(e => e.id_purchase)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_purchase)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.interest).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.payed).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.principal).HasColumnType("decimal(12,2) unsigned");
            });

            modelBuilder.Entity<piorpi_alerts>(entity =>
            {
                entity.HasKey(e => e.id_alert)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_user, "fk_piorpi_alerts_1_idx");

                entity.Property(e => e.id_alert).HasColumnType("int(10) unsigned");

                entity.Property(e => e.alerts).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.percentage).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.piorpi_alerts)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_piorpi_alerts_1");
            });

            modelBuilder.Entity<piorpi_alerts_entries>(entity =>
            {
                entity.HasKey(e => e.id_alert_entry)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_alert, "fk_piorpi_alerts_entries_1_idx");

                entity.HasIndex(e => e.id_distributor, "fk_piorpi_alerts_entries_2_idx");

                entity.Property(e => e.id_alert_entry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.id_alert).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_alertNavigation)
                    .WithMany(p => p.piorpi_alerts_entries)
                    .HasForeignKey(d => d.id_alert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_piorpi_alerts_entries_1");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.piorpi_alerts_entries)
                    .HasForeignKey(d => d.id_distributor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_piorpi_alerts_entries_2");

                entity.HasMany(d => d.id_purchase)
                    .WithMany(p => p.id_alert_entry)
                    .UsingEntity<Dictionary<string, object>>(
                        "piorpi_alerts_entries_purchases",
                        l => l.HasOne<credit_puchases>().WithMany().HasForeignKey("id_purchase").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_piorpi_alerts_entries_purchases_2"),
                        r => r.HasOne<piorpi_alerts_entries>().WithMany().HasForeignKey("id_alert_entry").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_piorpi_alerts_entries_purchases_1"),
                        j =>
                        {
                            j.HasKey("id_alert_entry", "id_purchase").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("piorpi_alerts_entries_purchases").HasCharSet("utf8").UseCollation("utf8_general_ci");

                            j.HasIndex(new[] { "id_purchase" }, "fk_piorpi_alerts_entries_purchases_2_idx");

                            j.IndexerProperty<uint>("id_alert_entry").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_purchase").HasColumnType("int(10) unsigned");
                        });
            });

            modelBuilder.Entity<piorpi_black_lists>(entity =>
            {
                entity.HasKey(e => e.id_black_list)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_black_list).HasColumnType("int(10) unsigned");

                entity.Property(e => e.last_update).HasColumnType("datetime");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.service).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<piorpi_black_lists_entries>(entity =>
            {
                entity.HasKey(e => e.id_black_list_entry)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_black_list, "fk_piorpi_black_lists_entries_1_idx");

                entity.Property(e => e.id_black_list_entry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.address).HasMaxLength(100);

                entity.Property(e => e.id_black_list).HasColumnType("int(10) unsigned");

                entity.Property(e => e.last_name).HasMaxLength(100);

                entity.Property(e => e.last_name_soundex).HasMaxLength(100);

                entity.Property(e => e.list_type).HasMaxLength(200);

                entity.Property(e => e.middle_name).HasMaxLength(100);

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.name_soundex).HasMaxLength(100);

                entity.Property(e => e.note).HasMaxLength(200);

                entity.Property(e => e.place_birth).HasMaxLength(100);

                entity.Property(e => e.reference).HasMaxLength(100);

                entity.Property(e => e.second_last_name).HasMaxLength(100);

                entity.HasOne(d => d.id_black_listNavigation)
                    .WithMany(p => p.piorpi_black_lists_entries)
                    .HasForeignKey(d => d.id_black_list)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_piorpi_black_lists_entries_1");
            });

            modelBuilder.Entity<piorpi_salaries>(entity =>
            {
                entity.HasKey(e => e.id_salary)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id_salary).HasColumnType("int(10) unsigned");

                entity.Property(e => e.month).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.salary).HasColumnType("decimal(5,2) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.year).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<session>(entity =>
            {
                entity.HasKey(e => new { e.id, e.name })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.id)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.name)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.lifetime).HasColumnType("int(11)");

                entity.Property(e => e.modified).HasColumnType("int(11)");
            });

            modelBuilder.Entity<tempo>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.amount).HasPrecision(10, 2);

                entity.Property(e => e.id_distributor).HasColumnType("int(11)");
            });

            modelBuilder.Entity<treasury_box_closures>(entity =>
            {
                entity.HasKey(e => e.id_box_closure)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_user, "fk_treasury_box_closures_1_idx");

                entity.HasIndex(e => e.id_box, "fk_treasury_box_closures_2_idx");

                entity.Property(e => e.id_box_closure).HasColumnType("int(10) unsigned");

                entity.Property(e => e.available).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.drag_available)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.id_box).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.in_amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.out_amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.register_date).HasColumnType("datetime");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_boxNavigation)
                    .WithMany(p => p.treasury_box_closures)
                    .HasForeignKey(d => d.id_box)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_treasury_box_closures_2");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.treasury_box_closures)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_treasury_box_closures_1");

                entity.HasMany(d => d.id_box_injection)
                    .WithMany(p => p.id_box_closure)
                    .UsingEntity<Dictionary<string, object>>(
                        "treasury_box_closures_boxes_injections",
                        l => l.HasOne<treasury_boxes_injections>().WithMany().HasForeignKey("id_box_injection").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_treasury_box_closures_boxes_injections_2"),
                        r => r.HasOne<treasury_box_closures>().WithMany().HasForeignKey("id_box_closure").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_treasury_box_closures_boxes_injections_1"),
                        j =>
                        {
                            j.HasKey("id_box_closure", "id_box_injection").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("treasury_box_closures_boxes_injections").HasCharSet("latin1").UseCollation("latin1_swedish_ci");

                            j.HasIndex(new[] { "id_box_injection" }, "fk_treasury_box_closures_boxes_injections_2_idx");

                            j.IndexerProperty<uint>("id_box_closure").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_box_injection").HasColumnType("int(10) unsigned");
                        });

                entity.HasMany(d => d.id_box_payment)
                    .WithMany(p => p.id_box_closure)
                    .UsingEntity<Dictionary<string, object>>(
                        "treasury_box_closures_boxes_payments",
                        l => l.HasOne<treasury_boxes_payments>().WithMany().HasForeignKey("id_box_payment").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_treasury_box_closures_boxes_payments_2"),
                        r => r.HasOne<treasury_box_closures>().WithMany().HasForeignKey("id_box_closure").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_treasury_box_closures_boxes_payments_1"),
                        j =>
                        {
                            j.HasKey("id_box_closure", "id_box_payment").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("treasury_box_closures_boxes_payments").HasCharSet("latin1").UseCollation("latin1_swedish_ci");

                            j.HasIndex(new[] { "id_box_payment" }, "fk_treasury_box_closures_boxes_payments_2_idx");

                            j.IndexerProperty<uint>("id_box_closure").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_box_payment").HasColumnType("int(10) unsigned");
                        });

                entity.HasMany(d => d.id_shift_closing)
                    .WithMany(p => p.id_box_closure)
                    .UsingEntity<Dictionary<string, object>>(
                        "treasury_box_closures_shift_closings",
                        l => l.HasOne<treasury_shift_closings>().WithMany().HasForeignKey("id_shift_closing").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_treasury_box_closures_shift_closings_2"),
                        r => r.HasOne<treasury_box_closures>().WithMany().HasForeignKey("id_box_closure").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_treasury_box_closures_shift_closings_1"),
                        j =>
                        {
                            j.HasKey("id_box_closure", "id_shift_closing").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("treasury_box_closures_shift_closings").HasCharSet("latin1").UseCollation("latin1_swedish_ci");

                            j.HasIndex(new[] { "id_shift_closing" }, "fk_treasury_box_closures_shift_closings_2_idx");

                            j.IndexerProperty<uint>("id_box_closure").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_shift_closing").HasColumnType("int(10) unsigned");
                        });
            });

            modelBuilder.Entity<treasury_box_drags>(entity =>
            {
                entity.HasKey(e => e.id_drag)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_box, "fk_treasury_box_drags_1_idx");

                entity.HasIndex(e => e.id_box_closure, "fk_treasury_box_drags_2_idx");

                entity.Property(e => e.id_drag).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.id_box).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_box_closure).HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.id_boxNavigation)
                    .WithMany(p => p.treasury_box_drags)
                    .HasForeignKey(d => d.id_box)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_treasury_box_drags_1");

                entity.HasOne(d => d.id_box_closureNavigation)
                    .WithMany(p => p.treasury_box_drags)
                    .HasForeignKey(d => d.id_box_closure)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_treasury_box_drags_2");
            });

            modelBuilder.Entity<treasury_boxes>(entity =>
            {
                entity.HasKey(e => e.id_box)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_branch, "fk_treasury_boxes_1_idx");

                entity.HasIndex(e => e.id_user, "fk_treasury_boxes_2_idx");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_box).HasColumnType("int(10) unsigned");

                entity.Property(e => e.end).HasColumnType("time");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.limit).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.name).HasMaxLength(45);

                entity.Property(e => e.order)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.start).HasColumnType("time");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_branchNavigation)
                    .WithMany(p => p.treasury_boxes)
                    .HasForeignKey(d => d.id_branch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_treasury_boxes_1");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.treasury_boxes)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_treasury_boxes_2");

                entity.HasMany(d => d.id_user1)
                    .WithMany(p => p.id_box)
                    .UsingEntity<Dictionary<string, object>>(
                        "treasury_boxes_users",
                        l => l.HasOne<core_users>().WithMany().HasForeignKey("id_user").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_treasury_boxes_users_2"),
                        r => r.HasOne<treasury_boxes>().WithMany().HasForeignKey("id_box").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_treasury_boxes_users_1"),
                        j =>
                        {
                            j.HasKey("id_box", "id_user").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("treasury_boxes_users").HasCharSet("utf8").UseCollation("utf8_general_ci");

                            j.HasIndex(new[] { "id_user" }, "fk_treasury_boxes_users_2_idx");

                            j.IndexerProperty<uint>("id_box").HasColumnType("int(10) unsigned");

                            j.IndexerProperty<uint>("id_user").HasColumnType("int(10) unsigned");
                        });
            });

            modelBuilder.Entity<treasury_boxes_injections>(entity =>
            {
                entity.HasKey(e => e.id_box_injection)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_box, "fk_treasury_boxes_injections_1_idx");

                entity.HasIndex(e => e.id_provider, "fk_treasury_boxes_injections_2_idx");

                entity.HasIndex(e => e.id_user, "fk_treasury_boxes_injections_3_idx");

                entity.Property(e => e.id_box_injection).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.id_box).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_provider).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_provider_request).HasColumnType("int(11)");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_boxNavigation)
                    .WithMany(p => p.treasury_boxes_injections)
                    .HasForeignKey(d => d.id_box)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_treasury_boxes_injections_1");

                entity.HasOne(d => d.id_providerNavigation)
                    .WithMany(p => p.treasury_boxes_injections)
                    .HasForeignKey(d => d.id_provider)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_treasury_boxes_injections_2");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.treasury_boxes_injections)
                    .HasForeignKey(d => d.id_user)
                    .HasConstraintName("fk_treasury_boxes_injections_3");
            });

            modelBuilder.Entity<treasury_boxes_payments>(entity =>
            {
                entity.HasKey(e => e.id_box_payment)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_box, "fk_treasury_boxes_payments_1_idx");

                entity.HasIndex(e => e.id_distributor, "fk_treasury_boxes_payments_2_idx");

                entity.HasIndex(e => e.id_customer, "fk_treasury_boxes_payments_3_idx");

                entity.HasIndex(e => e.id_provider, "fk_treasury_boxes_payments_5_idx");

                entity.HasIndex(e => e.id_payment, "fk_treasury_boxes_payments_6_idx");

                entity.HasIndex(e => e.id_user, "fk_treasury_boxes_payments_7_idx");

                entity.HasIndex(e => e.id_purchase, "fk_treasury_boxes_payments_8_idx");

                entity.Property(e => e.id_box_payment).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.cancellation_date).HasColumnType("datetime");

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.id_box).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_customer).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_distributor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_payment).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_provider).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_purchase).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_boxNavigation)
                    .WithMany(p => p.treasury_boxes_payments)
                    .HasForeignKey(d => d.id_box)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_treasury_boxes_payments_1");

                entity.HasOne(d => d.id_customerNavigation)
                    .WithMany(p => p.treasury_boxes_payments)
                    .HasForeignKey(d => d.id_customer)
                    .HasConstraintName("fk_treasury_boxes_payments_3");

                entity.HasOne(d => d.id_distributorNavigation)
                    .WithMany(p => p.treasury_boxes_payments)
                    .HasForeignKey(d => d.id_distributor)
                    .HasConstraintName("fk_treasury_boxes_payments_2");

                entity.HasOne(d => d.id_paymentNavigation)
                    .WithMany(p => p.treasury_boxes_payments)
                    .HasForeignKey(d => d.id_payment)
                    .HasConstraintName("fk_treasury_boxes_payments_6");

                entity.HasOne(d => d.id_providerNavigation)
                    .WithMany(p => p.treasury_boxes_payments)
                    .HasForeignKey(d => d.id_provider)
                    .HasConstraintName("fk_treasury_boxes_payments_5");

                entity.HasOne(d => d.id_purchaseNavigation)
                    .WithMany(p => p.treasury_boxes_payments)
                    .HasForeignKey(d => d.id_purchase)
                    .HasConstraintName("fk_treasury_boxes_payments_8");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.treasury_boxes_payments)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_treasury_boxes_payments_7");
            });

            modelBuilder.Entity<treasury_providers>(entity =>
            {
                entity.HasKey(e => e.id_provider)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_branch, "fk_treasury_money_providers_1_idx");

                entity.HasIndex(e => e.name, "name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.id_provider).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_branch).HasColumnType("int(10) unsigned");

                entity.Property(e => e.maximun).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.minimum).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.name).HasMaxLength(100);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.id_branchNavigation)
                    .WithMany(p => p.treasury_providers)
                    .HasForeignKey(d => d.id_branch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_treasury_money_providers_1");
            });

            modelBuilder.Entity<treasury_providers_requests>(entity =>
            {
                entity.HasKey(e => e.id_provider_request)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_provider, "fk_treasury_providers_requests_1_idx");

                entity.HasIndex(e => e.id_request, "fk_treasury_providers_requests_2_idx");

                entity.HasIndex(e => e.id_box, "fk_treasury_providers_requests_3_idx");

                entity.HasIndex(e => e.id_user, "fk_treasury_providers_requests_4_idx");

                entity.Property(e => e.id_provider_request).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.cancellation_date).HasColumnType("timestamp");

                entity.Property(e => e.cancellation_note).HasMaxLength(150);

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.id_box).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_provider).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_request).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user_cancellation).HasColumnType("int(11)");

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.type).HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.id_boxNavigation)
                    .WithMany(p => p.treasury_providers_requests)
                    .HasForeignKey(d => d.id_box)
                    .HasConstraintName("fk_treasury_providers_requests_3");

                entity.HasOne(d => d.id_providerNavigation)
                    .WithMany(p => p.treasury_providers_requests)
                    .HasForeignKey(d => d.id_provider)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_treasury_providers_requests_1");

                entity.HasOne(d => d.id_requestNavigation)
                    .WithMany(p => p.treasury_providers_requests)
                    .HasForeignKey(d => d.id_request)
                    .HasConstraintName("fk_treasury_providers_requests_2");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.treasury_providers_requests)
                    .HasForeignKey(d => d.id_user)
                    .HasConstraintName("fk_treasury_providers_requests_4");
            });

            modelBuilder.Entity<treasury_requests>(entity =>
            {
                entity.HasKey(e => e.id_request)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.id_provider, "fk_treasury_requests_1_idx");

                entity.Property(e => e.id_request).HasColumnType("int(10) unsigned");

                entity.Property(e => e.amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.id_provider).HasColumnType("int(10) unsigned");

                entity.Property(e => e.reference).HasMaxLength(45);

                entity.Property(e => e.status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.id_providerNavigation)
                    .WithMany(p => p.treasury_requests)
                    .HasForeignKey(d => d.id_provider)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_treasury_requests_1");
            });

            modelBuilder.Entity<treasury_shift_closing_types>(entity =>
            {
                entity.HasKey(e => e.id_shift_closing_type)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id_shift_closing_type).HasColumnType("int(11)");

                entity.Property(e => e.description).HasMaxLength(100);

                entity.Property(e => e.status)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<treasury_shift_closings>(entity =>
            {
                entity.HasKey(e => e.id_shift_closing)
                    .HasName("PRIMARY");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.id_user, "fk_treasury_shift_closings_1_idx");

                entity.HasIndex(e => e.id_box, "fk_treasury_shift_closings_2_idx");

                entity.HasIndex(e => e.id_shift_closing_type, "treasury_shift_closings_FK");

                entity.Property(e => e.id_shift_closing).HasColumnType("int(10) unsigned");

                entity.Property(e => e.available).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.cancellation_date)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.cancellation_note).HasMaxLength(150);

                entity.Property(e => e.date).HasColumnType("datetime");

                entity.Property(e => e.id_box).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_shift_closing_type).HasColumnType("int(11)");

                entity.Property(e => e.id_user).HasColumnType("int(10) unsigned");

                entity.Property(e => e.id_user_cancellation).HasColumnType("int(11)");

                entity.Property(e => e.in_amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.note).HasColumnType("text");

                entity.Property(e => e.out_amount).HasColumnType("decimal(12,2) unsigned");

                entity.Property(e => e.taked).HasColumnType("decimal(12,2) unsigned");

                entity.HasOne(d => d.id_boxNavigation)
                    .WithMany(p => p.treasury_shift_closings)
                    .HasForeignKey(d => d.id_box)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_treasury_shift_closings_2");

                entity.HasOne(d => d.id_shift_closing_typeNavigation)
                    .WithMany(p => p.treasury_shift_closings)
                    .HasForeignKey(d => d.id_shift_closing_type)
                    .HasConstraintName("treasury_shift_closings_FK");

                entity.HasOne(d => d.id_userNavigation)
                    .WithMany(p => p.treasury_shift_closings)
                    .HasForeignKey(d => d.id_user)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_treasury_shift_closings_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
