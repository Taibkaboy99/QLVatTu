using Microsoft.EntityFrameworkCore;
using QLVatTu.Entity;
using QLVatTu.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVatTu.Services
{
    internal class PhieuXuatService : IPhieuXuatService
    {
        AppDbContext DbContext { get; set; }
        public PhieuXuatService()
        {
            DbContext = new AppDbContext();
        }
        public void ThemPhieuXuatMoi()
        {
            PhieuXuat phieuxuat = new PhieuXuat();
            phieuxuat.Nhap();
            if (DbContext.PhieuXuats.Any(x => x.PhieuXuatId == phieuxuat.PhieuXuatId))
            {
                Console.WriteLine("Phieu Xuat da ton tai!");
            }
            else
            {
                DbContext.PhieuXuats.Add(phieuxuat);
                DbContext.SaveChanges();
                ChiTietPhieuXuat chitietx = new ChiTietPhieuXuat();
                chitietx.Nhap(phieuxuat.PhieuXuatId);
                var checkvattu = DbContext.VatTus.FirstOrDefault(x => x.VatTuId == chitietx.vatTuId);
                if (checkvattu != null)
                {
                    DbContext.ChiTietPhieuXuats.Add(chitietx);
                    checkvattu.SoLuongTon = checkvattu.SoLuongTon - chitietx.SoLuongXuat;
                    DbContext.Update(checkvattu);
                    DbContext.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Vat tu muon xuat chi thiet khong ton tai!");
                }
            }
            Console.WriteLine("Da them Phieu xuat thanh cong!");
        }
    }
}
