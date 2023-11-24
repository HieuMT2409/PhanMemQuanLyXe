using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThueXeOTo.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Orders_OrdersOrderID",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomersID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomersID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Cars_OrdersOrderID",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CustomersID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrdersOrderID",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_OrderID",
                table: "Cars",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Orders_OrderID",
                table: "Cars",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Orders_OrderID",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Cars_OrderID",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "CustomersID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrdersOrderID",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomersID",
                table: "Orders",
                column: "CustomersID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_OrdersOrderID",
                table: "Cars",
                column: "OrdersOrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Orders_OrdersOrderID",
                table: "Cars",
                column: "OrdersOrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomersID",
                table: "Orders",
                column: "CustomersID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
