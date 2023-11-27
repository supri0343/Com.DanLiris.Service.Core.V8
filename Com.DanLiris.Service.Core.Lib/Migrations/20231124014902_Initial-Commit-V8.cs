using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Com.DanLiris.Service.Core.Lib.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommitV8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountBanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    BankCode = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    BankAddress = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    AccountName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    AccountCOA = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    SwiftCode = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    CurrencyCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    CurrencySymbol = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    CurrencyRate = table.Column<double>(type: "float", nullable: false),
                    CurrencyDescription = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    DivisionName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    DivisionCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    DivisionId = table.Column<int>(type: "int", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountBanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountingCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AccountingLayoutIndex = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountingUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    DivisionCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DivisionName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BudgetCashflowLayoutOrder = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankCashReceiptTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    COACode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    COAId = table.Column<int>(type: "int", nullable: false),
                    COAName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankCashReceiptTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BICurrencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BICurrencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BudgetCurrencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetCurrencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BudgetingCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetingCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    City = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Tempo = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NPWP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NIK = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Job = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BuyerOwner = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CodeRequirement = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    PurchasingCOA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StockCOA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocalDebtCOA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImportDebtCOA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AccountingCategoryId = table.Column<int>(type: "int", nullable: false),
                    BudgetingCategoryId = table.Column<int>(type: "int", nullable: false),
                    ReportLayoutIndex = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColorTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comodities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comodities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rate = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DebitCreditNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeDCN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemTypeDCN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebitCreditNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DesignMotives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignMotives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COACode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BudgetCashflowLayoutOrder = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinishType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinishType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentAdditionalCharges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentAdditionalCharges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentBuyerBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BuyerId = table.Column<int>(type: "int", nullable: false),
                    BuyerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuyerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentBuyerBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentBuyers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    City = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Tempo = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NPWP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentBuyers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CodeRequirement = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CategoryType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UomId = table.Column<int>(type: "int", nullable: true),
                    UomUnit = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentComodities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentComodities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentCouriers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Attention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NPWP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentCouriers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentCurrencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentCurrencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentDetailCurrencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentDetailCurrencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentEMKLs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Attention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NPWP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentEMKLs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentFabricTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentFabricTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentForwarders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Attention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NPWP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentForwarders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentInsurances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Attention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SwiftCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NPWP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentInsurances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentLeftoverWarehouseBuyers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NIK = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NPWP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WPName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KaberType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentLeftoverWarehouseBuyers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentLeftoverWarehouseComodities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentLeftoverWarehouseComodities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentLeftoverWarehouseProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UomId = table.Column<int>(type: "int", nullable: true),
                    UomUnit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: true),
                    ProductTypeCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentLeftoverWarehouseProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentMarketings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ResponsibleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentMarketings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UomId = table.Column<int>(type: "int", nullable: true),
                    UomUnit = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Composition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Const = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Yarn = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Width = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalRO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalKadiv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentSections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentShippingStaffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentShippingStaffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentSuppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PIC = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Import = table.Column<bool>(type: "bit", nullable: true),
                    UseVat = table.Column<bool>(type: "bit", nullable: true),
                    NPWP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UseTax = table.Column<bool>(type: "bit", nullable: true),
                    IncomeTaxesId = table.Column<int>(type: "int", nullable: false),
                    IncomeTaxesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncomeTaxesRate = table.Column<double>(type: "float", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentSuppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentTransactionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    COAId = table.Column<int>(type: "int", nullable: true),
                    COACode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    COAName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentTransactionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentWareHouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Attention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NPWP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentWareHouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: true),
                    DivisionName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IBCurrencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IBCurrencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncomeTaxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COACodeCredit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeTaxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LampStandard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LampStandard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MachineSpinnings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CounterCondition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Delivery = table.Column<int>(type: "int", nullable: false),
                    CapacityPerHour = table.Column<double>(type: "float", nullable: false),
                    UomId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UomUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Line = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MachineCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineSpinnings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MappingCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MappingCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialConstructions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialConstructions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Menu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    SubMenu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcessType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SPPCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderTypeId = table.Column<int>(type: "int", nullable: false),
                    OrderTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderTypeRemark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductPriceHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PriceOrigin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    CurrencyCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CurrencySymbol = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EditReason = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UomId = table.Column<int>(type: "int", nullable: true),
                    UomUnit = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DateBefore = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPriceHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    CurrencyCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CurrencySymbol = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UomId = table.Column<int>(type: "int", nullable: true),
                    UomUnit = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTextiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UomId = table.Column<int>(type: "int", nullable: true),
                    UomUnit = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BuyerType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTextiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeIdx = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StandardMinuteValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BuyerId = table.Column<int>(type: "int", nullable: false),
                    BuyerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuyerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComodityId = table.Column<int>(type: "int", nullable: false),
                    ComodityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComodityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SMVDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SMVCutting = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SMVSewing = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SMVFinishing = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardMinuteValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StandardTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardTests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: true),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DivisionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PIC = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Import = table.Column<bool>(type: "bit", nullable: true),
                    NPWP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TermOfPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsExport = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermOfPayments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Box = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitOfMeasurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfMeasurements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    DivisionCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DivisionName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COACode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VBDocumentLayoutOrder = table.Column<int>(type: "int", nullable: false),
                    AccountingUnitId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COACodeCredit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YarnMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YarnMaterials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MachineSpinningProcessType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MachineSpinningId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineSpinningProcessType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MachineSpinningProcessType_MachineSpinnings_MachineSpinningId",
                        column: x => x.MachineSpinningId,
                        principalTable: "MachineSpinnings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSPPProperties",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProductionOrderId = table.Column<int>(type: "int", nullable: false),
                    ProductionOrderNo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DesignCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DesignNumber = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    OrderTypeId = table.Column<int>(type: "int", nullable: false),
                    OrderTypeCode = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    OrderTypeName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    BuyerId = table.Column<int>(type: "int", nullable: false),
                    BuyerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BuyerAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ColorName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Construction = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Lot = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSPPProperties", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ProductSPPProperties_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    UnitCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Division = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    permission = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    _CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _CreatedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _LastModifiedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    _DeletedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _DeletedAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountRoles_RoleId",
                table: "AccountRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Buyers_Code",
                table: "Buyers",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_MachineSpinningProcessType_MachineSpinningId",
                table: "MachineSpinningProcessType",
                column: "MachineSpinningId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_RoleId",
                table: "Permissions",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountBanks");

            migrationBuilder.DropTable(
                name: "AccountingCategories");

            migrationBuilder.DropTable(
                name: "AccountingUnits");

            migrationBuilder.DropTable(
                name: "AccountProfiles");

            migrationBuilder.DropTable(
                name: "AccountRoles");

            migrationBuilder.DropTable(
                name: "BankCashReceiptTypes");

            migrationBuilder.DropTable(
                name: "BICurrencies");

            migrationBuilder.DropTable(
                name: "BudgetCurrencies");

            migrationBuilder.DropTable(
                name: "BudgetingCategories");

            migrationBuilder.DropTable(
                name: "Budgets");

            migrationBuilder.DropTable(
                name: "Buyers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ColorTypes");

            migrationBuilder.DropTable(
                name: "Comodities");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "DebitCreditNotes");

            migrationBuilder.DropTable(
                name: "DesignMotives");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "FinishType");

            migrationBuilder.DropTable(
                name: "GarmentAdditionalCharges");

            migrationBuilder.DropTable(
                name: "GarmentBuyerBrands");

            migrationBuilder.DropTable(
                name: "GarmentBuyers");

            migrationBuilder.DropTable(
                name: "GarmentCategories");

            migrationBuilder.DropTable(
                name: "GarmentComodities");

            migrationBuilder.DropTable(
                name: "GarmentCouriers");

            migrationBuilder.DropTable(
                name: "GarmentCurrencies");

            migrationBuilder.DropTable(
                name: "GarmentDetailCurrencies");

            migrationBuilder.DropTable(
                name: "GarmentEMKLs");

            migrationBuilder.DropTable(
                name: "GarmentFabricTypes");

            migrationBuilder.DropTable(
                name: "GarmentForwarders");

            migrationBuilder.DropTable(
                name: "GarmentInsurances");

            migrationBuilder.DropTable(
                name: "GarmentLeftoverWarehouseBuyers");

            migrationBuilder.DropTable(
                name: "GarmentLeftoverWarehouseComodities");

            migrationBuilder.DropTable(
                name: "GarmentLeftoverWarehouseProducts");

            migrationBuilder.DropTable(
                name: "GarmentMarketings");

            migrationBuilder.DropTable(
                name: "GarmentProducts");

            migrationBuilder.DropTable(
                name: "GarmentSections");

            migrationBuilder.DropTable(
                name: "GarmentShippingStaffs");

            migrationBuilder.DropTable(
                name: "GarmentSuppliers");

            migrationBuilder.DropTable(
                name: "GarmentTransactionTypes");

            migrationBuilder.DropTable(
                name: "GarmentWareHouses");

            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.DropTable(
                name: "IBCurrencies");

            migrationBuilder.DropTable(
                name: "IncomeTaxes");

            migrationBuilder.DropTable(
                name: "LampStandard");

            migrationBuilder.DropTable(
                name: "MachineSpinningProcessType");

            migrationBuilder.DropTable(
                name: "MappingCategories");

            migrationBuilder.DropTable(
                name: "MaterialConstructions");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "OrderTypes");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "ProcessType");

            migrationBuilder.DropTable(
                name: "ProductPriceHistories");

            migrationBuilder.DropTable(
                name: "ProductSPPProperties");

            migrationBuilder.DropTable(
                name: "ProductTextiles");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Qualities");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "StandardMinuteValues");

            migrationBuilder.DropTable(
                name: "StandardTests");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "TermOfPayments");

            migrationBuilder.DropTable(
                name: "Track");

            migrationBuilder.DropTable(
                name: "UnitOfMeasurements");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Vat");

            migrationBuilder.DropTable(
                name: "YarnMaterials");

            migrationBuilder.DropTable(
                name: "MachineSpinnings");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
