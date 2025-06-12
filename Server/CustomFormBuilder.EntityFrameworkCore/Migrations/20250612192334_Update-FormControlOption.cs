using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomFormBuilder.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFormControlOption : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormControlOptions");

            migrationBuilder.CreateTable(
                name: "FormControlValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormControlId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormControlValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormControlValues_FormControls_FormControlId",
                        column: x => x.FormControlId,
                        principalTable: "FormControls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormControlValues_FormControlId",
                table: "FormControlValues",
                column: "FormControlId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormControlValues");

            migrationBuilder.CreateTable(
                name: "FormControlOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormControlId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormControlOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormControlOptions_FormControls_FormControlId",
                        column: x => x.FormControlId,
                        principalTable: "FormControls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormControlOptions_FormControlId",
                table: "FormControlOptions",
                column: "FormControlId");
        }
    }
}
