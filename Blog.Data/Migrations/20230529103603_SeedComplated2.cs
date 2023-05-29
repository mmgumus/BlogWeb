using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedComplated2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("57cd0257-cb11-4be8-9933-ded3b55ec1d0"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e56aa179-841b-4e68-bbef-50956ea437f4"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("30cf4200-e8e9-4f9d-842b-78b498abb53f"), new Guid("dd5c4adc-4079-4e20-8df3-7c7985708bad"), "Test Content2", "Admin Test2", new DateTime(2023, 5, 29, 13, 36, 3, 182, DateTimeKind.Local).AddTicks(5120), null, null, new Guid("278e8df1-9dc0-47d1-80f4-f3c5a3622cc8"), false, null, null, "Test Article2", 17 },
                    { new Guid("df41eff7-0042-4410-94a0-7062c51193cd"), new Guid("43111c27-bd52-4ebf-a2a1-4045fc8bc6cf"), "Test Content", "Admin Test", new DateTime(2023, 5, 29, 13, 36, 3, 182, DateTimeKind.Local).AddTicks(5115), null, null, new Guid("c0d4bbe1-4f93-4f50-8641-e5c59342d9a1"), false, null, null, "Test Article", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43111c27-bd52-4ebf-a2a1-4045fc8bc6cf"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 13, 36, 3, 182, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd5c4adc-4079-4e20-8df3-7c7985708bad"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 13, 36, 3, 182, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("278e8df1-9dc0-47d1-80f4-f3c5a3622cc8"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 13, 36, 3, 182, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("c0d4bbe1-4f93-4f50-8641-e5c59342d9a1"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 13, 36, 3, 182, DateTimeKind.Local).AddTicks(5402));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("30cf4200-e8e9-4f9d-842b-78b498abb53f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("df41eff7-0042-4410-94a0-7062c51193cd"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("57cd0257-cb11-4be8-9933-ded3b55ec1d0"), new Guid("43111c27-bd52-4ebf-a2a1-4045fc8bc6cf"), "Test Content", "Admin Test", new DateTime(2023, 5, 29, 9, 16, 0, 81, DateTimeKind.Local).AddTicks(9430), null, null, new Guid("c0d4bbe1-4f93-4f50-8641-e5c59342d9a1"), false, null, null, "Test Article", 15 },
                    { new Guid("e56aa179-841b-4e68-bbef-50956ea437f4"), new Guid("dd5c4adc-4079-4e20-8df3-7c7985708bad"), "Test Content2", "Admin Test2", new DateTime(2023, 5, 29, 9, 16, 0, 81, DateTimeKind.Local).AddTicks(9434), null, null, new Guid("278e8df1-9dc0-47d1-80f4-f3c5a3622cc8"), false, null, null, "Test Article2", 17 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43111c27-bd52-4ebf-a2a1-4045fc8bc6cf"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 9, 16, 0, 81, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd5c4adc-4079-4e20-8df3-7c7985708bad"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 9, 16, 0, 81, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("278e8df1-9dc0-47d1-80f4-f3c5a3622cc8"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 9, 16, 0, 81, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("c0d4bbe1-4f93-4f50-8641-e5c59342d9a1"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 9, 16, 0, 81, DateTimeKind.Local).AddTicks(9779));
        }
    }
}
