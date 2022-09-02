using System;
using System.Collections.Generic;
using ComCom_WebAPI.Models.DataPG;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class databasecomCom : DbContext
    {
        public databasecomCom()
        {
        }

        public databasecomCom(DbContextOptions<databasecomCom> options)
            : base(options)
        {
        }

        public virtual DbSet<auth_group> auth_group { get; set; } = null!;
        public virtual DbSet<auth_group_permissions> auth_group_permissions { get; set; } = null!;
        public virtual DbSet<auth_permission> auth_permission { get; set; } = null!;
        public virtual DbSet<auth_user> auth_user { get; set; } = null!;
        public virtual DbSet<auth_user_groups> auth_user_groups { get; set; } = null!;
        public virtual DbSet<auth_user_user_permissions> auth_user_user_permissions { get; set; } = null!;
        public virtual DbSet<bill> bill { get; set; } = null!;
        public virtual DbSet<business_client> business_client { get; set; } = null!;
        public virtual DbSet<change_service_history> change_service_history { get; set; } = null!;
        public virtual DbSet<client> client { get; set; } = null!;
        public virtual DbSet<client_error_disconnect> client_error_disconnect { get; set; } = null!;
        public virtual DbSet<client_historicalrmusers> client_historicalrmusers { get; set; } = null!;
        public virtual DbSet<client_localization> client_localization { get; set; } = null!;
        public virtual DbSet<client_wifi_credential> client_wifi_credential { get; set; } = null!;
        public virtual DbSet<configuration> configuration { get; set; } = null!;
        public virtual DbSet<contact> contact { get; set; } = null!;
        public virtual DbSet<coupon> coupon { get; set; } = null!;
        public virtual DbSet<deposit> deposit { get; set; } = null!;
        public virtual DbSet<deposit_credit> deposit_credit { get; set; } = null!;
        public virtual DbSet<deposit_debit> deposit_debit { get; set; } = null!;
        public virtual DbSet<digital_tax_receipt_online> digital_tax_receipt_online { get; set; } = null!;
        public virtual DbSet<django_admin_log> django_admin_log { get; set; } = null!;
        public virtual DbSet<django_content_type> django_content_type { get; set; } = null!;
        public virtual DbSet<django_migrations> django_migrations { get; set; } = null!;
        public virtual DbSet<django_session> django_session { get; set; } = null!;
        public virtual DbSet<employee_client> employee_client { get; set; } = null!;
        public virtual DbSet<file_imported_credit> file_imported_credit { get; set; } = null!;
        public virtual DbSet<file_report> file_report { get; set; } = null!;
        public virtual DbSet<group_business_client> group_business_client { get; set; } = null!;
        public virtual DbSet<group_business_client_fk_business_client> group_business_client_fk_business_client { get; set; } = null!;
        public virtual DbSet<manager_business_client> manager_business_client { get; set; } = null!;
        public virtual DbSet<oxxo_code> oxxo_code { get; set; } = null!;
        public virtual DbSet<price_list> price_list { get; set; } = null!;
        public virtual DbSet<reference_person> reference_person { get; set; } = null!;
        public virtual DbSet<residential_client> residential_client { get; set; } = null!;
        public virtual DbSet<service_status> service_status { get; set; } = null!;
        public virtual DbSet<temp_client> temp_client { get; set; } = null!;
        public virtual DbSet<tower_client> tower_client { get; set; } = null!;
        public virtual DbSet<type_debit_credit> type_debit_credit { get; set; } = null!;
        public virtual DbSet<unsubscribe_temp_client> unsubscribe_temp_client { get; set; } = null!;
        public virtual DbSet<vip_client> vip_client { get; set; } = null!;
        public virtual DbSet<voucher> voucher { get; set; } = null!;
        public virtual DbSet<voucher_fk_credits> voucher_fk_credits { get; set; } = null!;
        public virtual DbSet<way_pay> way_pay { get; set; } = null!;
        public virtual DbSet<webhook_response> webhook_response { get; set; } = null!;
        public virtual DbSet<zone> zone { get; set; } = null!;
        public virtual DbSet<zone_category> zone_category { get; set; } = null!;
        public virtual DbSet<zone_category_fk_zone> zone_category_fk_zone { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("ServicesDataPostgresql");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<auth_group>(entity =>
            {
                entity.HasIndex(e => e.name, "auth_group_name_a6ea08ec_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.name, "auth_group_name_key")
                    .IsUnique();

                entity.Property(e => e.name).HasMaxLength(150);
            });

            modelBuilder.Entity<auth_group_permissions>(entity =>
            {
                entity.HasIndex(e => e.group_id, "auth_group_permissions_group_id_b120cbf9");

                entity.HasIndex(e => new { e.group_id, e.permission_id }, "auth_group_permissions_group_id_permission_id_0cd325b0_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.permission_id, "auth_group_permissions_permission_id_84c5c92e");

                entity.HasOne(d => d.group)
                    .WithMany(p => p.auth_group_permissions)
                    .HasForeignKey(d => d.group_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_group_permissions_group_id_b120cbf9_fk_auth_group_id");

                entity.HasOne(d => d.permission)
                    .WithMany(p => p.auth_group_permissions)
                    .HasForeignKey(d => d.permission_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_group_permissio_permission_id_84c5c92e_fk_auth_perm");
            });

            modelBuilder.Entity<auth_permission>(entity =>
            {
                entity.HasIndex(e => e.content_type_id, "auth_permission_content_type_id_2f476e4b");

                entity.HasIndex(e => new { e.content_type_id, e.codename }, "auth_permission_content_type_id_codename_01ab375a_uniq")
                    .IsUnique();

                entity.Property(e => e.codename).HasMaxLength(100);

                entity.Property(e => e.name).HasMaxLength(255);

                entity.HasOne(d => d.content_type)
                    .WithMany(p => p.auth_permission)
                    .HasForeignKey(d => d.content_type_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_permission_content_type_id_2f476e4b_fk_django_co");
            });

            modelBuilder.Entity<auth_user>(entity =>
            {
                entity.HasIndex(e => e.username, "auth_user_username_6821ab7c_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.username, "auth_user_username_key")
                    .IsUnique();

                entity.Property(e => e.email).HasMaxLength(254);

                entity.Property(e => e.first_name).HasMaxLength(150);

                entity.Property(e => e.last_name).HasMaxLength(150);

                entity.Property(e => e.password).HasMaxLength(128);

                entity.Property(e => e.username).HasMaxLength(150);
            });

            modelBuilder.Entity<auth_user_groups>(entity =>
            {
                entity.HasIndex(e => e.group_id, "auth_user_groups_group_id_97559544");

                entity.HasIndex(e => e.user_id, "auth_user_groups_user_id_6a12ed8b");

                entity.HasIndex(e => new { e.user_id, e.group_id }, "auth_user_groups_user_id_group_id_94350c0c_uniq")
                    .IsUnique();

                entity.HasOne(d => d.group)
                    .WithMany(p => p.auth_user_groups)
                    .HasForeignKey(d => d.group_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_groups_group_id_97559544_fk_auth_group_id");

                entity.HasOne(d => d.user)
                    .WithMany(p => p.auth_user_groups)
                    .HasForeignKey(d => d.user_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_groups_user_id_6a12ed8b_fk_auth_user_id");
            });

            modelBuilder.Entity<auth_user_user_permissions>(entity =>
            {
                entity.HasIndex(e => e.permission_id, "auth_user_user_permissions_permission_id_1fbb5f2c");

                entity.HasIndex(e => e.user_id, "auth_user_user_permissions_user_id_a95ead1b");

                entity.HasIndex(e => new { e.user_id, e.permission_id }, "auth_user_user_permissions_user_id_permission_id_14a6b632_uniq")
                    .IsUnique();

                entity.HasOne(d => d.permission)
                    .WithMany(p => p.auth_user_user_permissions)
                    .HasForeignKey(d => d.permission_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_user_permi_permission_id_1fbb5f2c_fk_auth_perm");

                entity.HasOne(d => d.user)
                    .WithMany(p => p.auth_user_user_permissions)
                    .HasForeignKey(d => d.user_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_user_permissions_user_id_a95ead1b_fk_auth_user_id");
            });

            modelBuilder.Entity<bill>(entity =>
            {
                entity.Property(e => e.bill_number).HasMaxLength(12);

                entity.Property(e => e.client_name).HasMaxLength(255);
            });

            modelBuilder.Entity<business_client>(entity =>
            {
                entity.HasKey(e => e.client_ptr_id)
                    .HasName("business_client_pkey");

                entity.HasIndex(e => e.fk_manager_business_client_id, "business_client_fk_manager_business_client_id_63857d45");

                entity.Property(e => e.client_ptr_id).ValueGeneratedNever();

                entity.Property(e => e.business_name).HasMaxLength(255);

                entity.Property(e => e.business_type).HasMaxLength(150);

                entity.Property(e => e.commercial_name).HasMaxLength(255);

                entity.Property(e => e.fiscal_reference_number).HasMaxLength(255);

                entity.HasOne(d => d.client_ptr)
                    .WithOne(p => p.business_client)
                    .HasForeignKey<business_client>(d => d.client_ptr_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("business_client_client_ptr_id_e09148ac_fk_client_id");

                entity.HasOne(d => d.fk_manager_business_client)
                    .WithMany(p => p.business_client)
                    .HasForeignKey(d => d.fk_manager_business_client_id)
                    .HasConstraintName("business_client_fk_manager_business__63857d45_fk_manager_b");
            });

            modelBuilder.Entity<change_service_history>(entity =>
            {
                entity.Property(e => e.service).HasMaxLength(255);

                entity.Property(e => e.type_equivalent).HasMaxLength(100);

                entity.Property(e => e.username).HasMaxLength(255);
            });

            modelBuilder.Entity<client>(entity =>
            {
                entity.HasIndex(e => e.created_by_id, "client_created_by_id_ef61a462");

                entity.HasIndex(e => e.fk_deposit_id, "client_fk_deposit_id_44a09b6d");

                entity.HasIndex(e => e.fk_digital_tax_receipt_online_id, "client_fk_digital_tax_receipt_online_id_c037d020");

                entity.HasIndex(e => e.fk_price_list_id, "client_fk_price_list_id_2008b0e9");

                entity.HasIndex(e => e.fk_service_status_id, "client_fk_service_status_id_6e6ce374");

                entity.HasIndex(e => e.fk_way_pay_id, "client_fk_way_pay_id_cf36105f");

                entity.HasIndex(e => e.fk_zone_id, "client_fk_zone_id_26cd5ffc");

                entity.HasIndex(e => e.username, "client_username_d35806d0_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.username, "client_username_key")
                    .IsUnique();

                entity.Property(e => e.colony_fraction).HasMaxLength(255);

                entity.Property(e => e.contract_file).HasMaxLength(100);

                entity.Property(e => e.indoor_number).HasMaxLength(100);

                entity.Property(e => e.monitoring_status).HasMaxLength(150);

                entity.Property(e => e.outdoor_number).HasMaxLength(100);

                entity.Property(e => e.street).HasMaxLength(255);

                entity.Property(e => e.type).HasMaxLength(150);

                entity.Property(e => e.username).HasMaxLength(150);

                entity.HasOne(d => d.created_by)
                    .WithMany(p => p.client)
                    .HasForeignKey(d => d.created_by_id)
                    .HasConstraintName("client_created_by_id_ef61a462_fk_auth_user_id");

                entity.HasOne(d => d.fk_deposit)
                    .WithMany(p => p.client)
                    .HasForeignKey(d => d.fk_deposit_id)
                    .HasConstraintName("client_fk_deposit_id_44a09b6d_fk_deposit_id");

                entity.HasOne(d => d.fk_digital_tax_receipt_online)
                    .WithMany(p => p.client)
                    .HasForeignKey(d => d.fk_digital_tax_receipt_online_id)
                    .HasConstraintName("client_fk_digital_tax_recei_c037d020_fk_digital_t");

                entity.HasOne(d => d.fk_price_list)
                    .WithMany(p => p.client)
                    .HasForeignKey(d => d.fk_price_list_id)
                    .HasConstraintName("client_fk_price_list_id_2008b0e9_fk_price_list_id");

                entity.HasOne(d => d.fk_service_status)
                    .WithMany(p => p.client)
                    .HasForeignKey(d => d.fk_service_status_id)
                    .HasConstraintName("client_fk_service_status_id_6e6ce374_fk_service_status_id");

                entity.HasOne(d => d.fk_way_pay)
                    .WithMany(p => p.client)
                    .HasForeignKey(d => d.fk_way_pay_id)
                    .HasConstraintName("client_fk_way_pay_id_cf36105f_fk_way_pay_id");

                entity.HasOne(d => d.fk_zone)
                    .WithMany(p => p.client)
                    .HasForeignKey(d => d.fk_zone_id)
                    .HasConstraintName("client_fk_zone_id_26cd5ffc_fk_zone_id");
            });

            modelBuilder.Entity<client_historicalrmusers>(entity =>
            {
                entity.HasKey(e => e.history_id)
                    .HasName("client_historicalrmusers_pkey");

                entity.HasIndex(e => e.history_user_id, "client_historicalrmusers_history_user_id_6f51ed33");

                entity.HasIndex(e => e.username, "client_historicalrmusers_username_48962ef5");

                entity.HasIndex(e => e.username, "client_historicalrmusers_username_48962ef5_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.Property(e => e.actcode).HasMaxLength(60);

                entity.Property(e => e.address).HasMaxLength(100);

                entity.Property(e => e.city).HasMaxLength(50);

                entity.Property(e => e.cnic).HasMaxLength(13);

                entity.Property(e => e.comment).HasMaxLength(500);

                entity.Property(e => e.company).HasMaxLength(50);

                entity.Property(e => e.contractid).HasMaxLength(50);

                entity.Property(e => e.country).HasMaxLength(50);

                entity.Property(e => e.createdby).HasMaxLength(64);

                entity.Property(e => e.credits).HasPrecision(20, 2);

                entity.Property(e => e.custattr).HasMaxLength(10240);

                entity.Property(e => e.email).HasMaxLength(100);

                entity.Property(e => e.firstname).HasMaxLength(50);

                entity.Property(e => e.gpslat).HasPrecision(17, 14);

                entity.Property(e => e.gpslong).HasPrecision(17, 14);

                entity.Property(e => e.history_change_reason).HasMaxLength(100);

                entity.Property(e => e.history_type).HasMaxLength(1);

                entity.Property(e => e.lang).HasMaxLength(30);

                entity.Property(e => e.lastname).HasMaxLength(50);

                entity.Property(e => e.mac).HasMaxLength(17);

                entity.Property(e => e.maccm).HasMaxLength(17);

                entity.Property(e => e.mobile).HasMaxLength(15);

                entity.Property(e => e.owner).HasMaxLength(64);

                entity.Property(e => e.password).HasMaxLength(32);

                entity.Property(e => e.phone).HasMaxLength(15);

                entity.Property(e => e.state).HasMaxLength(50);

                entity.Property(e => e.staticipcm).HasMaxLength(15);

                entity.Property(e => e.staticipcpe).HasMaxLength(15);

                entity.Property(e => e.taxid).HasMaxLength(40);

                entity.Property(e => e.username).HasMaxLength(64);

                entity.Property(e => e.verifycode).HasMaxLength(10);

                entity.Property(e => e.verifymobile).HasMaxLength(15);

                entity.Property(e => e.zip).HasMaxLength(8);

                entity.HasOne(d => d.history_user)
                    .WithMany(p => p.client_historicalrmusers)
                    .HasForeignKey(d => d.history_user_id)
                    .HasConstraintName("client_historicalrmu_history_user_id_6f51ed33_fk_auth_user");
            });

            modelBuilder.Entity<client_localization>(entity =>
            {
                entity.HasIndex(e => e.fk_client_id, "client_localization_fk_client_id_key")
                    .IsUnique();

                entity.Property(e => e.coordinates).HasMaxLength(255);

                entity.HasOne(d => d.fk_client)
                    .WithOne(p => p.client_localization)
                    .HasForeignKey<client_localization>(d => d.fk_client_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("client_localization_fk_client_id_6365a02d_fk_client_id");
            });

            modelBuilder.Entity<configuration>(entity =>
            {
                entity.Property(e => e.value).HasMaxLength(255);
            });

            modelBuilder.Entity<contact>(entity =>
            {
                entity.HasIndex(e => e.fk_client_id, "contact_fk_client_id_cd500ad9");

                entity.Property(e => e.owner).HasMaxLength(150);

                entity.Property(e => e.type).HasMaxLength(150);

                entity.HasOne(d => d.fk_client)
                    .WithMany(p => p.contact)
                    .HasForeignKey(d => d.fk_client_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contact_fk_client_id_cd500ad9_fk_client_id");
            });

            modelBuilder.Entity<coupon>(entity =>
            {
                entity.HasIndex(e => e.fk_client_id, "coupon_fk_client_id_180fd76a");

                entity.Property(e => e.status).HasMaxLength(150);

                entity.Property(e => e.type).HasMaxLength(150);

                entity.HasOne(d => d.fk_client)
                    .WithMany(p => p.coupon)
                    .HasForeignKey(d => d.fk_client_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("coupon_fk_client_id_180fd76a_fk_client_wifi_credential_id");
            });

            modelBuilder.Entity<deposit_credit>(entity =>
            {
                entity.HasIndex(e => e.created_by_id, "deposit_credit_created_by_id_5646be96");

                entity.HasIndex(e => e.fk_deposit_id, "deposit_credit_fk_deposit_id_b6fd6fc8");

                entity.HasIndex(e => e.fk_type_credit_id, "deposit_credit_fk_type_credit_id_70a26622");

                entity.Property(e => e.payment_concepts).HasMaxLength(150);

                entity.HasOne(d => d.created_by)
                    .WithMany(p => p.deposit_credit)
                    .HasForeignKey(d => d.created_by_id)
                    .HasConstraintName("deposit_credit_created_by_id_5646be96_fk_auth_user_id");

                entity.HasOne(d => d.fk_deposit)
                    .WithMany(p => p.deposit_credit)
                    .HasForeignKey(d => d.fk_deposit_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deposit_credit_fk_deposit_id_b6fd6fc8_fk_deposit_id");

                entity.HasOne(d => d.fk_type_credit)
                    .WithMany(p => p.deposit_credit)
                    .HasForeignKey(d => d.fk_type_credit_id)
                    .HasConstraintName("deposit_credit_fk_type_credit_id_70a26622_fk_type_debi");
            });

            modelBuilder.Entity<deposit_debit>(entity =>
            {
                entity.HasIndex(e => e.created_by_id, "deposit_debit_created_by_id_edf6f7be");

                entity.HasIndex(e => e.fk_bill_id, "deposit_debit_fk_bill_id_ec2d7a22");

                entity.HasIndex(e => e.fk_deposit_id, "deposit_debit_fk_deposit_id_78c1c019");

                entity.HasIndex(e => e.fk_type_debit_id, "deposit_debit_fk_type_debit_id_8053c6e8");

                entity.Property(e => e.key).HasMaxLength(255);

                entity.HasOne(d => d.created_by)
                    .WithMany(p => p.deposit_debit)
                    .HasForeignKey(d => d.created_by_id)
                    .HasConstraintName("deposit_debit_created_by_id_edf6f7be_fk_auth_user_id");

                entity.HasOne(d => d.fk_bill)
                    .WithMany(p => p.deposit_debit)
                    .HasForeignKey(d => d.fk_bill_id)
                    .HasConstraintName("deposit_debit_fk_bill_id_ec2d7a22_fk_bill_id");

                entity.HasOne(d => d.fk_deposit)
                    .WithMany(p => p.deposit_debit)
                    .HasForeignKey(d => d.fk_deposit_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deposit_debit_fk_deposit_id_78c1c019_fk_deposit_id");

                entity.HasOne(d => d.fk_type_debit)
                    .WithMany(p => p.deposit_debit)
                    .HasForeignKey(d => d.fk_type_debit_id)
                    .HasConstraintName("deposit_debit_fk_type_debit_id_8053c6e8_fk_type_debit_credit_id");
            });

            modelBuilder.Entity<digital_tax_receipt_online>(entity =>
            {
                entity.Property(e => e.value).HasMaxLength(255);
            });

            modelBuilder.Entity<django_admin_log>(entity =>
            {
                entity.HasIndex(e => e.content_type_id, "django_admin_log_content_type_id_c4bce8eb");

                entity.HasIndex(e => e.user_id, "django_admin_log_user_id_c564eba6");

                entity.Property(e => e.object_repr).HasMaxLength(200);

                entity.HasOne(d => d.content_type)
                    .WithMany(p => p.django_admin_log)
                    .HasForeignKey(d => d.content_type_id)
                    .HasConstraintName("django_admin_log_content_type_id_c4bce8eb_fk_django_co");

                entity.HasOne(d => d.user)
                    .WithMany(p => p.django_admin_log)
                    .HasForeignKey(d => d.user_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("django_admin_log_user_id_c564eba6_fk_auth_user_id");
            });

            modelBuilder.Entity<django_content_type>(entity =>
            {
                entity.HasIndex(e => new { e.app_label, e.model }, "django_content_type_app_label_model_76bd3d3b_uniq")
                    .IsUnique();

                entity.Property(e => e.app_label).HasMaxLength(100);

                entity.Property(e => e.model).HasMaxLength(100);
            });

            modelBuilder.Entity<django_migrations>(entity =>
            {
                entity.Property(e => e.app).HasMaxLength(255);

                entity.Property(e => e.name).HasMaxLength(255);
            });

            modelBuilder.Entity<django_session>(entity =>
            {
                entity.HasKey(e => e.session_key)
                    .HasName("django_session_pkey");

                entity.HasIndex(e => e.expire_date, "django_session_expire_date_a5c62663");

                entity.HasIndex(e => e.session_key, "django_session_session_key_c0390e0f_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.Property(e => e.session_key).HasMaxLength(40);
            });

            modelBuilder.Entity<employee_client>(entity =>
            {
                entity.HasKey(e => e.client_ptr_id)
                    .HasName("employee_client_pkey");

                entity.Property(e => e.client_ptr_id).ValueGeneratedNever();

                entity.HasOne(d => d.client_ptr)
                    .WithOne(p => p.employee_client)
                    .HasForeignKey<employee_client>(d => d.client_ptr_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employee_client_client_ptr_id_75700b23_fk_client_id");
            });

            modelBuilder.Entity<file_imported_credit>(entity =>
            {
                entity.HasIndex(e => e.created_by_id, "file_imported_credit_created_by_id_8f845bcf");

                entity.HasIndex(e => e.imported_file, "file_imported_credit_imported_file_de0fcdf1_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.imported_file, "file_imported_credit_imported_file_key")
                    .IsUnique();

                entity.Property(e => e.imported_file).HasMaxLength(100);

                entity.HasOne(d => d.created_by)
                    .WithMany(p => p.file_imported_credit)
                    .HasForeignKey(d => d.created_by_id)
                    .HasConstraintName("file_imported_credit_created_by_id_8f845bcf_fk_auth_user_id");
            });

            modelBuilder.Entity<file_report>(entity =>
            {
                entity.Property(e => e.created_by).HasMaxLength(255);

                entity.Property(e => e.imported_file).HasMaxLength(255);

                entity.Property(e => e.type).HasMaxLength(150);
            });

            modelBuilder.Entity<group_business_client>(entity =>
            {
                entity.Property(e => e.name).HasMaxLength(255);
            });

            modelBuilder.Entity<group_business_client_fk_business_client>(entity =>
            {
                entity.HasIndex(e => e.businessclient_id, "group_business_client_fk_b_businessclient_id_f2c5e560");

                entity.HasIndex(e => e.groupbusinessclient_id, "group_business_client_fk_b_groupbusinessclient_id_9b231d3e");

                entity.HasIndex(e => new { e.groupbusinessclient_id, e.businessclient_id }, "group_business_client_fk_groupbusinessclient_id_b_a25fc89b_uniq")
                    .IsUnique();

                entity.HasOne(d => d.businessclient)
                    .WithMany(p => p.group_business_client_fk_business_client)
                    .HasForeignKey(d => d.businessclient_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("group_business_clien_businessclient_id_f2c5e560_fk_business_");

                entity.HasOne(d => d.groupbusinessclient)
                    .WithMany(p => p.group_business_client_fk_business_client)
                    .HasForeignKey(d => d.groupbusinessclient_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("group_business_clien_groupbusinessclient__9b231d3e_fk_group_bus");
            });

            modelBuilder.Entity<manager_business_client>(entity =>
            {
                entity.HasIndex(e => e.fk_deposit_manager_id, "manager_business_client_fk_deposit_manager_id_afff9172");

                entity.Property(e => e.name).HasMaxLength(255);

                entity.HasOne(d => d.fk_deposit_manager)
                    .WithMany(p => p.manager_business_client)
                    .HasForeignKey(d => d.fk_deposit_manager_id)
                    .HasConstraintName("manager_business_cli_fk_deposit_manager_i_afff9172_fk_deposit_i");
            });

            modelBuilder.Entity<oxxo_code>(entity =>
            {
                entity.HasIndex(e => e.fk_client_id, "oxxo_code_fk_client_id_a4a0fe79");

                entity.Property(e => e.code).HasMaxLength(255);

                entity.HasOne(d => d.fk_client)
                    .WithMany(p => p.oxxo_code)
                    .HasForeignKey(d => d.fk_client_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("oxxo_code_fk_client_id_a4a0fe79_fk_client_wifi_credential_id");
            });

            modelBuilder.Entity<price_list>(entity =>
            {
                entity.HasIndex(e => e.fk_zone_id, "price_list_fk_zone_id_932e8888");

                entity.Property(e => e.name).HasMaxLength(255);

                entity.HasOne(d => d.fk_zone)
                    .WithMany(p => p.price_list)
                    .HasForeignKey(d => d.fk_zone_id)
                    .HasConstraintName("price_list_fk_zone_id_932e8888_fk_zone_id");
            });

            modelBuilder.Entity<reference_person>(entity =>
            {
                entity.HasIndex(e => e.fk_residential_client_id, "reference_person_fk_residential_client_id_cbbfa19e");

                entity.Property(e => e.full_name).HasMaxLength(255);

                entity.Property(e => e.phone_number).HasMaxLength(150);

                entity.Property(e => e.relationship).HasMaxLength(150);

                entity.HasOne(d => d.fk_residential_client)
                    .WithMany(p => p.reference_person)
                    .HasForeignKey(d => d.fk_residential_client_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reference_person_fk_residential_clien_cbbfa19e_fk_residenti");
            });

            modelBuilder.Entity<residential_client>(entity =>
            {
                entity.HasKey(e => e.client_ptr_id)
                    .HasName("residential_client_pkey");

                entity.Property(e => e.client_ptr_id).ValueGeneratedNever();

                entity.Property(e => e.barcode).HasMaxLength(100);

                entity.Property(e => e.proof_address_file).HasMaxLength(100);

                entity.HasOne(d => d.client_ptr)
                    .WithOne(p => p.residential_client)
                    .HasForeignKey<residential_client>(d => d.client_ptr_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("residential_client_client_ptr_id_06a2da39_fk_client_id");
            });

            modelBuilder.Entity<service_status>(entity =>
            {
                entity.Property(e => e.value).HasMaxLength(255);
            });

            modelBuilder.Entity<temp_client>(entity =>
            {
                entity.HasKey(e => e.client_ptr_id)
                    .HasName("temp_client_pkey");

                entity.Property(e => e.client_ptr_id).ValueGeneratedNever();

                entity.HasOne(d => d.client_ptr)
                    .WithOne(p => p.temp_client)
                    .HasForeignKey<temp_client>(d => d.client_ptr_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("temp_client_client_ptr_id_3a9e1c68_fk_client_id");
            });

            modelBuilder.Entity<tower_client>(entity =>
            {
                entity.HasKey(e => e.client_ptr_id)
                    .HasName("tower_client_pkey");

                entity.Property(e => e.client_ptr_id).ValueGeneratedNever();

                entity.HasOne(d => d.client_ptr)
                    .WithOne(p => p.tower_client)
                    .HasForeignKey<tower_client>(d => d.client_ptr_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tower_client_client_ptr_id_d0bfc98c_fk_client_id");
            });

            modelBuilder.Entity<type_debit_credit>(entity =>
            {
                entity.Property(e => e.key).HasMaxLength(150);

                entity.Property(e => e.type).HasMaxLength(150);

                entity.Property(e => e.value).HasMaxLength(255);
            });

            modelBuilder.Entity<unsubscribe_temp_client>(entity =>
            {
                entity.HasIndex(e => e.username, "unsubscribe_temp_client_username_bc4a1dff_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.username, "unsubscribe_temp_client_username_key")
                    .IsUnique();

                entity.Property(e => e.address).HasMaxLength(100);

                entity.Property(e => e.firstname).HasMaxLength(50);

                entity.Property(e => e.lastname).HasMaxLength(50);

                entity.Property(e => e.mobile).HasMaxLength(15);

                entity.Property(e => e.phone).HasMaxLength(15);

                entity.Property(e => e.username).HasMaxLength(150);
            });

            modelBuilder.Entity<vip_client>(entity =>
            {
                entity.HasKey(e => e.client_ptr_id)
                    .HasName("vip_client_pkey");

                entity.Property(e => e.client_ptr_id).ValueGeneratedNever();

                entity.HasOne(d => d.client_ptr)
                    .WithOne(p => p.vip_client)
                    .HasForeignKey<vip_client>(d => d.client_ptr_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vip_client_client_ptr_id_512fcff1_fk_client_id");
            });

            modelBuilder.Entity<voucher>(entity =>
            {
                entity.HasIndex(e => e.created_by_id, "voucher_created_by_id_83747f56");

                entity.HasIndex(e => e.fk_client_id, "voucher_fk_client_id_d5d49e18");

                entity.Property(e => e.code).HasMaxLength(255);

                entity.HasOne(d => d.created_by)
                    .WithMany(p => p.voucher)
                    .HasForeignKey(d => d.created_by_id)
                    .HasConstraintName("voucher_created_by_id_83747f56_fk_auth_user_id");

                entity.HasOne(d => d.fk_client)
                    .WithMany(p => p.voucher)
                    .HasForeignKey(d => d.fk_client_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("voucher_fk_client_id_d5d49e18_fk_client_id");
            });

            modelBuilder.Entity<voucher_fk_credits>(entity =>
            {
                entity.HasIndex(e => e.depositcredit_id, "voucher_fk_credits_depositcredit_id_ad87dcfa");

                entity.HasIndex(e => e.voucher_id, "voucher_fk_credits_voucher_id_2dc796ae");

                entity.HasIndex(e => new { e.voucher_id, e.depositcredit_id }, "voucher_fk_credits_voucher_id_depositcredit_id_961225b1_uniq")
                    .IsUnique();

                entity.HasOne(d => d.depositcredit)
                    .WithMany(p => p.voucher_fk_credits)
                    .HasForeignKey(d => d.depositcredit_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("voucher_fk_credits_depositcredit_id_ad87dcfa_fk_deposit_c");

                entity.HasOne(d => d.voucher)
                    .WithMany(p => p.voucher_fk_credits)
                    .HasForeignKey(d => d.voucher_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("voucher_fk_credits_voucher_id_2dc796ae_fk_voucher_id");
            });

            modelBuilder.Entity<way_pay>(entity =>
            {
                entity.Property(e => e.value).HasMaxLength(255);
            });

            modelBuilder.Entity<webhook_response>(entity =>
            {
                entity.Property(e => e.code).HasMaxLength(255);

                entity.Property(e => e.type).HasMaxLength(150);
            });

            modelBuilder.Entity<zone>(entity =>
            {
                entity.Property(e => e.name).HasMaxLength(255);
            });

            modelBuilder.Entity<zone_category>(entity =>
            {
                entity.Property(e => e.name).HasMaxLength(30);

                entity.Property(e => e.type).HasMaxLength(255);
            });

            modelBuilder.Entity<zone_category_fk_zone>(entity =>
            {
                entity.HasIndex(e => e.zone_id, "zone_category_fk_zone_zone_id_ca5787a8");

                entity.HasIndex(e => e.zonecategory_id, "zone_category_fk_zone_zonecategory_id_edd5eaa3");

                entity.HasIndex(e => new { e.zonecategory_id, e.zone_id }, "zone_category_fk_zone_zonecategory_id_zone_id_9d2613ad_uniq")
                    .IsUnique();

                entity.HasOne(d => d.zone)
                    .WithMany(p => p.zone_category_fk_zone)
                    .HasForeignKey(d => d.zone_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("zone_category_fk_zone_zone_id_ca5787a8_fk_zone_id");

                entity.HasOne(d => d.zonecategory)
                    .WithMany(p => p.zone_category_fk_zone)
                    .HasForeignKey(d => d.zonecategory_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("zone_category_fk_zon_zonecategory_id_edd5eaa3_fk_zone_cate");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
