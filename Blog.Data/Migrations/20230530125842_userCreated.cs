using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class userCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("30cf4200-e8e9-4f9d-842b-78b498abb53f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("df41eff7-0042-4410-94a0-7062c51193cd"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("4bc4e834-2ebf-4b3d-b678-50e1d07a97f6"), new Guid("dd5c4adc-4079-4e20-8df3-7c7985708bad"), "Test Content2", "Admin Test2", new DateTime(2023, 5, 30, 15, 58, 42, 420, DateTimeKind.Local).AddTicks(6015), null, null, new Guid("278e8df1-9dc0-47d1-80f4-f3c5a3622cc8"), false, null, null, "Test Article2", 17 },
                    { new Guid("9f84978b-ef27-481e-9548-e4988780ebab"), new Guid("43111c27-bd52-4ebf-a2a1-4045fc8bc6cf"), "Test Content", "Admin Test", new DateTime(2023, 5, 30, 15, 58, 42, 420, DateTimeKind.Local).AddTicks(6011), null, null, new Guid("c0d4bbe1-4f93-4f50-8641-e5c59342d9a1"), false, null, null, "Test Article", 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("99cc3570-90fa-4ecb-8b5c-d50fcda470e9"), "e9e8fd6e-8465-499a-8ee8-64f6831cac52", "admin", "ADMIN" },
                    { new Guid("a0f0f0f0-90fa-4ecb-8b5c-d50fcda470e9"), "4dd951e6-790b-4f78-8499-5f37f3e5bef9", "superAdmin", "SUPERADMIN" },
                    { new Guid("b0f0f0f0-90fa-4ecb-8b5c-d50fcda470e9"), "52211065-445a-43c8-a578-893f29328219", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("34f4249a-e193-4224-b881-43fb15c8dcfb"), 0, "af22932f-99c3-4769-a9d5-b424c7a12292", "superadmin@gmail.com", true, "Cem", "Keskin", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEE0FPlI8QGQH3gKHFQ1EW397QZ41EOtCkZ8C3YxIDKH7bsQRXvXVG/22xTm7oXqR/Q==", "+903223232323", true, "af789d92-26b4-4b05-b9ae-3e6c2aac2958", false, "superadmin@gmail.com" },
                    { new Guid("906cf7b6-99ad-49d4-80dd-70b75e6b1dd6"), 0, "5e72a34e-0960-429a-874e-6506fc75b0d3", "admin@gmail.com", true, "Hasan", "Yildirim", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAENX1RJ/g37XLblrK1QrUKeMvWYf8NWXFoOvB6m64ZiqmVMC5EUUUfnfVTt9SfHuqtA==", "+903223232323", true, "01254e3a-4cc8-4167-928b-dd837ab06505", false, "superadmin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43111c27-bd52-4ebf-a2a1-4045fc8bc6cf"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 30, 15, 58, 42, 420, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd5c4adc-4079-4e20-8df3-7c7985708bad"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 30, 15, 58, 42, 420, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("278e8df1-9dc0-47d1-80f4-f3c5a3622cc8"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 30, 15, 58, 42, 420, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("c0d4bbe1-4f93-4f50-8641-e5c59342d9a1"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 30, 15, 58, 42, 420, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("a0f0f0f0-90fa-4ecb-8b5c-d50fcda470e9"), new Guid("34f4249a-e193-4224-b881-43fb15c8dcfb") },
                    { new Guid("99cc3570-90fa-4ecb-8b5c-d50fcda470e9"), new Guid("906cf7b6-99ad-49d4-80dd-70b75e6b1dd6") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_UserId",
                table: "AspNetRoleClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_RoleId",
                table: "AspNetUserClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4bc4e834-2ebf-4b3d-b678-50e1d07a97f6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9f84978b-ef27-481e-9548-e4988780ebab"));

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
    }
}
