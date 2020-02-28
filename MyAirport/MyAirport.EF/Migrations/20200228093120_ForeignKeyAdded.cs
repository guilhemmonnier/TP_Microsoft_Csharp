using Microsoft.EntityFrameworkCore.Migrations;

namespace glhm.MyAirport.EF.Migrations
{
    public partial class ForeignKeyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "VolId",
                table: "Bagages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Bagages_VolId",
                table: "Bagages",
                column: "VolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VolId",
                table: "Bagages",
                column: "VolId",
                principalTable: "Vols",
                principalColumn: "VolId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VolId",
                table: "Bagages");

            migrationBuilder.DropIndex(
                name: "IX_Bagages_VolId",
                table: "Bagages");

            migrationBuilder.AlterColumn<int>(
                name: "VolId",
                table: "Bagages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
