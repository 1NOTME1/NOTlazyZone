using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NOTlazyZone.Migrations
{
    /// <inheritdoc />
    public partial class AddCwPtIdToCwiczenia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cw_opis",
                table: "Cwiczenia",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cw_pt_id",
                table: "Cwiczenia",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cwiczenia_cw_pt_id",
                table: "Cwiczenia",
                column: "cw_pt_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cwiczenia_PlanTreningowy_cw_pt_id",
                table: "Cwiczenia",
                column: "cw_pt_id",
                principalTable: "PlanTreningowy",
                principalColumn: "pt_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cwiczenia_PlanTreningowy_cw_pt_id",
                table: "Cwiczenia");

            migrationBuilder.DropIndex(
                name: "IX_Cwiczenia_cw_pt_id",
                table: "Cwiczenia");

            migrationBuilder.DropColumn(
                name: "cw_opis",
                table: "Cwiczenia");

            migrationBuilder.DropColumn(
                name: "cw_pt_id",
                table: "Cwiczenia");
        }
    }
}
