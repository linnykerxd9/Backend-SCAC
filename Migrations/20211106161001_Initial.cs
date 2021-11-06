using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend_SCAC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommunityLeader",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Rg = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Login = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExitDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityLeader", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrgPublic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Responsible = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgPublic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Priority",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priority", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resident",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Rg = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Birthday = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    District = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    Complement = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resident", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameResponsible = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Hour = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_Status_IdStatus",
                        column: x => x.IdStatus,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vindication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CompletionDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    OpenDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IdLeader = table.Column<int>(type: "int", nullable: false),
                    IdResident = table.Column<int>(type: "int", nullable: false),
                    IdStatus = table.Column<int>(type: "int", nullable: false),
                    IdOrgPublic = table.Column<int>(type: "int", nullable: true),
                    IdPriority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vindication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vindication_CommunityLeader_IdLeader",
                        column: x => x.IdLeader,
                        principalTable: "CommunityLeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vindication_OrgPublic_IdOrgPublic",
                        column: x => x.IdOrgPublic,
                        principalTable: "OrgPublic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vindication_Priority_IdPriority",
                        column: x => x.IdPriority,
                        principalTable: "Priority",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vindication_Resident_IdResident",
                        column: x => x.IdResident,
                        principalTable: "Resident",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vindication_Status_IdStatus",
                        column: x => x.IdStatus,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Event_IdStatus",
                table: "Event",
                column: "IdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Vindication_IdLeader",
                table: "Vindication",
                column: "IdLeader");

            migrationBuilder.CreateIndex(
                name: "IX_Vindication_IdOrgPublic",
                table: "Vindication",
                column: "IdOrgPublic");

            migrationBuilder.CreateIndex(
                name: "IX_Vindication_IdPriority",
                table: "Vindication",
                column: "IdPriority");

            migrationBuilder.CreateIndex(
                name: "IX_Vindication_IdResident",
                table: "Vindication",
                column: "IdResident");

            migrationBuilder.CreateIndex(
                name: "IX_Vindication_IdStatus",
                table: "Vindication",
                column: "IdStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Vindication");

            migrationBuilder.DropTable(
                name: "CommunityLeader");

            migrationBuilder.DropTable(
                name: "OrgPublic");

            migrationBuilder.DropTable(
                name: "Priority");

            migrationBuilder.DropTable(
                name: "Resident");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
