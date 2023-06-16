using QLVatTu.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVatTu.Entity
{
    public class PhieuNhap
    {
        public int PhieuNhapId { get; set; }
        public int MaPhieu { get; set; }
        public string TieuDe { get; set; }
        public List<ChiTietPhieuNhap> chiTietPhieuNhaps { get; set; }
        public DateTime NgayNhap { get; set; }
        public void Nhap()
        {
            MaPhieu = InputHelper.KieuSN("Nhap Ma phieu cho phieu nhap: ");
            TieuDe = InputHelper.KieuChuoi("Nhap Tieu de: ");
            Console.WriteLine("Nhap ngay nhap: ");
            NgayNhap = DateTime.Parse(Console.ReadLine());
        }
    }
}
