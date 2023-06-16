using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLVatTu.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VatTus_ChiTietPhieuNhaps_ChiTietPhieuNhapId",
                table: "VatTus");

            migrationBuilder.DropForeignKey(
                name: "FK_VatTus_ChiTietPhieuXuats_ChiTietPhieuXuatId",
                table: "VatTus");

            migrationBuilder.DropIndex(
                name: "IX_VatTus_ChiTietPhieuNhapId",
                table: "VatTus");

            migrationBuilder.DropIndex(
                name: "IX_VatTus_ChiTietPhieuXuatId",
                table: "VatTus");

            migrationBuilder.DropColumn(
                name: "ChiTietPhieuNhapId",
                table: "VatTus");

            migrationBuilder.DropColumn(
                name: "ChiTietPhieuXuatId",
                table: "VatTus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChiTietPhieuNhapId",
                table: "VatTus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChiTietPhieuXuatId",
                table: "VatTus",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VatTus_ChiTietPhieuNhapId",
                table: "VatTus",
                column: "ChiTietPhieuNhapId");

            migrationBuilder.CreateIndex(
                name: "IX_VatTus_ChiTietPhieuXuatId",
                table: "VatTus",
                column: "ChiTietPhieuXuatId");

            migrationBuilder.AddForeignKey(
                name: "FK_VatTus_ChiTietPhieuNhaps_ChiTietPhieuNhapId",
                table: "VatTus",
                column: "ChiTietPhieuNhapId",
                principalTable: "ChiTietPhieuNhaps",
                principalColumn: "ChiTietPhieuNhapId");

            migrationBuilder.AddForeignKey(
                name: "FK_VatTus_ChiTietPhieuXuats_ChiTietPhieuXuatId",
                table: "VatTus",
                column: "ChiTietPhieuXuatId",
                principalTable: "ChiTietPhieuXuats",
                principalColumn: "ChiTietPhieuXuatId");
        }
    }
}
