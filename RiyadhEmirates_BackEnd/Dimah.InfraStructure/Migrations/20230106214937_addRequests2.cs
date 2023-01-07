using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dimah.InfraStructure.Migrations
{
    public partial class addRequests2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPayed",
                schema: "Request",
                table: "DailyRequestMains",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Charities",
                keyColumn: "Id",
                keyValue: new Guid("22d0eeca-467a-48bc-a600-3624ff0887b6"),
                column: "ConcurrencyStamp",
                value: new Guid("6b495929-2038-4894-8d8f-ce35ac22601f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("667a0559-db02-4985-955d-5ee55bc4a859"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("3c4029c3-e0dc-4c39-9023-c85bb1122eba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("c3caddfe-63d1-4d87-95b1-74df8af32871"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("f646a9f0-c5b8-4ee6-8617-34e1fe6b5ff6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: new Guid("d7a5a665-b9e4-47d1-9c05-4c169565ce62"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: new Guid("acbc33f3-7323-45a9-8ee7-ea20a1685437"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: new Guid("5f6dce5c-55ec-47d5-937c-63c607c5a180"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: new Guid("d35f90a2-377c-4f77-b049-7460a20fec1c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: new Guid("ebb0283f-2d6a-4bab-b341-d8c49946c933"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: new Guid("54d414b6-bef6-4e52-8ea7-30b88e2ceb4f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: new Guid("085173de-64ec-4239-82d3-d7a7fe35954d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: new Guid("bbbed0f0-47d2-482b-bbad-ce486ca9f350"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: new Guid("9044182a-dc7a-495b-aa7a-678d05f2dcff"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: new Guid("8b369ab3-e885-47ef-b626-f0b3a2ab93e2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: new Guid("786d30a8-901e-4eb9-a93b-c7f35297e9ed"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: new Guid("a207d1be-3e3a-4ce5-bd3a-affb632d9be7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: new Guid("7cd97948-a0ec-4f27-ab07-1f4685a0b854"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: new Guid("7442be63-61df-404a-980c-0c719283674d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: new Guid("8d5e55c0-5489-4daa-b899-bb696b375a13"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: new Guid("59b9cc81-358e-4e3c-ba0a-a8e03441a141"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: new Guid("cd3698ea-fadf-4172-8159-7d3da398a731"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: new Guid("5ee123e4-f412-43f3-a355-1dec6ef5f1ad"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 23,
                column: "ConcurrencyStamp",
                value: new Guid("43827e9c-2fac-4935-90f5-3512adb99327"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 24,
                column: "ConcurrencyStamp",
                value: new Guid("8f953f34-ac56-42cb-93e8-11249d015466"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 25,
                column: "ConcurrencyStamp",
                value: new Guid("5ddee6d5-f989-407a-b714-d25d25395e8a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 26,
                column: "ConcurrencyStamp",
                value: new Guid("a83e96d6-5df5-4be3-a8ee-0d931eaf0dec"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 27,
                column: "ConcurrencyStamp",
                value: new Guid("395585fc-e66c-440c-bc41-537c6b256fb9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 28,
                column: "ConcurrencyStamp",
                value: new Guid("50791aa8-d030-4efb-b15d-0c512be868f3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 29,
                column: "ConcurrencyStamp",
                value: new Guid("ed6bd2ee-acc4-42c8-8da5-8d7ea77cefa9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 30,
                column: "ConcurrencyStamp",
                value: new Guid("46ca5362-1d38-4398-bb39-9e73da7356a4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 31,
                column: "ConcurrencyStamp",
                value: new Guid("bfc8665a-ad8a-475d-afda-f513e364279d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 32,
                column: "ConcurrencyStamp",
                value: new Guid("564e8890-523c-47e9-91f3-06d4823de8a9"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 33,
                column: "ConcurrencyStamp",
                value: new Guid("4fd422db-8a7f-45a5-873e-05a36b6f7f4b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 34,
                column: "ConcurrencyStamp",
                value: new Guid("2b8783f8-cb2a-4f36-88ac-099c9323a0dc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 35,
                column: "ConcurrencyStamp",
                value: new Guid("183b7c0a-2a8f-400b-ba18-12e0dcce344f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 36,
                column: "ConcurrencyStamp",
                value: new Guid("1d94490e-f5d5-4d88-94f4-edcc9bef9b67"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 37,
                column: "ConcurrencyStamp",
                value: new Guid("ef489d67-2a52-4489-9fc0-955035b41f75"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 38,
                column: "ConcurrencyStamp",
                value: new Guid("d5b8d284-4ee8-41a9-8187-f1ec33d04fb2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 39,
                column: "ConcurrencyStamp",
                value: new Guid("e72e4337-fede-4d17-ac19-f62ef4c26612"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 40,
                column: "ConcurrencyStamp",
                value: new Guid("37485b2c-b07b-4fca-945b-5a37c7fa7dd0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 41,
                column: "ConcurrencyStamp",
                value: new Guid("bbfe57fa-2668-46a7-80bc-e6bc182e78c6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 42,
                column: "ConcurrencyStamp",
                value: new Guid("c85c934a-cf88-4ddd-853c-13a4275029bf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 43,
                column: "ConcurrencyStamp",
                value: new Guid("05310b0e-600f-4d26-81a3-33b9d45cb99d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 44,
                column: "ConcurrencyStamp",
                value: new Guid("31c6bc2c-a64c-43d1-ae7e-f8235bff73f6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 45,
                column: "ConcurrencyStamp",
                value: new Guid("5a8203f1-ad2e-4e8b-9660-730808972801"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 46,
                column: "ConcurrencyStamp",
                value: new Guid("66a78fc2-0ff5-4df3-99a3-2de003b3a712"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 47,
                column: "ConcurrencyStamp",
                value: new Guid("8705acb1-d804-4d83-8ce7-e9d0e537392a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 48,
                column: "ConcurrencyStamp",
                value: new Guid("6b294bf8-e528-4454-b467-c7b1e7a85d9a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 49,
                column: "ConcurrencyStamp",
                value: new Guid("d059945c-fbb7-492b-9199-4914b19cd2e2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 50,
                column: "ConcurrencyStamp",
                value: new Guid("5c635f15-cc55-47c1-baff-01f22ceb8b93"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 51,
                column: "ConcurrencyStamp",
                value: new Guid("14a333d8-9fd3-4f3d-96dc-1470960a5203"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 52,
                column: "ConcurrencyStamp",
                value: new Guid("8d736f63-e55c-454a-9f29-547238c210ae"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 53,
                column: "ConcurrencyStamp",
                value: new Guid("fe7445c5-23cb-45d1-8ac2-fa68ecd91b59"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 54,
                column: "ConcurrencyStamp",
                value: new Guid("7add8924-86cd-4f11-8238-24be2330a6c8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 55,
                column: "ConcurrencyStamp",
                value: new Guid("9a20d70f-f922-4865-97c4-eccb813f1145"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 56,
                column: "ConcurrencyStamp",
                value: new Guid("a0c9b39f-db3a-4d21-bf3b-6984dbee1053"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 57,
                column: "ConcurrencyStamp",
                value: new Guid("8b7dabe2-215a-4e84-b940-069201e1bbba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 58,
                column: "ConcurrencyStamp",
                value: new Guid("ff341bfe-1ae5-4d93-8c3f-9146b6e3aab4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 59,
                column: "ConcurrencyStamp",
                value: new Guid("978be274-09d5-4cb9-838d-950d0f953fc5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 60,
                column: "ConcurrencyStamp",
                value: new Guid("bac59c08-3af6-4e47-8cf5-d2eb244443c5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 61,
                column: "ConcurrencyStamp",
                value: new Guid("1d243853-e433-475f-b5f4-2878272b0f80"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 62,
                column: "ConcurrencyStamp",
                value: new Guid("5004e6ea-7cdc-4a49-b92e-98c25f358210"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 63,
                column: "ConcurrencyStamp",
                value: new Guid("4efb9809-cf2c-4a0a-9d0f-4b4471fa62a7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 64,
                column: "ConcurrencyStamp",
                value: new Guid("b066a9ed-1bee-40ac-ae7d-6e584bef9701"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 65,
                column: "ConcurrencyStamp",
                value: new Guid("700e1006-2fb5-43ab-9fa9-e6678c1d1792"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 66,
                column: "ConcurrencyStamp",
                value: new Guid("519820eb-6116-40bf-8db0-60dc299921fd"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 67,
                column: "ConcurrencyStamp",
                value: new Guid("d7e1cc19-f5e7-4cb7-b70b-dc588b695c4f"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 68,
                column: "ConcurrencyStamp",
                value: new Guid("92a1389c-bc29-4041-ba39-5235214ec521"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 69,
                column: "ConcurrencyStamp",
                value: new Guid("f237ac8b-1590-4877-8fc3-c0d8fa66b81d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 70,
                column: "ConcurrencyStamp",
                value: new Guid("5cdcdd1b-7a04-4b3b-a0cf-ac1d617290b0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 71,
                column: "ConcurrencyStamp",
                value: new Guid("68fee2b7-95e9-4e15-9da0-ef1275b1d3be"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 72,
                column: "ConcurrencyStamp",
                value: new Guid("bb02e759-caed-49d8-bb3d-a53755a97614"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 73,
                column: "ConcurrencyStamp",
                value: new Guid("c925a4c9-d6e8-46b0-8f7e-767def27efbf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 74,
                column: "ConcurrencyStamp",
                value: new Guid("b29d5ad8-e93e-46ee-a2ec-c80deda4bfc1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 75,
                column: "ConcurrencyStamp",
                value: new Guid("95547f08-239f-42bf-b9be-dc631734ffa0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 76,
                column: "ConcurrencyStamp",
                value: new Guid("58b37ee9-c6ae-4267-bbb2-5c7baef4ab50"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 77,
                column: "ConcurrencyStamp",
                value: new Guid("0c65a9bf-4bed-47db-8834-ce6b95b670a2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 78,
                column: "ConcurrencyStamp",
                value: new Guid("4d0481be-01a1-461a-b104-6d73341032f8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 79,
                column: "ConcurrencyStamp",
                value: new Guid("c186945a-5dca-4010-a402-42df4aadd617"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 80,
                column: "ConcurrencyStamp",
                value: new Guid("758b73e5-a50e-46e1-9126-f407a8fa9a76"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 81,
                column: "ConcurrencyStamp",
                value: new Guid("80d056a4-5062-4f74-92bc-03cb0b67313e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 82,
                column: "ConcurrencyStamp",
                value: new Guid("87d5bc17-4675-4b3b-81f1-de21396223c0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 83,
                column: "ConcurrencyStamp",
                value: new Guid("abe82591-4e61-4fb5-ba3c-8e8027315c01"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 84,
                column: "ConcurrencyStamp",
                value: new Guid("9de20d35-ee45-4495-b664-3db60f9c8dd8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 85,
                column: "ConcurrencyStamp",
                value: new Guid("b13cdf82-eff6-4013-838a-97a5be161141"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 86,
                column: "ConcurrencyStamp",
                value: new Guid("66295f03-dfa4-412d-af7a-d618536ad450"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 87,
                column: "ConcurrencyStamp",
                value: new Guid("5a2e46c4-684a-46c8-bb10-baefab4a7f89"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 88,
                column: "ConcurrencyStamp",
                value: new Guid("1ce1d9fa-0825-4771-8be9-6cf2d52ad862"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 89,
                column: "ConcurrencyStamp",
                value: new Guid("99e6171f-f30a-49a2-8157-4a5f58f5d369"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 90,
                column: "ConcurrencyStamp",
                value: new Guid("e0bf1896-74d8-41fa-b056-5592061b190d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 91,
                column: "ConcurrencyStamp",
                value: new Guid("753a7bd3-5c84-4aa8-9874-f44f08e44a28"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 92,
                column: "ConcurrencyStamp",
                value: new Guid("32757771-781b-439e-9dda-977f0f43e9bf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 93,
                column: "ConcurrencyStamp",
                value: new Guid("e3cd5191-a0a4-4138-8165-2d7c7bcffcd3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 94,
                column: "ConcurrencyStamp",
                value: new Guid("2d692e02-2fc3-41d8-bcb8-77819f22a818"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 95,
                column: "ConcurrencyStamp",
                value: new Guid("ea17a784-7c4c-47e3-a1d6-a95041d1e526"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 96,
                column: "ConcurrencyStamp",
                value: new Guid("bd4a2420-a8b4-48a1-9977-babe50415006"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 97,
                column: "ConcurrencyStamp",
                value: new Guid("52cfd0bb-7cb0-4326-aee3-96cf7e1bb6ba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 98,
                column: "ConcurrencyStamp",
                value: new Guid("7a669591-02dc-48b2-a0de-d92e5f36eba7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 99,
                column: "ConcurrencyStamp",
                value: new Guid("ee5b2ce3-0331-4838-8672-346af5a92eaf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: new Guid("0c082c76-ae21-4358-92bd-ef53b65d92a1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: new Guid("9fac85da-ded1-4287-96b5-fe44c79a730e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: new Guid("ddd254d1-181f-4a54-ac6c-692fe6b7acc4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 103,
                column: "ConcurrencyStamp",
                value: new Guid("53a663bd-1fdf-4326-9f2e-a4697fa4a949"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 104,
                column: "ConcurrencyStamp",
                value: new Guid("4159fdf5-60ff-4d8d-9132-88538bda9371"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 105,
                column: "ConcurrencyStamp",
                value: new Guid("95eefe80-b588-4da4-bcfc-7451bd354985"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 106,
                column: "ConcurrencyStamp",
                value: new Guid("6bf714d7-c21e-46dd-b1c9-792788a40f02"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 107,
                column: "ConcurrencyStamp",
                value: new Guid("f7d04418-ef92-4bea-8a18-f4a6a60f584c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 108,
                column: "ConcurrencyStamp",
                value: new Guid("a14e70e0-fbf0-4789-9486-77940ea02f41"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 109,
                column: "ConcurrencyStamp",
                value: new Guid("b85cc63a-5ae3-48ff-9137-d09021b701c7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 110,
                column: "ConcurrencyStamp",
                value: new Guid("7fc563eb-1710-4adc-8592-c702c9688096"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 111,
                column: "ConcurrencyStamp",
                value: new Guid("5e8f91db-b15f-4721-ad6c-2f715870e262"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 112,
                column: "ConcurrencyStamp",
                value: new Guid("da043275-0345-4cba-a222-526f300e4a1b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 113,
                column: "ConcurrencyStamp",
                value: new Guid("6ebd32c8-4926-48bb-9603-fa5a9af9404b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 114,
                column: "ConcurrencyStamp",
                value: new Guid("3db25255-675e-4a30-940c-9e0dc2292e5d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 115,
                column: "ConcurrencyStamp",
                value: new Guid("52c3611d-675b-465f-a958-da5d18575ff5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 116,
                column: "ConcurrencyStamp",
                value: new Guid("4eccc4dc-a6a4-41ca-8faa-b38df0d96457"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 117,
                column: "ConcurrencyStamp",
                value: new Guid("5971ec68-00c6-4c40-9f87-b22bc699fde8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 118,
                column: "ConcurrencyStamp",
                value: new Guid("7004fa87-09b4-4669-b6ef-0ba9773a52d7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 119,
                column: "ConcurrencyStamp",
                value: new Guid("832275b9-61d8-41eb-971a-3947e21e62be"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 120,
                column: "ConcurrencyStamp",
                value: new Guid("20e825d6-cffc-43c4-8e8a-4aacb700b0af"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 121,
                column: "ConcurrencyStamp",
                value: new Guid("d195d3cb-7bfc-4a6d-800b-03e803a86eb2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 122,
                column: "ConcurrencyStamp",
                value: new Guid("ef5abf8e-0f2e-42ed-b11a-7a82ce5fa9d6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 123,
                column: "ConcurrencyStamp",
                value: new Guid("94a0321c-bec7-4892-8dbb-75abb17e6329"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 124,
                column: "ConcurrencyStamp",
                value: new Guid("a681d93f-d4fd-4569-9977-d07ef08a5938"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 125,
                column: "ConcurrencyStamp",
                value: new Guid("196db7a1-2da3-478f-907a-74b82dc1fd07"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 126,
                column: "ConcurrencyStamp",
                value: new Guid("6bd27ad0-92e4-4349-82dc-e74b0348afda"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 127,
                column: "ConcurrencyStamp",
                value: new Guid("1f047665-e430-4a95-a952-5054a8e73189"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 128,
                column: "ConcurrencyStamp",
                value: new Guid("bf697488-dd26-45fe-aa63-1013b38c6f0b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 129,
                column: "ConcurrencyStamp",
                value: new Guid("e02ccf00-7230-406e-8714-c9dc3ea1a80d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 130,
                column: "ConcurrencyStamp",
                value: new Guid("245fd2c1-7b44-4546-b062-2d9db85914c1"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 131,
                column: "ConcurrencyStamp",
                value: new Guid("6359809f-d346-465a-af1d-b39deb6e248b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 132,
                column: "ConcurrencyStamp",
                value: new Guid("9a1ddc8c-669a-4634-bba9-ecbabacd7370"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 133,
                column: "ConcurrencyStamp",
                value: new Guid("6b06c175-ff51-4345-8244-7b7b0bb5e343"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 134,
                column: "ConcurrencyStamp",
                value: new Guid("948d8391-3735-43de-80f2-bad4de36bdd5"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 135,
                column: "ConcurrencyStamp",
                value: new Guid("7e088d8c-88fd-4631-bfde-8f5b89275962"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 136,
                column: "ConcurrencyStamp",
                value: new Guid("48d56506-7778-4e03-8a73-f1b3d673e378"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 137,
                column: "ConcurrencyStamp",
                value: new Guid("6c7b8e42-1249-4ee4-bc86-9e16cea1609e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 138,
                column: "ConcurrencyStamp",
                value: new Guid("5c496c51-9329-4f6d-9ba4-11df410ebc57"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 139,
                column: "ConcurrencyStamp",
                value: new Guid("ee7c3f15-4e1e-4586-905c-456db65f6e91"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 140,
                column: "ConcurrencyStamp",
                value: new Guid("ba735601-2292-4109-b78a-bd6f4bac49b6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 141,
                column: "ConcurrencyStamp",
                value: new Guid("48c7dc94-6b24-4ecb-9cc6-a9d4297ae522"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 142,
                column: "ConcurrencyStamp",
                value: new Guid("25a979c9-ac48-4e69-8dc2-676fb2fe0112"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 143,
                column: "ConcurrencyStamp",
                value: new Guid("96bf64db-1f15-469e-9b52-03563e49c717"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 144,
                column: "ConcurrencyStamp",
                value: new Guid("ccaa5663-1ecb-4345-b374-9a2ce2d4992c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 145,
                column: "ConcurrencyStamp",
                value: new Guid("3f713d95-c88a-47b6-acc8-4cf01c02135e"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 146,
                column: "ConcurrencyStamp",
                value: new Guid("a627edcb-6853-4480-ba07-5362285cb889"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 147,
                column: "ConcurrencyStamp",
                value: new Guid("a6b474f2-cba4-4c50-8e57-ecc7e3d9d56d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 148,
                column: "ConcurrencyStamp",
                value: new Guid("e78a304c-b936-42a7-a3f6-8f415d152f6c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 149,
                column: "ConcurrencyStamp",
                value: new Guid("fa63e9aa-0058-4bd0-9f00-dca14d417042"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 150,
                column: "ConcurrencyStamp",
                value: new Guid("403e46f7-7cf5-4e78-b528-3e05b8dabcd7"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 151,
                column: "ConcurrencyStamp",
                value: new Guid("d43b7c06-fc5c-4022-88ad-604eb683a0ee"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 152,
                column: "ConcurrencyStamp",
                value: new Guid("07f15511-fff4-4c52-bd19-e88dd71a3eff"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 153,
                column: "ConcurrencyStamp",
                value: new Guid("6d0cbd0f-cb08-491a-a430-bbba5399b4f3"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 154,
                column: "ConcurrencyStamp",
                value: new Guid("4b93b973-704b-4d6c-98f3-65621a142448"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 155,
                column: "ConcurrencyStamp",
                value: new Guid("1a835f0b-f6af-442e-8ac9-f62d366f25c8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 156,
                column: "ConcurrencyStamp",
                value: new Guid("21bd9891-bb27-40f9-a917-eae06a2ed786"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 157,
                column: "ConcurrencyStamp",
                value: new Guid("a5801783-9a96-42d9-a455-75c5ea2c2181"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 158,
                column: "ConcurrencyStamp",
                value: new Guid("0dbe99b2-6604-40e7-ad8f-e3f5f1fa8a13"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 159,
                column: "ConcurrencyStamp",
                value: new Guid("47686e0f-1516-49f9-8dcb-ea04ab5087ec"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 160,
                column: "ConcurrencyStamp",
                value: new Guid("65c80957-0bb3-460f-8f6f-446ed8aaa050"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 161,
                column: "ConcurrencyStamp",
                value: new Guid("e2db1682-09e9-4c33-b20a-ed3bfa0348ba"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 162,
                column: "ConcurrencyStamp",
                value: new Guid("6da7fab3-3512-4cd6-9777-32b98eccdb44"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 163,
                column: "ConcurrencyStamp",
                value: new Guid("c09e68c2-ea18-4e3b-a82f-9b8b169475d8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 164,
                column: "ConcurrencyStamp",
                value: new Guid("19d614fa-2c0b-48ef-a12e-141ab36475f6"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 165,
                column: "ConcurrencyStamp",
                value: new Guid("1840d0f0-96a4-4d36-8449-43a1fcc0b288"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 166,
                column: "ConcurrencyStamp",
                value: new Guid("31be6961-a175-422d-8d63-fdcc81185d62"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 167,
                column: "ConcurrencyStamp",
                value: new Guid("437bc92d-bbb0-4d2b-ab94-eeda8042e20d"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 168,
                column: "ConcurrencyStamp",
                value: new Guid("eea3a1c1-cfdb-4940-9c74-e7825df91939"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 169,
                column: "ConcurrencyStamp",
                value: new Guid("50e8fe0d-92e4-41b7-a717-282d4088b5b4"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 170,
                column: "ConcurrencyStamp",
                value: new Guid("4d8e470f-d30c-4cf4-b817-a4f12167e97a"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 171,
                column: "ConcurrencyStamp",
                value: new Guid("e8043546-2903-42bd-b489-7a07abaf7e81"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 172,
                column: "ConcurrencyStamp",
                value: new Guid("50cd09a7-7742-4608-8e17-a32363b27b47"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 173,
                column: "ConcurrencyStamp",
                value: new Guid("1bdba5b5-9183-40e1-97b7-f9d2753fcd76"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 174,
                column: "ConcurrencyStamp",
                value: new Guid("57701b12-dadf-4ece-be8e-443433ffd011"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 175,
                column: "ConcurrencyStamp",
                value: new Guid("59dd1fda-2db9-4e85-b757-decbceb4c6af"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 176,
                column: "ConcurrencyStamp",
                value: new Guid("c59a3254-5f94-490e-812b-32448390d7ed"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 177,
                column: "ConcurrencyStamp",
                value: new Guid("3b88fd0b-bfad-49da-8d5d-08908a23a6b2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 178,
                column: "ConcurrencyStamp",
                value: new Guid("633e74f3-1707-4e52-b03e-b90e423e2bd0"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 179,
                column: "ConcurrencyStamp",
                value: new Guid("57f70032-a642-4516-9950-d13e8e87d862"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 180,
                column: "ConcurrencyStamp",
                value: new Guid("4976d7c7-805d-468f-9195-1fdb8cdd312b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 181,
                column: "ConcurrencyStamp",
                value: new Guid("3c4fb0f4-57b8-4e46-8498-08a332f7b8ce"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 182,
                column: "ConcurrencyStamp",
                value: new Guid("82f03ccf-aac9-4cee-90eb-96214f3fc162"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 183,
                column: "ConcurrencyStamp",
                value: new Guid("af2d3e62-ccde-4d04-8ef6-4b20f6135bc8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 184,
                column: "ConcurrencyStamp",
                value: new Guid("8d76e458-f58f-4c39-be97-27138fbf7f6b"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 185,
                column: "ConcurrencyStamp",
                value: new Guid("9db32e1e-ff16-440c-a55b-7455a938b54c"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 186,
                column: "ConcurrencyStamp",
                value: new Guid("a54e49a9-d278-4e40-bd89-c4a2914423a2"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 187,
                column: "ConcurrencyStamp",
                value: new Guid("5f64a922-d95d-4784-923d-6331310c12af"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 188,
                column: "ConcurrencyStamp",
                value: new Guid("209c8d92-05ff-4da6-a6a9-d788b1a9bdaf"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 189,
                column: "ConcurrencyStamp",
                value: new Guid("385577c7-3157-4e9b-a7d7-a342c828d9cc"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 190,
                column: "ConcurrencyStamp",
                value: new Guid("c760866b-91d7-4535-9653-3f8a89dac285"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Posters",
                keyColumn: "Id",
                keyValue: new Guid("08a67378-487c-40f3-9d53-5c2acb9cb78d"),
                column: "ConcurrencyStamp",
                value: new Guid("15370ff5-4124-473e-aa00-018e3c2022fe"));

            migrationBuilder.UpdateData(
                schema: "DataManagement",
                table: "Posters",
                keyColumn: "Id",
                keyValue: new Guid("f760c6af-419a-4378-9348-d6742ee62f9d"),
                column: "ConcurrencyStamp",
                value: new Guid("b6051fb7-69d5-4578-a4ee-4893b53fc688"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("02fa2cc2-2c01-402b-91fa-84526ca51edc"),
                column: "ConcurrencyStamp",
                value: new Guid("f027e6b8-1bc6-41db-af15-7f2074005795"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3060bbf4-415c-4767-8ad6-ba49685a31e1"),
                column: "ConcurrencyStamp",
                value: new Guid("e088a8e0-d01d-4b58-a856-bfd01d1eefe8"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("7a24cdc2-0f48-4e34-9c8e-745a9b06d0d7"),
                column: "ConcurrencyStamp",
                value: new Guid("59f307c5-0df6-44b4-9e50-8f6974006837"));

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("9830a808-b80b-41d6-84fb-b186bbec6d45"),
                column: "ConcurrencyStamp",
                value: new Guid("70326796-4268-4b46-b44f-0291de330e75"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: new Guid("b8855a81-43b1-4862-aa37-192730fe6178"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: new Guid("915fcb29-9907-449d-ad2b-69ddbd1ca88d"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: new Guid("66d9eaf8-7a10-46c5-840d-b9ffd1a48cdf"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: new Guid("8a138405-f4e4-4d13-a8e6-833307fc54f0"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("0b93bea1-eee3-4838-8513-7ade73017e5a"),
                column: "ConcurrencyStamp",
                value: new Guid("f8122c66-efc8-4af3-bc75-cd840affa2b8"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("e8de7eaf-13f0-4c77-b341-45f3cc10bc00"),
                column: "ConcurrencyStamp",
                value: new Guid("feb7f059-30a1-40f0-ae31-c047cb037898"));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 246, 199, 227, 141, 221, 152, 123, 241, 2, 239, 194, 81, 110, 222, 229, 80, 105, 247, 151, 165, 111, 138, 251, 177, 93, 222, 170, 111, 38, 216, 73, 126, 44, 124, 5, 145, 149, 144, 174, 41, 157, 27, 237, 255, 50, 76, 49, 53, 80, 107, 66, 72, 155, 181, 135, 153, 202, 97, 22, 122, 41, 181, 15, 211 }, new byte[] { 96, 210, 60, 87, 145, 229, 183, 250, 167, 223, 38, 94, 114, 241, 78, 62, 153, 83, 195, 234, 200, 70, 42, 228, 157, 73, 192, 40, 247, 169, 29, 234, 62, 6, 241, 234, 137, 58, 94, 48, 1, 77, 134, 187, 105, 252, 200, 159, 79, 6, 100, 199, 16, 18, 39, 245, 191, 99, 70, 250, 239, 80, 147, 205, 243, 97, 134, 235, 209, 194, 27, 30, 214, 24, 228, 165, 131, 69, 220, 135, 176, 165, 239, 98, 132, 215, 76, 130, 160, 210, 127, 234, 61, 108, 153, 54, 2, 209, 99, 191, 215, 215, 83, 91, 31, 123, 42, 190, 215, 181, 137, 158, 248, 135, 57, 147, 16, 206, 12, 14, 196, 158, 156, 241, 248, 232, 245, 8 } });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa42bf46-7255-4347-a10d-9a0f58fc1c80"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 246, 199, 227, 141, 221, 152, 123, 241, 2, 239, 194, 81, 110, 222, 229, 80, 105, 247, 151, 165, 111, 138, 251, 177, 93, 222, 170, 111, 38, 216, 73, 126, 44, 124, 5, 145, 149, 144, 174, 41, 157, 27, 237, 255, 50, 76, 49, 53, 80, 107, 66, 72, 155, 181, 135, 153, 202, 97, 22, 122, 41, 181, 15, 211 }, new byte[] { 96, 210, 60, 87, 145, 229, 183, 250, 167, 223, 38, 94, 114, 241, 78, 62, 153, 83, 195, 234, 200, 70, 42, 228, 157, 73, 192, 40, 247, 169, 29, 234, 62, 6, 241, 234, 137, 58, 94, 48, 1, 77, 134, 187, 105, 252, 200, 159, 79, 6, 100, 199, 16, 18, 39, 245, 191, 99, 70, 250, 239, 80, 147, 205, 243, 97, 134, 235, 209, 194, 27, 30, 214, 24, 228, 165, 131, 69, 220, 135, 176, 165, 239, 98, 132, 215, 76, 130, 160, 210, 127, 234, 61, 108, 153, 54, 2, 209, 99, 191, 215, 215, 83, 91, 31, 123, 42, 190, 215, 181, 137, 158, 248, 135, 57, 147, 16, 206, 12, 14, 196, 158, 156, 241, 248, 232, 245, 8 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPayed",
                schema: "Request",
                table: "DailyRequestMains");

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
        }
    }
}
