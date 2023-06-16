using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVatTu.Helper
{
    internal class InputHelper
    {
        public static int KieuSN(string mes, string err = "Can phai nhap so nguyen!")
        {
            int so;
            bool check = true;
            do
            {
                Console.WriteLine(mes);
                check = int.TryParse(Console.ReadLine(), out so);
                if (!check)
                {
                    Console.WriteLine(err);
                }
            } while (!check);
            return so;
        }
        public static string KieuChuoi(string mes1, string err1 = "Loi", int min = 0, int max = int.MaxValue)
        {
            string chuoi;
            bool ok = true;
            do
            {
                Console.WriteLine(mes1);
                chuoi = Console.ReadLine();
                ok = chuoi.Length >= min && chuoi.Length <= max;
                if (!ok)
                {
                    Console.WriteLine(err1);
                }
            } while (!ok);
            return chuoi;
        }
    }
}
