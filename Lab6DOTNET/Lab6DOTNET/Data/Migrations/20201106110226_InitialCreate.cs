using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab6DOTNET.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    IsDone = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 1, new DateTime(2020, 11, 6, 13, 2, 26, 318, DateTimeKind.Local).AddTicks(3106), "Termina Lab DOTNET", true });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 2, new DateTime(2020, 11, 6, 13, 2, 26, 320, DateTimeKind.Local).AddTicks(8889), "Continua Tema SI", false });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 3, new DateTime(2020, 11, 6, 13, 2, 26, 320, DateTimeKind.Local).AddTicks(8933), "Tema ML", false });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 4, new DateTime(2020, 11, 6, 13, 2, 26, 320, DateTimeKind.Local).AddTicks(8939), "Tema AI", false });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 5, new DateTime(2020, 11, 6, 13, 2, 26, 320, DateTimeKind.Local).AddTicks(8942), "IMR", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDos");
        }
    }
}
