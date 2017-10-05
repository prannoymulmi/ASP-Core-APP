using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class UserDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    HobbieId = table.Column<Guid>(nullable: false),
                    AspNetUserId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.HobbieId);
                    table.ForeignKey(
                        name: "FK_Hobbies_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Indvidual",
                columns: table => new
                {
                    IndividualId = table.Column<Guid>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    AspNetUserId = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indvidual", x => x.IndividualId);
                    table.ForeignKey(
                        name: "FK_Indvidual_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    AspNetUserId = table.Column<string>(nullable: true),
                    BusinessName = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(nullable: true),
                    HireDate = table.Column<DateTime>(nullable: false),
                    Profession = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.OrganizationId);
                    table.ForeignKey(
                        name: "FK_Organization_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_AspNetUserId",
                table: "Hobbies",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Indvidual_AspNetUserId",
                table: "Indvidual",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_AspNetUserId",
                table: "Organization",
                column: "AspNetUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Indvidual");

            migrationBuilder.DropTable(
                name: "Organization");
        }
    }
}
