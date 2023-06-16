using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLVatTu.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VatTuId",
                table: "ChiTietPhieuXuats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VatTuId",
                table: "ChiTietPhieuNhaps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuXuats_VatTuId",
                table: "ChiTietPhieuXuats",
                column: "VatTuId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhaps_VatTuId",
                table: "ChiTietPhieuNhaps",
                column: "VatTuId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuNhaps_VatTus_VatTuId",
                table: "ChiTietPhieuNhaps",
                column: "VatTuId",
                principalTable: "VatTus",
                principalColumn: "VatTuId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuXuats_VatTus_VatTuId",
                table: "ChiTietPhieuXuats",
                column: "VatTuId",
                principalTable: "VatTus",
                principalColumn: "VatTuId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuNhaps_VatTus_VatTuId",
                table: "ChiTietPhieuNhaps");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuXuats_VatTus_VatTuId",
                table: "ChiTietPhieuXuats");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietPhieuXuats_VatTuId",
                table: "ChiTietPhieuXuats");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietPhieuNhaps_VatTuId",
                table: "ChiTietPhieuNhaps");

            migrationBuilder.DropColumn(
                name: "VatTuId",
                table: "ChiTietPhieuXuats");

            migrationBuilder.DropColumn(
                name: "VatTuId",
                table: "ChiTietPhieuNhaps");
        }
    }
}
