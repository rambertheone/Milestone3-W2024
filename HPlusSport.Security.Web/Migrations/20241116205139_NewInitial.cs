using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPlusSport.Security.Web.Migrations
{
    /// <inheritdoc />
    public partial class NewInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Password", "Salt" },
                values: new object[] { "/6yvta3LQcbRxsZ+Yp9PvBMTnUU=", "", "9US/yrV3qCdamh206jrbMuGlkw7N9o0kU5P4p6yIBpk=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Password", "Salt" },
                values: new object[] { "MNE2x5LF5auSIPtgt9wif3H13Jw=", "", "DyxCno+7Nd+SE8wRHnPfZEYNb1TYk5zZk0gMxWlufDQ=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Password", "Salt" },
                values: new object[] { "", "Adam's secret", "" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Password", "Salt" },
                values: new object[] { "", "b@rb@r@", "" });
        }
    }
}
