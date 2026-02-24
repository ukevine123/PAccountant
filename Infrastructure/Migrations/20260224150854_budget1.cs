using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class budget1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budgets_BudgetCategory_CategoryId",
                table: "Budgets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BudgetCategory",
                table: "BudgetCategory");

            migrationBuilder.RenameTable(
                name: "BudgetCategory",
                newName: "BudgetCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BudgetCategories",
                table: "BudgetCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Budgets_BudgetCategories_CategoryId",
                table: "Budgets",
                column: "CategoryId",
                principalTable: "BudgetCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budgets_BudgetCategories_CategoryId",
                table: "Budgets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BudgetCategories",
                table: "BudgetCategories");

            migrationBuilder.RenameTable(
                name: "BudgetCategories",
                newName: "BudgetCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BudgetCategory",
                table: "BudgetCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Budgets_BudgetCategory_CategoryId",
                table: "Budgets",
                column: "CategoryId",
                principalTable: "BudgetCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
