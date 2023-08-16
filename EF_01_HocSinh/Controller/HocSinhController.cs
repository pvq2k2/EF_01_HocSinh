using EF_01_HocSinh.Helper;
using EF_01_HocSinh.Resources;
using EF_01_HocSinh.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_HocSinh.Controller
{
    public class HocSinhController
    {
        HocSinhServices services;

        public HocSinhController()
        {
            services = new HocSinhServices();
        }

        public void ThucThi(char c)
        {
            switch (c)
            {
                case '1':
                    int IDHSAdd = InputHelper.InputInt(HocSinhRes.HocSinhId, HocSinhRes.ErrorHocSinhId);
                    int IDLopAdd = InputHelper.InputInt(HocSinhRes.LopId, HocSinhRes.ErrorLopId);
                    LogHelper.HocSinhLog(services.ThemHocSinhVaoLop(IDHSAdd, IDLopAdd));
                    break;
                case '2':
                    int IDHSUpdate = InputHelper.InputInt(HocSinhRes.HocSinhId, HocSinhRes.HocSinhId);
                    LogHelper.HocSinhLog(services.SuaThongTinHocSinh(IDHSUpdate));
                    break;
                case '3':
                    int IDHSRemove = InputHelper.InputInt(HocSinhRes.HocSinhId, HocSinhRes.HocSinhId);
                    LogHelper.HocSinhLog(services.XoaHocSinh(IDHSRemove));
                    break;
                case '4':
                    int IDHSChuyenLop = InputHelper.InputInt(HocSinhRes.HocSinhId, HocSinhRes.HocSinhId);
                    int IDLopOdd = InputHelper.InputInt("Nhap ID lop cu: ", "Vui long nhap ID lop cu la so");
                    int IDLopNew = InputHelper.InputInt("Nhap ID lop moi: ", "Vui long nhap ID lop moi la so");
                    LogHelper.HocSinhLog(services.ChuyenLop(IDHSChuyenLop, IDLopOdd, IDLopNew));
                    break;
                case '5':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Khong co chuc nang nay, vui long nhap lai!");
                    break;
            }
            Console.WriteLine("\nNhan phim bat ky de tiep tuc!");
            Console.ReadKey();
        }
    }
}
