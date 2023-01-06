using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dimah.InfraStructure.Migrations
{
    public partial class addRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyRequestMains",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonationValue = table.Column<int>(type: "int", nullable: false),
                    DonationPeriod = table.Column<int>(type: "int", nullable: false),
                    ActForName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ActForMobile = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsFinished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyRequestMains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyRequestMains_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DailyRequestDetails",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DailyRequestMainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPayed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyRequestDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyRequestDetails_DailyRequestMains_DailyRequestMainId",
                        column: x => x.DailyRequestMainId,
                        principalSchema: "Request",
                        principalTable: "DailyRequestMains",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Charities",
                keyColumn: "Id",
                keyValue: new Guid("22d0eeca-467a-48bc-a600-3624ff0887b6"),
                column: "ConcurrencyStamp",
                value: new Guid("1d267ead-9bc9-4339-8994-829575b78b01"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("56c7f9c1-e145-4e6a-9f91-36f4f67eb236"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("b8d3a202-4012-4e54-b182-c1c496cef985"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("03dbc63f-d504-494e-81a8-a58165946ab2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("7e7fa7b8-3d28-427c-909d-a67637b1c6b2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("df615176-ba17-493b-8e0e-4ceec0b79754"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("353cdea7-bd3c-4c30-8e2c-8d46c18156df"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("9d5e4e1c-5832-4f8e-acd2-494976dafb07"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("a1803c21-ab4a-468d-b3bc-aa43e60efcf7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("6467412c-74f0-4633-bcd4-95ecb8a54f71"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("91ab1f23-3d2d-4c8a-ab65-f1fe65101cea"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("df49f3b4-dbf4-46ea-b116-5c6899ac6ab8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("8e4c56c2-4eb1-4f09-9bd8-ea8e52366ec7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("4b934295-550f-48cc-9427-c20bb48d0a92"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("100f1122-f42c-4ce5-bac9-e3bc2401cb60"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("90853f3c-952d-49c8-8db0-919a1a84006f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("525f226b-4f82-4188-8c26-8a7e0dfc39f6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("dfa4ae77-7054-487e-aa25-9b5c13d241c0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("383f1ac0-86be-4a08-8f5d-f75566f17627"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("66d045f8-06ca-4ca3-a7e3-abf42577e0f8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("92f08c97-9e68-4d27-882f-817dbcceacc7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("f56339ba-7daa-4b35-b60b-1c0e60506538"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("c5f616c2-d5d2-469a-b46d-fbae3adc5f7e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("710e13b3-ec94-4430-bf39-32d8433815c7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("677cdd99-875e-4a43-aade-68cbd08c01b7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("5d49ab9d-d270-4ae0-af59-57dc1875471f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("440415e9-f06c-47ed-920a-a0e07e10d40b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("dd8ae3dc-8b9c-4059-8eb0-8ac95b062975"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("38fd1d6a-0ad5-4755-9376-fd4c295f691f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("ce8335b5-ca07-44cc-bc6e-7d65314fc264"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("78e24702-c560-4c36-8468-de18b14be9e7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("f9d6edd4-7c5c-4564-a39f-522c09fc5e60"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("723964e8-f71c-49e6-b3b6-955299b6e42b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("fefb6e03-db20-481f-afc6-c58fe06243b6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("028d0491-890e-4a2d-9a4b-489bf351bd15"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("23eda79f-2d6f-45ec-9242-2e7023a854b4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("de81a064-fee3-4cc5-ba5f-44f4d3d27478"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("d6687e29-de25-48f4-bdf4-72735cb21fb8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("533e0717-5540-419b-8504-3fd2e737aed4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("e5e74822-af78-4413-9dd5-75bd5bc635a0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("140dd61e-5b76-4b7e-b411-885e89b6bec5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("6c909c71-3e0d-492a-879a-cc309c4b4ce9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("0d50a814-fef9-4aef-ab50-8a48b57fc9b3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("6b2f321f-3078-4da3-a147-616de875c2b0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("18817e54-553f-492a-87aa-165773ceb40f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("6aae8173-77fe-4e41-b00b-99f6dec19151"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("c0cd49f6-45e7-4fa6-82e2-4b85c4321b2c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("750825b3-1b75-407f-8d31-02049a08a41a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("3508d912-4aaa-4f30-943d-cdf79468ec0b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("7d104a58-1f8f-4f33-b203-5346aa582904"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("705fad46-da2d-4b57-8112-c28742416e6f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("b537956f-6998-47da-8321-dd5cecf168cf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("8728e59f-cc57-4408-bc3e-901a250f015c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("52bfdb0f-d124-478c-b5f3-60a14622ae17"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("2481ac84-65c5-4816-b9c0-d37aaec398f0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("88d40868-7aab-4693-8b4a-1337a930c286"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("a3aaa61c-7210-4cba-aaa2-b0181cfc18f2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("e4028237-11d6-4ab7-84f4-ca3c3c2a6a19"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("4d95faa9-d843-4968-a2c4-c2f745f12088"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("51bf4009-929d-49eb-9bdb-daec1a87a981"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("4237dfc6-0202-432c-8def-6defeacfea92"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("9cf63a2b-a542-4c6b-b242-52f271b1578c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("56e3f252-ced3-4b84-a901-9b699e6c38f1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("dca2f0bd-9f2a-4ac0-a4aa-a44c8d1fd901"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("c5469a7f-1478-47fd-8cd0-a2c8054d15d3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("99f18bf4-9720-41f1-9e37-5234630eb626"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("984bf118-868a-4338-8cfd-f7b9ccf7f207"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("719cab88-edf6-4b7d-babd-eab6f955fd14"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("85317963-cf43-49f5-9b04-dd02277c6511"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("f0585212-7553-4045-bed6-2e93b08b7009"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("06efdb0a-a6d8-4006-b2d2-c69d5d389165"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: new Guid("dd3c633c-b636-4cdb-9db4-717c64851f49"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: new Guid("f1f0c8ee-913d-416e-a362-8f5441c9048a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: new Guid("fd7630e6-3073-4430-a322-bfa2c69bc3d6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: new Guid("50f97ccd-0157-4027-bd88-5fc4f4565a74"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: new Guid("6d66d593-4ada-4a84-a337-5de21354c8a1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: new Guid("03ac9a8b-349a-4652-8390-b998360000f8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: new Guid("bf751614-acea-4e19-8aa7-9ae913cc49c5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: new Guid("349f1663-4d67-4873-9518-b8303f7b78f2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: new Guid("7a341238-7a71-4cc1-a8a7-ed6dfede4e60"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: new Guid("429e5f5b-75ab-456e-9670-5d924d3132ca"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: new Guid("3880ca3e-61ac-441f-9426-dd0864cd4682"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: new Guid("79298126-328a-48ec-bf27-df605e5ca812"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: new Guid("94dbda63-ac62-4b23-8561-bcabab676596"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: new Guid("9e11b673-b7e0-4bf1-ac92-8fdb2e9198f7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: new Guid("c267dde9-e314-4183-bbb2-5f4dc1ae670f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: new Guid("54f3c4b9-1ec9-4e6d-845b-6b762fef709b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: new Guid("a3159586-2739-4496-ae33-af3ba4222b1d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: new Guid("63a21cc0-a1da-464a-b13f-77391ff87933"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: new Guid("9d021116-d319-4817-bd0a-5d590356e15b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: new Guid("ed0f3ae5-61d5-493f-89e3-d1c22a2cdb58"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: new Guid("35ed0f8c-a218-4b47-8724-726f97cd3fdf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: new Guid("c280ece7-92c7-45e0-9d6f-6087eda0c6e4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: new Guid("64a8d986-d9e8-458b-9899-78036e7bd804"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: new Guid("4a509a24-e993-4460-9bcf-54c16976678e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: new Guid("081b6b89-001e-4495-bc9a-1ba52ea83bc8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: new Guid("ce3a9210-4e44-4b16-ac2c-b750b7fad43b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: new Guid("dd9dad50-3fb5-489c-a576-812885d63596"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: new Guid("6bc86e97-9622-48d4-9e38-361e652e21bf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: new Guid("5eaa9e23-1928-42dd-aa5d-a9893c88cbda"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: new Guid("3abeb15c-728e-4ef4-b081-bc2176bf232a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: new Guid("8a59d761-5f13-400e-a550-04a553fe3bfe"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: new Guid("8ff886ed-b103-4fc3-8558-b8a8e81c8ed1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: new Guid("80abeca0-663e-4471-ab7d-a2098a967272"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: new Guid("d846dabf-1196-4874-9c6d-21b12263367b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: new Guid("86a98938-f3b8-47ad-a86a-d197b290f5f0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: new Guid("ab6d9188-446e-4205-8c4b-7ad4f164afdc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: new Guid("ef568c55-68e4-41f7-aca0-0787b566d6f2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: new Guid("a5d730ed-3b1c-4546-bfb3-c38a9838c388"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: new Guid("d8310478-8e7b-492e-b246-9ea110fe444a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: new Guid("c39ce6f1-79d6-46c2-aac9-6b97cd328968"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: new Guid("dfdcf4fe-351f-405a-865f-b091e78c43ee"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: new Guid("adb24f95-5093-4ebd-809f-61163693e78c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: new Guid("84f8d3f7-515a-4ca8-8749-68340f69d30c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: new Guid("006e9b44-efdf-4476-9f49-53694b5b65ef"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 115,
                column: "ConcurrencyStamp",
                value: new Guid("842068c8-3b93-49ff-acaa-75a50404355e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 116,
                column: "ConcurrencyStamp",
                value: new Guid("3da3a8b3-4730-4997-a547-a92f4702bb23"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 117,
                column: "ConcurrencyStamp",
                value: new Guid("3e97be4e-a3f7-406b-b140-8bbadddd7e75"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 118,
                column: "ConcurrencyStamp",
                value: new Guid("180a50be-0e4c-43db-a3e6-a53e76f3f1dc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 119,
                column: "ConcurrencyStamp",
                value: new Guid("436f56c0-69e9-4b2a-8b18-a62bb11ba82d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 120,
                column: "ConcurrencyStamp",
                value: new Guid("88edb5a8-4868-46ba-950f-c561f495a3ff"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 121,
                column: "ConcurrencyStamp",
                value: new Guid("b126be7f-1060-467d-bf92-c0a8a18650ff"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 122,
                column: "ConcurrencyStamp",
                value: new Guid("dd858dac-c6d6-4686-b297-66566d5a26ad"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 123,
                column: "ConcurrencyStamp",
                value: new Guid("f2342479-d6b2-4d1b-b1de-4b75ac7be4e1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 124,
                column: "ConcurrencyStamp",
                value: new Guid("919f37d7-9536-4643-84f5-452c2522ae3e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 125,
                column: "ConcurrencyStamp",
                value: new Guid("76caa5d0-6454-4dcc-8b4a-7ab6aee7fdb6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 126,
                column: "ConcurrencyStamp",
                value: new Guid("5b481b7b-db96-4d0e-b3b1-de5e51a3f447"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 127,
                column: "ConcurrencyStamp",
                value: new Guid("77aac2c9-43ea-4b28-bd4a-085a3ab23191"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 128,
                column: "ConcurrencyStamp",
                value: new Guid("1373446c-2cb9-4c2e-a6ce-c6bafa6917d6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 129,
                column: "ConcurrencyStamp",
                value: new Guid("5380660f-bbd2-49bc-95a4-12c70c0640d1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 130,
                column: "ConcurrencyStamp",
                value: new Guid("0e7da324-4475-4e1f-940c-e103674ad5b1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 131,
                column: "ConcurrencyStamp",
                value: new Guid("ce5c9ba5-e13c-4b91-81c8-634d5cf68c22"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 132,
                column: "ConcurrencyStamp",
                value: new Guid("e9f2cf6b-509f-477b-b67d-1e8dfd16d059"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 133,
                column: "ConcurrencyStamp",
                value: new Guid("529fdea9-280d-47b6-bab4-6d821a3907d2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 134,
                column: "ConcurrencyStamp",
                value: new Guid("14d21a2e-e85b-472b-b8f5-f2f58cd3183f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 135,
                column: "ConcurrencyStamp",
                value: new Guid("9e79427b-512f-4a37-b2f7-49d86a685711"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 136,
                column: "ConcurrencyStamp",
                value: new Guid("d1ac84d4-7503-4503-bb98-456d1b0f5bd9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 137,
                column: "ConcurrencyStamp",
                value: new Guid("e5f77bc7-bf5b-4351-b27f-1dd898651586"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 138,
                column: "ConcurrencyStamp",
                value: new Guid("ecc94a1c-0f5f-4a99-807b-535afeba41f7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 139,
                column: "ConcurrencyStamp",
                value: new Guid("7cc3700b-6866-4c02-ad93-b80c5e551ca0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 140,
                column: "ConcurrencyStamp",
                value: new Guid("466e0ee7-6fd6-4bc7-88d3-d57fc39fe8b3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 141,
                column: "ConcurrencyStamp",
                value: new Guid("7c179ba2-deef-4710-ade1-ae392d9d4acf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 142,
                column: "ConcurrencyStamp",
                value: new Guid("0dae8e38-bf34-4ba8-b6ce-3b553cece10a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 143,
                column: "ConcurrencyStamp",
                value: new Guid("708edd94-a5b9-4800-8df9-7467e9fae393"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 144,
                column: "ConcurrencyStamp",
                value: new Guid("f0f27c1c-6c5c-4112-b032-287d9513179f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 145,
                column: "ConcurrencyStamp",
                value: new Guid("686b524d-d214-422b-adc3-c3b712d9e345"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 146,
                column: "ConcurrencyStamp",
                value: new Guid("6d8799d8-a50d-425f-b3e7-e246f222d052"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 147,
                column: "ConcurrencyStamp",
                value: new Guid("55dee491-be68-4ce8-8bab-38073a6282fc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 148,
                column: "ConcurrencyStamp",
                value: new Guid("c6a42e2b-2c11-4dff-8714-f19ae3a4ba14"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 149,
                column: "ConcurrencyStamp",
                value: new Guid("6eb77b80-de2b-43bd-94ff-0d519f54c7a3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 150,
                column: "ConcurrencyStamp",
                value: new Guid("aed63792-1a06-4d5c-85ae-956e17a24a62"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 151,
                column: "ConcurrencyStamp",
                value: new Guid("b1ac7c65-c3fa-4bc3-bec4-cc7c03dab547"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 152,
                column: "ConcurrencyStamp",
                value: new Guid("7fe6f724-cf05-42c1-99af-2a8b2cad46ba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 153,
                column: "ConcurrencyStamp",
                value: new Guid("f197403e-4925-4d6e-bdb6-c0812209138e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 154,
                column: "ConcurrencyStamp",
                value: new Guid("80c6d605-d502-42e7-9611-30cfa47b182b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 155,
                column: "ConcurrencyStamp",
                value: new Guid("9bbfa9c5-dc5c-49a5-824f-2b54437c1033"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 156,
                column: "ConcurrencyStamp",
                value: new Guid("66966c27-b0a8-47b6-8760-711401116dcd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 157,
                column: "ConcurrencyStamp",
                value: new Guid("27f7d1c5-4f64-4fc4-85b3-0faccf239099"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 158,
                column: "ConcurrencyStamp",
                value: new Guid("9ddc278a-16f7-4068-a9c9-c2304f342ded"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 159,
                column: "ConcurrencyStamp",
                value: new Guid("806a43a0-535b-44b2-8aaa-df8844067760"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 160,
                column: "ConcurrencyStamp",
                value: new Guid("103cdeb1-5840-4442-b828-82e456329364"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 161,
                column: "ConcurrencyStamp",
                value: new Guid("ed190273-8d0b-4ddd-a0ed-f088a27b7ab9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 162,
                column: "ConcurrencyStamp",
                value: new Guid("2e8cf57a-ae71-4ded-a4fd-5e16480aa66a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 163,
                column: "ConcurrencyStamp",
                value: new Guid("8e5085d1-ca7e-46d6-87f6-29c1759f837e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 164,
                column: "ConcurrencyStamp",
                value: new Guid("728b9831-8386-4322-89b8-d9a8c0071e02"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 165,
                column: "ConcurrencyStamp",
                value: new Guid("6a8f6b4c-db21-47f3-9db7-9a3085323cc0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 166,
                column: "ConcurrencyStamp",
                value: new Guid("794b7064-4a40-48d1-8340-ebf5ddeb94c5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 167,
                column: "ConcurrencyStamp",
                value: new Guid("8596e4a7-aebd-4332-bea0-d84c52bbf803"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 168,
                column: "ConcurrencyStamp",
                value: new Guid("4b2758e5-379e-42c4-918b-aacfefd03053"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 169,
                column: "ConcurrencyStamp",
                value: new Guid("c924355b-189d-4866-b74d-9724aa7852f2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 170,
                column: "ConcurrencyStamp",
                value: new Guid("fe28e047-3e9e-42c8-a726-f57f500baff9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 171,
                column: "ConcurrencyStamp",
                value: new Guid("465deabf-0179-49ba-a398-0b428a364704"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 172,
                column: "ConcurrencyStamp",
                value: new Guid("1d3048c3-d146-4b54-957b-53380a5b09e0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 173,
                column: "ConcurrencyStamp",
                value: new Guid("b6307e69-79c1-4e43-b7e5-1cfdb7c4c67f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 174,
                column: "ConcurrencyStamp",
                value: new Guid("aa460eec-ef59-4290-b22b-57f43e3bf4f3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 175,
                column: "ConcurrencyStamp",
                value: new Guid("056353ff-191c-42f8-be55-bacd8043a6ca"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 176,
                column: "ConcurrencyStamp",
                value: new Guid("114cee6c-0f9c-47f1-a71c-656050fb46af"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 177,
                column: "ConcurrencyStamp",
                value: new Guid("ae09478b-c65c-4709-bf0f-75f283c33ceb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 178,
                column: "ConcurrencyStamp",
                value: new Guid("1738d663-f191-404c-8dab-58bfd8b0e50c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 179,
                column: "ConcurrencyStamp",
                value: new Guid("5cffc9d7-e0a6-41ab-89be-0b1a06af7988"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 180,
                column: "ConcurrencyStamp",
                value: new Guid("1f4e38cc-1df6-4472-8ab3-d84a68b38acc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 181,
                column: "ConcurrencyStamp",
                value: new Guid("9c00a715-f24d-44c7-867b-b9fe9aa1f357"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 182,
                column: "ConcurrencyStamp",
                value: new Guid("2f25941c-d76d-4c49-93ad-2c229ffc136b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 183,
                column: "ConcurrencyStamp",
                value: new Guid("abd51881-4c2c-4de0-b544-4b266ef15301"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 184,
                column: "ConcurrencyStamp",
                value: new Guid("85a2eae4-b8f0-4d27-be34-c4ff3d8f489a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 185,
                column: "ConcurrencyStamp",
                value: new Guid("c36ae0a1-56ce-4c71-a848-59a309d106f0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 186,
                column: "ConcurrencyStamp",
                value: new Guid("112a9a46-8693-4d9f-be14-9bfa26e13597"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 187,
                column: "ConcurrencyStamp",
                value: new Guid("a25ef59e-8684-44fa-80b5-ac1524ed0738"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 188,
                column: "ConcurrencyStamp",
                value: new Guid("578d1dc3-ad41-43b0-98b5-460efbd4d43f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 189,
                column: "ConcurrencyStamp",
                value: new Guid("84f21925-9d0d-4658-89ca-8d21d78414d7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 190,
                column: "ConcurrencyStamp",
                value: new Guid("504f6632-2db1-403e-b2d2-f4c2e11cb7f5"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Posters",
                keyColumn: "Id",
                keyValue: new Guid("08a67378-487c-40f3-9d53-5c2acb9cb78d"),
                column: "ConcurrencyStamp",
                value: new Guid("5dc3f9fe-be21-4115-876b-c15ca8d62b2b"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Posters",
                keyColumn: "Id",
                keyValue: new Guid("f760c6af-419a-4378-9348-d6742ee62f9d"),
                column: "ConcurrencyStamp",
                value: new Guid("66a42341-7539-42fe-8e77-638216a15960"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("02fa2cc2-2c01-402b-91fa-84526ca51edc"),
                column: "ConcurrencyStamp",
                value: new Guid("a6057fa4-86f2-404b-85e3-0d3ec83acc66"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3060bbf4-415c-4767-8ad6-ba49685a31e1"),
                column: "ConcurrencyStamp",
                value: new Guid("c7021910-712f-4bb7-9efc-c1d1e34b7025"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("7a24cdc2-0f48-4e34-9c8e-745a9b06d0d7"),
                column: "ConcurrencyStamp",
                value: new Guid("bb2fdd54-7592-4039-a6ac-3404868d5fd6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("9830a808-b80b-41d6-84fb-b186bbec6d45"),
                column: "ConcurrencyStamp",
                value: new Guid("f5d7aaee-6381-4fff-b243-015aeee5acba"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("6ecbefff-3620-4ce6-82ab-a68239c72235"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("dd8ca174-c45d-4c46-8a81-d440c9012e29"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("7c470970-30a2-4f6e-8cc7-1f2aa3c22281"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("1d213917-c4e5-4ad5-84a7-b0272555343b"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("0b93bea1-eee3-4838-8513-7ade73017e5a"),
                column: "ConcurrencyStamp",
                value: new Guid("17ccaf8d-d13e-4cdf-82dd-2191b3098f66"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("e8de7eaf-13f0-4c77-b341-45f3cc10bc00"),
                column: "ConcurrencyStamp",
                value: new Guid("1903e338-2e00-41e5-99ba-8e57c790589b"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 176, 51, 210, 27, 155, 5, 180, 210, 178, 26, 88, 228, 4, 204, 146, 217, 199, 169, 214, 155, 95, 126, 157, 144, 167, 60, 173, 173, 116, 151, 29, 167, 0, 164, 188, 75, 208, 224, 177, 45, 130, 111, 206, 181, 229, 128, 137, 210, 155, 243, 234, 225, 139, 244, 137, 115, 253, 170, 31, 99, 223, 87, 160, 148 }, new byte[] { 217, 146, 195, 65, 169, 84, 154, 230, 89, 28, 223, 50, 9, 115, 113, 224, 9, 13, 240, 21, 147, 239, 157, 235, 207, 153, 153, 56, 9, 89, 48, 205, 200, 240, 247, 64, 39, 80, 39, 146, 157, 70, 53, 236, 6, 79, 164, 123, 227, 64, 127, 142, 43, 96, 207, 215, 120, 246, 67, 146, 146, 116, 20, 175, 251, 111, 144, 180, 37, 182, 51, 138, 18, 233, 227, 136, 179, 181, 119, 165, 225, 96, 16, 197, 95, 105, 130, 167, 118, 25, 93, 93, 168, 150, 98, 238, 238, 156, 151, 194, 180, 22, 242, 43, 26, 146, 143, 129, 142, 223, 213, 25, 130, 115, 152, 124, 24, 203, 7, 113, 34, 195, 64, 113, 23, 74, 59, 42 } });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa42bf46-7255-4347-a10d-9a0f58fc1c80"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 176, 51, 210, 27, 155, 5, 180, 210, 178, 26, 88, 228, 4, 204, 146, 217, 199, 169, 214, 155, 95, 126, 157, 144, 167, 60, 173, 173, 116, 151, 29, 167, 0, 164, 188, 75, 208, 224, 177, 45, 130, 111, 206, 181, 229, 128, 137, 210, 155, 243, 234, 225, 139, 244, 137, 115, 253, 170, 31, 99, 223, 87, 160, 148 }, new byte[] { 217, 146, 195, 65, 169, 84, 154, 230, 89, 28, 223, 50, 9, 115, 113, 224, 9, 13, 240, 21, 147, 239, 157, 235, 207, 153, 153, 56, 9, 89, 48, 205, 200, 240, 247, 64, 39, 80, 39, 146, 157, 70, 53, 236, 6, 79, 164, 123, 227, 64, 127, 142, 43, 96, 207, 215, 120, 246, 67, 146, 146, 116, 20, 175, 251, 111, 144, 180, 37, 182, 51, 138, 18, 233, 227, 136, 179, 181, 119, 165, 225, 96, 16, 197, 95, 105, 130, 167, 118, 25, 93, 93, 168, 150, 98, 238, 238, 156, 151, 194, 180, 22, 242, 43, 26, 146, 143, 129, 142, 223, 213, 25, 130, 115, 152, 124, 24, 203, 7, 113, 34, 195, 64, 113, 23, 74, 59, 42 } });

            migrationBuilder.CreateIndex(
                name: "IX_DailyRequestDetails_DailyRequestMainId",
                schema: "Request",
                table: "DailyRequestDetails",
                column: "DailyRequestMainId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRequestMains_CreatedBy",
                schema: "Request",
                table: "DailyRequestMains",
                column: "CreatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyRequestDetails",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "DailyRequestMains",
                schema: "Request");

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Charities",
                keyColumn: "Id",
                keyValue: new Guid("22d0eeca-467a-48bc-a600-3624ff0887b6"),
                column: "ConcurrencyStamp",
                value: new Guid("8e09d784-6875-47cd-af80-54ca61a9ad70"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("7acbf85a-c24e-4a98-9afa-d0836ecee4f9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("5f9cba24-3671-4cb9-9c0d-599d615008ff"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("137c22b1-6cc3-4d4e-adc5-f6271a41118b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("0821c2fa-ee16-4fef-8ad1-c4ee3460cf2a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("05003d4a-67b7-430e-9ca0-cfd95f96ff60"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("1b48fd25-f61a-47ee-a615-5636dbdb749f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("20ddc8f0-c820-4aee-b2b1-e97c53a07356"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("6a3d1249-a107-4d18-a1cf-5d08238db1e1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("555f066e-e5ae-44f8-99b5-98f5cc3f71c9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("32c07a02-ccc0-4ebe-ba75-999825bd710f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("607c7334-f716-48d4-a3e5-8d8fe96d1c85"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("f999ae60-25fb-4255-9ae3-3969ad73b053"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("3ca76ea8-e608-4ac2-b89b-9df926c175b7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("6cfb1505-f1b3-4433-9e24-ae9e73fe41be"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("7d50270c-e324-4ed6-84d1-3557842b48a4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("5d1883eb-85c0-43e4-b784-0701e821c2e2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("f2be4067-2235-473a-b3c6-6144c32ebf94"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("8e6efaaa-73c2-43ca-aa0c-7a2fc4580937"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("811dfa9c-dfe1-4368-9108-ab4d6b9ab596"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("b86f5d5c-1659-440d-944e-449990cd611e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("fe5b7a29-3347-4411-9c5b-7e805e40448a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("ee1b912f-3e82-4826-bc76-d83d5eab8ffe"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("022a9843-3f2b-4455-ac12-097e2632d5ff"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("cfc537d8-a807-4231-9c23-886b03dd3655"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("98fade23-ca7a-46c6-ace3-052bd551c986"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("bc342a95-c303-4759-bfb6-1c2bf1538bdc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("c5c1727c-7b25-46be-9412-6ef036c910c0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("7a05f052-a6f2-4c35-80b8-8428011c6935"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("f1855ef9-7d9e-43ef-922f-7c8dcd69027a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("2f19431d-f997-4054-8f26-cb9ff570999d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("16de5ab9-de3a-4bdb-833b-b91aa12447b1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("e32e0169-35e5-49f9-acec-9bb2cbb115f7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("41152e82-1f94-402d-a285-623e5a7259c8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("27341e75-4eb8-4761-be3d-c6033e588fdf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("2b3835f3-7383-456e-9964-771aa2bcade8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("646182e4-d540-4216-8477-0ef399bf21ef"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("8f728e53-5b01-49f9-b576-3363b9ab8cb9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("1cd9bfe1-54b1-4fa2-89c1-20697541dbba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("d1174f5b-2508-4b99-91ca-81f8c812c8f4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("0f32bbee-87c4-42d2-8eb2-3b5a820355dc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("801d709e-3536-48ae-9d4f-965d9270b715"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("f07d39a6-c2d2-42bf-b935-48d6410f7791"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("5aeb3d5f-563c-4e19-a148-636be3dd2f69"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("e16a7907-ff04-4a13-9f1d-1408fefcb3d0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("d47b665a-10c2-4d9f-8406-f04b2cde5c31"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("a1bdffbd-940d-4b8c-b748-dfd9fc28c982"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("99f86c1f-6c7b-4123-ac6b-5dded63f7f88"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("42677461-b4fb-4de2-804a-a93881045836"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("31de44ae-d0b2-4530-b30a-63c36696ac89"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("041619d5-9eeb-4608-92f8-e4f875248eba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("407f8795-2b55-44ac-af7d-d64be08d2b06"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("bcfc1d9c-0c7c-4fbc-b481-fa5ea104d6b5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("cde8774f-0298-41d9-ab62-94f4106678e2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("76e7c8e4-ab3a-42e5-bc96-8450ec35fda6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("c223b9d6-92fc-47a1-93fa-b91f7d0f4ff5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("35de77b4-2b59-43e7-92ac-5f1f16bef2eb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("7bc81212-214d-4279-9e22-e50a280e4a27"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("03fa3120-d0ed-4f3a-a047-b6fe014066a6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("a630c77f-69a9-4042-b9de-fec7ee146c20"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("0db80a26-415c-41b3-89e9-4192f06ce4d0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("ad1f67b3-02c7-42ad-b1fc-38da83fa2183"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("109f7788-0a92-4fbf-b17e-7d9644c13975"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("21ba1c5b-c667-4f0c-9595-20fe130f8811"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("c6470623-d27f-4b59-bdc5-70bca1ab32a0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("309aa77c-0849-499a-b584-892825267596"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("7179b99e-5cb2-4e3d-9075-27e0a4292221"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("4388f4a4-220c-4fec-935a-c1ddbdf07b0d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("d7745a83-0518-4557-8091-55989d081b30"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("e93adc90-19d8-4cf8-94b7-5449fd3e1429"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("8bbdae05-c1f1-47d3-88db-2356fc7319c3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: new Guid("0de257c0-f2b6-4282-a1d3-71406c981c32"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: new Guid("9f1aa6d9-23d7-434a-86cf-cb37958991f7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: new Guid("e098a1be-4007-4d1b-9f88-935a52f4975c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: new Guid("aa35f252-8339-442b-bb8b-8e377a2a66a9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: new Guid("73e2a06c-e34c-49a7-87f6-11bcc56e330e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: new Guid("d18f853c-03d9-471e-b72f-97124e950903"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: new Guid("bfd68380-20d8-4778-95da-bf1d692c1f6c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: new Guid("3fad43e8-b014-4eba-8bae-223f17f40ef1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: new Guid("662da985-7731-41e6-a25d-dd1d17e11e01"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: new Guid("7d88ae24-cf9c-4f3e-ac1c-7630bd7ae21b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: new Guid("4997881b-2b0e-480b-920a-0b6dc29f7950"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: new Guid("f65f637e-6873-4fbe-bd96-609ad7c20add"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: new Guid("cdfb9665-f021-4fe1-beca-f69c7506ab94"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: new Guid("37ab4e9c-be06-4afd-839a-f95c550652e1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: new Guid("ef19ffd7-c0d9-46b7-93d6-05378811f2eb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: new Guid("3ce47005-6202-4c24-a36e-d66b5a0f40dd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: new Guid("c1cbf4ac-aaaa-4010-b373-888b6e42a48b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: new Guid("5773945b-ac5f-46cd-ab2b-5609d457d9b5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: new Guid("59e25a26-3f17-4d19-9b89-6eaf0f19b1e5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: new Guid("b22aecac-4121-49d4-a627-342db4a84791"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: new Guid("dfd20c11-2ade-4837-a589-12225933a3c9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: new Guid("7076ab94-9217-4869-aaea-6a05f8b54fd2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: new Guid("98c7f962-3306-4e66-838c-442f17ddd18d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: new Guid("0ea3cc1e-e717-420a-a819-7dd0c72a2fb6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: new Guid("acc9f25f-18f7-4e88-9b85-b8f214cdaa55"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: new Guid("4ea0e435-d879-47a9-9d9e-c23cb094d7ab"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: new Guid("44744d81-cdd8-4969-bcd3-e34105810e87"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: new Guid("feb3dbb6-0298-4e96-8b9c-70090dc23b11"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: new Guid("034e44d2-eb9b-47e3-9aa0-0f84bf39ef81"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: new Guid("86f3e580-0682-4ba7-a0c0-26dacffc63cd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: new Guid("3ab5de0e-a3ca-49f4-b65f-baa998eb2f96"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: new Guid("8c3d89a5-2525-41d4-9763-d96ae3bed89a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: new Guid("3c8ff56b-07b3-4fd7-9345-11c0a4051150"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: new Guid("b44c384e-d7d1-4928-b8ab-2112d8abe9e9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: new Guid("c33e61ce-a45f-4597-bf08-4ba0ea153a61"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: new Guid("85022bbc-e814-4c1b-93ee-1fe38720999b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: new Guid("deb43b13-27e5-43d3-b77f-6fb0d1e531df"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: new Guid("5643e9a7-6f3e-4fdf-9c06-29c7afa4045a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: new Guid("049fa27b-5aaa-4167-afa1-3eff6ce2ea54"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: new Guid("b069af08-cae1-46a5-bb22-3fa1837054fb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: new Guid("b4fdf528-914e-4329-bd34-94a65233d8db"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: new Guid("3912d8e0-dbb0-415e-8d04-f58cf2d0d834"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: new Guid("883e0383-b270-477b-8b91-f848a19aa4cc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: new Guid("ea82dfeb-0f40-4e72-b0e2-0e7a0da32597"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 115,
                column: "ConcurrencyStamp",
                value: new Guid("57b8d546-16c0-4b63-b119-7d90f3be3143"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 116,
                column: "ConcurrencyStamp",
                value: new Guid("f2eb54dd-8fce-4973-9a2e-16e46206b2e4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 117,
                column: "ConcurrencyStamp",
                value: new Guid("37ac9134-45ba-4654-a5f0-f233852a9d4e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 118,
                column: "ConcurrencyStamp",
                value: new Guid("6c4f54b5-fa22-4e6b-824a-1020f2c5eb6a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 119,
                column: "ConcurrencyStamp",
                value: new Guid("4acc7226-d9eb-4d21-aa17-80612e9a8f23"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 120,
                column: "ConcurrencyStamp",
                value: new Guid("185f4a72-d308-47b4-897a-b3d60956e46d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 121,
                column: "ConcurrencyStamp",
                value: new Guid("e04b46aa-4d80-41bd-950d-8e913049f595"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 122,
                column: "ConcurrencyStamp",
                value: new Guid("9ba32e5b-39bb-4fc4-b057-efba55bbc57c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 123,
                column: "ConcurrencyStamp",
                value: new Guid("1449412c-46c3-4448-a0cb-04faaf5c6fc9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 124,
                column: "ConcurrencyStamp",
                value: new Guid("76be082e-2c32-4f37-8796-d5020608e500"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 125,
                column: "ConcurrencyStamp",
                value: new Guid("11314fdd-d15b-439e-acc1-c147b20f7ba9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 126,
                column: "ConcurrencyStamp",
                value: new Guid("f4c1a3f6-7494-4c4e-8697-e9e6273ac279"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 127,
                column: "ConcurrencyStamp",
                value: new Guid("b61be9a6-e0cf-4bf8-886a-9aadf7fddddf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 128,
                column: "ConcurrencyStamp",
                value: new Guid("f75e5457-8a78-4ef7-bd8a-9b2810f69056"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 129,
                column: "ConcurrencyStamp",
                value: new Guid("eae1594c-fe96-4493-8c20-f311b61a981e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 130,
                column: "ConcurrencyStamp",
                value: new Guid("e1e34a9e-971c-4ab8-b64a-d782bc73bc5a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 131,
                column: "ConcurrencyStamp",
                value: new Guid("8213cda0-b0fa-435e-bf74-fc9011265693"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 132,
                column: "ConcurrencyStamp",
                value: new Guid("72d07646-6037-4c5e-ac89-b47884242d52"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 133,
                column: "ConcurrencyStamp",
                value: new Guid("7362d5c6-9413-4787-a3dd-e046b76989b9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 134,
                column: "ConcurrencyStamp",
                value: new Guid("0b97ac9a-2504-42d2-935a-833acf5a7e99"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 135,
                column: "ConcurrencyStamp",
                value: new Guid("f3a51799-62e0-4184-b9b6-c021beec342e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 136,
                column: "ConcurrencyStamp",
                value: new Guid("e40a63a0-78c0-4b7d-8dd3-1a6e24802c2d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 137,
                column: "ConcurrencyStamp",
                value: new Guid("6c466c1c-84a6-434d-9baf-06789c1afd5c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 138,
                column: "ConcurrencyStamp",
                value: new Guid("b008dbeb-9ad6-4fe6-afe0-d3efee6a4a01"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 139,
                column: "ConcurrencyStamp",
                value: new Guid("6dac0d6d-f00c-4ab2-b8c1-a6d67505f2d9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 140,
                column: "ConcurrencyStamp",
                value: new Guid("464a24c3-1aeb-466d-945c-c82e1051e5ab"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 141,
                column: "ConcurrencyStamp",
                value: new Guid("b059be48-7d34-4fd2-ad82-fb8475132267"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 142,
                column: "ConcurrencyStamp",
                value: new Guid("f4a9290d-c276-4d47-a59a-0bcfac66c799"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 143,
                column: "ConcurrencyStamp",
                value: new Guid("03446662-8a30-460a-9a93-b786cee6133d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 144,
                column: "ConcurrencyStamp",
                value: new Guid("5475c41a-4b08-46bd-8fcb-b57071edc4ee"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 145,
                column: "ConcurrencyStamp",
                value: new Guid("20494dc7-e480-46ef-9f87-8bc4d5afc36f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 146,
                column: "ConcurrencyStamp",
                value: new Guid("964e03ab-4572-4601-bef7-e26e85d6d90a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 147,
                column: "ConcurrencyStamp",
                value: new Guid("369078b8-4de9-4bc0-849b-60409e05c363"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 148,
                column: "ConcurrencyStamp",
                value: new Guid("0caca53c-b767-4fc9-9c78-609fec072363"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 149,
                column: "ConcurrencyStamp",
                value: new Guid("34ad415b-ee2d-4d94-919a-1ec9356965df"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 150,
                column: "ConcurrencyStamp",
                value: new Guid("3c62b796-611d-46cc-8032-0383da9d5176"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 151,
                column: "ConcurrencyStamp",
                value: new Guid("ffb4a973-0a23-4576-8046-1edc0df1e934"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 152,
                column: "ConcurrencyStamp",
                value: new Guid("18421274-79b8-4e74-b67e-ee29970aa797"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 153,
                column: "ConcurrencyStamp",
                value: new Guid("8f776b5e-e1f4-4166-96e4-200f55112186"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 154,
                column: "ConcurrencyStamp",
                value: new Guid("3844e561-b80e-4776-ab52-a6d912349296"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 155,
                column: "ConcurrencyStamp",
                value: new Guid("7613f072-67a7-4703-8ac6-08d6d7830c0f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 156,
                column: "ConcurrencyStamp",
                value: new Guid("9c861acd-d130-40e3-82b8-16479e83e7ff"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 157,
                column: "ConcurrencyStamp",
                value: new Guid("ba2e86c0-abc4-4b74-97d9-459e61a26444"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 158,
                column: "ConcurrencyStamp",
                value: new Guid("c95c61db-4f38-416e-8b45-29ccc64ad306"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 159,
                column: "ConcurrencyStamp",
                value: new Guid("fea75c78-5b62-44df-831c-3f5c0f08259c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 160,
                column: "ConcurrencyStamp",
                value: new Guid("8470dc53-a920-407b-b07f-4ee4b8ff9926"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 161,
                column: "ConcurrencyStamp",
                value: new Guid("f8622d73-c23e-44e2-9a8c-0dd70704b3e4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 162,
                column: "ConcurrencyStamp",
                value: new Guid("18efc8f5-9b9d-49a9-8306-0851a155040c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 163,
                column: "ConcurrencyStamp",
                value: new Guid("b225e608-d7fc-4304-8373-47d9aac6e62b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 164,
                column: "ConcurrencyStamp",
                value: new Guid("005dbe72-8dbd-428b-8e8f-18b66a28bd2d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 165,
                column: "ConcurrencyStamp",
                value: new Guid("2955ef5d-2691-48df-b18d-df1901c34196"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 166,
                column: "ConcurrencyStamp",
                value: new Guid("a80f4b61-ce61-42a8-8cfc-f211981776f2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 167,
                column: "ConcurrencyStamp",
                value: new Guid("7520abe6-ce5a-48e8-9904-dd971534f282"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 168,
                column: "ConcurrencyStamp",
                value: new Guid("d47ce1fa-8ee1-4034-948b-ee3cc6d7f7fa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 169,
                column: "ConcurrencyStamp",
                value: new Guid("d1f42462-c176-4d8d-b985-e8cc96744cac"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 170,
                column: "ConcurrencyStamp",
                value: new Guid("58555793-9419-4ec4-bb05-d02cbf72f033"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 171,
                column: "ConcurrencyStamp",
                value: new Guid("681524e8-1020-4472-b84d-61d6fee73576"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 172,
                column: "ConcurrencyStamp",
                value: new Guid("5128bcfc-0418-445d-bb83-781d81ecf2a5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 173,
                column: "ConcurrencyStamp",
                value: new Guid("5b8cb22f-45e9-466d-9864-b04c653750cf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 174,
                column: "ConcurrencyStamp",
                value: new Guid("26756855-7730-4ef9-ad87-57d163b4121d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 175,
                column: "ConcurrencyStamp",
                value: new Guid("7c9ea7f9-5472-4818-82ca-f5f20e6f9884"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 176,
                column: "ConcurrencyStamp",
                value: new Guid("82b29d0b-56e4-4cfd-b31e-fed3e72e2c61"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 177,
                column: "ConcurrencyStamp",
                value: new Guid("ce669de2-0fd2-4c8f-bd9a-9247c5ce7f15"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 178,
                column: "ConcurrencyStamp",
                value: new Guid("f912f796-32ac-409c-821f-20a366aaebc7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 179,
                column: "ConcurrencyStamp",
                value: new Guid("d4e71546-0187-46c6-bf70-5f5ab2a3d526"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 180,
                column: "ConcurrencyStamp",
                value: new Guid("0408ff10-45b5-46d8-a56e-8cb1889c463d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 181,
                column: "ConcurrencyStamp",
                value: new Guid("40c558e4-c7a4-4b63-b29e-8d2cfa35b5dc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 182,
                column: "ConcurrencyStamp",
                value: new Guid("66704fea-1230-4844-bf5d-53538d226296"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 183,
                column: "ConcurrencyStamp",
                value: new Guid("d8979298-ba25-4718-87a2-2bec0a31b0f4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 184,
                column: "ConcurrencyStamp",
                value: new Guid("26d02b90-848d-42d1-8136-82b9840191b9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 185,
                column: "ConcurrencyStamp",
                value: new Guid("9a32c0cc-f19d-4b6d-b53c-1a0e3ac336ea"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 186,
                column: "ConcurrencyStamp",
                value: new Guid("889163b8-6361-423d-9657-73d9a0bf2598"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 187,
                column: "ConcurrencyStamp",
                value: new Guid("554f39b4-7435-48f6-ac0a-79690f202c24"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 188,
                column: "ConcurrencyStamp",
                value: new Guid("a43cb3d3-1a03-42e1-af6b-da6e5c6f72aa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 189,
                column: "ConcurrencyStamp",
                value: new Guid("590dd629-f090-4f5d-8ffc-031a4965b60d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 190,
                column: "ConcurrencyStamp",
                value: new Guid("9d9cfec7-9564-4a63-8451-1651784d20e3"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Posters",
                keyColumn: "Id",
                keyValue: new Guid("08a67378-487c-40f3-9d53-5c2acb9cb78d"),
                column: "ConcurrencyStamp",
                value: new Guid("542c9bdc-4365-4aea-a707-becb7300ffb4"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Posters",
                keyColumn: "Id",
                keyValue: new Guid("f760c6af-419a-4378-9348-d6742ee62f9d"),
                column: "ConcurrencyStamp",
                value: new Guid("c27b9d3e-9519-49d1-94f8-e269b5a965a5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("02fa2cc2-2c01-402b-91fa-84526ca51edc"),
                column: "ConcurrencyStamp",
                value: new Guid("80d63964-0fb8-4724-a3c3-5ef5c457930a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3060bbf4-415c-4767-8ad6-ba49685a31e1"),
                column: "ConcurrencyStamp",
                value: new Guid("66d1f3e8-2f14-4cb8-a51b-7044a0fc6931"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("7a24cdc2-0f48-4e34-9c8e-745a9b06d0d7"),
                column: "ConcurrencyStamp",
                value: new Guid("ea883c20-423b-4520-a50e-6f5b754f6983"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("9830a808-b80b-41d6-84fb-b186bbec6d45"),
                column: "ConcurrencyStamp",
                value: new Guid("f3b5b24f-9191-47ba-9596-1280096c02d3"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("f1b853d9-952a-42a2-a948-93dbc3979b4c"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("7352964f-7463-4a7e-8d6f-1a5627964841"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("d69d4ba3-3899-4288-bb16-55cf31530e9a"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("237c312a-53d7-43e0-aa1e-b1a4ca5025b8"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("0b93bea1-eee3-4838-8513-7ade73017e5a"),
                column: "ConcurrencyStamp",
                value: new Guid("6010e733-bc86-4297-aa1f-be4a65b64957"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("e8de7eaf-13f0-4c77-b341-45f3cc10bc00"),
                column: "ConcurrencyStamp",
                value: new Guid("7eda7784-8d5d-4254-a789-3d04a5f906e5"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 183, 237, 252, 29, 139, 160, 10, 231, 239, 22, 51, 170, 198, 93, 54, 68, 127, 29, 192, 2, 197, 156, 13, 103, 78, 190, 34, 177, 60, 181, 61, 178, 130, 184, 34, 96, 171, 13, 3, 213, 185, 161, 125, 12, 104, 30, 18, 97, 238, 148, 204, 237, 17, 39, 50, 102, 183, 168, 168, 199, 182, 87, 116, 16 }, new byte[] { 85, 182, 38, 10, 218, 236, 40, 143, 201, 211, 171, 121, 31, 218, 176, 193, 176, 212, 45, 63, 156, 179, 70, 67, 208, 205, 144, 86, 216, 125, 71, 124, 64, 39, 19, 178, 244, 184, 13, 123, 13, 20, 23, 168, 102, 19, 36, 136, 91, 131, 164, 43, 1, 10, 126, 171, 104, 213, 29, 186, 37, 147, 200, 194, 59, 60, 224, 53, 48, 255, 153, 53, 72, 235, 13, 204, 117, 246, 82, 203, 228, 222, 226, 91, 104, 23, 169, 126, 80, 2, 172, 163, 235, 125, 52, 215, 80, 6, 215, 212, 123, 173, 151, 206, 207, 197, 241, 141, 216, 110, 206, 189, 244, 75, 131, 99, 233, 36, 7, 156, 49, 59, 179, 150, 63, 159, 143, 243 } });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa42bf46-7255-4347-a10d-9a0f58fc1c80"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 183, 237, 252, 29, 139, 160, 10, 231, 239, 22, 51, 170, 198, 93, 54, 68, 127, 29, 192, 2, 197, 156, 13, 103, 78, 190, 34, 177, 60, 181, 61, 178, 130, 184, 34, 96, 171, 13, 3, 213, 185, 161, 125, 12, 104, 30, 18, 97, 238, 148, 204, 237, 17, 39, 50, 102, 183, 168, 168, 199, 182, 87, 116, 16 }, new byte[] { 85, 182, 38, 10, 218, 236, 40, 143, 201, 211, 171, 121, 31, 218, 176, 193, 176, 212, 45, 63, 156, 179, 70, 67, 208, 205, 144, 86, 216, 125, 71, 124, 64, 39, 19, 178, 244, 184, 13, 123, 13, 20, 23, 168, 102, 19, 36, 136, 91, 131, 164, 43, 1, 10, 126, 171, 104, 213, 29, 186, 37, 147, 200, 194, 59, 60, 224, 53, 48, 255, 153, 53, 72, 235, 13, 204, 117, 246, 82, 203, 228, 222, 226, 91, 104, 23, 169, 126, 80, 2, 172, 163, 235, 125, 52, 215, 80, 6, 215, 212, 123, 173, 151, 206, 207, 197, 241, 141, 216, 110, 206, 189, 244, 75, 131, 99, 233, 36, 7, 156, 49, 59, 179, 150, 63, 159, 143, 243 } });
        }
    }
}
