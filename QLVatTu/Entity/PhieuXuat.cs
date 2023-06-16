using QLVatTu.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVatTu.Entity
{
    public class PhieuXuat
    {
        public int PhieuXuatId { get; set; }
        public int MaPhieu { get; set; }
        public string TieuDe { get; set; }
        public List<ChiTietPhieuXuat> chiTietPhieuXuats { get; set; }
        public DateTime NgayXuat { get; set; }
        public void Nhap()
        {
            MaPhieu = InputHelper.KieuSN("Nhap Ma phieu cho phieu xuat: ");
            TieuDe = InputHelper.KieuChuoi("Nhap Tieu de cho phieu xuat");
            Console.WriteLine("Nhap ngay xuat: ");
            NgayXuat = DateTime.Parse(Console.ReadLine());
        }
    }
}
