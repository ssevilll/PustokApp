using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PustokAppMvc.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Key);
                });

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: new Guid("f1000000-0000-0000-0000-000000000000"),
                column: "ImageUrl",
                value: "product-details-1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: new Guid("f2000000-0000-0000-0000-000000000000"),
                column: "ImageUrl",
                value: "product-details-2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000000"),
                column: "ImageUrl",
                value: "product-details-3.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000000"),
                column: "ImageUrl",
                value: "product-details-4.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000000"),
                column: "ImageUrl",
                value: "product-details-5.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b1000000-0000-0000-0000-000000000000"),
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "product-2.jpg", "product-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b2000000-0000-0000-0000-000000000000"),
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "product-4.jpg", "product-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b3000000-0000-0000-0000-000000000000"),
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "product-6.jpg", "product-5.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4000000-0000-0000-0000-000000000000"),
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "product-8.jpg", "product-7.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b5000000-0000-0000-0000-000000000000"),
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "product-10.jpg", "product-9.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b6000000-0000-0000-0000-000000000000"),
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "product-12.jpg", "product-11.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b7000000-0000-0000-0000-000000000000"),
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "product-1.jpg", "product-13.jpg" });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "address", "Example Street 98, HH2 BacHa, New York, USA" },
                    { "email", "support@hastech.com" },
                    { "logourl", "logo.png" },
                    { "phone", "+18088 234 5678" },
                    { "supportemail", "support@hastech.com" },
                    { "supportphone", "+01-202-555-0181" }
                });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: new Guid("d1000000-0000-0000-0000-000000000000"),
                column: "ImageUrl",
                value: "home-slider-1-ai.png");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: new Guid("d2000000-0000-0000-0000-000000000000"),
                column: "ImageUrl",
                value: "home-slider-2-ai.png");

            migrationBuilder.CreateIndex(
                name: "IX_BookTags_TagId",
                table: "BookTags",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTags_Books_BookId",
                table: "BookTags",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTags_Tags_TagId",
                table: "BookTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTags_Books_BookId",
                table: "BookTags");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTags_Tags_TagId",
                table: "BookTags");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropIndex(
                name: "IX_BookTags_TagId",
                table: "BookTags");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: new Guid("f1000000-0000-0000-0000-000000000000"),
                column: "ImageUrl",
                value: "image/products/product-details-1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: new Guid("f2000000-0000-0000-0000-000000000000"),
                column: "ImageUrl",
                value: "image/products/product-details-2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000000"),
                column: "ImageUrl",
                value: "image/products/product-details-3.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000000"),
                column: "ImageUrl",
                value: "image/products/product-details-4.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000000"),
                column: "ImageUrl",
                value: "image/products/product-details-5.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b1000000-0000-0000-0000-000000000000"),
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "image/products/product-2.jpg", "image/products/product-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b2000000-0000-0000-0000-000000000000"),
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "image/products/product-4.jpg", "image/products/product-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b3000000-0000-0000-0000-000000000000"),
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "image/products/product-6.jpg", "image/products/product-5.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4000000-0000-0000-0000-000000000000"),
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "image/products/product-8.jpg", "image/products/product-7.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b5000000-0000-0000-0000-000000000000"),
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "image/products/product-10.jpg", "image/products/product-9.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b6000000-0000-0000-0000-000000000000"),
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "image/products/product-12.jpg", "image/products/product-11.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b7000000-0000-0000-0000-000000000000"),
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "image/products/product-1.jpg", "image/products/product-13.jpg" });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: new Guid("d1000000-0000-0000-0000-000000000000"),
                column: "ImageUrl",
                value: "image/bg-images/home-slider-1-ai.png");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: new Guid("d2000000-0000-0000-0000-000000000000"),
                column: "ImageUrl",
                value: "image/bg-images/home-slider-2-ai.png");
        }
    }
}
