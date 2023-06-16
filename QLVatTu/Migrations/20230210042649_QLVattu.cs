using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLVatTu.Migrations
{
    /// <inheritdoc />
    public partial class QLVattu : Migration
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

            migrationBuilder.DropColumn(
                name: "VaTuId",
                table: "ChiTietPhieuXuats");

            migrationBuilder.DropColumn(
                name: "VaTuId",
                table: "ChiTietPhieuNhaps");

            migrationBuilder.RenameColumn(
                name: "VatTuId",
                table: "ChiTietPhieuXuats",
                newName: "vatTuId");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuXuats_VatTuId",
                table: "ChiTietPhieuXuats",
                newName: "IX_ChiTietPhieuXuats_vatTuId");

            migrationBuilder.RenameColumn(
                name: "VatTuId",
                table: "ChiTietPhieuNhaps",
                newName: "vattuId");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuNhaps_VatTuId",
                table: "ChiTietPhieuNhaps",
                newName: "IX_ChiTietPhieuNhaps_vattuId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuNhaps_VatTus_vattuId",
                table: "ChiTietPhieuNhaps",
                column: "vattuId",
                principalTable: "VatTus",
                principalColumn: "VatTuId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuXuats_VatTus_vatTuId",
                table: "ChiTietPhieuXuats",
                column: "vatTuId",
                principalTable: "VatTus",
                principalColumn: "VatTuId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuNhaps_VatTus_vattuId",
                table: "ChiTietPhieuNhaps");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuXuats_VatTus_vatTuId",
                table: "ChiTietPhieuXuats");

            migrationBuilder.RenameColumn(
                name: "vatTuId",
                table: "ChiTietPhieuXuats",
                newName: "VatTuId");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuXuats_vatTuId",
                table: "ChiTietPhieuXuats",
                newName: "IX_ChiTietPhieuXuats_VatTuId");

            migrationBuilder.RenameColumn(
                name: "vattuId",
                table: "ChiTietPhieuNhaps",
                newName: "VatTuId");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuNhaps_vattuId",
                table: "ChiTietPhieuNhaps",
                newName: "IX_ChiTietPhieuNhaps_VatTuId");

            migrationBuilder.AddColumn<int>(
                name: "VaTuId",
                table: "ChiTietPhieuXuats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VaTuId",
                table: "ChiTietPhieuNhaps",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
