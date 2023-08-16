using EF_01_HocSinh.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_HocSinh.Helper
{
    public enum LogType
    {
        Thoat,
        KhongTimThayHocSinh,
        KhongTimThayLop,
        KhongTimThayLopCu,
        KhongTimThayLopMoi,
        HocSinhDangOTrongLop,
        LopDuSiSo,
        DanhSachTrong,
        ErrorHoVaTen,
        ErrorNgaySinh,
        ErrorQueQuan,
        ErrorSoTu,
        ErrorTenLop,
        ThanhCong
    }
    internal class LogHelper
    {
        public static void HocSinhLog(LogType log)
        {
            switch (log)
            {
                case LogType.ThanhCong:
                    Console.WriteLine(HocSinhRes.LogThanhCong);
                    break;
                case LogType.KhongTimThayHocSinh:
                    Console.WriteLine(HocSinhRes.LogKhongTimThayHocSinh);
                    break;
                case LogType.KhongTimThayLop:
                    Console.WriteLine(HocSinhRes.LogKhongTimThayLop);
                    break;
                case LogType.KhongTimThayLopCu:
                    Console.WriteLine(HocSinhRes.LogKhongTimThayLopCu);
                    break;
                case LogType.KhongTimThayLopMoi:
                    Console.WriteLine(HocSinhRes.LogKhongTimThayLopMoi);
                    break;
                case LogType.HocSinhDangOTrongLop:
                    Console.WriteLine(HocSinhRes.LogHocSinhDangOTrongLop);
                    break;
                case LogType.LopDuSiSo:
                    Console.WriteLine(HocSinhRes.LogLopDuSiSo);
                    break;
                case LogType.DanhSachTrong:
                    Console.WriteLine(HocSinhRes.LogDanhSachTrong);
                    break;
                case LogType.ErrorHoVaTen:
                    Console.WriteLine(HocSinhRes.ErrorHoVaTen);
                    break;
                case LogType.ErrorNgaySinh:
                    Console.WriteLine(HocSinhRes.ErrorNgaySinh);
                    break;
                case LogType.ErrorQueQuan:
                    Console.WriteLine(HocSinhRes.ErrorQueQuan);
                    break;
                case LogType.ErrorSoTu:
                    Console.WriteLine(HocSinhRes.ErrorSoTu);
                    break;
                case LogType.ErrorTenLop:
                    Console.WriteLine(HocSinhRes.ErrorTenLop);
                    break;
            }
        }
    }
}
