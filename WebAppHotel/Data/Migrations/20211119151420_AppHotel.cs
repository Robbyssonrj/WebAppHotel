using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppHotel.Data.Migrations
{
    public partial class AppHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataNasc",
                table: "Reservas",
                newName: "DataSaida");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoReserva",
                table: "Servicos",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AddColumn<string>(
                name: "classificacao",
                table: "Reservas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "enderecoId",
                table: "Hospedes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hospedes_enderecoId",
                table: "Hospedes",
                column: "enderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hospedes_Endereco_enderecoId",
                table: "Hospedes",
                column: "enderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hospedes_Endereco_enderecoId",
                table: "Hospedes");

            migrationBuilder.DropIndex(
                name: "IX_Hospedes_enderecoId",
                table: "Hospedes");

            migrationBuilder.DropColumn(
                name: "classificacao",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "enderecoId",
                table: "Hospedes");

            migrationBuilder.RenameColumn(
                name: "DataSaida",
                table: "Reservas",
                newName: "DataNasc");

            migrationBuilder.AlterColumn<float>(
                name: "PrecoReserva",
                table: "Servicos",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
