using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrgManager.WinForms.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrgNodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LeaderEmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgNodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrgNodes_Employees_LeaderEmployeeId",
                        column: x => x.LeaderEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OrgNodes_OrgNodes_ParentId",
                        column: x => x.ParentId,
                        principalTable: "OrgNodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "OrgNodes",
                columns: new[] { "Id", "Code", "LeaderEmployeeId", "Name", "ParentId", "Type" },
                values: new object[] { 1, "COMP", null, "Moja Firma", null, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_OrgNodes_Code",
                table: "OrgNodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrgNodes_LeaderEmployeeId",
                table: "OrgNodes",
                column: "LeaderEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgNodes_ParentId",
                table: "OrgNodes",
                column: "ParentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrgNodes");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
