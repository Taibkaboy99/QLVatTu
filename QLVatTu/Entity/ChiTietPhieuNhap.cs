using QLVatTu.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVatTu.Entity
{
    public class ChiTietPhieuNhap
    {
        public int ChiTietPhieuNhapId { get; set; }
        public int vattuId { get; set; }
        public VatTu Vattu { get; set; }
        public int PhieuNhapId { get; set; }
        public  PhieuNhap PhieuNhap { get; set; }
        public int SoLuongNhap { get; set; }
        public ChiTietPhieuNhap() { }
        public void Nhap(int phieunhapid)
        {
            vattuId = InputHelper.KieuSN("Nhap id vat tu cho CT Phieu nhap: ");
            PhieuNhapId = phieunhapid;
            SoLuongNhap = InputHelper.KieuSN("Nhap so luong nhap: ");
        }
    }
}
