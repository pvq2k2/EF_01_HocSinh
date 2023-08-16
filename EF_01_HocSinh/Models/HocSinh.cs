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
    public class HocSinh
    {
        public int HocSinhId { get; set; }
        [MinLength(2)]
        [MaxLength(20)]
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public int LopId { get; set; }
        public Lop Lop { get; set; }

        public void Input() {
            HoVaTen = InputHelper.InputName(HocSinhRes.HoVaTen, HocSinhRes.ErrorHoVaTen, HocSinhRes.ErrorSoTu,  2, 20);
            NgaySinh = InputHelper.InputDateTime(HocSinhRes.NgaySinh, HocSinhRes.ErrorNgaySinh, 2001, 2013, HocSinhRes.ErrorNam);
            QueQuan = InputHelper.InputCheckCity(HocSinhRes.QueQuan, HocSinhRes.ErrorQueQuan);
            LopId = InputHelper.InputInt(HocSinhRes.LopId, HocSinhRes.ErrorLopId);
        }

        public void Input(int lopID)
        {
            HoVaTen = InputHelper.InputName(HocSinhRes.HoVaTen, HocSinhRes.ErrorHoVaTen, HocSinhRes.ErrorSoTu, 2, 20);
            NgaySinh = InputHelper.InputDateTime(HocSinhRes.NgaySinh, HocSinhRes.ErrorNgaySinh, 2001, 2013, HocSinhRes.ErrorNam);
            QueQuan = InputHelper.InputCheckCity(HocSinhRes.QueQuan, HocSinhRes.ErrorQueQuan);
            LopId = lopID;
        }

        public void Output() {
            Console.WriteLine($"Ho va ten: {HoVaTen}\n" +
                $"Ngay sinh: {NgaySinh.ToShortDateString()}\n" +
                $"Que quan: {QueQuan}");
        }
    }
}
