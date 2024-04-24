using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProjectManager.Models.Migrations
{
    public partial class updte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("e87ac7c5-95a5-46dd-92e4-9785bf11b5f3") });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e87ac7c5-95a5-46dd-92e4-9785bf11b5f3"));

            migrationBuilder.AddColumn<bool>(
                name: "IsReceiveMail",
                table: "User",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReceiveMail",
                table: "User");

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("e87ac7c5-95a5-46dd-92e4-9785bf11b5f3") });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "IsActive", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "ba0c0e46-5d0a-4d6f-a5fb-16360f204b7b", "Administrator role", true, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedOn", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Gender", "IsActive", "IsVerification", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedOn", "UrlAvatar", "UserName" },
                values: new object[] { new Guid("e87ac7c5-95a5-46dd-92e4-9785bf11b5f3"), 0, "Đà Nẵng", "ad25a31b-2fb4-4f72-a313-246d8f5d2fb8", new DateTime(2022, 4, 9, 11, 20, 3, 905, DateTimeKind.Local).AddTicks(6499), new DateTime(2000, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Nam", true, true, true, "Tran Thanh", false, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEBn/lfgI3YT5je5TLzIY1IcdAcvRrDiKWEc/Hj4FSQFrxxvutu17nzJ/HlwHox0dQA==", "0968354148", false, "", false, new DateTime(2022, 4, 9, 11, 20, 3, 905, DateTimeKind.Local).AddTicks(6510), "/upload/avatar/admin1.jpg", "admin123" });
        }
    }
}
