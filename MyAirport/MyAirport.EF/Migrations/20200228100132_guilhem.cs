using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace glhm.MyAirport.EF.Migrations
{
    public partial class guilhem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Jex",
                table: "Vols");

            migrationBuilder.DropColumn(
                name: "Code_Iata",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "Date_Creation",
                table: "Bagages");

            migrationBuilder.RenameColumn(
                name: "BagageId",
                table: "Bagages",
                newName: "BagageID");

            migrationBuilder.AlterColumn<string>(
                name: "Cie",
                table: "Vols",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Classe",
                table: "Bagages",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AddColumn<string>(
                name: "CodeIata",
                table: "Bagages",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreation",
                table: "Bagages",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeIata",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "DateCreation",
                table: "Bagages");

            migrationBuilder.RenameColumn(
                name: "BagageID",
                table: "Bagages",
                newName: "BagageId");

            migrationBuilder.AlterColumn<int>(
                name: "Cie",
                table: "Vols",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Jex",
                table: "Vols",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Classe",
                table: "Bagages",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code_Iata",
                table: "Bagages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date_Creation",
                table: "Bagages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
