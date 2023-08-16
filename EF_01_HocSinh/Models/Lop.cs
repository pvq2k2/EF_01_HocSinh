using EF_01_HocSinh.Helper;
using EF_01_HocSinh.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_HocSinh.Models
{
    public class Lop
    {
        public int LopId { get; set; }
        [MaxLength(10)]
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public List<HocSinh> ListHocSinh { get; set; }

        public void Input() { 
            TenLop = InputHelper.InputString(HocSinhRes.TenLop, HocSinhRes.ErrorTenLop, 1, 10);
            SiSo = InputHelper.InputInt(HocSinhRes.SiSo, HocSinhRes.ErrorSiSo, 0, 20, HocSinhRes.ErrorValue);
        }

        public void Output() {
            Console.WriteLine($"Ten lop: {TenLop}\n" +
                $"Si so: {SiSo}");
        }
    }
}
