using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BenchmarkEfCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RelatedItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    CreatedAtUtc = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roots",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Foo0 = table.Column<string>(nullable: true),
                    Foo1 = table.Column<string>(nullable: true),
                    Foo2 = table.Column<string>(nullable: true),
                    Foo3 = table.Column<string>(nullable: true),
                    Foo4 = table.Column<string>(nullable: true),
                    Foo5 = table.Column<string>(nullable: true),
                    Foo6 = table.Column<string>(maxLength: 100, nullable: true),
                    Foo7 = table.Column<string>(maxLength: 1000, nullable: true),
                    Foo8 = table.Column<string>(maxLength: 250, nullable: true),
                    Foo9 = table.Column<string>(maxLength: 200, nullable: true),
                    Bar0 = table.Column<bool>(nullable: false),
                    Bar1 = table.Column<bool>(nullable: false),
                    Bar2 = table.Column<bool>(nullable: false),
                    Bar3 = table.Column<bool>(nullable: true),
                    Bar4 = table.Column<bool>(nullable: true),
                    Baz0 = table.Column<int>(nullable: false),
                    Baz1 = table.Column<int>(nullable: false),
                    Baz2 = table.Column<int>(nullable: false),
                    Baz3 = table.Column<int>(nullable: false),
                    Baz4 = table.Column<int>(nullable: true),
                    Baz5 = table.Column<int>(nullable: true),
                    OptionA = table.Column<int>(nullable: false),
                    OptionB = table.Column<int>(nullable: false),
                    OptionC = table.Column<int>(nullable: false),
                    OptionD = table.Column<int>(nullable: true),
                    OptionE = table.Column<int>(nullable: true),
                    OptionF = table.Column<int>(nullable: true),
                    Stamp1 = table.Column<DateTimeOffset>(nullable: false),
                    Stamp2 = table.Column<DateTimeOffset>(nullable: false),
                    Stamp3 = table.Column<DateTimeOffset>(nullable: false),
                    Stamp4 = table.Column<DateTimeOffset>(nullable: true),
                    Stamp5 = table.Column<DateTimeOffset>(nullable: true),
                    RelatedEntityId = table.Column<Guid>(nullable: true),
                    ChildOne_Foo0 = table.Column<string>(nullable: true),
                    ChildOne_Foo1 = table.Column<string>(nullable: true),
                    ChildOne_Foo2 = table.Column<string>(nullable: true),
                    ChildOne_Foo3 = table.Column<string>(nullable: true),
                    ChildOne_Foo4 = table.Column<string>(nullable: true),
                    ChildOne_Foo5 = table.Column<string>(nullable: true),
                    ChildOne_Foo6 = table.Column<string>(nullable: true),
                    ChildOne_Foo7 = table.Column<string>(nullable: true),
                    ChildOne_Foo8 = table.Column<string>(nullable: true),
                    ChildOne_Foo9 = table.Column<string>(nullable: true),
                    ChildOne_Bar0 = table.Column<bool>(nullable: false),
                    ChildOne_Bar1 = table.Column<bool>(nullable: false),
                    ChildOne_Bar2 = table.Column<bool>(nullable: false),
                    ChildOne_Bar3 = table.Column<bool>(nullable: true),
                    ChildOne_Bar4 = table.Column<bool>(nullable: true),
                    ChildOne_Baz0 = table.Column<int>(nullable: false),
                    ChildOne_Baz1 = table.Column<int>(nullable: false),
                    ChildOne_Baz2 = table.Column<int>(nullable: false),
                    ChildOne_Baz3 = table.Column<int>(nullable: false),
                    ChildOne_Baz4 = table.Column<int>(nullable: true),
                    ChildOne_Baz5 = table.Column<int>(nullable: true),
                    ChildOne_OptionA = table.Column<int>(nullable: false),
                    ChildOne_OptionB = table.Column<int>(nullable: false),
                    ChildOne_OptionC = table.Column<int>(nullable: false),
                    ChildOne_OptionD = table.Column<int>(nullable: true),
                    ChildOne_OptionE = table.Column<int>(nullable: true),
                    ChildOne_OptionF = table.Column<int>(nullable: true),
                    ChildOne_OwnedValueObjects = table.Column<string>(nullable: true),
                    ChildTwo1_Foo0 = table.Column<string>(nullable: true),
                    ChildTwo1_Foo1 = table.Column<string>(nullable: true),
                    ChildTwo1_Foo2 = table.Column<string>(nullable: true),
                    ChildTwo1_Foo3 = table.Column<string>(nullable: true),
                    ChildTwo1_Foo4 = table.Column<string>(nullable: true),
                    ChildTwo1_Foo5 = table.Column<string>(nullable: true),
                    ChildTwo1_Foo6 = table.Column<string>(nullable: true),
                    ChildTwo1_Foo7 = table.Column<string>(nullable: true),
                    ChildTwo1_Foo8 = table.Column<string>(nullable: true),
                    ChildTwo1_Foo9 = table.Column<string>(nullable: true),
                    ChildTwo1_Bar0 = table.Column<bool>(nullable: false),
                    ChildTwo1_Bar1 = table.Column<bool>(nullable: false),
                    ChildTwo1_Bar2 = table.Column<bool>(nullable: false),
                    ChildTwo1_Bar3 = table.Column<bool>(nullable: true),
                    ChildTwo1_Bar4 = table.Column<bool>(nullable: true),
                    ChildTwo1_Baz0 = table.Column<int>(nullable: false),
                    ChildTwo1_Baz1 = table.Column<int>(nullable: false),
                    ChildTwo1_Baz2 = table.Column<int>(nullable: false),
                    ChildTwo1_Baz3 = table.Column<int>(nullable: false),
                    ChildTwo1_Baz4 = table.Column<int>(nullable: true),
                    ChildTwo1_Baz5 = table.Column<int>(nullable: true),
                    ChildTwo1_OptionA = table.Column<int>(nullable: false),
                    ChildTwo1_OptionB = table.Column<int>(nullable: false),
                    ChildTwo1_OptionC = table.Column<int>(nullable: false),
                    ChildTwo1_OptionD = table.Column<int>(nullable: true),
                    ChildTwo1_OptionE = table.Column<int>(nullable: true),
                    ChildTwo1_OptionF = table.Column<int>(nullable: true),
                    ChildTwo2_Foo0 = table.Column<string>(nullable: true),
                    ChildTwo2_Foo1 = table.Column<string>(nullable: true),
                    ChildTwo2_Foo2 = table.Column<string>(nullable: true),
                    ChildTwo2_Foo3 = table.Column<string>(nullable: true),
                    ChildTwo2_Foo4 = table.Column<string>(nullable: true),
                    ChildTwo2_Foo5 = table.Column<string>(nullable: true),
                    ChildTwo2_Foo6 = table.Column<string>(nullable: true),
                    ChildTwo2_Foo7 = table.Column<string>(nullable: true),
                    ChildTwo2_Foo8 = table.Column<string>(nullable: true),
                    ChildTwo2_Foo9 = table.Column<string>(nullable: true),
                    ChildTwo2_Bar0 = table.Column<bool>(nullable: false),
                    ChildTwo2_Bar1 = table.Column<bool>(nullable: false),
                    ChildTwo2_Bar2 = table.Column<bool>(nullable: false),
                    ChildTwo2_Bar3 = table.Column<bool>(nullable: true),
                    ChildTwo2_Bar4 = table.Column<bool>(nullable: true),
                    ChildTwo2_Baz0 = table.Column<int>(nullable: false),
                    ChildTwo2_Baz1 = table.Column<int>(nullable: false),
                    ChildTwo2_Baz2 = table.Column<int>(nullable: false),
                    ChildTwo2_Baz3 = table.Column<int>(nullable: false),
                    ChildTwo2_Baz4 = table.Column<int>(nullable: true),
                    ChildTwo2_Baz5 = table.Column<int>(nullable: true),
                    ChildTwo2_OptionA = table.Column<int>(nullable: false),
                    ChildTwo2_OptionB = table.Column<int>(nullable: false),
                    ChildTwo2_OptionC = table.Column<int>(nullable: false),
                    ChildTwo2_OptionD = table.Column<int>(nullable: true),
                    ChildTwo2_OptionE = table.Column<int>(nullable: true),
                    ChildTwo2_OptionF = table.Column<int>(nullable: true),
                    ChildTwo3_Foo0 = table.Column<string>(nullable: true),
                    ChildTwo3_Foo1 = table.Column<string>(nullable: true),
                    ChildTwo3_Foo2 = table.Column<string>(nullable: true),
                    ChildTwo3_Foo3 = table.Column<string>(nullable: true),
                    ChildTwo3_Foo4 = table.Column<string>(nullable: true),
                    ChildTwo3_Foo5 = table.Column<string>(nullable: true),
                    ChildTwo3_Foo6 = table.Column<string>(nullable: true),
                    ChildTwo3_Foo7 = table.Column<string>(nullable: true),
                    ChildTwo3_Foo8 = table.Column<string>(nullable: true),
                    ChildTwo3_Foo9 = table.Column<string>(nullable: true),
                    ChildTwo3_Bar0 = table.Column<bool>(nullable: false),
                    ChildTwo3_Bar1 = table.Column<bool>(nullable: false),
                    ChildTwo3_Bar2 = table.Column<bool>(nullable: false),
                    ChildTwo3_Bar3 = table.Column<bool>(nullable: true),
                    ChildTwo3_Bar4 = table.Column<bool>(nullable: true),
                    ChildTwo3_Baz0 = table.Column<int>(nullable: false),
                    ChildTwo3_Baz1 = table.Column<int>(nullable: false),
                    ChildTwo3_Baz2 = table.Column<int>(nullable: false),
                    ChildTwo3_Baz3 = table.Column<int>(nullable: false),
                    ChildTwo3_Baz4 = table.Column<int>(nullable: true),
                    ChildTwo3_Baz5 = table.Column<int>(nullable: true),
                    ChildTwo3_OptionA = table.Column<int>(nullable: false),
                    ChildTwo3_OptionB = table.Column<int>(nullable: false),
                    ChildTwo3_OptionC = table.Column<int>(nullable: false),
                    ChildTwo3_OptionD = table.Column<int>(nullable: true),
                    ChildTwo3_OptionE = table.Column<int>(nullable: true),
                    ChildTwo3_OptionF = table.Column<int>(nullable: true),
                    ChildTwo4_Foo0 = table.Column<string>(nullable: true),
                    ChildTwo4_Foo1 = table.Column<string>(nullable: true),
                    ChildTwo4_Foo2 = table.Column<string>(nullable: true),
                    ChildTwo4_Foo3 = table.Column<string>(nullable: true),
                    ChildTwo4_Foo4 = table.Column<string>(nullable: true),
                    ChildTwo4_Foo5 = table.Column<string>(nullable: true),
                    ChildTwo4_Foo6 = table.Column<string>(nullable: true),
                    ChildTwo4_Foo7 = table.Column<string>(nullable: true),
                    ChildTwo4_Foo8 = table.Column<string>(nullable: true),
                    ChildTwo4_Foo9 = table.Column<string>(nullable: true),
                    ChildTwo4_Bar0 = table.Column<bool>(nullable: false),
                    ChildTwo4_Bar1 = table.Column<bool>(nullable: false),
                    ChildTwo4_Bar2 = table.Column<bool>(nullable: false),
                    ChildTwo4_Bar3 = table.Column<bool>(nullable: true),
                    ChildTwo4_Bar4 = table.Column<bool>(nullable: true),
                    ChildTwo4_Baz0 = table.Column<int>(nullable: false),
                    ChildTwo4_Baz1 = table.Column<int>(nullable: false),
                    ChildTwo4_Baz2 = table.Column<int>(nullable: false),
                    ChildTwo4_Baz3 = table.Column<int>(nullable: false),
                    ChildTwo4_Baz4 = table.Column<int>(nullable: true),
                    ChildTwo4_Baz5 = table.Column<int>(nullable: true),
                    ChildTwo4_OptionA = table.Column<int>(nullable: false),
                    ChildTwo4_OptionB = table.Column<int>(nullable: false),
                    ChildTwo4_OptionC = table.Column<int>(nullable: false),
                    ChildTwo4_OptionD = table.Column<int>(nullable: true),
                    ChildTwo4_OptionE = table.Column<int>(nullable: true),
                    ChildTwo4_OptionF = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roots_RelatedItems_RelatedEntityId",
                        column: x => x.RelatedEntityId,
                        principalTable: "RelatedItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RelatedItems_Code",
                table: "RelatedItems",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Roots_RelatedEntityId",
                table: "Roots",
                column: "RelatedEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roots");

            migrationBuilder.DropTable(
                name: "RelatedItems");
        }
    }
}
