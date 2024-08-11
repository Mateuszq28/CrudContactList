using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudContactList.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "category",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "subcategory",
                table: "Contact");

            migrationBuilder.RenameColumn(
                name: "surname",
                table: "Contact",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Contact",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Contact",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Contact",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "birthDate",
                table: "Contact",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Contact",
                newName: "Email");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Subcategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Contact",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubcategoryId",
                table: "Contact",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Subcategory");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "SubcategoryId",
                table: "Contact");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Contact",
                newName: "surname");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Contact",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Contact",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Contact",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Contact",
                newName: "birthDate");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Contact",
                newName: "email");

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "subcategory",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
