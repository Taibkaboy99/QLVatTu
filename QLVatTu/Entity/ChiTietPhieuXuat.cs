using QLVatTu.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVatTu.Entity
{
    public class ChiTietPhieuXuat
    {
        public int ChiTietPhieuXuatId { get; set; }
        public int vatTuId { get; set; }
        public VatTu Vattu { get; set; }
        public int PhieuXuatId { get; set; }
        public PhieuXuat PhieuXuat { get; set; }
        public int SoLuongXuat { get; set; }
        public ChiTietPhieuXuat() { }
        public void Nhap(int phieuxuatid)
        {
            vatTuId = InputHelper.KieuSN("Nhap id vat tu cho CT Phieu xuat:");
            PhieuXuatId = phieuxuatid;
            SoLuongXuat = InputHelper.KieuSN("Nhap so luong xuat: ");
        }
    }
}
