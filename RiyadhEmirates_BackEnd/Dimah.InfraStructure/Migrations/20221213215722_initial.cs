using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dimah.InfraStructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "DataManagement");

            migrationBuilder.EnsureSchema(
                name: "Lookup");

            migrationBuilder.EnsureSchema(
                name: "Auth");

            migrationBuilder.EnsureSchema(
                name: "FileManager");

            migrationBuilder.CreateTable(
                name: "Charities",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                schema: "Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Iso2 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DialCode = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FullNameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    FullNameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NationalityId = table.Column<int>(type: "int", nullable: true),
                    IsMale = table.Column<bool>(type: "bit", nullable: false),
                    IsEmployee = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    Last2Factor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalSchema: "Lookup",
                        principalTable: "Nationalities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Posters",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posters_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Posters_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectTypes",
                schema: "Lookup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTypes_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectTypes_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Roles_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UploadedFiles",
                schema: "FileManager",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityId = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    EntityName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    SubEntityName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    OriginalName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Extention = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadedFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UploadedFiles_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UploadedFiles_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CharityProjects",
                schema: "DataManagement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CharityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    DescriptionEn = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ProjectCost = table.Column<double>(type: "float", nullable: false),
                    ProjectLocation = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharityProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharityProjects_Charities_CharityId",
                        column: x => x.CharityId,
                        principalSchema: "DataManagement",
                        principalTable: "Charities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CharityProjects_ProjectTypes_ProjectTypeId",
                        column: x => x.ProjectTypeId,
                        principalSchema: "Lookup",
                        principalTable: "ProjectTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CharityProjects_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CharityProjects_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Auth",
                        principalTable: "Roles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, "101", new Guid("64872c56-aa6f-4b0f-9f7e-dd199bbf266f"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "971", true, "ae", null, null, "الامارات العربية", "Arab Emirates" },
                    { 2, "102", new Guid("88e970fd-abbc-4784-a366-865ed2d9a454"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "962", true, "jo", null, null, "الاردن", "Jordan" },
                    { 3, "103", new Guid("93dd6bdf-a318-4b84-8bee-75c08a978d2d"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "973", true, "bh", null, null, "البحرين", "Bahrain" },
                    { 4, "104", new Guid("276a4e84-4554-4811-a341-f49399f0a003"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "963", true, "sy", null, null, "سوريا", "Syria" },
                    { 5, "105", new Guid("bb67c37a-ba7f-4a4a-a979-dfbc5f2c64f0"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "964", true, "iq", null, null, "العراق", "Iraq" },
                    { 6, "106", new Guid("2bfce83a-97ad-4961-9f32-70ac8f2e71d6"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "968", true, "om", null, null, "عمان", "Oman" },
                    { 7, "107", new Guid("579c58ab-c660-4496-9e65-6a5d8b7bd5e8"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "970", true, "ps", null, null, "فلسطين", "Palestine" },
                    { 8, "108", new Guid("3da03271-116e-4871-9981-48f5291242df"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "974", true, "qa", null, null, "قطر", "Qatar" },
                    { 9, "109", new Guid("59061dd0-d106-4f41-a2d1-9a3c4331d493"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "965", true, "kw", null, null, "الكويت", "Kuwait" },
                    { 10, "110", new Guid("edeb16b0-f44a-4c3e-b5bf-0090d47a8e13"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "961", true, "lb", null, null, "لبنان", "Lebanon" },
                    { 11, "111", new Guid("41865f12-948d-4c14-ab7e-08fbacc721c0"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "967", true, "ye", null, null, "اليمن", "Yemen" },
                    { 12, "113", new Guid("a96a8aa8-0d99-48ed-93bc-ba96a90d3d2c"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "966", true, "sa", null, null, "العربية السعودية", "Saudi Arabia" },
                    { 13, "201", new Guid("abedda8a-c930-4e91-97c6-76384935075f"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "216", true, "tn", null, null, "تونس", "Tunisia" },
                    { 14, "202", new Guid("232d5d2e-9884-46d6-9454-34e1727e8374"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "213", true, "dz", null, null, "الجزائر", "Algeria" },
                    { 15, "203", new Guid("48c10c65-e177-429f-b7df-2c19fdc08b7d"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "253", true, "dj", null, null, "جيبوتى", "Djibouti" },
                    { 16, "204", new Guid("46a0b26c-32b8-4477-8053-5c99f8dafe47"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "249", true, "sd", null, null, "السودان", "Sudan" },
                    { 17, "205", new Guid("83780fe1-87c2-49a7-87b1-d1510f8bf293"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "252", true, "so", null, null, "الصومال", "Somalia" },
                    { 18, "206", new Guid("5e60c0af-1f03-4245-aa86-60b9f1b661fd"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "218", true, "ly", null, null, "ليبيا", "Libya" },
                    { 19, "207", new Guid("37bd801d-018f-4dcd-adc8-59ddd5808dea"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "20", true, "eg", null, null, "مصر", "Egypt" },
                    { 20, "208", new Guid("051b175a-9712-47d8-bb5f-f634d0db7034"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "212", true, "ma", null, null, "المغرب", "Morocco" },
                    { 21, "209", new Guid("86900204-871f-4035-93de-10ec3edf76ad"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "222", true, "mr", null, null, "موريتانيا", "Mauritania" },
                    { 22, "301", new Guid("54408f48-e094-4c32-9e54-a595c574499a"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "93", true, "af", null, null, "افغانستان", "Afghanistan" },
                    { 23, "302", new Guid("2fb40a22-d1a1-42d3-a226-4916891dfc7b"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "62", true, "id", null, null, "اندونيسيا", "Indonesia" },
                    { 24, "303", new Guid("1bdaa805-ec6b-4d9c-8f2e-d9d0aac21db8"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "98", true, "ir", null, null, "ايران", "Iran" },
                    { 25, "304", new Guid("0960b9d1-1720-4710-a591-03860425d561"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "92", true, "pk", null, null, "باكستان", "Pakistan" },
                    { 26, "305", new Guid("2ad623f7-aa36-4cb5-bcc8-b8ee8996d3ab"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "880", true, "bd", null, null, "بنجلاديش", "Bangladesh" },
                    { 27, "306", new Guid("689edb81-ca50-4686-95ee-8e1c60b42852"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "673", true, "bn", null, null, "بروني", "Brunei" },
                    { 28, "307", new Guid("4c1205be-25bb-4077-bcb6-f095afb7dd79"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "95", true, "mm", null, null, "جمهورية ميانمار", "Myanmar" },
                    { 29, "308", new Guid("13397018-e8c7-4f86-ae46-ddfc29d2d2fe"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "66", true, "th", null, null, "تايلند", "Thailand" },
                    { 30, "309", new Guid("849255cb-d88b-4429-8686-9b6c8f1e59bf"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "90", true, "tr", null, null, "تركيا", "Turkey" },
                    { 31, "310", new Guid("328b151e-f69f-46a7-aebf-2925bdca32ab"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "960", true, "mv", null, null, "جزر مالديف", "Maldives" },
                    { 32, "311", new Guid("1f93d014-7b80-42c6-893f-ddc2da718cae"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", true, "ru", null, null, "روسيا الاتحادية", "Russia" },
                    { 33, "312", new Guid("5b16d5a4-55a1-43e6-bd08-957d58134565"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "65", true, "sg", null, null, "سنغافورة", "Singapore" },
                    { 34, "313", new Guid("4b535205-a830-4798-b2cc-d8a9480c2fb5"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "94", true, "lk", null, null, "سري لنكا", "Sri Lanka" },
                    { 35, "315", new Guid("a02060a3-54f4-4639-b37c-0e150c4293d6"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "63", true, "ph", null, null, "الفلبين", "Philippines" },
                    { 36, "316", new Guid("d7d50de1-5852-4886-864d-85a9f207db88"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "84", true, "vn", null, null, "فيتنام", "Vietnam" },
                    { 37, "317", new Guid("3eebe3e6-a6a5-48ac-ad89-dea9b37c4dc8"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "855", true, "kh", null, null, "كمبوديا", "Cambodia" },
                    { 38, "318", new Guid("f25edb2a-311d-49dd-822e-8e4feb224586"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "82", true, "kr", null, null, "كوريا الجنوبية", "South Korea" },
                    { 39, "319", new Guid("90d45d44-ec15-402f-a575-0d134eb164bc"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "60", true, "my", null, null, "ماليزيا", "Malaysia" },
                    { 40, "320", new Guid("4f614c51-e250-46dc-82b7-7d89e5393602"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "977", true, "np", null, null, "نيبال", "Nepal" },
                    { 41, "321", new Guid("dcb06d87-ce05-4d7f-ab55-d65b91551e67"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "91", true, "in", null, null, "الهند", "India" },
                    { 42, "322", new Guid("68177a89-e5cf-4960-9ac8-541dd97d7ea3"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "852", true, "hk", null, null, "هونج كونج", "Hong Kong" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 43, "323", new Guid("f579d3e2-212c-4f4d-86e0-afdf8a590c45"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "81", true, "jp", null, null, "اليابان", "Japan" },
                    { 44, "324", new Guid("084359e3-4907-4c80-8aeb-b39b3d06a87e"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "975", true, "bt", null, null, "بهوتان", "Bhutan" },
                    { 45, "325", new Guid("838fe681-22fa-4938-a7e6-52b0b38c7697"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "86", true, "cn", null, null, "الصين الشعبية", "China" },
                    { 46, "326", new Guid("f457f1db-be42-4650-a8f6-12a9cb873d8a"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "357", true, "cy", null, null, "قبرص", "Cyprus" },
                    { 47, "328", new Guid("c1723f6e-1e72-4f61-8ef4-fb33e0e4b5ba"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "850", true, "kp", null, null, "كوريا الشمالية", "North Korea" },
                    { 48, "329", new Guid("3355a45a-32d5-4bd3-8718-1296e43ae585"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "856", true, "la", null, null, "لاوس", "Laos" },
                    { 49, "330", new Guid("77a06515-0e73-45c9-883d-14db27491677"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "976", true, "mn", null, null, "منغوليا", "Mongolia" },
                    { 50, "331", new Guid("ede1c1ae-955a-4780-9c0d-86ac18015c0e"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "853", true, "mo", null, null, "ماكاو", "Macao" },
                    { 51, "332", new Guid("409a90a2-6d81-46ef-9450-35d74ae740ef"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "تركستان", "Turkistan" },
                    { 52, "335", new Guid("e5303763-93d2-451d-85cb-12aa81e5b6f4"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "القبائل النازحة", "Tribes Emigrated" },
                    { 53, "336", new Guid("74c3d841-89a2-4a5d-bffa-9774318f9b35"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", true, "kz", null, null, "كازاخستان", "Kazakhstan" },
                    { 54, "337", new Guid("3ee57ed4-9b6d-4518-bcbf-7e10e924152a"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "998", true, "uz", null, null, "ازبكستان", "Uzbekistan" },
                    { 55, "338", new Guid("41504479-5437-4ed4-b19d-89124b087ff4"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "993", true, "tm", null, null, "تركمانستان", "Turkmenistan" },
                    { 56, "339", new Guid("c2393464-5dce-4919-a996-56d63b3fa75b"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "992", true, "tj", null, null, "طاجكستان", "Tajikistan" },
                    { 57, "340", new Guid("9cc8eb6c-d267-43e0-ae94-ab25ce50cf59"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "996", false, "kg", null, null, "قرغيزستان", "kyrgyzstan" },
                    { 58, "343", new Guid("94688552-0f7f-4233-b992-170aae078523"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "994", true, "az", null, null, "اذربيجان", "Azerbaijan" },
                    { 59, "344", new Guid("b4ae4df1-90bc-4390-913f-d3a57fcc51be"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "الشاشان", "Chechnya" },
                    { 60, "345", new Guid("7f717a31-77ef-4d49-944c-d474575d1264"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "872", false, "da", null, null, "داغستان", "Dagestan" },
                    { 61, "346", new Guid("d87528d3-01ce-42de-b1b5-f2c7adf6b6a5"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "انقوش", "Anquosh" },
                    { 62, "347", new Guid("7d20c8ee-b347-41a9-bce4-6265a3053afe"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", false, "ta", null, null, "تتارستان", "Tatarstan" },
                    { 63, "349", new Guid("7c58ad28-d2d1-4b34-86eb-f0ece2813a76"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "670", false, "tp", null, null, "تيمور الشرقية", "East Timor" },
                    { 64, "401", new Guid("b3bf8336-d649-40bc-8c77-ab4eacb34fd2"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "251", true, "et", null, null, "اثيوبيا", "Ethiopia" },
                    { 65, "402", new Guid("bb1f04fb-ad8a-4b96-aa2a-eeff3cd8ff33"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "256", true, "ug", null, null, "اوغندة", "Uganda" },
                    { 66, "403", new Guid("1087068e-2c97-4855-a518-7d33d390df3e"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "267", true, "bw", null, null, "بوتسوانا", "Botswana" },
                    { 67, "404", new Guid("221730f7-0b6f-4563-aa80-70db0b26ef22"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "257", true, "bi", null, null, "بورندي", "Burundi" },
                    { 68, "405", new Guid("2cd4f60f-c13e-4a1c-aae0-a8737fc55dd6"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "235", true, "td", null, null, "تشاد", "Chad" },
                    { 69, "406", new Guid("df2d53dd-fef6-4b5b-8865-fcd9df0461bc"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "255", true, "tz", null, null, "تنزانيا", "Tanzania" },
                    { 70, "407", new Guid("d48fac5f-ad42-43bf-a755-e0e1d1056dd6"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "228", true, "tg", null, null, "توجو", "Togo" },
                    { 71, "408", new Guid("1cef45b8-a230-4b81-a35a-433d3e8b6b76"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "241", true, "ga", null, null, "جابون", "Answer" },
                    { 72, "409", new Guid("248e8724-9400-48d4-8f65-f3d3ec4c5037"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "220", true, "gm", null, null, "غامبيا", "Gambia" },
                    { 73, "410", new Guid("60421f2d-e8a3-47ed-82ae-375775c7752a"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "269", true, "km", null, null, "جزر القمر", "Comoros" },
                    { 74, "411", new Guid("727a19d6-05cf-4ce0-975b-a8e400f40641"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "27", true, "za", null, null, "جنوب افريقيا", "South Africa" },
                    { 75, "412", new Guid("feacd751-7cdf-415d-831f-04d296a35ed5"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "264", true, "na", null, null, "ناميبيا", "Namibia" },
                    { 76, "413", new Guid("057793ff-135a-48f5-a141-19d2d799f002"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "229", true, "bj", null, null, "بنين", "Benin" },
                    { 77, "414", new Guid("3c1fb2f0-ac59-4a5b-ac87-4a82affab25b"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "250", true, "rw", null, null, "رواندا", "Rwanda" },
                    { 78, "415", new Guid("ad9a067c-6116-4c30-aa88-66f281da3309"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "263", true, "zw", null, null, "زمبابوي", "Zimbabwe" },
                    { 79, "416", new Guid("572dcdf5-f1fe-46b1-9ceb-4b13c3d83f9f"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "243", false, "zr", null, null, "زائير", "Zaire" },
                    { 80, "417", new Guid("a29ebc3f-9be2-4520-a011-672c6a0836d7"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "260", true, "zm", null, null, "زامبيا", "Zambia" },
                    { 81, "418", new Guid("a3f9ff37-6c6d-4ac3-8798-12455f1f5e7b"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "225", false, "ci", null, null, "ساحل العاج", "Ivory Coast" },
                    { 82, "419", new Guid("f7184735-025e-466a-9d83-d1d2ec28ec02"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "sn  221", null, null, "السنغال", "Senegal" },
                    { 83, "420", new Guid("97a56f19-b8cc-4f78-a7b5-6f50c7b9dfb3"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "232", true, "sl", null, null, "سيراليون", "Sierra Leone" },
                    { 84, "421", new Guid("7d0bb277-a0ee-416e-8562-95dc3daf4ef7"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "233", true, "gh", null, null, "غانا", "Ghana" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 85, "422", new Guid("6039a9d5-50d8-459e-b3a9-d0f67872d5da"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "224", true, "gn", null, null, "غينيا", "Guinea" },
                    { 86, "423", new Guid("74077b6a-33d3-4ece-8c13-3b96548abad2"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "245", true, "gw", null, null, "غينيابيساو", "Guinea Bissau" },
                    { 87, "424", new Guid("0b8daf4d-f608-4841-a574-3b1d10846dca"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "226", true, "bf", null, null, "بوركينافاسو", "Burkina Faso" },
                    { 88, "425", new Guid("346863ad-2709-4173-945c-f72bfe5008e1"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "237", true, "cm", null, null, "الكاميرون", "Cameroon" },
                    { 89, "426", new Guid("6133b0a4-7f53-41a4-8545-1a12e6833c44"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "243", true, "cd", null, null, "جمهورية الكونغو الديمقراطية", "Congo(DRC)" },
                    { 90, "427", new Guid("8271e615-6e55-4283-9642-70a930fa1b2e"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "254", true, "ke", null, null, "كينيا", "Kenya" },
                    { 91, "428", new Guid("ccb80bff-46b9-4a6c-9161-2b95ea2c262a"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "266", true, "ls", null, null, "ليسوتو", "Lesotho" },
                    { 92, "429", new Guid("caa9c47e-dc90-469b-8055-d4218041711d"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "231", true, "lr", null, null, "ليبيريا", "Liberia" },
                    { 93, "430", new Guid("fdc07997-f94c-4a7b-b477-de35312fad93"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "223", true, "ml", null, null, "مالي", "Mali" },
                    { 94, "432", new Guid("2ce4a6a4-4f59-4182-9532-e7e3167c43cc"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "265", true, "mw", null, null, "ملاوي", "Malawi" },
                    { 95, "433", new Guid("c15a2ebe-d2d1-4ec7-9699-6c510aaf4443"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "230", true, "mu", null, null, "موريشيوس", "Mauritius" },
                    { 96, "434", new Guid("adccae2e-0228-4090-a685-8b8babda4f9a"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "258", true, "mz", null, null, "موزمبيق", "Mozambique" },
                    { 97, "435", new Guid("153c0448-2979-4568-8dac-52c8d140a8a9"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "234", true, "ng", null, null, "نيجيريا", "Nigeria" },
                    { 98, "436", new Guid("be6e902a-66dd-4bad-964f-dc56483290ea"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "227", true, "ne", null, null, "النيجر", "Niger" },
                    { 99, "437", new Guid("85f7b1a8-0c08-4151-9698-1136d8fa3d8d"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "236", true, "cf", null, null, "افريقيا الوسطى", "Central Africa" },
                    { 100, "438", new Guid("ff68e4da-1fbe-4108-bc4c-f55c1baa0d29"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "244", true, "ao", null, null, "انجولا", "Angola" },
                    { 101, "439", new Guid("3cbb7b24-5932-4f2c-9fbb-2fdaf8a511fc"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "599", true, "bq", null, null, "الجزر الكاريبية الهولندية", "Caribbean Netherlands" },
                    { 102, "440", new Guid("8fa4c5fc-4a70-49ac-a91c-72e73df57453"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "240", true, "gq", null, null, "غينيا الاستوائية", "Equatorial Guinea" },
                    { 103, "441", new Guid("878457be-fb9d-4f30-b0fb-db5f2c509e63"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "ملاجاسي", "Mlajasi" },
                    { 104, "442", new Guid("cfb570db-05e5-4e52-9a73-09b1365f6c8e"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "239", true, "st", null, null, "ساوتومي/برنسبى", "S? o Tomé and Pr? ncipe" },
                    { 105, "443", new Guid("ba6be218-0db6-4137-a70a-c542d717b225"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "248", true, "sc", null, null, "جزر سيشل", "Seychelles Islands" },
                    { 106, "444", new Guid("c77d345e-9e23-4417-af2f-4c1faa968246"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "268", false, "sz", null, null, "سوزيلاند", "Swaziland" },
                    { 107, "449", new Guid("9807ee59-cd9f-49ce-a7db-e2157dae7f84"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "291", true, "er", null, null, "ارتيريا", "Eritrea" },
                    { 108, "453", new Guid("942778b8-6bda-4a15-be77-2eb7f3532a9a"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "211", false, "ss", null, null, "جمهورية جنوب السودان", "Republic of South Sudan" },
                    { 109, "454", new Guid("9f32239f-049b-4344-9ab2-13222f072d2c"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "238", true, "cv", null, null, "كاب فيرد(الراس الاخضر)", "Cape Verde" },
                    { 110, "501", new Guid("3af8572b-3564-43c2-8095-bc400cc5198b"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "34", true, "es", null, null, "اسبانيا", "Spain" },
                    { 111, "502", new Guid("906e87aa-9127-4203-adc2-5a282e077d90"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "355", true, "al", null, null, "البانيا", "Albania" },
                    { 112, "503", new Guid("410e4d0b-2a39-423a-a3c3-80207d352650"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "49", true, "de", null, null, "المانيا", "Germany" },
                    { 113, "504", new Guid("dca982a3-c3d8-4b92-ae79-6abde2c96d44"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "353", true, "ie", null, null, "ايرلندا", "Ireland" },
                    { 114, "505", new Guid("0579addb-1d5c-46d0-be8d-76061d0184d9"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "39", true, "it", null, null, "ايطاليا", "Italy" },
                    { 115, "506", new Guid("dabc1ca8-66fd-4f3c-acad-7fd0d1cfa6af"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "44", true, "gb", null, null, "المملكة المتحدة", "United Kingdom" },
                    { 116, "507", new Guid("cc3772dd-f133-4a6c-9e0c-0d1bc27c06bd"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "351", true, "pt", null, null, "البرتغال", "Portugal" },
                    { 117, "508", new Guid("aa96d542-23d0-47ac-916f-cb3b2c9701f5"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "359", true, "bg", null, null, "بلغاريا", "Bulgaria" },
                    { 118, "509", new Guid("1388ce11-a0f4-46c9-8469-1e4e45e06b15"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "32", true, "be", null, null, "بلجيكا", "Belgium" },
                    { 119, "510", new Guid("fa7dd0a0-07fa-44e2-a4dd-c0756d5fd0db"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "48", true, "pl", null, null, "بولندا", "Poland" },
                    { 120, "512", new Guid("912b734f-3fec-4c51-849c-a384efa37d2c"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "45", true, "dk", null, null, "الدانمارك", "Denmark" },
                    { 121, "513", new Guid("a19a1bd3-8687-4817-9abd-2ef9cab52c7c"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "40", true, "ro", null, null, "رومانيا", "Romania" },
                    { 122, "514", new Guid("c6bbf7c3-22e1-4469-9c29-fd89a297958d"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "46", true, "se", null, null, "السويد", "Sweden" },
                    { 123, "515", new Guid("d49b48f4-de69-41fb-9e1a-b95947c5a572"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "41", true, "ch", null, null, "سويسرا", "Switzerland" },
                    { 124, "516", new Guid("0a31c548-1d06-401e-b2cb-0ac3bc4455e6"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "33", true, "fr", null, null, "فرنسا", "France" },
                    { 125, "517", new Guid("375f8235-af21-4a5d-918b-498b228496da"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "358", true, "fi", null, null, "فنلندا", "Finland" },
                    { 126, "518", new Guid("1b379977-612c-4d23-8ae0-640097f51e01"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "381", true, "rs", null, null, "صربيا", "Serbia" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 127, "519", new Guid("4b6350f1-dda4-4d96-8901-fffbb6864093"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "31", true, "nl", null, null, "هولندا", "Netherlands" },
                    { 128, "521", new Guid("bd3a9734-de5c-430b-af8f-05dc7a53d0fe"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "30", true, "gr", null, null, "اليونان", "Greece" },
                    { 129, "522", new Guid("66c43789-6f00-4ee7-8042-86ce8e0e7f1c"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "376", true, "ad", null, null, "اندورا", "Andorra" },
                    { 130, "523", new Guid("a189987c-58d7-46ca-8bdd-3a099703f113"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "43", true, "at", null, null, "النمسا", "Austria" },
                    { 131, "524", new Guid("d8ca7081-c14e-432a-9ed7-e017140d4fd5"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "382", true, "me", null, null, "الجبل الأ سود", "Montenegro" },
                    { 132, "525", new Guid("ec4ed658-7027-4e65-9334-249c8e89b507"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "36", true, "hu", null, null, "هنغاريا", "Hungary" },
                    { 133, "526", new Guid("e63c52eb-eb63-42e8-be26-93ca1d794961"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "354", true, "is", null, null, "ايسلندا", "Iceland" },
                    { 134, "527", new Guid("35aceb80-a982-4ee0-916f-f52bd6521bee"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "423", true, "li", null, null, "ليختنشتين", "Liechtenstein" },
                    { 135, "528", new Guid("f4213731-3fdb-4e8a-ba15-11b81ee316ef"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "352", true, "lu", null, null, "لوكسمبورغ", "Luxembourg" },
                    { 136, "529", new Guid("3a93546b-9845-4360-9352-961e84c7710f"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "356", true, "mt", null, null, "مالطا", "Malta" },
                    { 137, "530", new Guid("230a6255-b8ce-4ff6-889e-a9834dca3096"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "377", true, "mc", null, null, "موناكو", "Monaco" },
                    { 138, "531", new Guid("985fcbee-f740-4e9a-bcc0-48acb1007b4d"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "47", true, "no", null, null, "النرويج", "Norway" },
                    { 139, "532", new Guid("d512dbae-3337-413f-943f-07dd49cfd9db"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "378", true, "sm", null, null, "سان مارينو", "San Marino" },
                    { 140, "533", new Guid("21821f94-b7e7-4500-9618-35ca5cc98fb9"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "39", true, "va", null, null, "مدينة الفاتيكان", "Vatican City" },
                    { 141, "534", new Guid("85fbf590-dd05-4bdb-8dc1-49392ea29120"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "350", true, "gi", null, null, "جبل طارق", "Gibraltar" },
                    { 142, "536", new Guid("fc3ca058-942e-4b4f-b521-db43eda07faf"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "380", true, "ua", null, null, "اوكرانيا", "Ukraine" },
                    { 143, "537", new Guid("698b701a-7414-44eb-bd5c-83f9e834ebfa"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "روسيا البيضاء", "Byelorussia" },
                    { 144, "539", new Guid("b612ed31-c5e5-44e4-9a08-3cdaecfd37e0"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "374", true, "am", null, null, "ارمينيا", "Armenia" },
                    { 145, "540", new Guid("799629e8-445f-4ae3-b560-7467117cdca6"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "373", true, "md", null, null, "مولدافيا", "Moldova" },
                    { 146, "541", new Guid("d5a94f5d-4a4f-4163-a095-5ef2c50c7563"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "995", true, "ge", null, null, "جورجيا", "Georgia" },
                    { 147, "542", new Guid("c399b2d1-abea-4ec8-b3ca-f1e41be2aab1"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "370", true, "lt", null, null, "ليتوانيا", "Lithuania" },
                    { 148, "543", new Guid("dc45ef0b-db1d-4560-905d-e0b1daf5f518"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "372", true, "ee", null, null, "استونيا", "Estonia" },
                    { 149, "544", new Guid("8ae3eb14-c029-447b-97e6-3a690330e905"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "371", true, "lv", null, null, "لاتفيا", "Latvia" },
                    { 150, "545", new Guid("6fe00636-1510-4601-8e39-3cb589de0284"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "387", true, "ba", null, null, "البوسنة والهرسك", "Bosnia / Herzegovina" },
                    { 151, "546", new Guid("dcbe2a95-e5a2-4f03-97c6-da4cbb914913"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "385", true, "hr", null, null, "كرواتيا", "Croatia" },
                    { 152, "547", new Guid("cc2bddd2-76ba-40fe-b36f-c8c8e130bb33"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "386", true, "si", null, null, "سلوفينيا", "Slovenia" },
                    { 153, "549", new Guid("a5f94989-fec3-4954-8768-f491ad1a619a"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "389", true, "mk", null, null, "مقدونيا", "Macedonia" },
                    { 154, "552", new Guid("6b09dea0-beeb-45a6-b772-81757ddcb068"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "420", true, "cz", null, null, "تشيك", "Czech Republic" },
                    { 155, "553", new Guid("635bfea0-cdb2-404d-8aea-ee1ecce5ea7a"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "421", true, "sk", null, null, "سلوفاكيا", "Slovakia" },
                    { 156, "554", new Guid("37b65973-5f05-4e5f-aa60-4eabef9e2a5a"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "298", true, "fo", null, null, "جزر فيرو", "Faroe Islands" },
                    { 157, "555", new Guid("7aebd238-4900-4553-ba19-3d8b8d8bd1e8"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "33", false, "fx", null, null, "ميتروبوليتان فرنسية", "France Metropolitan" },
                    { 158, "601", new Guid("418e1a82-3a1a-4c99-9e22-6111f7bfb935"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "us", null, null, "الولايات المتحدة", "United States" },
                    { 159, "602", new Guid("ef72e05b-f805-4b44-8ff5-467805ae9947"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "54", true, "ar", null, null, "الارجنتين", "Argentina" },
                    { 160, "603", new Guid("f182ec71-fbde-4119-8c15-0df7b50c8bdc"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "bb", null, null, "بربادوس", "Barbados" },
                    { 161, "604", new Guid("bd198d48-8dfb-4480-9b1c-497fff1dd956"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "55", true, "br", null, null, "البرازيل", "Brazil" },
                    { 162, "605", new Guid("3fe7a2cd-d80e-4b2c-96fc-5dee9505219b"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "507", true, "pa", null, null, "بنما", "Panama" },
                    { 163, "606", new Guid("8216bc18-f95b-451a-b7a2-5c4b897664eb"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "tt", null, null, "ترينداد وتوباجو", "Trinidad and Tobago" },
                    { 164, "607", new Guid("addab93b-ecd9-43fe-aba5-e53807516814"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "jm", null, null, "جامايكا", "Jamaica" },
                    { 165, "608", new Guid("333b69d4-e855-4777-ad62-4c6afe5e98ef"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, null, "جوانا", "Joanna" },
                    { 166, "609", new Guid("002e2747-df86-4ab0-857c-76d826387472"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "58", true, "ve", null, null, "فنزويلا", "Venezuela" },
                    { 167, "610", new Guid("441ad416-388f-47c3-ade2-fd21eb42457f"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "ca", null, null, "كندا", "Canada" },
                    { 168, "611", new Guid("37db7d88-95e2-47ab-97d5-dda888583ee0"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "57", true, "co", null, null, "كولمبيا", "Columbia" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Nationalities",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "CreatedUserId", "DialCode", "IsActive", "Iso2", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 169, "612", new Guid("78db8339-4379-4fa7-ad97-f32ef8497ad4"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "bs", null, null, "جزر البهاما", "Bahamas" },
                    { 170, "613", new Guid("56702d85-0256-4f01-84bb-c5f2b5151bdc"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "506", true, "cr", null, null, "كوستاريكا", "Costa Rica" },
                    { 171, "614", new Guid("b43bcccd-d495-4286-8166-4541557689ce"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "53", true, "cu", null, null, "كوبا", "Cuba" },
                    { 172, "615", new Guid("dbf8702e-83a1-4cb7-a61d-fad05855d07d"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "dm", null, null, "دومينيكا", "Dominica" },
                    { 173, "616", new Guid("5b3ba34c-0bbf-4b51-ad99-8ea27e9c1c65"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "do", null, null, "جمهورية دمينكان", "Republic Dominica" },
                    { 174, "617", new Guid("fb498e88-3815-4137-80db-89c5a940f73f"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "503", true, "sv", null, null, "السلفادور", "El Salvador" },
                    { 175, "618", new Guid("cdf7a348-961e-488d-85c9-5cefe3398302"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "gd", null, null, "جرانادا", "Granada" },
                    { 176, "619", new Guid("6bd7d3e7-4f9c-444b-840a-fed846f11a22"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "502", true, "gt", null, null, "جواتيمالا", "Guatemala" },
                    { 177, "620", new Guid("b860cecc-6ec5-42d8-aa7d-5e58a93ceb39"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "509", true, "ht", null, null, "هايتي", "Haiti" },
                    { 178, "621", new Guid("098f5b15-f8fc-4ce5-a367-e20e78e4a079"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "504", true, "hn", null, null, "هوندوراس", "Honduras" },
                    { 179, "622", new Guid("7a1b983a-93cc-47f6-97fc-42fd57d6a9bf"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "52", true, "mx", null, null, "المكسيك", "Mexico" },
                    { 180, "623", new Guid("512d4c53-a399-4f6e-86eb-8dde79372e77"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "505", true, "ni", null, null, "نيكاراجوا", "Nicaragua" },
                    { 181, "624", new Guid("ad7939ec-051e-493a-9d39-0eb86ff4effb"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "lc", null, null, "سانت لوسيا", "Saint Lucia" },
                    { 182, "625", new Guid("3eab17fe-54e5-4240-912e-7f717e454e44"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", true, "vc", null, null, "سان فينسنت", "Saint Vincent" },
                    { 183, "626", new Guid("bbce09e7-ef04-492c-8e4b-90e9864e0b97"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "591", true, "bo", null, null, "بوليفيا", "Bolivia" },
                    { 184, "627", new Guid("438b7146-e274-46ab-b4ca-8836781a2879"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "56", true, "cl", null, null, "شيلي", "Chile" },
                    { 185, "628", new Guid("2039b6e1-4dd3-40a5-9de1-291c8bf5ed11"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "593", true, "ec", null, null, "اكوادور", "Ecuador" },
                    { 186, "629", new Guid("df3a50db-11c2-40d8-a5f6-62236abcf8e3"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "595", true, "py", null, null, "باراجواي", "Paraguay" },
                    { 187, "630", new Guid("158f0199-d69d-4fae-b1ec-189135b431e8"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "51", true, "pe", null, null, "بيرو", "Peru" },
                    { 188, "701", new Guid("95f5ac7e-6c4d-41e2-86b6-3b7b7e24f520"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "61", true, "au", null, null, "استراليا", "Australia" },
                    { 189, "702", new Guid("b317d0fe-adb8-4997-bbd4-cf9190735b32"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "64", true, "nz", null, null, "نيوزيلندا", "New Zealand" },
                    { 190, "703", new Guid("438efe9a-d177-41d7-a2c0-edd49e8d8a77"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "598", true, "yu", null, null, "أوروغواي", "Uruguay" }
                });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "FullNameAr", "FullNameEn", "IsActive", "IsEmployee", "IsMale", "Last2Factor", "LastLoginDate", "LastModifiedDate", "NationalityId", "PasswordHash", "PasswordSalt", "PhoneNumber", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "superadmin@gmail.com", "مدير عام النظام", "Super System Admin", true, true, true, null, null, null, null, new byte[] { 195, 241, 126, 211, 70, 4, 157, 34, 38, 100, 96, 223, 54, 203, 130, 10, 107, 218, 137, 125, 246, 121, 179, 107, 19, 49, 121, 87, 122, 175, 52, 213, 160, 137, 139, 26, 107, 47, 180, 53, 18, 214, 178, 41, 43, 66, 216, 246, 214, 98, 162, 181, 183, 8, 53, 40, 52, 123, 181, 18, 25, 9, 97, 254 }, new byte[] { 51, 206, 128, 107, 175, 127, 255, 210, 88, 250, 101, 220, 71, 240, 53, 167, 104, 31, 40, 77, 34, 112, 75, 128, 157, 33, 40, 225, 167, 234, 63, 9, 27, 161, 221, 40, 34, 9, 9, 117, 35, 221, 146, 199, 174, 135, 92, 230, 169, 86, 135, 199, 26, 86, 41, 81, 203, 96, 172, 251, 238, 135, 6, 122, 214, 39, 192, 95, 14, 3, 96, 102, 254, 53, 91, 203, 59, 53, 50, 131, 116, 12, 222, 14, 218, 155, 137, 235, 169, 60, 76, 162, 105, 237, 211, 50, 238, 164, 195, 225, 226, 192, 88, 26, 219, 150, 39, 96, 98, 163, 238, 31, 27, 82, 152, 12, 46, 159, 235, 22, 141, 199, 67, 21, 3, 200, 225, 126 }, "0500000000", true, "superadmin" },
                    { new Guid("aa42bf46-7255-4347-a10d-9a0f58fc1c80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@yahoo.com", "مدير النظام", "System Admin", true, false, true, null, null, null, null, new byte[] { 195, 241, 126, 211, 70, 4, 157, 34, 38, 100, 96, 223, 54, 203, 130, 10, 107, 218, 137, 125, 246, 121, 179, 107, 19, 49, 121, 87, 122, 175, 52, 213, 160, 137, 139, 26, 107, 47, 180, 53, 18, 214, 178, 41, 43, 66, 216, 246, 214, 98, 162, 181, 183, 8, 53, 40, 52, 123, 181, 18, 25, 9, 97, 254 }, new byte[] { 51, 206, 128, 107, 175, 127, 255, 210, 88, 250, 101, 220, 71, 240, 53, 167, 104, 31, 40, 77, 34, 112, 75, 128, 157, 33, 40, 225, 167, 234, 63, 9, 27, 161, 221, 40, 34, 9, 9, 117, 35, 221, 146, 199, 174, 135, 92, 230, 169, 86, 135, 199, 26, 86, 41, 81, 203, 96, 172, 251, 238, 135, 6, 122, 214, 39, 192, 95, 14, 3, 96, 102, 254, 53, 91, 203, 59, 53, 50, 131, 116, 12, 222, 14, 218, 155, 137, 235, 169, 60, 76, 162, 105, 237, 211, 50, 238, 164, 195, 225, 226, 192, 88, 26, 219, 150, 39, 96, 98, 163, 238, 31, 27, 82, 152, 12, 46, 159, 235, 22, 141, 199, 67, 21, 3, 200, 225, 126 }, "0500000001", true, "admin" }
                });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "Charities",
                columns: new[] { "Id", "Address", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "Email", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn", "PhoneNumber" },
                values: new object[] { new Guid("22d0eeca-467a-48bc-a600-3624ff0887b6"), "AddressAddressAddressAddress", new Guid("854d7aa8-9486-49dd-ad81-3bf4ba375ab8"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dimah@d.org", true, null, null, "ديمه", "Dimah", "0501234567" });

            migrationBuilder.InsertData(
                schema: "DataManagement",
                table: "Posters",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "ImageName", "IsActive", "LastModifiedBy", "LastModifiedDate", "Order", "TitleAr", "TitleEn" },
                values: new object[,]
                {
                    { new Guid("08a67378-487c-40f3-9d53-5c2acb9cb78d"), new Guid("81c87907-3f74-408b-86ec-bf5c0fa2abae"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "banner2.jpg", true, null, null, 2, "تجربة", "test" },
                    { new Guid("f760c6af-419a-4378-9348-d6742ee62f9d"), new Guid("2f5b8170-ff17-45ff-9fa2-37b3d0e52786"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "banner1.png", true, null, null, 1, "حديث", "Hadieth" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "ProjectTypes",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "ImageName", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("02fa2cc2-2c01-402b-91fa-84526ca51edc"), new Guid("29b499bf-7ec3-46b6-9989-2c115c15fb37"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "maried.svg", true, null, null, "زواج", "Marriage" },
                    { new Guid("3060bbf4-415c-4767-8ad6-ba49685a31e1"), new Guid("34a866e0-6a6f-40f3-bc66-65de279b8761"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "food.svg", true, null, null, "إفطار صائم", "Break Fast" },
                    { new Guid("7a24cdc2-0f48-4e34-9c8e-745a9b06d0d7"), new Guid("b0e2dc82-e2c1-4c4c-b91a-ba8aefe84794"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "water-dot.svg", false, null, null, "سقيا الماء", "Water" },
                    { new Guid("9830a808-b80b-41d6-84fb-b186bbec6d45"), new Guid("c04719d4-85af-45e6-869c-a46c99633d2d"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "food-method.svg", true, null, null, "وجبة معتمر", "Eating" }
                });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new Guid("8b769c3b-1777-434e-9ef0-e63610403dfa"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "مدير عام النظام", "Super System Admin" },
                    { 2, new Guid("9ad49456-9c02-4ebd-bd73-09b1b34b93a8"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "مدير النظام", "System Admin" },
                    { 3, new Guid("e995a86c-ad39-4e88-b692-7326dc54480c"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "صلاحيات الاعدادات", "Setting Permission" },
                    { 4, new Guid("9fb76ec9-2711-4093-8c5c-bcbf48e887d6"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "صلاحيات المستخدمين", "Users Permission" }
                });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "UserRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RoleId", "UserId" },
                values: new object[] { new Guid("0b93bea1-eee3-4838-8513-7ade73017e5a"), new Guid("6aaa31c7-f3d6-40d1-852f-5bfab94f05e2"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2, new Guid("aa42bf46-7255-4347-a10d-9a0f58fc1c80") });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "UserRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "RoleId", "UserId" },
                values: new object[] { new Guid("e8de7eaf-13f0-4c77-b341-45f3cc10bc00"), new Guid("d0388b67-d6ad-4468-9e76-61a3755f5840"), new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, new Guid("83ee0b03-015e-4441-9294-8a4421d3b124") });

            migrationBuilder.CreateIndex(
                name: "IX_Charities_CreatedBy",
                schema: "DataManagement",
                table: "Charities",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Charities_LastModifiedBy",
                schema: "DataManagement",
                table: "Charities",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CharityProjects_CharityId",
                schema: "DataManagement",
                table: "CharityProjects",
                column: "CharityId");

            migrationBuilder.CreateIndex(
                name: "IX_CharityProjects_CreatedBy",
                schema: "DataManagement",
                table: "CharityProjects",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CharityProjects_LastModifiedBy",
                schema: "DataManagement",
                table: "CharityProjects",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CharityProjects_ProjectTypeId",
                schema: "DataManagement",
                table: "CharityProjects",
                column: "ProjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Nationalities_CreatedUserId",
                schema: "Lookup",
                table: "Nationalities",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Nationalities_LastModifiedBy",
                schema: "Lookup",
                table: "Nationalities",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Posters_CreatedBy",
                schema: "DataManagement",
                table: "Posters",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Posters_LastModifiedBy",
                schema: "DataManagement",
                table: "Posters",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTypes_CreatedBy",
                schema: "Lookup",
                table: "ProjectTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTypes_LastModifiedBy",
                schema: "Lookup",
                table: "ProjectTypes",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_CreatedBy",
                schema: "Auth",
                table: "Roles",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_LastModifiedBy",
                schema: "Auth",
                table: "Roles",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UploadedFiles_CreatedBy",
                schema: "FileManager",
                table: "UploadedFiles",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UploadedFiles_LastModifiedBy",
                schema: "FileManager",
                table: "UploadedFiles",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_CreatedBy",
                schema: "Auth",
                table: "UserRoles",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_LastModifiedBy",
                schema: "Auth",
                table: "UserRoles",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "Auth",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                schema: "Auth",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_NationalityId",
                schema: "Auth",
                table: "Users",
                column: "NationalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Charities_Users_CreatedBy",
                schema: "DataManagement",
                table: "Charities",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Charities_Users_LastModifiedBy",
                schema: "DataManagement",
                table: "Charities",
                column: "LastModifiedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Nationalities_Users_CreatedUserId",
                schema: "Lookup",
                table: "Nationalities",
                column: "CreatedUserId",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Nationalities_Users_LastModifiedBy",
                schema: "Lookup",
                table: "Nationalities",
                column: "LastModifiedBy",
                principalSchema: "Auth",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nationalities_Users_CreatedUserId",
                schema: "Lookup",
                table: "Nationalities");

            migrationBuilder.DropForeignKey(
                name: "FK_Nationalities_Users_LastModifiedBy",
                schema: "Lookup",
                table: "Nationalities");

            migrationBuilder.DropTable(
                name: "CharityProjects",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "Posters",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "UploadedFiles",
                schema: "FileManager");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "Charities",
                schema: "DataManagement");

            migrationBuilder.DropTable(
                name: "ProjectTypes",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "Nationalities",
                schema: "Lookup");
        }
    }
}
