using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness.Migrations
{
    public partial class changelistofsupplements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Supplements_Orders_OrderId",
                table: "Supplements");

            migrationBuilder.DropIndex(
                name: "IX_Supplements_OrderId",
                table: "Supplements");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Supplements");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Supplements",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Supplements_OrderId",
                table: "Supplements",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Supplements_Orders_OrderId",
                table: "Supplements",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
