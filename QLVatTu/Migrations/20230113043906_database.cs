using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLVatTu.Migrations
{
    /// <inheritdoc />
    public partial class database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
