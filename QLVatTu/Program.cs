using Microsoft.EntityFrameworkCore;
using QLVatTu.Entity;
using QLVatTu.Helper;
using QLVatTu.IServices;
using QLVatTu.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        //Hien thi danh sach vat tu
        VattuService vattu = new VattuService();
        vattu.LayDanhSachVattu();

        //Hien thi danh sach vat tu can nhap them
        vattu.LayDanhSachVatTuCanNhapThem();

        //Them moi phieu nhap
        PhieuNhapService phieunhaps = new PhieuNhapService();
        phieunhaps.ThemMoiPhieuNhap();

        //Them moi phieu xuat
        PhieuXuatService phieuxuats = new PhieuXuatService();
        phieuxuats.ThemPhieuXuatMoi();
    }
}