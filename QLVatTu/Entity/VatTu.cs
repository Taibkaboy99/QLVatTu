using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVatTu.Entity
{
    public class VatTu
    {
        public int VatTuId { get; set; }
        public string TenVatTu { get; set; }
        public int SoLuongTon { get; set; }
        public List<ChiTietPhieuNhap> chiTietPhieuNhaps { get; set; }
        public List<ChiTietPhieuXuat> chiTietPhieuXuats { get; set; }
        public VatTu() { }
        public void NhapThongTin()
        {
            Console.WriteLine("Nhap Ten Vat Tu:");
            TenVatTu = Console.ReadLine();
            Console.WriteLine("Nhap So Luong Ton");
            SoLuongTon = int.Parse(Console.ReadLine());
        }
    }
}
