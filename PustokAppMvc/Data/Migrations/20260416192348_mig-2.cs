using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PustokAppMvc.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { new Guid("a1000000-0000-0000-0000-000000000000"), "Stephen King" },
                    { new Guid("a2000000-0000-0000-0000-000000000000"), "J.K. Rowling" },
                    { new Guid("a3000000-0000-0000-0000-000000000000"), "George R.R. Martin" }
                });

            migrationBuilder.InsertData(
                table: "BookTags",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { new Guid("b1000000-0000-0000-0000-000000000000"), new Guid("c1000000-0000-0000-0000-000000000000") },
                    { new Guid("b1000000-0000-0000-0000-000000000000"), new Guid("c2000000-0000-0000-0000-000000000000") },
                    { new Guid("b2000000-0000-0000-0000-000000000000"), new Guid("c1000000-0000-0000-0000-000000000000") },
                    { new Guid("b2000000-0000-0000-0000-000000000000"), new Guid("c3000000-0000-0000-0000-000000000000") },
                    { new Guid("b3000000-0000-0000-0000-000000000000"), new Guid("c1000000-0000-0000-0000-000000000000") },
                    { new Guid("b3000000-0000-0000-0000-000000000000"), new Guid("c3000000-0000-0000-0000-000000000000") },
                    { new Guid("b4000000-0000-0000-0000-000000000000"), new Guid("c2000000-0000-0000-0000-000000000000") },
                    { new Guid("b5000000-0000-0000-0000-000000000000"), new Guid("c3000000-0000-0000-0000-000000000000") },
                    { new Guid("b6000000-0000-0000-0000-000000000000"), new Guid("c3000000-0000-0000-0000-000000000000") },
                    { new Guid("b7000000-0000-0000-0000-000000000000"), new Guid("c1000000-0000-0000-0000-000000000000") },
                    { new Guid("b7000000-0000-0000-0000-000000000000"), new Guid("c2000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "ButtonText", "ButtonUrl", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("d1000000-0000-0000-0000-000000000000"), "Shop Now", "/books", "Get up to 50% discount", "image/bg-images/home-slider-1-ai.png", "Book Festival" },
                    { new Guid("d2000000-0000-0000-0000-000000000000"), "Discover", "/books", "Huge collections of new books", "image/bg-images/home-slider-2-ai.png", "Summer Sale" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c1000000-0000-0000-0000-000000000000"), "Fiction" },
                    { new Guid("c2000000-0000-0000-0000-000000000000"), "Horror" },
                    { new Guid("c3000000-0000-0000-0000-000000000000"), "Fantasy" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Code", "Description", "DiscountPercent", "HoverImageUrl", "InStock", "IsFeatured", "IsNew", "MainImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("b1000000-0000-0000-0000-000000000000"), new Guid("a1000000-0000-0000-0000-000000000000"), 1001, "A horror classic", 10m, "image/products/product-2.jpg", true, true, true, "image/products/product-1.jpg", "The Shining", 19.99m },
                    { new Guid("b2000000-0000-0000-0000-000000000000"), new Guid("a2000000-0000-0000-0000-000000000000"), 1002, "Wizard boy", 5m, "image/products/product-4.jpg", true, true, false, "image/products/product-3.jpg", "Harry Potter and the Sorcerer's Stone", 25.00m },
                    { new Guid("b3000000-0000-0000-0000-000000000000"), new Guid("a3000000-0000-0000-0000-000000000000"), 1003, "Winter is coming", 0m, "image/products/product-6.jpg", true, true, true, "image/products/product-5.jpg", "A Game of Thrones", 30.00m },
                    { new Guid("b4000000-0000-0000-0000-000000000000"), new Guid("a1000000-0000-0000-0000-000000000000"), 1004, "Clown horror", 15m, "image/products/product-8.jpg", true, false, false, "image/products/product-7.jpg", "IT", 22.50m },
                    { new Guid("b5000000-0000-0000-0000-000000000000"), new Guid("a3000000-0000-0000-0000-000000000000"), 1005, "More winter", 0m, "image/products/product-10.jpg", true, false, true, "image/products/product-9.jpg", "A Clash of Kings", 28.00m },
                    { new Guid("b6000000-0000-0000-0000-000000000000"), new Guid("a2000000-0000-0000-0000-000000000000"), 1006, "Wizard boy 2", 5m, "image/products/product-12.jpg", false, true, false, "image/products/product-11.jpg", "Harry Potter and the Chamber of Secrets", 26.00m },
                    { new Guid("b7000000-0000-0000-0000-000000000000"), new Guid("a1000000-0000-0000-0000-000000000000"), 1007, "Post-apocalyptic", 20m, "image/products/product-1.jpg", true, true, true, "image/products/product-13.jpg", "The Stand", 35.00m }
                });

            migrationBuilder.InsertData(
                table: "BookImages",
                columns: new[] { "Id", "BookId", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("f1000000-0000-0000-0000-000000000000"), new Guid("b1000000-0000-0000-0000-000000000000"), "image/products/product-details-1.jpg" },
                    { new Guid("f2000000-0000-0000-0000-000000000000"), new Guid("b1000000-0000-0000-0000-000000000000"), "image/products/product-details-2.jpg" },
                    { new Guid("f3000000-0000-0000-0000-000000000000"), new Guid("b2000000-0000-0000-0000-000000000000"), "image/products/product-details-3.jpg" },
                    { new Guid("f4000000-0000-0000-0000-000000000000"), new Guid("b3000000-0000-0000-0000-000000000000"), "image/products/product-details-4.jpg" },
                    { new Guid("f5000000-0000-0000-0000-000000000000"), new Guid("b4000000-0000-0000-0000-000000000000"), "image/products/product-details-5.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: new Guid("f1000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: new Guid("f2000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("b1000000-0000-0000-0000-000000000000"), new Guid("c1000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("b1000000-0000-0000-0000-000000000000"), new Guid("c2000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("b2000000-0000-0000-0000-000000000000"), new Guid("c1000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("b2000000-0000-0000-0000-000000000000"), new Guid("c3000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("b3000000-0000-0000-0000-000000000000"), new Guid("c1000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("b3000000-0000-0000-0000-000000000000"), new Guid("c3000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("b4000000-0000-0000-0000-000000000000"), new Guid("c2000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("b5000000-0000-0000-0000-000000000000"), new Guid("c3000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("b6000000-0000-0000-0000-000000000000"), new Guid("c3000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("b7000000-0000-0000-0000-000000000000"), new Guid("c1000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("b7000000-0000-0000-0000-000000000000"), new Guid("c2000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b5000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b6000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b7000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: new Guid("d1000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: new Guid("d2000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c1000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c2000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c3000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b1000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b2000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b3000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a1000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a2000000-0000-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000000"));
        }
    }
}
