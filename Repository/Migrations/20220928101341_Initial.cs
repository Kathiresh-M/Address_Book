﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RefSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefSet_Key = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefTerm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefTerm_Key = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefTerm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SetRefTerm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefSet_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefTerm_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetRefTerm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SetRefTerm_RefSet_RefSet_Id",
                        column: x => x.RefSet_Id,
                        principalTable: "RefSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetRefTerm_RefTerm_RefTerm_Id",
                        column: x => x.RefTerm_Id,
                        principalTable: "RefTerm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Line1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Line2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefTerm_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_RefTerm_RefTerm_Id",
                        column: x => x.RefTerm_Id,
                        principalTable: "RefTerm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Address_User_Details_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User_Details",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assert",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Asserts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assert", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assert_User_Details_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User_Details",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefTerm_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Email_RefTerm_RefTerm_Id",
                        column: x => x.RefTerm_Id,
                        principalTable: "RefTerm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Email_User_Details_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User_Details",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Phone_Number = table.Column<int>(type: "int", nullable: false),
                    Phone_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefTerm_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phone_RefTerm_RefTerm_Id",
                        column: x => x.RefTerm_Id,
                        principalTable: "RefTerm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phone_User_Details_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User_Details",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_RefTerm_Id",
                table: "Address",
                column: "RefTerm_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Address_User_Id",
                table: "Address",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Assert_User_Id",
                table: "Assert",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Email_RefTerm_Id",
                table: "Email",
                column: "RefTerm_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Email_User_Id",
                table: "Email",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_RefTerm_Id",
                table: "Phone",
                column: "RefTerm_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_User_Id",
                table: "Phone",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SetRefTerm_RefSet_Id",
                table: "SetRefTerm",
                column: "RefSet_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SetRefTerm_RefTerm_Id",
                table: "SetRefTerm",
                column: "RefTerm_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Assert");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "SetRefTerm");

            migrationBuilder.DropTable(
                name: "User_Details");

            migrationBuilder.DropTable(
                name: "RefSet");

            migrationBuilder.DropTable(
                name: "RefTerm");
        }
    }
}
