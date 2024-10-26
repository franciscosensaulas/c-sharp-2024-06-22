using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorios.Migrations
{
    /// <inheritdoc />
    public partial class AlterarTabelaMarcasAlterandoNomeColunaRegistroAtivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BIT",
                table: "marcas",
                newName: "RegistroAtivo");

            migrationBuilder.AlterColumn<bool>(
                name: "RegistroAtivo",
                table: "marcas",
                type: "BIT",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RegistroAtivo",
                table: "marcas",
                newName: "BIT");

            migrationBuilder.AlterColumn<bool>(
                name: "BIT",
                table: "marcas",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "BIT",
                oldDefaultValue: true);
        }
    }
}
