using Microsoft.EntityFrameworkCore.Migrations;

namespace Db_Context.Migrations
{
    public partial class OrderInfoView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW OrderInfoView AS 
            SELECT O.Id, C.Name CustomerName, O.OrderNo OrderNo, O.Date OrderDate, SUM(OD.Qty * OD.UnitPrice) AS TotalAmount 
            FROM Orders AS O
            LEFT JOIN Customers AS C ON O.CustomerId = C.Id
            LEFT JOIN OrderDetails AS OD ON O.Id = OD.OrderId
            LEFT JOIN Products AS P ON OD.ProductId = P.Id 
            GROUP BY O.Id, O.Date, C.Name, O.OrderNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS dbo.OrderInfoView");
        }
    }
}
