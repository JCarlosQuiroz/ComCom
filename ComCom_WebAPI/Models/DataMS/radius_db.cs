using System;
using System.Collections.Generic;
using ComCom_WebAPI.Models.DataMS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class radius_db : DbContext
    {
        public radius_db()
        {
        }

        public radius_db(DbContextOptions<radius_db> options)
            : base(options)
        {
        }

        public virtual DbSet<nas> Nas { get; set; } = null!;
        public virtual DbSet<radacct> Radacct { get; set; } = null!;
        public virtual DbSet<radcheck> Radcheck { get; set; } = null!;
        public virtual DbSet<radgroupcheck> Radgroupcheck { get; set; } = null!;
        public virtual DbSet<radgroupreply> Radgroupreply { get; set; } = null!;
        public virtual DbSet<radippool> Radippool { get; set; } = null!;
        public virtual DbSet<radpostauth> Radpostauth { get; set; } = null!;
        public virtual DbSet<radreply> Radreply { get; set; } = null!;
        public virtual DbSet<radusergroup> Radusergroup { get; set; } = null!;
        public virtual DbSet<rm_actsrv> Rm_actsrv { get; set; } = null!;
        public virtual DbSet<rm_allowedmanagers> Rm_allowedmanagers { get; set; } = null!;
        public virtual DbSet<rm_allowednases> Rm_allowednases { get; set; } = null!;
        public virtual DbSet<rm_ap> Rm_ap { get; set; } = null!;
        public virtual DbSet<rm_cards> Rm_cards { get; set; } = null!;
        public virtual DbSet<rm_changesrv> Rm_changesrv { get; set; } = null!;
        public virtual DbSet<rm_cmts> Rm_cmts { get; set; } = null!;
        public virtual DbSet<rm_colsetlistdocsis> Rm_colsetlistdocsis { get; set; } = null!;
        public virtual DbSet<rm_colsetlistradius> Rm_colsetlistradius { get; set; } = null!;
        public virtual DbSet<rm_colsetlistusers> Rm_colsetlistusers { get; set; } = null!;
        public virtual DbSet<rm_dailyacct> Rm_dailyacct { get; set; } = null!;
        public virtual DbSet<rm_ias> Rm_ias { get; set; } = null!;
        public virtual DbSet<rm_invoices> Rm_invoices { get; set; } = null!;
        public virtual DbSet<rm_ippools> Rm_ippools { get; set; } = null!;
        public virtual DbSet<rm_managers> Rm_managers { get; set; } = null!;
        public virtual DbSet<rm_newusers> Rm_newusers { get; set; } = null!;
        public virtual DbSet<rm_onlinecm> Rm_onlinecm { get; set; } = null!;
        public virtual DbSet<rm_phpsess> Rm_phpsess { get; set; } = null!;
        public virtual DbSet<rm_radacct> Rm_radacct { get; set; } = null!;
        public virtual DbSet<rm_services> Rm_services { get; set; } = null!;
        public virtual DbSet<rm_settings> Rm_settings { get; set; } = null!;
        public virtual DbSet<rm_specperacnt> Rm_specperacnt { get; set; } = null!;
        public virtual DbSet<rm_specperbw> Rm_specperbw { get; set; } = null!;
        public virtual DbSet<rm_syslog> Rm_syslog { get; set; } = null!;
        public virtual DbSet<rm_usergroups> Rm_usergroups { get; set; } = null!;
        public virtual DbSet<rm_users> Rm_users { get; set; } = null!;
        public virtual DbSet<rm_wlan> Rm_wlan { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=database_radius;username=root;password=Temporal9713@", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.24-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<nas>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.nasname, "nasname");

                entity.Property(e => e.apipassword).HasMaxLength(32);

                entity.Property(e => e.apiusername).HasMaxLength(32);

                entity.Property(e => e.community).HasMaxLength(50);

                entity.Property(e => e.description)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("'RADIUS Client'");

                entity.Property(e => e.nasname).HasMaxLength(128);

                entity.Property(e => e.secret)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'secret'");

                entity.Property(e => e.shortname).HasMaxLength(32);

                entity.Property(e => e.starospassword).HasMaxLength(32);

                entity.Property(e => e.type)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'other'");
            });

            modelBuilder.Entity<radacct>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e._accttime, "_AcctTime");

                entity.HasIndex(e => e.acctsessionid, "acctsessionid");

                entity.HasIndex(e => e.acctsessiontime, "acctsessiontime");

                entity.HasIndex(e => e.acctstarttime, "acctstarttime");

                entity.HasIndex(e => e.acctstoptime, "acctstoptime");

                entity.HasIndex(e => e.acctuniqueid, "acctuniqueid");

                entity.HasIndex(e => e.callingstationid, "callingstationid");

                entity.HasIndex(e => e.framedipaddress, "framedipaddress");

                entity.HasIndex(e => e.nasipaddress, "nasipaddress");

                entity.HasIndex(e => e.username, "username");

                entity.Property(e => e._accttime).HasColumnType("datetime");

                entity.Property(e => e.acctauthentic).HasMaxLength(32);

                entity.Property(e => e.acctsessionid)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.acctstarttime).HasColumnType("datetime");

                entity.Property(e => e.acctstoptime).HasColumnType("datetime");

                entity.Property(e => e.acctterminatecause)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.acctuniqueid)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.calledstationid)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.callingstationid)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.connectinfo_start).HasMaxLength(50);

                entity.Property(e => e.connectinfo_stop).HasMaxLength(50);

                entity.Property(e => e.framedipaddress)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.framedprotocol).HasMaxLength(32);

                entity.Property(e => e.groupname)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.nasipaddress)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.nasportid).HasMaxLength(15);

                entity.Property(e => e.nasporttype).HasMaxLength(32);

                entity.Property(e => e.realm)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.servicetype).HasMaxLength(32);

                entity.Property(e => e.username)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.xascendsessionsvrkey).HasMaxLength(10);
            });

            modelBuilder.Entity<radcheck>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.username, "username");

                entity.Property(e => e.attribute)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.op)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("'=='")
                    .IsFixedLength();

                entity.Property(e => e.username)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.value)
                    .HasMaxLength(253)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<radgroupcheck>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.groupname, "groupname");

                entity.Property(e => e.attribute)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.groupname)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.op)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("'=='")
                    .IsFixedLength();

                entity.Property(e => e.value)
                    .HasMaxLength(253)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<radgroupreply>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.groupname, "groupname");

                entity.Property(e => e.attribute)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.groupname)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.op)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("'='")
                    .IsFixedLength();

                entity.Property(e => e.value)
                    .HasMaxLength(253)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<radippool>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.calledstationid).HasMaxLength(30);

                entity.Property(e => e.callingstationid).HasMaxLength(30);

                entity.Property(e => e.expiry_time).HasColumnType("datetime");

                entity.Property(e => e.framedipaddress).HasMaxLength(15);

                entity.Property(e => e.nasipaddress).HasMaxLength(15);

                entity.Property(e => e.pool_key).HasMaxLength(30);

                entity.Property(e => e.pool_name).HasMaxLength(30);

                entity.Property(e => e.username).HasMaxLength(64);
            });

            modelBuilder.Entity<radpostauth>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.authdate, "authdate");

                entity.HasIndex(e => e.nasipaddress, "nasipaddress");

                entity.HasIndex(e => e.username, "username");

                entity.Property(e => e.authdate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.nasipaddress).HasMaxLength(15);

                entity.Property(e => e.pass)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.reply)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.username)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<radreply>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.username, "username");

                entity.Property(e => e.attribute)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.op)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("'='")
                    .IsFixedLength();

                entity.Property(e => e.username)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.value)
                    .HasMaxLength(253)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<radusergroup>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.username, "username");

                entity.Property(e => e.groupname)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.priority).HasDefaultValueSql("'1'");

                entity.Property(e => e.username)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<rm_actsrv>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.datetime, "datetime");

                entity.HasIndex(e => e.id, "id")
                    .IsUnique();

                entity.HasIndex(e => e.username, "username");

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.id).ValueGeneratedOnAdd();

                entity.Property(e => e.username).HasMaxLength(64);
            });

            modelBuilder.Entity<rm_allowedmanagers>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.managername, "managername");

                entity.HasIndex(e => e.srvid, "srvid");

                entity.Property(e => e.managername).HasMaxLength(64);
            });

            modelBuilder.Entity<rm_allowednases>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.nasid, "nasid");

                entity.HasIndex(e => e.srvid, "srvid");
            });

            modelBuilder.Entity<rm_ap>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.ip, "ip");

                entity.Property(e => e.apipassword).HasMaxLength(32);

                entity.Property(e => e.apiusername).HasMaxLength(32);

                entity.Property(e => e.community).HasMaxLength(32);

                entity.Property(e => e.description).HasMaxLength(200);

                entity.Property(e => e.ip).HasMaxLength(15);

                entity.Property(e => e.name).HasMaxLength(32);
            });

            modelBuilder.Entity<rm_cards>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.cardnum, "cardnum")
                    .IsUnique();

                entity.HasIndex(e => e.owner, "owner");

                entity.HasIndex(e => e.series, "series");

                entity.HasIndex(e => e.used, "used");

                entity.Property(e => e.id).ValueGeneratedNever();

                entity.Property(e => e.cardnum).HasMaxLength(16);

                entity.Property(e => e.owner).HasMaxLength(64);

                entity.Property(e => e.password).HasMaxLength(8);

                entity.Property(e => e.series).HasMaxLength(16);

                entity.Property(e => e.transid).HasMaxLength(32);

                entity.Property(e => e.used).HasColumnType("datetime");

                entity.Property(e => e.value).HasPrecision(22, 2);
            });

            modelBuilder.Entity<rm_changesrv>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.requestdate, "requestdate");

                entity.HasIndex(e => e.scheduledate, "scheduledate");

                entity.Property(e => e.newsrvname).HasMaxLength(50);

                entity.Property(e => e.requested).HasMaxLength(64);

                entity.Property(e => e.transid).HasMaxLength(32);

                entity.Property(e => e.username).HasMaxLength(64);
            });

            modelBuilder.Entity<rm_cmts>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.ip, "ip");

                entity.Property(e => e.community).HasMaxLength(32);

                entity.Property(e => e.descr).HasMaxLength(200);

                entity.Property(e => e.ip).HasMaxLength(15);

                entity.Property(e => e.name).HasMaxLength(32);
            });

            modelBuilder.Entity<rm_colsetlistdocsis>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.managername, "managername");

                entity.Property(e => e.colname).HasMaxLength(32);

                entity.Property(e => e.managername).HasMaxLength(64);
            });

            modelBuilder.Entity<rm_colsetlistradius>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.managername, "managername");

                entity.Property(e => e.colname).HasMaxLength(32);

                entity.Property(e => e.managername).HasMaxLength(64);
            });

            modelBuilder.Entity<rm_colsetlistusers>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.managername, "managername");

                entity.Property(e => e.colname).HasMaxLength(32);

                entity.Property(e => e.managername).HasMaxLength(64);
            });

            modelBuilder.Entity<rm_dailyacct>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.acctuniqueid, "acctuniqueid");

                entity.HasIndex(e => e.radacctid, "radacctid");

                entity.HasIndex(e => e.username, "username");

                entity.Property(e => e.acctstarttime).HasColumnType("datetime");

                entity.Property(e => e.acctstoptime).HasColumnType("datetime");

                entity.Property(e => e.acctuniqueid).HasMaxLength(32);

                entity.Property(e => e.username).HasMaxLength(64);
            });

            modelBuilder.Entity<rm_ias>(entity =>
            {
                entity.HasKey(e => e.iasid)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.iasname).HasMaxLength(50);

                entity.Property(e => e.price).HasPrecision(20, 2);
            });

            modelBuilder.Entity<rm_invoices>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.comment, "comment");

                entity.HasIndex(e => e.date, "date");

                entity.HasIndex(e => e.gwtransid, "gwtransid");

                entity.HasIndex(e => e.invgroup, "invgroup");

                entity.HasIndex(e => e.invnum, "invnum");

                entity.HasIndex(e => e.managername, "managername");

                entity.HasIndex(e => e.paid, "paid");

                entity.HasIndex(e => e.paymode, "paymode");

                entity.HasIndex(e => e.username, "username");

                entity.Property(e => e.address).HasMaxLength(50);

                entity.Property(e => e.advtax).HasPrecision(25, 6);

                entity.Property(e => e.advtaxpercent).HasPrecision(4, 2);

                entity.Property(e => e.amount).HasPrecision(13, 2);

                entity.Property(e => e.balance).HasPrecision(20, 2);

                entity.Property(e => e.city).HasMaxLength(50);

                entity.Property(e => e.comment).HasMaxLength(200);

                entity.Property(e => e.country).HasMaxLength(50);

                entity.Property(e => e.fullname).HasMaxLength(100);

                entity.Property(e => e.invnum).HasMaxLength(16);

                entity.Property(e => e.managername).HasMaxLength(64);

                entity.Property(e => e.mobile).HasMaxLength(15);

                entity.Property(e => e.phone).HasMaxLength(15);

                entity.Property(e => e.price).HasPrecision(25, 6);

                entity.Property(e => e.remark).HasMaxLength(400);

                entity.Property(e => e.service).HasMaxLength(60);

                entity.Property(e => e.state).HasMaxLength(50);

                entity.Property(e => e.tax).HasPrecision(25, 6);

                entity.Property(e => e.taxid).HasMaxLength(40);

                entity.Property(e => e.transid).HasMaxLength(32);

                entity.Property(e => e.username).HasMaxLength(64);

                entity.Property(e => e.vatpercent).HasPrecision(4, 2);

                entity.Property(e => e.zip).HasMaxLength(8);
            });

            modelBuilder.Entity<rm_ippools>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.name, "name");

                entity.HasIndex(e => e.nextpoolid, "nextid");

                entity.Property(e => e.descr).HasMaxLength(200);

                entity.Property(e => e.fromip).HasMaxLength(15);

                entity.Property(e => e.name).HasMaxLength(32);

                entity.Property(e => e.toip).HasMaxLength(15);
            });

            modelBuilder.Entity<rm_managers>(entity =>
            {
                entity.HasKey(e => e.managername)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.managername).HasMaxLength(64);

                entity.Property(e => e.address).HasMaxLength(50);

                entity.Property(e => e.balance).HasPrecision(20, 2);

                entity.Property(e => e.city).HasMaxLength(50);

                entity.Property(e => e.comment).HasMaxLength(200);

                entity.Property(e => e.company).HasMaxLength(50);

                entity.Property(e => e.country).HasMaxLength(50);

                entity.Property(e => e.email).HasMaxLength(50);

                entity.Property(e => e.firstname).HasMaxLength(50);

                entity.Property(e => e.lang).HasMaxLength(30);

                entity.Property(e => e.lastname).HasMaxLength(50);

                entity.Property(e => e.mobile).HasMaxLength(15);

                entity.Property(e => e.password).HasMaxLength(32);

                entity.Property(e => e.phone).HasMaxLength(15);

                entity.Property(e => e.state).HasMaxLength(50);

                entity.Property(e => e.vatid).HasMaxLength(40);

                entity.Property(e => e.zip).HasMaxLength(8);
            });

            modelBuilder.Entity<rm_newusers>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.actcode).HasMaxLength(10);

                entity.Property(e => e.address).HasMaxLength(100);

                entity.Property(e => e.city).HasMaxLength(50);

                entity.Property(e => e.country).HasMaxLength(50);

                entity.Property(e => e.email).HasMaxLength(100);

                entity.Property(e => e.firstname).HasMaxLength(50);

                entity.Property(e => e.lang).HasMaxLength(30);

                entity.Property(e => e.lastname).HasMaxLength(50);

                entity.Property(e => e.mobile).HasMaxLength(15);

                entity.Property(e => e.phone).HasMaxLength(15);

                entity.Property(e => e.state).HasMaxLength(50);

                entity.Property(e => e.username).HasMaxLength(64);

                entity.Property(e => e.vatid).HasMaxLength(40);

                entity.Property(e => e.zip).HasMaxLength(8);
            });

            modelBuilder.Entity<rm_onlinecm>(entity =>
            {
                entity.HasKey(e => e.username)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.groupname, "groupname");

                entity.HasIndex(e => e.ipcpe, "ipcpe");

                entity.HasIndex(e => e.maccm, "maccm");

                entity.HasIndex(e => e.staticipcm, "staticipcm");

                entity.Property(e => e.username)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.groupname).HasMaxLength(50);

                entity.Property(e => e.ipcpe).HasMaxLength(15);

                entity.Property(e => e.maccm).HasMaxLength(17);

                entity.Property(e => e.maccpe).HasMaxLength(17);

                entity.Property(e => e.pingtime).HasPrecision(11, 1);

                entity.Property(e => e.rxpwr).HasPrecision(11, 1);

                entity.Property(e => e.snrds).HasPrecision(11, 1);

                entity.Property(e => e.snrus).HasPrecision(11, 1);

                entity.Property(e => e.staticipcm).HasMaxLength(15);

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.txpwr).HasPrecision(11, 1);

                entity.Property(e => e.upstreamname).HasMaxLength(50);
            });

            modelBuilder.Entity<rm_phpsess>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.managername, "managername");

                entity.Property(e => e.ip).HasMaxLength(15);

                entity.Property(e => e.lastact).HasColumnType("datetime");

                entity.Property(e => e.managername).HasMaxLength(64);

                entity.Property(e => e.sessid).HasMaxLength(64);
            });

            modelBuilder.Entity<rm_radacct>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.acctstarttime, "acctstarttime");

                entity.HasIndex(e => e.acctstoptime, "acctstoptime");

                entity.HasIndex(e => e.acctuniqueid, "acctuniqueid");

                entity.HasIndex(e => e.radacctid, "radacctid");

                entity.HasIndex(e => e.username, "username");

                entity.Property(e => e.acctsessiontimeratio).HasPrecision(3, 2);

                entity.Property(e => e.acctstarttime).HasColumnType("datetime");

                entity.Property(e => e.acctstoptime).HasColumnType("datetime");

                entity.Property(e => e.acctuniqueid).HasMaxLength(32);

                entity.Property(e => e.dlratio).HasPrecision(3, 2);

                entity.Property(e => e.ulratio).HasPrecision(3, 2);

                entity.Property(e => e.username).HasMaxLength(64);
            });

            modelBuilder.Entity<rm_services>(entity =>
            {
                entity.HasKey(e => e.srvid)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.srvname, "srvname");

                entity.Property(e => e.srvid).ValueGeneratedNever();

                entity.Property(e => e.cmcfg).HasMaxLength(10240);

                entity.Property(e => e.custattr).HasMaxLength(10240);

                entity.Property(e => e.descr).HasMaxLength(255);

                entity.Property(e => e.policymapdl).HasMaxLength(50);

                entity.Property(e => e.policymapul).HasMaxLength(50);

                entity.Property(e => e.poolname).HasMaxLength(50);

                entity.Property(e => e.srvname).HasMaxLength(50);

                entity.Property(e => e.unitprice).HasPrecision(25, 6);

                entity.Property(e => e.unitpriceadd).HasPrecision(25, 6);

                entity.Property(e => e.unitpriceaddtax).HasPrecision(25, 6);

                entity.Property(e => e.unitpricetax).HasPrecision(25, 6);
            });

            modelBuilder.Entity<rm_settings>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.advtaxpercent).HasPrecision(4, 2);

                entity.Property(e => e.currency).HasMaxLength(15);

                entity.Property(e => e.quotatpl).HasMaxLength(30);

                entity.Property(e => e.remotehostname).HasMaxLength(100);

                entity.Property(e => e.vatpercent).HasPrecision(4, 2);
            });

            modelBuilder.Entity<rm_specperacnt>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.starttime, "fromtime");

                entity.HasIndex(e => e.srvid, "srvid");

                entity.HasIndex(e => e.endtime, "totime");

                entity.Property(e => e.dlratio).HasPrecision(3, 2);

                entity.Property(e => e.endtime).HasColumnType("time");

                entity.Property(e => e.starttime).HasColumnType("time");

                entity.Property(e => e.timeratio).HasPrecision(3, 2);

                entity.Property(e => e.ulratio).HasPrecision(3, 2);
            });

            modelBuilder.Entity<rm_specperbw>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.endtime).HasColumnType("time");

                entity.Property(e => e.starttime).HasColumnType("time");
            });

            modelBuilder.Entity<rm_syslog>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.data1).HasMaxLength(64);

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.ip).HasMaxLength(15);

                entity.Property(e => e.name).HasMaxLength(64);
            });

            modelBuilder.Entity<rm_usergroups>(entity =>
            {
                entity.HasKey(e => e.groupid)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.descr).HasMaxLength(200);

                entity.Property(e => e.groupname).HasMaxLength(50);
            });

            modelBuilder.Entity<rm_users>(entity =>
            {
                entity.HasKey(e => e.username)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.acctype, "acctype");

                entity.HasIndex(e => e.address, "address");

                entity.HasIndex(e => e.city, "city");

                entity.HasIndex(e => e.comment, "comment")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 255 });

                entity.HasIndex(e => e.company, "company");

                entity.HasIndex(e => e.contractid, "contractid");

                entity.HasIndex(e => e.contractvalid, "contractvalid");

                entity.HasIndex(e => e.country, "country");

                entity.HasIndex(e => e.createdon, "createdon");

                entity.HasIndex(e => e.email, "email");

                entity.HasIndex(e => e.enableuser, "enableuser");

                entity.HasIndex(e => e.expiration, "expiration");

                entity.HasIndex(e => e.firstname, "firstname");

                entity.HasIndex(e => e.groupid, "groupid");

                entity.HasIndex(e => e.lastlogoff, "lastlogoff");

                entity.HasIndex(e => e.lastname, "lastname");

                entity.HasIndex(e => e.mac, "mac");

                entity.HasIndex(e => e.maccm, "maccm");

                entity.HasIndex(e => e.mobile, "mobile");

                entity.HasIndex(e => e.owner, "owner");

                entity.HasIndex(e => e.phone, "phone");

                entity.HasIndex(e => e.srvid, "srvid");

                entity.HasIndex(e => e.state, "state");

                entity.HasIndex(e => e.staticipcm, "staticipcm");

                entity.HasIndex(e => e.staticipcpe, "staticipcpe");

                entity.HasIndex(e => e.zip, "zip");

                entity.Property(e => e.username).HasMaxLength(64);

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

                entity.Property(e => e.expiration).HasColumnType("datetime");

                entity.Property(e => e.firstname).HasMaxLength(50);

                entity.Property(e => e.gpslat).HasPrecision(17, 14);

                entity.Property(e => e.gpslong).HasPrecision(17, 14);

                entity.Property(e => e.lang).HasMaxLength(30);

                entity.Property(e => e.lastlogoff).HasColumnType("datetime");

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

                entity.Property(e => e.verifycode).HasMaxLength(10);

                entity.Property(e => e.verifymobile).HasMaxLength(15);

                entity.Property(e => e.zip).HasMaxLength(8);
            });

            modelBuilder.Entity<rm_wlan>(entity =>
            {
                entity.HasNoKey();

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.maccpe, "maccpe");

                entity.Property(e => e.apip).HasMaxLength(15);

                entity.Property(e => e.maccpe).HasMaxLength(17);

                entity.Property(e => e.timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
