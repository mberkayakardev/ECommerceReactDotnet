using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppApplicationType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppApplicationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClaimDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    UserFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    FalseEntryCount = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescriptionForTextEdit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppClaimId = table.Column<int>(type: "int", nullable: false),
                    AppApplicationTypeId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppMenus_AppApplicationType_AppApplicationTypeId",
                        column: x => x.AppApplicationTypeId,
                        principalTable: "AppApplicationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppMenus_AppClaims_AppClaimId",
                        column: x => x.AppClaimId,
                        principalTable: "AppClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppRoleClaims_AppClaims_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "AppClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppRoleClaims_AppRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppTokens_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserClaims_AppClaims_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "AppClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserClaims_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AppRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppMVCMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RootId = table.Column<int>(type: "int", nullable: true),
                    MenuOrderNumber = table.Column<int>(type: "int", nullable: false),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControllerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parameter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNewTab = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMVCMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppMVCMenus_AppMVCMenus_RootId",
                        column: x => x.RootId,
                        principalTable: "AppMVCMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppMVCMenus_AppMenus_Id",
                        column: x => x.Id,
                        principalTable: "AppMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppApplicationType",
                columns: new[] { "Id", "ApplicationDescription", "ApplicationName", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName" },
                values: new object[,]
                {
                    { 1, "MVC", "MVC", new DateTime(2025, 4, 26, 13, 46, 56, 179, DateTimeKind.Utc).AddTicks(6294), null, "SeedData", true, new DateTime(2025, 4, 26, 13, 46, 56, 179, DateTimeKind.Utc).AddTicks(6577), null, "SeedData" },
                    { 2, "React", "React", new DateTime(2025, 4, 26, 13, 46, 56, 179, DateTimeKind.Utc).AddTicks(7467), null, "SeedData", true, new DateTime(2025, 4, 26, 13, 46, 56, 179, DateTimeKind.Utc).AddTicks(7467), null, "SeedData" }
                });

            migrationBuilder.InsertData(
                table: "AppClaims",
                columns: new[] { "Id", "ClaimDescription", "ClaimName", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName" },
                values: new object[] { 1, "Admin Layout içerisindeki Dashboard ın görülebilmesi için eklenmiş olan bir cliam dir.", "Admin.Dashboard", new DateTime(2025, 4, 26, 13, 46, 56, 180, DateTimeKind.Utc).AddTicks(3884), null, "SeedData", true, new DateTime(2025, 4, 26, 13, 46, 56, 180, DateTimeKind.Utc).AddTicks(3886), null, "SeedData" });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "RoleDescription", "RoleName" },
                values: new object[] { 1, new DateTime(2025, 4, 26, 16, 46, 56, 181, DateTimeKind.Local).AddTicks(579), null, "Seed Data", true, new DateTime(2025, 4, 26, 16, 46, 56, 181, DateTimeKind.Local).AddTicks(8567), null, null, "En yetkili kullanıcı", "Sistem Admin" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "CreatedUserName", "EmailConfirmed", "FalseEntryCount", "IsActive", "IsBlocked", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "UserEmail", "UserFullName", "UserName", "UserPassword" },
                values: new object[] { 1, new DateTime(2025, 4, 26, 16, 46, 56, 182, DateTimeKind.Local).AddTicks(3420), null, "Seed Data", true, 0, true, false, new DateTime(2025, 4, 26, 16, 46, 56, 182, DateTimeKind.Local).AddTicks(3424), null, "Seed Data", "berkayakar@gmail.com", "Berkay AKAR", "berkayakar", "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "ProductDescription", "ProductDescriptionForTextEdit", "ProductName", "ProductPrice", "Stock" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 26, 16, 46, 56, 192, DateTimeKind.Local).AddTicks(9737), null, "SeedData", true, new DateTime(2025, 4, 26, 16, 46, 56, 192, DateTimeKind.Local).AddTicks(9741), null, "SeedData", "Telefon", "Telefon", "Telefon", 15000m, 20 },
                    { 2, new DateTime(2025, 4, 26, 16, 46, 56, 193, DateTimeKind.Local).AddTicks(480), null, "SeedData", true, new DateTime(2025, 4, 26, 16, 46, 56, 193, DateTimeKind.Local).AddTicks(481), null, "SeedData", "Tablet", "Tablet", "Tablet", 15000m, 20 },
                    { 3, new DateTime(2025, 4, 26, 16, 46, 56, 193, DateTimeKind.Local).AddTicks(484), null, "SeedData", true, new DateTime(2025, 4, 26, 16, 46, 56, 193, DateTimeKind.Local).AddTicks(484), null, "SeedData", "Masaüstü PC", "Masaüstü PC", "Masaüstü PC", 15000m, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppMenus_AppApplicationTypeId",
                table: "AppMenus",
                column: "AppApplicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppMenus_AppClaimId",
                table: "AppMenus",
                column: "AppClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_AppMVCMenus_RootId",
                table: "AppMVCMenus",
                column: "RootId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRoleClaims_ClaimId",
                table: "AppRoleClaims",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRoleClaims_RoleId",
                table: "AppRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AppTokens_AppUserId",
                table: "AppTokens",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUserClaims_ClaimId",
                table: "AppUserClaims",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserClaims_UserId",
                table: "AppUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_RoleId",
                table: "AppUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_UserId",
                table: "AppUserRoles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppMVCMenus");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppTokens");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AppMenus");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "AppApplicationType");

            migrationBuilder.DropTable(
                name: "AppClaims");
        }
    }
}
