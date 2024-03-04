using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizApp.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2ab386c-82bb-4006-8f8b-7b98da867aaf", "AQAAAAIAAYagAAAAEDY6tE4vXw1b+aG3SO/RL7jgTEPDrNbIOYptQijmqRvXSPzNxwvmrIqKBcjlF4DCrg==", "42035afc-b6d0-4431-9d1d-eae037378f0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d7e7ca6-b6fb-4740-bdb1-b723752de43c", "AQAAAAIAAYagAAAAEC9RuHMbhUhftjCuFMr9OBk0O5+C7lYUvSeiQdXpG5kaHLHs4myFRyOdaNADJODatw==", "31a58358-4163-40b2-925e-e7bc1ad07f97" });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "CreatedDate", "Description", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It holds ten questions ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maths quiz on Diferential Calculs" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It holds ten questions ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Biology quiz on Cell body" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It holds ten questions ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Physics quiz on Quantum mechanics " },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It holds ten questions ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chemistry quiz on Diferential Calculs" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a3d1119-8061-417b-88bd-2e39c6b874ac", "AQAAAAIAAYagAAAAEM6Msqh1U3OE7ZQuKXaPVQqYX8fJUEHuvwJlg12Q4thD2ld7z3NFTzwBoTGEvMX51g==", "65d2d0bc-a1b3-442b-9b36-8499ab9df89d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9413347a-d908-4f9a-beb1-15bdc8021541", "AQAAAAIAAYagAAAAEN/9+rfWjvteFB6/HPK6yz24rSpgEDY2MtJNo3fkbnJTMU+Bsiz/yTWwHIMLPlJFTw==", "77f28577-40c7-4c01-ad74-2d0796094665" });
        }
    }
}
