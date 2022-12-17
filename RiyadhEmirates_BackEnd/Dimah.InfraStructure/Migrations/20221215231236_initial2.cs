using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dimah.InfraStructure.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Request");

            migrationBuilder.CreateTable(
                name: "ChartItemStatuses",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChartItemStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChartItems",
                schema: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharityProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonationValue = table.Column<int>(type: "int", nullable: false),
                    DonationPeriod = table.Column<int>(type: "int", nullable: false),
                    ChartItemStatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChartItems_CharityProjects_CharityProjectId",
                        column: x => x.CharityProjectId,
                        principalSchema: "DataManagement",
                        principalTable: "CharityProjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChartItems_ChartItemStatuses_ChartItemStatusId",
                        column: x => x.ChartItemStatusId,
                        principalSchema: "Request",
                        principalTable: "ChartItemStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChartItems_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChartItems_Users_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Charities",
                keyColumn: "Id",
                keyValue: new Guid("22d0eeca-467a-48bc-a600-3624ff0887b6"),
                column: "ConcurrencyStamp",
                value: new Guid("8e09d784-6875-47cd-af80-54ca61a9ad70"));

            migrationBuilder.InsertData(
                schema: "Request",
                table: "ChartItemStatuses",
                columns: new[] { "Id", "IsActive", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, true, "جديد", "New" },
                    { 2, true, "تم الدفع", "Payed" },
                    { 3, true, "تم الحذف", "Deleted" }
                });

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
                columns: new[] { "ConcurrencyStamp", "IsActive" },
                values: new object[] { new Guid("ea883c20-423b-4520-a50e-6f5b754f6983"), true });

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

            migrationBuilder.CreateIndex(
                name: "IX_ChartItems_CharityProjectId",
                schema: "Request",
                table: "ChartItems",
                column: "CharityProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartItems_ChartItemStatusId",
                schema: "Request",
                table: "ChartItems",
                column: "ChartItemStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartItems_CreatedBy",
                schema: "Request",
                table: "ChartItems",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ChartItems_LastModifiedBy",
                schema: "Request",
                table: "ChartItems",
                column: "LastModifiedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChartItems",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "ChartItemStatuses",
                schema: "Request");

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Charities",
                keyColumn: "Id",
                keyValue: new Guid("22d0eeca-467a-48bc-a600-3624ff0887b6"),
                column: "ConcurrencyStamp",
                value: new Guid("854d7aa8-9486-49dd-ad81-3bf4ba375ab8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("64872c56-aa6f-4b0f-9f7e-dd199bbf266f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("88e970fd-abbc-4784-a366-865ed2d9a454"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("93dd6bdf-a318-4b84-8bee-75c08a978d2d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("276a4e84-4554-4811-a341-f49399f0a003"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("bb67c37a-ba7f-4a4a-a979-dfbc5f2c64f0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("2bfce83a-97ad-4961-9f32-70ac8f2e71d6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("579c58ab-c660-4496-9e65-6a5d8b7bd5e8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("3da03271-116e-4871-9981-48f5291242df"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("59061dd0-d106-4f41-a2d1-9a3c4331d493"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("edeb16b0-f44a-4c3e-b5bf-0090d47a8e13"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("41865f12-948d-4c14-ab7e-08fbacc721c0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("a96a8aa8-0d99-48ed-93bc-ba96a90d3d2c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("abedda8a-c930-4e91-97c6-76384935075f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("232d5d2e-9884-46d6-9454-34e1727e8374"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("48c10c65-e177-429f-b7df-2c19fdc08b7d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("46a0b26c-32b8-4477-8053-5c99f8dafe47"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("83780fe1-87c2-49a7-87b1-d1510f8bf293"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("5e60c0af-1f03-4245-aa86-60b9f1b661fd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("37bd801d-018f-4dcd-adc8-59ddd5808dea"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("051b175a-9712-47d8-bb5f-f634d0db7034"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("86900204-871f-4035-93de-10ec3edf76ad"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("54408f48-e094-4c32-9e54-a595c574499a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("2fb40a22-d1a1-42d3-a226-4916891dfc7b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("1bdaa805-ec6b-4d9c-8f2e-d9d0aac21db8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("0960b9d1-1720-4710-a591-03860425d561"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("2ad623f7-aa36-4cb5-bcc8-b8ee8996d3ab"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("689edb81-ca50-4686-95ee-8e1c60b42852"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("4c1205be-25bb-4077-bcb6-f095afb7dd79"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("13397018-e8c7-4f86-ae46-ddfc29d2d2fe"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("849255cb-d88b-4429-8686-9b6c8f1e59bf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("328b151e-f69f-46a7-aebf-2925bdca32ab"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("1f93d014-7b80-42c6-893f-ddc2da718cae"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("5b16d5a4-55a1-43e6-bd08-957d58134565"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("4b535205-a830-4798-b2cc-d8a9480c2fb5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("a02060a3-54f4-4639-b37c-0e150c4293d6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("d7d50de1-5852-4886-864d-85a9f207db88"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("3eebe3e6-a6a5-48ac-ad89-dea9b37c4dc8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("f25edb2a-311d-49dd-822e-8e4feb224586"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("90d45d44-ec15-402f-a575-0d134eb164bc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("4f614c51-e250-46dc-82b7-7d89e5393602"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("dcb06d87-ce05-4d7f-ab55-d65b91551e67"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("68177a89-e5cf-4960-9ac8-541dd97d7ea3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("f579d3e2-212c-4f4d-86e0-afdf8a590c45"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("084359e3-4907-4c80-8aeb-b39b3d06a87e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("838fe681-22fa-4938-a7e6-52b0b38c7697"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("f457f1db-be42-4650-a8f6-12a9cb873d8a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("c1723f6e-1e72-4f61-8ef4-fb33e0e4b5ba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("3355a45a-32d5-4bd3-8718-1296e43ae585"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("77a06515-0e73-45c9-883d-14db27491677"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("ede1c1ae-955a-4780-9c0d-86ac18015c0e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("409a90a2-6d81-46ef-9450-35d74ae740ef"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("e5303763-93d2-451d-85cb-12aa81e5b6f4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("74c3d841-89a2-4a5d-bffa-9774318f9b35"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("3ee57ed4-9b6d-4518-bcbf-7e10e924152a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("41504479-5437-4ed4-b19d-89124b087ff4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("c2393464-5dce-4919-a996-56d63b3fa75b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("9cc8eb6c-d267-43e0-ae94-ab25ce50cf59"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("94688552-0f7f-4233-b992-170aae078523"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("b4ae4df1-90bc-4390-913f-d3a57fcc51be"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("7f717a31-77ef-4d49-944c-d474575d1264"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("d87528d3-01ce-42de-b1b5-f2c7adf6b6a5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("7d20c8ee-b347-41a9-bce4-6265a3053afe"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("7c58ad28-d2d1-4b34-86eb-f0ece2813a76"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("b3bf8336-d649-40bc-8c77-ab4eacb34fd2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("bb1f04fb-ad8a-4b96-aa2a-eeff3cd8ff33"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("1087068e-2c97-4855-a518-7d33d390df3e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("221730f7-0b6f-4563-aa80-70db0b26ef22"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("2cd4f60f-c13e-4a1c-aae0-a8737fc55dd6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("df2d53dd-fef6-4b5b-8865-fcd9df0461bc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("d48fac5f-ad42-43bf-a755-e0e1d1056dd6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: new Guid("1cef45b8-a230-4b81-a35a-433d3e8b6b76"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: new Guid("248e8724-9400-48d4-8f65-f3d3ec4c5037"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: new Guid("60421f2d-e8a3-47ed-82ae-375775c7752a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: new Guid("727a19d6-05cf-4ce0-975b-a8e400f40641"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: new Guid("feacd751-7cdf-415d-831f-04d296a35ed5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: new Guid("057793ff-135a-48f5-a141-19d2d799f002"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: new Guid("3c1fb2f0-ac59-4a5b-ac87-4a82affab25b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: new Guid("ad9a067c-6116-4c30-aa88-66f281da3309"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: new Guid("572dcdf5-f1fe-46b1-9ceb-4b13c3d83f9f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: new Guid("a29ebc3f-9be2-4520-a011-672c6a0836d7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: new Guid("a3f9ff37-6c6d-4ac3-8798-12455f1f5e7b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: new Guid("f7184735-025e-466a-9d83-d1d2ec28ec02"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: new Guid("97a56f19-b8cc-4f78-a7b5-6f50c7b9dfb3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: new Guid("7d0bb277-a0ee-416e-8562-95dc3daf4ef7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: new Guid("6039a9d5-50d8-459e-b3a9-d0f67872d5da"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: new Guid("74077b6a-33d3-4ece-8c13-3b96548abad2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: new Guid("0b8daf4d-f608-4841-a574-3b1d10846dca"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: new Guid("346863ad-2709-4173-945c-f72bfe5008e1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: new Guid("6133b0a4-7f53-41a4-8545-1a12e6833c44"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: new Guid("8271e615-6e55-4283-9642-70a930fa1b2e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: new Guid("ccb80bff-46b9-4a6c-9161-2b95ea2c262a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: new Guid("caa9c47e-dc90-469b-8055-d4218041711d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: new Guid("fdc07997-f94c-4a7b-b477-de35312fad93"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: new Guid("2ce4a6a4-4f59-4182-9532-e7e3167c43cc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: new Guid("c15a2ebe-d2d1-4ec7-9699-6c510aaf4443"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: new Guid("adccae2e-0228-4090-a685-8b8babda4f9a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: new Guid("153c0448-2979-4568-8dac-52c8d140a8a9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: new Guid("be6e902a-66dd-4bad-964f-dc56483290ea"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: new Guid("85f7b1a8-0c08-4151-9698-1136d8fa3d8d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: new Guid("ff68e4da-1fbe-4108-bc4c-f55c1baa0d29"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: new Guid("3cbb7b24-5932-4f2c-9fbb-2fdaf8a511fc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: new Guid("8fa4c5fc-4a70-49ac-a91c-72e73df57453"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: new Guid("878457be-fb9d-4f30-b0fb-db5f2c509e63"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: new Guid("cfb570db-05e5-4e52-9a73-09b1365f6c8e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: new Guid("ba6be218-0db6-4137-a70a-c542d717b225"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: new Guid("c77d345e-9e23-4417-af2f-4c1faa968246"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: new Guid("9807ee59-cd9f-49ce-a7db-e2157dae7f84"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: new Guid("942778b8-6bda-4a15-be77-2eb7f3532a9a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: new Guid("9f32239f-049b-4344-9ab2-13222f072d2c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: new Guid("3af8572b-3564-43c2-8095-bc400cc5198b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: new Guid("906e87aa-9127-4203-adc2-5a282e077d90"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: new Guid("410e4d0b-2a39-423a-a3c3-80207d352650"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: new Guid("dca982a3-c3d8-4b92-ae79-6abde2c96d44"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: new Guid("0579addb-1d5c-46d0-be8d-76061d0184d9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 115,
                column: "ConcurrencyStamp",
                value: new Guid("dabc1ca8-66fd-4f3c-acad-7fd0d1cfa6af"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 116,
                column: "ConcurrencyStamp",
                value: new Guid("cc3772dd-f133-4a6c-9e0c-0d1bc27c06bd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 117,
                column: "ConcurrencyStamp",
                value: new Guid("aa96d542-23d0-47ac-916f-cb3b2c9701f5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 118,
                column: "ConcurrencyStamp",
                value: new Guid("1388ce11-a0f4-46c9-8469-1e4e45e06b15"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 119,
                column: "ConcurrencyStamp",
                value: new Guid("fa7dd0a0-07fa-44e2-a4dd-c0756d5fd0db"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 120,
                column: "ConcurrencyStamp",
                value: new Guid("912b734f-3fec-4c51-849c-a384efa37d2c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 121,
                column: "ConcurrencyStamp",
                value: new Guid("a19a1bd3-8687-4817-9abd-2ef9cab52c7c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 122,
                column: "ConcurrencyStamp",
                value: new Guid("c6bbf7c3-22e1-4469-9c29-fd89a297958d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 123,
                column: "ConcurrencyStamp",
                value: new Guid("d49b48f4-de69-41fb-9e1a-b95947c5a572"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 124,
                column: "ConcurrencyStamp",
                value: new Guid("0a31c548-1d06-401e-b2cb-0ac3bc4455e6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 125,
                column: "ConcurrencyStamp",
                value: new Guid("375f8235-af21-4a5d-918b-498b228496da"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 126,
                column: "ConcurrencyStamp",
                value: new Guid("1b379977-612c-4d23-8ae0-640097f51e01"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 127,
                column: "ConcurrencyStamp",
                value: new Guid("4b6350f1-dda4-4d96-8901-fffbb6864093"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 128,
                column: "ConcurrencyStamp",
                value: new Guid("bd3a9734-de5c-430b-af8f-05dc7a53d0fe"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 129,
                column: "ConcurrencyStamp",
                value: new Guid("66c43789-6f00-4ee7-8042-86ce8e0e7f1c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 130,
                column: "ConcurrencyStamp",
                value: new Guid("a189987c-58d7-46ca-8bdd-3a099703f113"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 131,
                column: "ConcurrencyStamp",
                value: new Guid("d8ca7081-c14e-432a-9ed7-e017140d4fd5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 132,
                column: "ConcurrencyStamp",
                value: new Guid("ec4ed658-7027-4e65-9334-249c8e89b507"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 133,
                column: "ConcurrencyStamp",
                value: new Guid("e63c52eb-eb63-42e8-be26-93ca1d794961"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 134,
                column: "ConcurrencyStamp",
                value: new Guid("35aceb80-a982-4ee0-916f-f52bd6521bee"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 135,
                column: "ConcurrencyStamp",
                value: new Guid("f4213731-3fdb-4e8a-ba15-11b81ee316ef"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 136,
                column: "ConcurrencyStamp",
                value: new Guid("3a93546b-9845-4360-9352-961e84c7710f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 137,
                column: "ConcurrencyStamp",
                value: new Guid("230a6255-b8ce-4ff6-889e-a9834dca3096"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 138,
                column: "ConcurrencyStamp",
                value: new Guid("985fcbee-f740-4e9a-bcc0-48acb1007b4d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 139,
                column: "ConcurrencyStamp",
                value: new Guid("d512dbae-3337-413f-943f-07dd49cfd9db"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 140,
                column: "ConcurrencyStamp",
                value: new Guid("21821f94-b7e7-4500-9618-35ca5cc98fb9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 141,
                column: "ConcurrencyStamp",
                value: new Guid("85fbf590-dd05-4bdb-8dc1-49392ea29120"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 142,
                column: "ConcurrencyStamp",
                value: new Guid("fc3ca058-942e-4b4f-b521-db43eda07faf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 143,
                column: "ConcurrencyStamp",
                value: new Guid("698b701a-7414-44eb-bd5c-83f9e834ebfa"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 144,
                column: "ConcurrencyStamp",
                value: new Guid("b612ed31-c5e5-44e4-9a08-3cdaecfd37e0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 145,
                column: "ConcurrencyStamp",
                value: new Guid("799629e8-445f-4ae3-b560-7467117cdca6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 146,
                column: "ConcurrencyStamp",
                value: new Guid("d5a94f5d-4a4f-4163-a095-5ef2c50c7563"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 147,
                column: "ConcurrencyStamp",
                value: new Guid("c399b2d1-abea-4ec8-b3ca-f1e41be2aab1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 148,
                column: "ConcurrencyStamp",
                value: new Guid("dc45ef0b-db1d-4560-905d-e0b1daf5f518"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 149,
                column: "ConcurrencyStamp",
                value: new Guid("8ae3eb14-c029-447b-97e6-3a690330e905"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 150,
                column: "ConcurrencyStamp",
                value: new Guid("6fe00636-1510-4601-8e39-3cb589de0284"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 151,
                column: "ConcurrencyStamp",
                value: new Guid("dcbe2a95-e5a2-4f03-97c6-da4cbb914913"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 152,
                column: "ConcurrencyStamp",
                value: new Guid("cc2bddd2-76ba-40fe-b36f-c8c8e130bb33"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 153,
                column: "ConcurrencyStamp",
                value: new Guid("a5f94989-fec3-4954-8768-f491ad1a619a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 154,
                column: "ConcurrencyStamp",
                value: new Guid("6b09dea0-beeb-45a6-b772-81757ddcb068"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 155,
                column: "ConcurrencyStamp",
                value: new Guid("635bfea0-cdb2-404d-8aea-ee1ecce5ea7a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 156,
                column: "ConcurrencyStamp",
                value: new Guid("37b65973-5f05-4e5f-aa60-4eabef9e2a5a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 157,
                column: "ConcurrencyStamp",
                value: new Guid("7aebd238-4900-4553-ba19-3d8b8d8bd1e8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 158,
                column: "ConcurrencyStamp",
                value: new Guid("418e1a82-3a1a-4c99-9e22-6111f7bfb935"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 159,
                column: "ConcurrencyStamp",
                value: new Guid("ef72e05b-f805-4b44-8ff5-467805ae9947"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 160,
                column: "ConcurrencyStamp",
                value: new Guid("f182ec71-fbde-4119-8c15-0df7b50c8bdc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 161,
                column: "ConcurrencyStamp",
                value: new Guid("bd198d48-8dfb-4480-9b1c-497fff1dd956"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 162,
                column: "ConcurrencyStamp",
                value: new Guid("3fe7a2cd-d80e-4b2c-96fc-5dee9505219b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 163,
                column: "ConcurrencyStamp",
                value: new Guid("8216bc18-f95b-451a-b7a2-5c4b897664eb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 164,
                column: "ConcurrencyStamp",
                value: new Guid("addab93b-ecd9-43fe-aba5-e53807516814"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 165,
                column: "ConcurrencyStamp",
                value: new Guid("333b69d4-e855-4777-ad62-4c6afe5e98ef"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 166,
                column: "ConcurrencyStamp",
                value: new Guid("002e2747-df86-4ab0-857c-76d826387472"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 167,
                column: "ConcurrencyStamp",
                value: new Guid("441ad416-388f-47c3-ade2-fd21eb42457f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 168,
                column: "ConcurrencyStamp",
                value: new Guid("37db7d88-95e2-47ab-97d5-dda888583ee0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 169,
                column: "ConcurrencyStamp",
                value: new Guid("78db8339-4379-4fa7-ad97-f32ef8497ad4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 170,
                column: "ConcurrencyStamp",
                value: new Guid("56702d85-0256-4f01-84bb-c5f2b5151bdc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 171,
                column: "ConcurrencyStamp",
                value: new Guid("b43bcccd-d495-4286-8166-4541557689ce"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 172,
                column: "ConcurrencyStamp",
                value: new Guid("dbf8702e-83a1-4cb7-a61d-fad05855d07d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 173,
                column: "ConcurrencyStamp",
                value: new Guid("5b3ba34c-0bbf-4b51-ad99-8ea27e9c1c65"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 174,
                column: "ConcurrencyStamp",
                value: new Guid("fb498e88-3815-4137-80db-89c5a940f73f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 175,
                column: "ConcurrencyStamp",
                value: new Guid("cdf7a348-961e-488d-85c9-5cefe3398302"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 176,
                column: "ConcurrencyStamp",
                value: new Guid("6bd7d3e7-4f9c-444b-840a-fed846f11a22"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 177,
                column: "ConcurrencyStamp",
                value: new Guid("b860cecc-6ec5-42d8-aa7d-5e58a93ceb39"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 178,
                column: "ConcurrencyStamp",
                value: new Guid("098f5b15-f8fc-4ce5-a367-e20e78e4a079"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 179,
                column: "ConcurrencyStamp",
                value: new Guid("7a1b983a-93cc-47f6-97fc-42fd57d6a9bf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 180,
                column: "ConcurrencyStamp",
                value: new Guid("512d4c53-a399-4f6e-86eb-8dde79372e77"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 181,
                column: "ConcurrencyStamp",
                value: new Guid("ad7939ec-051e-493a-9d39-0eb86ff4effb"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 182,
                column: "ConcurrencyStamp",
                value: new Guid("3eab17fe-54e5-4240-912e-7f717e454e44"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 183,
                column: "ConcurrencyStamp",
                value: new Guid("bbce09e7-ef04-492c-8e4b-90e9864e0b97"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 184,
                column: "ConcurrencyStamp",
                value: new Guid("438b7146-e274-46ab-b4ca-8836781a2879"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 185,
                column: "ConcurrencyStamp",
                value: new Guid("2039b6e1-4dd3-40a5-9de1-291c8bf5ed11"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 186,
                column: "ConcurrencyStamp",
                value: new Guid("df3a50db-11c2-40d8-a5f6-62236abcf8e3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 187,
                column: "ConcurrencyStamp",
                value: new Guid("158f0199-d69d-4fae-b1ec-189135b431e8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 188,
                column: "ConcurrencyStamp",
                value: new Guid("95f5ac7e-6c4d-41e2-86b6-3b7b7e24f520"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 189,
                column: "ConcurrencyStamp",
                value: new Guid("b317d0fe-adb8-4997-bbd4-cf9190735b32"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 190,
                column: "ConcurrencyStamp",
                value: new Guid("438efe9a-d177-41d7-a2c0-edd49e8d8a77"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Posters",
                keyColumn: "Id",
                keyValue: new Guid("08a67378-487c-40f3-9d53-5c2acb9cb78d"),
                column: "ConcurrencyStamp",
                value: new Guid("81c87907-3f74-408b-86ec-bf5c0fa2abae"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Posters",
                keyColumn: "Id",
                keyValue: new Guid("f760c6af-419a-4378-9348-d6742ee62f9d"),
                column: "ConcurrencyStamp",
                value: new Guid("2f5b8170-ff17-45ff-9fa2-37b3d0e52786"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("02fa2cc2-2c01-402b-91fa-84526ca51edc"),
                column: "ConcurrencyStamp",
                value: new Guid("29b499bf-7ec3-46b6-9989-2c115c15fb37"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3060bbf4-415c-4767-8ad6-ba49685a31e1"),
                column: "ConcurrencyStamp",
                value: new Guid("34a866e0-6a6f-40f3-bc66-65de279b8761"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("7a24cdc2-0f48-4e34-9c8e-745a9b06d0d7"),
                columns: new[] { "ConcurrencyStamp", "IsActive" },
                values: new object[] { new Guid("b0e2dc82-e2c1-4c4c-b91a-ba8aefe84794"), false });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("9830a808-b80b-41d6-84fb-b186bbec6d45"),
                column: "ConcurrencyStamp",
                value: new Guid("c04719d4-85af-45e6-869c-a46c99633d2d"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("8b769c3b-1777-434e-9ef0-e63610403dfa"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("9ad49456-9c02-4ebd-bd73-09b1b34b93a8"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("e995a86c-ad39-4e88-b692-7326dc54480c"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("9fb76ec9-2711-4093-8c5c-bcbf48e887d6"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("0b93bea1-eee3-4838-8513-7ade73017e5a"),
                column: "ConcurrencyStamp",
                value: new Guid("6aaa31c7-f3d6-40d1-852f-5bfab94f05e2"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("e8de7eaf-13f0-4c77-b341-45f3cc10bc00"),
                column: "ConcurrencyStamp",
                value: new Guid("d0388b67-d6ad-4468-9e76-61a3755f5840"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 195, 241, 126, 211, 70, 4, 157, 34, 38, 100, 96, 223, 54, 203, 130, 10, 107, 218, 137, 125, 246, 121, 179, 107, 19, 49, 121, 87, 122, 175, 52, 213, 160, 137, 139, 26, 107, 47, 180, 53, 18, 214, 178, 41, 43, 66, 216, 246, 214, 98, 162, 181, 183, 8, 53, 40, 52, 123, 181, 18, 25, 9, 97, 254 }, new byte[] { 51, 206, 128, 107, 175, 127, 255, 210, 88, 250, 101, 220, 71, 240, 53, 167, 104, 31, 40, 77, 34, 112, 75, 128, 157, 33, 40, 225, 167, 234, 63, 9, 27, 161, 221, 40, 34, 9, 9, 117, 35, 221, 146, 199, 174, 135, 92, 230, 169, 86, 135, 199, 26, 86, 41, 81, 203, 96, 172, 251, 238, 135, 6, 122, 214, 39, 192, 95, 14, 3, 96, 102, 254, 53, 91, 203, 59, 53, 50, 131, 116, 12, 222, 14, 218, 155, 137, 235, 169, 60, 76, 162, 105, 237, 211, 50, 238, 164, 195, 225, 226, 192, 88, 26, 219, 150, 39, 96, 98, 163, 238, 31, 27, 82, 152, 12, 46, 159, 235, 22, 141, 199, 67, 21, 3, 200, 225, 126 } });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa42bf46-7255-4347-a10d-9a0f58fc1c80"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 195, 241, 126, 211, 70, 4, 157, 34, 38, 100, 96, 223, 54, 203, 130, 10, 107, 218, 137, 125, 246, 121, 179, 107, 19, 49, 121, 87, 122, 175, 52, 213, 160, 137, 139, 26, 107, 47, 180, 53, 18, 214, 178, 41, 43, 66, 216, 246, 214, 98, 162, 181, 183, 8, 53, 40, 52, 123, 181, 18, 25, 9, 97, 254 }, new byte[] { 51, 206, 128, 107, 175, 127, 255, 210, 88, 250, 101, 220, 71, 240, 53, 167, 104, 31, 40, 77, 34, 112, 75, 128, 157, 33, 40, 225, 167, 234, 63, 9, 27, 161, 221, 40, 34, 9, 9, 117, 35, 221, 146, 199, 174, 135, 92, 230, 169, 86, 135, 199, 26, 86, 41, 81, 203, 96, 172, 251, 238, 135, 6, 122, 214, 39, 192, 95, 14, 3, 96, 102, 254, 53, 91, 203, 59, 53, 50, 131, 116, 12, 222, 14, 218, 155, 137, 235, 169, 60, 76, 162, 105, 237, 211, 50, 238, 164, 195, 225, 226, 192, 88, 26, 219, 150, 39, 96, 98, 163, 238, 31, 27, 82, 152, 12, 46, 159, 235, 22, 141, 199, 67, 21, 3, 200, 225, 126 } });
        }
    }
}
