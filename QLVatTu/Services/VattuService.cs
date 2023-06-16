using QLVatTu.Entity;
using QLVatTu.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVatTu.Services
{
    internal class VattuService : IVattuServices
    {
        AppDbContext DbContext { get; set; }
        public VattuService()
        {
            DbContext= new AppDbContext();
        }
        public void LayDanhSachVattu()
        {
            List<VatTu> list = DbContext.VatTus.ToList();
            list.ForEach(x =>
            {
                if (x.SoLuongTon != 0)
                {
                    Console.WriteLine($"{x.TenVatTu}-SLTK = {x.SoLuongTon}");
                }else
                {
                    Console.WriteLine($"{x.TenVatTu} - Het hang ");
                }
            });
        }

        public void LayDanhSachVatTuCanNhapThem()
        {
            Console.WriteLine("Danh sach Vat tu can nhap them la: ");
           List<VatTu> list1 = DbContext.VatTus.ToList();
            list1.ForEach(x =>
            {
                if(x.SoLuongTon == 0)
                {
                    Console.WriteLine($"{x.TenVatTu}");
                }
            });
        }
    }
}
