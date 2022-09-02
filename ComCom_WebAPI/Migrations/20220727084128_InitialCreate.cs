using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComCom_WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Nas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nasname = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    shortname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    type = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, defaultValueSql: "'other'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ports = table.Column<int>(type: "int", nullable: true),
                    secret = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false, defaultValueSql: "'secret'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    community = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, defaultValueSql: "'RADIUS Client'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    starospassword = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ciscobwmode = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    apiusername = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    apipassword = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    apiver = table.Column<int>(type: "int", nullable: false),
                    coamode = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nas", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "Radacct",
                columns: table => new
                {
                    radacctid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    acctsessionid = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    acctuniqueid = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    username = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    groupname = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    realm = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    nasipaddress = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    nasportid = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    nasporttype = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    acctstarttime = table.Column<DateTime>(type: "datetime", nullable: true),
                    acctstoptime = table.Column<DateTime>(type: "datetime", nullable: true),
                    acctsessiontime = table.Column<int>(type: "int", nullable: true),
                    acctauthentic = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    connectinfo_start = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    connectinfo_stop = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    acctinputoctets = table.Column<long>(type: "bigint", nullable: true),
                    acctoutputoctets = table.Column<long>(type: "bigint", nullable: true),
                    calledstationid = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    callingstationid = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    acctterminatecause = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    servicetype = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    framedprotocol = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    framedipaddress = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    acctstartdelay = table.Column<int>(type: "int", nullable: true),
                    acctstopdelay = table.Column<int>(type: "int", nullable: true),
                    xascendsessionsvrkey = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    _accttime = table.Column<DateTime>(type: "datetime", nullable: true),
                    _srvid = table.Column<int>(type: "int", nullable: true),
                    _dailynextsrvactive = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    _apid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radacct", x => x.radacctid);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "Radcheck",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    attribute = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    op = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: false, defaultValueSql: "'=='", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    value = table.Column<string>(type: "varchar(253)", maxLength: 253, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radcheck", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "Radgroupcheck",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    groupname = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    attribute = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    op = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: false, defaultValueSql: "'=='", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    value = table.Column<string>(type: "varchar(253)", maxLength: 253, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radgroupcheck", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "Radgroupreply",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    groupname = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    attribute = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    op = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: false, defaultValueSql: "'='", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    value = table.Column<string>(type: "varchar(253)", maxLength: 253, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radgroupreply", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "Radippool",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pool_name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    framedipaddress = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    nasipaddress = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    calledstationid = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    callingstationid = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    expiry_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    username = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    pool_key = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radippool", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "Radpostauth",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    pass = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    reply = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    authdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    nasipaddress = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radpostauth", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "Radreply",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    attribute = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    op = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: false, defaultValueSql: "'='", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    value = table.Column<string>(type: "varchar(253)", maxLength: 253, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radreply", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "Radusergroup",
                columns: table => new
                {
                    username = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    groupname = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    priority = table.Column<int>(type: "int", nullable: false, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_actsrv",
                columns: table => new
                {
                    id = table.Column<long>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    datetime = table.Column<DateTime>(type: "datetime", nullable: false),
                    username = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    srvid = table.Column<int>(type: "int", nullable: false),
                    dailynextsrvactive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_allowedmanagers",
                columns: table => new
                {
                    srvid = table.Column<int>(type: "int", nullable: false),
                    managername = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_allowednases",
                columns: table => new
                {
                    srvid = table.Column<int>(type: "int", nullable: false),
                    nasid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_ap",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    accessmode = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ip = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    community = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    apiusername = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    apipassword = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rm_ap", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "Rm_cards",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    cardnum = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    password = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    value = table.Column<decimal>(type: "decimal(22,2)", precision: 22, scale: 2, nullable: false),
                    expiration = table.Column<string>(type: "longtext", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    series = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    date = table.Column<string>(type: "longtext", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    owner = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    used = table.Column<DateTime>(type: "datetime", nullable: false),
                    cardtype = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    revoked = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    downlimit = table.Column<long>(type: "bigint", nullable: false),
                    uplimit = table.Column<long>(type: "bigint", nullable: false),
                    comblimit = table.Column<long>(type: "bigint", nullable: false),
                    uptimelimit = table.Column<long>(type: "bigint", nullable: false),
                    srvid = table.Column<int>(type: "int", nullable: false),
                    transid = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    active = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    expiretime = table.Column<long>(type: "bigint", nullable: false),
                    timebaseexp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    timebaseonline = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rm_cards", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "Rm_changesrv",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    newsrvid = table.Column<int>(type: "int", nullable: false),
                    newsrvname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    scheduledate = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    requestdate = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    transid = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    requested = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rm_changesrv", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "Rm_cmts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ip = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    community = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    descr = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rm_cmts", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "Rm_colsetlistdocsis",
                columns: table => new
                {
                    managername = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    colname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "Rm_colsetlistradius",
                columns: table => new
                {
                    managername = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    colname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_colsetlistusers",
                columns: table => new
                {
                    managername = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    colname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_dailyacct",
                columns: table => new
                {
                    radacctid = table.Column<long>(type: "bigint", nullable: false),
                    acctuniqueid = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    username = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    acctstarttime = table.Column<DateTime>(type: "datetime", nullable: false),
                    acctstoptime = table.Column<DateTime>(type: "datetime", nullable: false),
                    acctsessiontime = table.Column<int>(type: "int", nullable: false),
                    dlbytesstart = table.Column<long>(type: "bigint", nullable: false),
                    dlbytesstop = table.Column<long>(type: "bigint", nullable: false),
                    dlbytes = table.Column<long>(type: "bigint", nullable: false),
                    ulbytesstart = table.Column<long>(type: "bigint", nullable: false),
                    ulbytesstop = table.Column<long>(type: "bigint", nullable: false),
                    ulbytes = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_ias",
                columns: table => new
                {
                    iasid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    iasname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    price = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: false),
                    downlimit = table.Column<long>(type: "bigint", nullable: false),
                    uplimit = table.Column<long>(type: "bigint", nullable: false),
                    comblimit = table.Column<long>(type: "bigint", nullable: false),
                    uptimelimit = table.Column<long>(type: "bigint", nullable: false),
                    expiretime = table.Column<long>(type: "bigint", nullable: false),
                    timebaseonline = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    timebaseexp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    srvid = table.Column<int>(type: "int", nullable: false),
                    enableias = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    expiremode = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    expiration = table.Column<string>(type: "longtext", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    simuse = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.iasid);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_invoices",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    invgroup = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    invnum = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    managername = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    username = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    date = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    bytesdl = table.Column<long>(type: "bigint", nullable: false),
                    bytesul = table.Column<long>(type: "bigint", nullable: false),
                    bytescomb = table.Column<long>(type: "bigint", nullable: false),
                    downlimit = table.Column<long>(type: "bigint", nullable: false),
                    uplimit = table.Column<long>(type: "bigint", nullable: false),
                    comblimit = table.Column<long>(type: "bigint", nullable: false),
                    time = table.Column<int>(type: "int", nullable: false),
                    uptimelimit = table.Column<long>(type: "bigint", nullable: false),
                    days = table.Column<int>(type: "int", nullable: false),
                    expiration = table.Column<string>(type: "longtext", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    capdl = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    capul = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    captotal = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    captime = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    capdate = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    service = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    comment = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    transid = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    amount = table.Column<decimal>(type: "decimal(13,2)", precision: 13, scale: 2, nullable: false),
                    address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    city = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    zip = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    country = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    state = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    fullname = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    taxid = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    paymentopt = table.Column<string>(type: "longtext", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    invtype = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    paymode = table.Column<sbyte>(type: "tinyint", nullable: false),
                    paid = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    price = table.Column<decimal>(type: "decimal(25,6)", precision: 25, scale: 6, nullable: false),
                    tax = table.Column<decimal>(type: "decimal(25,6)", precision: 25, scale: 6, nullable: false),
                    advtax = table.Column<decimal>(type: "decimal(25,6)", precision: 25, scale: 6, nullable: false),
                    vatpercent = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: false),
                    advtaxpercent = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: false),
                    remark = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    balance = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: false),
                    gwtransid = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    phone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    mobile = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rm_invoices", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "Rm_ippools",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    fromip = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    toip = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    descr = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    nextpoolid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rm_ippools", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_managers",
                columns: table => new
                {
                    managername = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    password = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    firstname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    lastname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    phone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    mobile = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    city = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    zip = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    country = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    state = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    comment = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    company = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    vatid = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    balance = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: false),
                    perm_listusers = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_createusers = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_editusers = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_edituserspriv = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_deleteusers = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_listmanagers = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_createmanagers = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_editmanagers = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_deletemanagers = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_listservices = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_createservices = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_editservices = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_deleteservices = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_listonlineusers = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_listinvoices = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_trafficreport = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_addcredits = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_negbalance = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_listallinvoices = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_showinvtotals = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_logout = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_cardsys = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_editinvoice = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_allusers = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_allowdiscount = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_enwriteoff = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_accessap = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_cts = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_email = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    perm_sms = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    enablemanager = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    lang = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.managername);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_newusers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    firstname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    lastname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    address = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    city = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    zip = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    country = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    state = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    phone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    mobile = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    vatid = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    srvid = table.Column<int>(type: "int", nullable: false),
                    actcode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    actcount = table.Column<int>(type: "int", nullable: false),
                    lang = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rm_newusers", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_onlinecm",
                columns: table => new
                {
                    username = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    maccm = table.Column<string>(type: "varchar(17)", maxLength: 17, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    enableuser = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    staticipcm = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    maccpe = table.Column<string>(type: "varchar(17)", maxLength: 17, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ipcpe = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ipmodecpe = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    cmtsid = table.Column<int>(type: "int", nullable: true),
                    groupid = table.Column<int>(type: "int", nullable: true),
                    groupname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    snrds = table.Column<decimal>(type: "decimal(11,1)", precision: 11, scale: 1, nullable: true),
                    snrus = table.Column<decimal>(type: "decimal(11,1)", precision: 11, scale: 1, nullable: true),
                    txpwr = table.Column<decimal>(type: "decimal(11,1)", precision: 11, scale: 1, nullable: true),
                    rxpwr = table.Column<decimal>(type: "decimal(11,1)", precision: 11, scale: 1, nullable: true),
                    pingtime = table.Column<decimal>(type: "decimal(11,1)", precision: 11, scale: 1, nullable: true),
                    upstreamname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ifidx = table.Column<int>(type: "int", nullable: true),
                    timestamp = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.username);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_phpsess",
                columns: table => new
                {
                    managername = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ip = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    sessid = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    lastact = table.Column<DateTime>(type: "datetime", nullable: false),
                    closed = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_radacct",
                columns: table => new
                {
                    radacctid = table.Column<long>(type: "bigint", nullable: false),
                    acctuniqueid = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    username = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    acctstarttime = table.Column<DateTime>(type: "datetime", nullable: false),
                    acctstoptime = table.Column<DateTime>(type: "datetime", nullable: false),
                    acctsessiontime = table.Column<int>(type: "int", nullable: false),
                    acctsessiontimeratio = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: false),
                    dlbytesstart = table.Column<long>(type: "bigint", nullable: false),
                    dlbytesstop = table.Column<long>(type: "bigint", nullable: false),
                    dlbytes = table.Column<long>(type: "bigint", nullable: false),
                    dlratio = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: false),
                    ulbytesstart = table.Column<long>(type: "bigint", nullable: false),
                    ulbytesstop = table.Column<long>(type: "bigint", nullable: false),
                    ulbytes = table.Column<long>(type: "bigint", nullable: false),
                    ulratio = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_services",
                columns: table => new
                {
                    srvid = table.Column<int>(type: "int", nullable: false),
                    srvname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    descr = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    downrate = table.Column<int>(type: "int", nullable: false),
                    uprate = table.Column<int>(type: "int", nullable: false),
                    limitdl = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    limitul = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    limitcomb = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    limitexpiration = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    limituptime = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    poolname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    unitprice = table.Column<decimal>(type: "decimal(25,6)", precision: 25, scale: 6, nullable: false),
                    unitpriceadd = table.Column<decimal>(type: "decimal(25,6)", precision: 25, scale: 6, nullable: false),
                    timebaseexp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    timebaseonline = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    timeunitexp = table.Column<int>(type: "int", nullable: false),
                    timeunitonline = table.Column<int>(type: "int", nullable: false),
                    trafficunitdl = table.Column<int>(type: "int", nullable: false),
                    trafficunitul = table.Column<int>(type: "int", nullable: false),
                    trafficunitcomb = table.Column<int>(type: "int", nullable: false),
                    inittimeexp = table.Column<int>(type: "int", nullable: false),
                    inittimeonline = table.Column<int>(type: "int", nullable: false),
                    initdl = table.Column<int>(type: "int", nullable: false),
                    initul = table.Column<int>(type: "int", nullable: false),
                    inittotal = table.Column<int>(type: "int", nullable: false),
                    srvtype = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    timeaddmodeexp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    timeaddmodeonline = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    trafficaddmode = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    monthly = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    enaddcredits = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    minamount = table.Column<int>(type: "int", nullable: false),
                    minamountadd = table.Column<int>(type: "int", nullable: false),
                    resetctrdate = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    resetctrneg = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pricecalcdownload = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pricecalcupload = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pricecalcuptime = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    unitpricetax = table.Column<decimal>(type: "decimal(25,6)", precision: 25, scale: 6, nullable: false),
                    unitpriceaddtax = table.Column<decimal>(type: "decimal(25,6)", precision: 25, scale: 6, nullable: false),
                    enableburst = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    dlburstlimit = table.Column<int>(type: "int", nullable: false),
                    ulburstlimit = table.Column<int>(type: "int", nullable: false),
                    dlburstthreshold = table.Column<int>(type: "int", nullable: false),
                    ulburstthreshold = table.Column<int>(type: "int", nullable: false),
                    dlbursttime = table.Column<int>(type: "int", nullable: false),
                    ulbursttime = table.Column<int>(type: "int", nullable: false),
                    enableservice = table.Column<int>(type: "int", nullable: false),
                    dlquota = table.Column<long>(type: "bigint", nullable: false),
                    ulquota = table.Column<long>(type: "bigint", nullable: false),
                    combquota = table.Column<long>(type: "bigint", nullable: false),
                    timequota = table.Column<long>(type: "bigint", nullable: false),
                    priority = table.Column<short>(type: "smallint", nullable: false),
                    nextsrvid = table.Column<int>(type: "int", nullable: false),
                    dailynextsrvid = table.Column<int>(type: "int", nullable: false),
                    disnextsrvid = table.Column<int>(type: "int", nullable: false),
                    availucp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    renew = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    carryover = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    policymapdl = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    policymapul = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    custattr = table.Column<string>(type: "varchar(10240)", maxLength: 10240, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    gentftp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    cmcfg = table.Column<string>(type: "varchar(10240)", maxLength: 10240, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    advcmcfg = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    addamount = table.Column<int>(type: "int", nullable: false),
                    ignstatip = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.srvid);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_settings",
                columns: table => new
                {
                    currency = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    unixacc = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    diskquota = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    quotatpl = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    paymentopt = table.Column<int>(type: "int", nullable: false),
                    changesrv = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    vatpercent = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: false),
                    advtaxpercent = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: false),
                    disablenotpaid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    disableexpcont = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    resetctr = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    newnasallsrv = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    newmanallsrv = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    disconnmethod = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    warndl = table.Column<long>(type: "bigint", nullable: false),
                    warndlpercent = table.Column<int>(type: "int", nullable: false),
                    warnul = table.Column<long>(type: "bigint", nullable: false),
                    warnulpercent = table.Column<int>(type: "int", nullable: false),
                    warncomb = table.Column<long>(type: "bigint", nullable: false),
                    warncombpercent = table.Column<int>(type: "int", nullable: false),
                    warnuptime = table.Column<long>(type: "bigint", nullable: false),
                    warnuptimepercent = table.Column<int>(type: "int", nullable: false),
                    warnexpiry = table.Column<int>(type: "int", nullable: false),
                    expalertmode = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    emailselfregman = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    emailwelcome = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    emailnewsrv = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    emailrenew = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    smsrenew = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    emailexpiry = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    smswelcome = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    smsexpiry = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    warnmode = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    edituserdata = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    hidelimits = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pm_internal = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pm_paypalstd = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pm_paypalpro = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pm_paypalexp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pm_sagepay = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pm_authorizenet = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pm_dps = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pm_2co = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pm_payfast = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pm_citrus = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pm_paytm = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    unixhost = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    remotehostname = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    maclock = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    billingstart = table.Column<sbyte>(type: "tinyint", nullable: false),
                    disconnpostpaid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    renewday = table.Column<sbyte>(type: "tinyint", nullable: false),
                    changepswucp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    redeemucp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    buycreditsucp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_firstname = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_lastname = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_address = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_city = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_zip = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_country = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_state = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_phone = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_mobile = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_email = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_mobactsms = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_nameactemail = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_nameactsms = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_endupemail = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_endupmobile = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg_vatid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ias_email = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ias_mobile = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ias_verify = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ias_endupemail = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ias_endupmobile = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    simuseselfreg = table.Column<int>(type: "int", nullable: false),
                    defgrpid = table.Column<int>(type: "int", nullable: false),
                    captcha = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_specperacnt",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    srvid = table.Column<int>(type: "int", nullable: false),
                    starttime = table.Column<TimeSpan>(type: "time", nullable: false),
                    endtime = table.Column<TimeSpan>(type: "time", nullable: false),
                    timeratio = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: false),
                    dlratio = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: false),
                    ulratio = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: false),
                    connallowed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    mon = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    tue = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    wed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    thu = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    fri = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    sat = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    sun = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rm_specperacnt", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_specperbw",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    srvid = table.Column<int>(type: "int", nullable: false),
                    starttime = table.Column<TimeSpan>(type: "time", nullable: false),
                    endtime = table.Column<TimeSpan>(type: "time", nullable: false),
                    dlrate = table.Column<int>(type: "int", nullable: false),
                    ulrate = table.Column<int>(type: "int", nullable: false),
                    dlburstlimit = table.Column<int>(type: "int", nullable: false),
                    ulburstlimit = table.Column<int>(type: "int", nullable: false),
                    dlburstthreshold = table.Column<int>(type: "int", nullable: false),
                    ulburstthreshold = table.Column<int>(type: "int", nullable: false),
                    dlbursttime = table.Column<int>(type: "int", nullable: false),
                    ulbursttime = table.Column<int>(type: "int", nullable: false),
                    enableburst = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    priority = table.Column<int>(type: "int", nullable: false),
                    mon = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    tue = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    wed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    thu = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    fri = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    sat = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    sun = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rm_specperbw", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_syslog",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    datetime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ip = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    eventid = table.Column<int>(type: "int", nullable: false),
                    data1 = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rm_syslog", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_usergroups",
                columns: table => new
                {
                    groupid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    groupname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    descr = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.groupid);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_users",
                columns: table => new
                {
                    username = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    password = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    groupid = table.Column<int>(type: "int", nullable: false),
                    enableuser = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    uplimit = table.Column<long>(type: "bigint", nullable: false),
                    downlimit = table.Column<long>(type: "bigint", nullable: false),
                    comblimit = table.Column<long>(type: "bigint", nullable: false),
                    firstname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    lastname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    company = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    phone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    mobile = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    address = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    city = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    zip = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    country = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    state = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    comment = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    gpslat = table.Column<decimal>(type: "decimal(17,14)", precision: 17, scale: 14, nullable: false),
                    gpslong = table.Column<decimal>(type: "decimal(17,14)", precision: 17, scale: 14, nullable: false),
                    mac = table.Column<string>(type: "varchar(17)", maxLength: 17, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    usemacauth = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    expiration = table.Column<DateTime>(type: "datetime", nullable: false),
                    uptimelimit = table.Column<long>(type: "bigint", nullable: false),
                    srvid = table.Column<int>(type: "int", nullable: false),
                    staticipcm = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    staticipcpe = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ipmodecm = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ipmodecpe = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    poolidcm = table.Column<int>(type: "int", nullable: false),
                    poolidcpe = table.Column<int>(type: "int", nullable: false),
                    createdon = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    acctype = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    credits = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: false),
                    cardfails = table.Column<sbyte>(type: "tinyint", nullable: false),
                    createdby = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    owner = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    taxid = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    cnic = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    maccm = table.Column<string>(type: "varchar(17)", maxLength: 17, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    custattr = table.Column<string>(type: "varchar(10240)", maxLength: 10240, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    warningsent = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    verifycode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    verified = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    selfreg = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    verifyfails = table.Column<sbyte>(type: "tinyint", nullable: false),
                    verifysentnum = table.Column<sbyte>(type: "tinyint", nullable: false),
                    verifymobile = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    contractid = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    contractvalid = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    actcode = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    pswactsmsnum = table.Column<sbyte>(type: "tinyint", nullable: false),
                    alertemail = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    alertsms = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    lang = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    lastlogoff = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.username);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "rm_wlan",
                columns: table => new
                {
                    maccpe = table.Column<string>(type: "varchar(17)", maxLength: 17, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    signal = table.Column<short>(type: "smallint", nullable: true),
                    ccq = table.Column<short>(type: "smallint", nullable: true),
                    snr = table.Column<short>(type: "smallint", nullable: true),
                    apip = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    timestamp = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateIndex(
                name: "nasname",
                table: "Nas",
                column: "nasname");

            migrationBuilder.CreateIndex(
                name: "_AcctTime",
                table: "Radacct",
                column: "_accttime");

            migrationBuilder.CreateIndex(
                name: "acctsessionid",
                table: "Radacct",
                column: "acctsessionid");

            migrationBuilder.CreateIndex(
                name: "acctsessiontime",
                table: "Radacct",
                column: "acctsessiontime");

            migrationBuilder.CreateIndex(
                name: "acctstarttime",
                table: "Radacct",
                column: "acctstarttime");

            migrationBuilder.CreateIndex(
                name: "acctstoptime",
                table: "Radacct",
                column: "acctstoptime");

            migrationBuilder.CreateIndex(
                name: "acctuniqueid",
                table: "Radacct",
                column: "acctuniqueid");

            migrationBuilder.CreateIndex(
                name: "callingstationid",
                table: "Radacct",
                column: "callingstationid");

            migrationBuilder.CreateIndex(
                name: "framedipaddress",
                table: "Radacct",
                column: "framedipaddress");

            migrationBuilder.CreateIndex(
                name: "nasipaddress",
                table: "Radacct",
                column: "nasipaddress");

            migrationBuilder.CreateIndex(
                name: "username",
                table: "Radacct",
                column: "username");

            migrationBuilder.CreateIndex(
                name: "username1",
                table: "Radcheck",
                column: "username");

            migrationBuilder.CreateIndex(
                name: "groupname",
                table: "Radgroupcheck",
                column: "groupname");

            migrationBuilder.CreateIndex(
                name: "groupname1",
                table: "Radgroupreply",
                column: "groupname");

            migrationBuilder.CreateIndex(
                name: "authdate",
                table: "Radpostauth",
                column: "authdate");

            migrationBuilder.CreateIndex(
                name: "nasipaddress1",
                table: "Radpostauth",
                column: "nasipaddress");

            migrationBuilder.CreateIndex(
                name: "username2",
                table: "Radpostauth",
                column: "username");

            migrationBuilder.CreateIndex(
                name: "username3",
                table: "Radreply",
                column: "username");

            migrationBuilder.CreateIndex(
                name: "username",
                table: "Radusergroup",
                column: "username");

            migrationBuilder.CreateIndex(
                name: "datetime",
                table: "rm_actsrv",
                column: "datetime");

            migrationBuilder.CreateIndex(
                name: "id",
                table: "rm_actsrv",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "username",
                table: "rm_actsrv",
                column: "username");

            migrationBuilder.CreateIndex(
                name: "managername",
                table: "rm_allowedmanagers",
                column: "managername");

            migrationBuilder.CreateIndex(
                name: "srvid",
                table: "rm_allowedmanagers",
                column: "srvid");

            migrationBuilder.CreateIndex(
                name: "nasid",
                table: "rm_allowednases",
                column: "nasid");

            migrationBuilder.CreateIndex(
                name: "srvid",
                table: "rm_allowednases",
                column: "srvid");

            migrationBuilder.CreateIndex(
                name: "ip",
                table: "rm_ap",
                column: "ip");

            migrationBuilder.CreateIndex(
                name: "cardnum",
                table: "rm_cards",
                column: "cardnum",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "owner",
                table: "rm_cards",
                column: "owner");

            migrationBuilder.CreateIndex(
                name: "series",
                table: "rm_cards",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "used",
                table: "rm_cards",
                column: "used");

            migrationBuilder.CreateIndex(
                name: "requestdate",
                table: "rm_changesrv",
                column: "requestdate");

            migrationBuilder.CreateIndex(
                name: "scheduledate",
                table: "rm_changesrv",
                column: "scheduledate");

            migrationBuilder.CreateIndex(
                name: "ip1",
                table: "rm_cmts",
                column: "ip");

            migrationBuilder.CreateIndex(
                name: "managername",
                table: "rm_colsetlistdocsis",
                column: "managername");

            migrationBuilder.CreateIndex(
                name: "managername",
                table: "rm_colsetlistradius",
                column: "managername");

            migrationBuilder.CreateIndex(
                name: "managername",
                table: "rm_colsetlistusers",
                column: "managername");

            migrationBuilder.CreateIndex(
                name: "acctuniqueid",
                table: "rm_dailyacct",
                column: "acctuniqueid");

            migrationBuilder.CreateIndex(
                name: "radacctid",
                table: "rm_dailyacct",
                column: "radacctid");

            migrationBuilder.CreateIndex(
                name: "username",
                table: "rm_dailyacct",
                column: "username");

            migrationBuilder.CreateIndex(
                name: "comment",
                table: "rm_invoices",
                column: "comment");

            migrationBuilder.CreateIndex(
                name: "date",
                table: "rm_invoices",
                column: "date");

            migrationBuilder.CreateIndex(
                name: "gwtransid",
                table: "rm_invoices",
                column: "gwtransid");

            migrationBuilder.CreateIndex(
                name: "invgroup",
                table: "rm_invoices",
                column: "invgroup");

            migrationBuilder.CreateIndex(
                name: "invnum",
                table: "rm_invoices",
                column: "invnum");

            migrationBuilder.CreateIndex(
                name: "managername",
                table: "rm_invoices",
                column: "managername");

            migrationBuilder.CreateIndex(
                name: "paid",
                table: "rm_invoices",
                column: "paid");

            migrationBuilder.CreateIndex(
                name: "paymode",
                table: "rm_invoices",
                column: "paymode");

            migrationBuilder.CreateIndex(
                name: "username4",
                table: "rm_invoices",
                column: "username");

            migrationBuilder.CreateIndex(
                name: "name",
                table: "rm_ippools",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "nextid",
                table: "rm_ippools",
                column: "nextpoolid");

            migrationBuilder.CreateIndex(
                name: "groupname2",
                table: "rm_onlinecm",
                column: "groupname");

            migrationBuilder.CreateIndex(
                name: "ipcpe",
                table: "rm_onlinecm",
                column: "ipcpe");

            migrationBuilder.CreateIndex(
                name: "maccm",
                table: "rm_onlinecm",
                column: "maccm");

            migrationBuilder.CreateIndex(
                name: "staticipcm",
                table: "rm_onlinecm",
                column: "staticipcm");

            migrationBuilder.CreateIndex(
                name: "managername",
                table: "rm_phpsess",
                column: "managername");

            migrationBuilder.CreateIndex(
                name: "acctstarttime",
                table: "rm_radacct",
                column: "acctstarttime");

            migrationBuilder.CreateIndex(
                name: "acctstoptime",
                table: "rm_radacct",
                column: "acctstoptime");

            migrationBuilder.CreateIndex(
                name: "acctuniqueid",
                table: "rm_radacct",
                column: "acctuniqueid");

            migrationBuilder.CreateIndex(
                name: "radacctid",
                table: "rm_radacct",
                column: "radacctid");

            migrationBuilder.CreateIndex(
                name: "username",
                table: "rm_radacct",
                column: "username");

            migrationBuilder.CreateIndex(
                name: "srvname",
                table: "rm_services",
                column: "srvname");

            migrationBuilder.CreateIndex(
                name: "fromtime",
                table: "rm_specperacnt",
                column: "starttime");

            migrationBuilder.CreateIndex(
                name: "srvid",
                table: "rm_specperacnt",
                column: "srvid");

            migrationBuilder.CreateIndex(
                name: "totime",
                table: "rm_specperacnt",
                column: "endtime");

            migrationBuilder.CreateIndex(
                name: "acctype",
                table: "rm_users",
                column: "acctype");

            migrationBuilder.CreateIndex(
                name: "address",
                table: "rm_users",
                column: "address");

            migrationBuilder.CreateIndex(
                name: "city",
                table: "rm_users",
                column: "city");

            migrationBuilder.CreateIndex(
                name: "comment1",
                table: "rm_users",
                column: "comment")
                .Annotation("MySql:IndexPrefixLength", new[] { 255 });

            migrationBuilder.CreateIndex(
                name: "company",
                table: "rm_users",
                column: "company");

            migrationBuilder.CreateIndex(
                name: "contractid",
                table: "rm_users",
                column: "contractid");

            migrationBuilder.CreateIndex(
                name: "contractvalid",
                table: "rm_users",
                column: "contractvalid");

            migrationBuilder.CreateIndex(
                name: "country",
                table: "rm_users",
                column: "country");

            migrationBuilder.CreateIndex(
                name: "createdon",
                table: "rm_users",
                column: "createdon");

            migrationBuilder.CreateIndex(
                name: "email",
                table: "rm_users",
                column: "email");

            migrationBuilder.CreateIndex(
                name: "enableuser",
                table: "rm_users",
                column: "enableuser");

            migrationBuilder.CreateIndex(
                name: "expiration",
                table: "rm_users",
                column: "expiration");

            migrationBuilder.CreateIndex(
                name: "firstname",
                table: "rm_users",
                column: "firstname");

            migrationBuilder.CreateIndex(
                name: "groupid",
                table: "rm_users",
                column: "groupid");

            migrationBuilder.CreateIndex(
                name: "lastlogoff",
                table: "rm_users",
                column: "lastlogoff");

            migrationBuilder.CreateIndex(
                name: "lastname",
                table: "rm_users",
                column: "lastname");

            migrationBuilder.CreateIndex(
                name: "mac",
                table: "rm_users",
                column: "mac");

            migrationBuilder.CreateIndex(
                name: "maccm1",
                table: "rm_users",
                column: "maccm");

            migrationBuilder.CreateIndex(
                name: "mobile",
                table: "rm_users",
                column: "mobile");

            migrationBuilder.CreateIndex(
                name: "owner1",
                table: "rm_users",
                column: "owner");

            migrationBuilder.CreateIndex(
                name: "phone",
                table: "rm_users",
                column: "phone");

            migrationBuilder.CreateIndex(
                name: "srvid1",
                table: "rm_users",
                column: "srvid");

            migrationBuilder.CreateIndex(
                name: "state",
                table: "rm_users",
                column: "state");

            migrationBuilder.CreateIndex(
                name: "staticipcm1",
                table: "rm_users",
                column: "staticipcm");

            migrationBuilder.CreateIndex(
                name: "staticipcpe",
                table: "rm_users",
                column: "staticipcpe");

            migrationBuilder.CreateIndex(
                name: "zip",
                table: "rm_users",
                column: "zip");

            migrationBuilder.CreateIndex(
                name: "maccpe",
                table: "rm_wlan",
                column: "maccpe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nas");

            migrationBuilder.DropTable(
                name: "Radacct");

            migrationBuilder.DropTable(
                name: "Radcheck");

            migrationBuilder.DropTable(
                name: "Radgroupcheck");

            migrationBuilder.DropTable(
                name: "Radgroupreply");

            migrationBuilder.DropTable(
                name: "Radippool");

            migrationBuilder.DropTable(
                name: "Radpostauth");

            migrationBuilder.DropTable(
                name: "Radreply");

            migrationBuilder.DropTable(
                name: "Radusergroup");

            migrationBuilder.DropTable(
                name: "rm_actsrv");

            migrationBuilder.DropTable(
                name: "rm_allowedmanagers");

            migrationBuilder.DropTable(
                name: "rm_allowednases");

            migrationBuilder.DropTable(
                name: "rm_ap");

            migrationBuilder.DropTable(
                name: "rm_cards");

            migrationBuilder.DropTable(
                name: "rm_changesrv");

            migrationBuilder.DropTable(
                name: "rm_cmts");

            migrationBuilder.DropTable(
                name: "rm_colsetlistdocsis");

            migrationBuilder.DropTable(
                name: "rm_colsetlistradius");

            migrationBuilder.DropTable(
                name: "rm_colsetlistusers");

            migrationBuilder.DropTable(
                name: "rm_dailyacct");

            migrationBuilder.DropTable(
                name: "rm_ias");

            migrationBuilder.DropTable(
                name: "rm_invoices");

            migrationBuilder.DropTable(
                name: "rm_ippools");

            migrationBuilder.DropTable(
                name: "rm_managers");

            migrationBuilder.DropTable(
                name: "rm_newusers");

            migrationBuilder.DropTable(
                name: "rm_onlinecm");

            migrationBuilder.DropTable(
                name: "rm_phpsess");

            migrationBuilder.DropTable(
                name: "rm_radacct");

            migrationBuilder.DropTable(
                name: "rm_services");

            migrationBuilder.DropTable(
                name: "rm_settings");

            migrationBuilder.DropTable(
                name: "rm_specperacnt");

            migrationBuilder.DropTable(
                name: "rm_specperbw");

            migrationBuilder.DropTable(
                name: "rm_syslog");

            migrationBuilder.DropTable(
                name: "rm_usergroups");

            migrationBuilder.DropTable(
                name: "rm_users");

            migrationBuilder.DropTable(
                name: "rm_wlan");
        }
    }
}
