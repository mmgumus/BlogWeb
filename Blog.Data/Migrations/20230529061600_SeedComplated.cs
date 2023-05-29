using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedComplated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("51e4ba80-771e-4fa5-bcf4-dba56b60dbee"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("52022353-f133-45d4-9398-bb95bf94a52a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3f9c3a0-0b0a-4b3a-8b0a-0b0a4b3a8b0a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0d95258-55a0-44a8-892d-b10209ffcccf"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b3f9c3a0-0b0a-4b3a-8b0a-0b0a4b3a8b0a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d0d95258-55a0-44a8-892d-b10209ffcccf"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("43111c27-bd52-4ebf-a2a1-4045fc8bc6cf"), "Admin Test", new DateTime(2023, 5, 29, 9, 16, 0, 81, DateTimeKind.Local).AddTicks(9669), null, null, false, null, null, "Test Category" },
                    { new Guid("dd5c4adc-4079-4e20-8df3-7c7985708bad"), "Admin Test", new DateTime(2023, 5, 29, 9, 16, 0, 81, DateTimeKind.Local).AddTicks(9672), null, null, false, null, null, "Visual Studio 2020" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("278e8df1-9dc0-47d1-80f4-f3c5a3622cc8"), "Admin Test", new DateTime(2023, 5, 29, 9, 16, 0, 81, DateTimeKind.Local).AddTicks(9782), null, null, "Test Image2", "jpg", false, null, null },
                    { new Guid("c0d4bbe1-4f93-4f50-8641-e5c59342d9a1"), "Admin Test", new DateTime(2023, 5, 29, 9, 16, 0, 81, DateTimeKind.Local).AddTicks(9779), null, null, "Test Image", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("57cd0257-cb11-4be8-9933-ded3b55ec1d0"), new Guid("43111c27-bd52-4ebf-a2a1-4045fc8bc6cf"), "Test Content", "Admin Test", new DateTime(2023, 5, 29, 9, 16, 0, 81, DateTimeKind.Local).AddTicks(9430), null, null, new Guid("c0d4bbe1-4f93-4f50-8641-e5c59342d9a1"), false, null, null, "Test Article", 15 },
                    { new Guid("e56aa179-841b-4e68-bbef-50956ea437f4"), new Guid("dd5c4adc-4079-4e20-8df3-7c7985708bad"), "Test Content2", "Admin Test2", new DateTime(2023, 5, 29, 9, 16, 0, 81, DateTimeKind.Local).AddTicks(9434), null, null, new Guid("278e8df1-9dc0-47d1-80f4-f3c5a3622cc8"), false, null, null, "Test Article2", 17 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("57cd0257-cb11-4be8-9933-ded3b55ec1d0"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e56aa179-841b-4e68-bbef-50956ea437f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43111c27-bd52-4ebf-a2a1-4045fc8bc6cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd5c4adc-4079-4e20-8df3-7c7985708bad"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("278e8df1-9dc0-47d1-80f4-f3c5a3622cc8"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("c0d4bbe1-4f93-4f50-8641-e5c59342d9a1"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("b3f9c3a0-0b0a-4b3a-8b0a-0b0a4b3a8b0a"), "Admin Test", new DateTime(2023, 5, 29, 9, 7, 32, 598, DateTimeKind.Local).AddTicks(3867), null, null, false, null, null, "Test Category" },
                    { new Guid("d0d95258-55a0-44a8-892d-b10209ffcccf"), "Admin Test", new DateTime(2023, 5, 29, 9, 7, 32, 598, DateTimeKind.Local).AddTicks(3869), null, null, false, null, null, "Visual Studio 2020" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("b3f9c3a0-0b0a-4b3a-8b0a-0b0a4b3a8b0a"), "Admin Test", new DateTime(2023, 5, 29, 9, 7, 32, 598, DateTimeKind.Local).AddTicks(3963), null, null, "Test Image", "jpg", false, null, null },
                    { new Guid("d0d95258-55a0-44a8-892d-b10209ffcccf"), "Admin Test2", new DateTime(2023, 5, 29, 9, 7, 32, 598, DateTimeKind.Local).AddTicks(3965), null, null, "Test Image2", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("51e4ba80-771e-4fa5-bcf4-dba56b60dbee"), new Guid("d0d95258-55a0-44a8-892d-b10209ffcccf"), "Test Content2", "Admin Test2", new DateTime(2023, 5, 29, 9, 7, 32, 598, DateTimeKind.Local).AddTicks(3668), null, null, new Guid("d0d95258-55a0-44a8-892d-b10209ffcccf"), false, null, null, "Test Article2", 17 },
                    { new Guid("52022353-f133-45d4-9398-bb95bf94a52a"), new Guid("00000000-0000-0000-0000-000000000000"), "Test Content", "Admin Test", new DateTime(2023, 5, 29, 9, 7, 32, 598, DateTimeKind.Local).AddTicks(3650), null, null, new Guid("b3f9c3a0-0b0a-4b3a-8b0a-0b0a4b3a8b0a"), false, null, null, "Test Article", 15 }
                });
        }
    }
}
