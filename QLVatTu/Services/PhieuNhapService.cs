using QLVatTu.Entity;
using QLVatTu.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVatTu.Services
{
    internal class PhieuNhapService : IPhieunhapService
    {
        AppDbContext DbContext { get; set; }
        public PhieuNhapService()
        {
            DbContext = new AppDbContext();
        }
        public void ThemMoiPhieuNhap()
        {
            PhieuNhap phieunhap = new PhieuNhap();
            phieunhap.Nhap();
            if(DbContext.PhieuNhaps.Any(x => x.PhieuNhapId == phieunhap.PhieuNhapId))
            {
                Console.WriteLine("Phieu Nhap da ton tai!");
            }
            else
            {
                DbContext.PhieuNhaps.Add(phieunhap);
                DbContext.SaveChanges();
                ChiTietPhieuNhap chitietn = new ChiTietPhieuNhap();
                chitietn.Nhap(phieunhap.PhieuNhapId);
                var checkvattu = DbContext.VatTus.FirstOrDefault(x => x.VatTuId == chitietn.vattuId);
                if(checkvattu != null)
                {
                    DbContext.ChiTietPhieuNhaps.Add(chitietn);
                    checkvattu.SoLuongTon = checkvattu.SoLuongTon + chitietn.SoLuongNhap;
                    DbContext.Update(checkvattu);
                    DbContext.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Vat tu muon them chi thiet khong ton tai!");
                }
            }
            Console.WriteLine("Da them Phieu nhap thanh cong!");
        }
    }
}
