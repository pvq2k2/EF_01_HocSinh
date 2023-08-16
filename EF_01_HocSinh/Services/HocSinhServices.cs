using EF_01_HocSinh.Helper;
using EF_01_HocSinh.IServices;
using EF_01_HocSinh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_HocSinh.Services
{
    public class HocSinhServices : IHocSinhServices
    {
        private readonly AppDbContext dbContext;

        public HocSinhServices()
        {
            dbContext = new AppDbContext();
        }

        private void CapNhatSiSo(int LopId)
        {
            var FindLop = dbContext.Lop.FirstOrDefault(x => x.LopId == LopId);
            if (FindLop != null)
            {
                FindLop.SiSo = dbContext.HocSinh.Count(x => x.LopId == LopId);
                dbContext.Lop.Update(FindLop);
                dbContext.SaveChanges();
            }
        }

        public LogType SuaThongTinHocSinh(int HocSinhId)
        {
            var FindHocSinh = dbContext.HocSinh.FirstOrDefault(x => x.HocSinhId == HocSinhId);
            if (FindHocSinh == null) return LogType.KhongTimThayHocSinh;
            HocSinh hocSinh = new HocSinh();
            hocSinh.Input(FindHocSinh.LopId);
            FindHocSinh.HoVaTen = hocSinh.HoVaTen;
            FindHocSinh.QueQuan = hocSinh.QueQuan;
            FindHocSinh.NgaySinh = hocSinh.NgaySinh;

            dbContext.HocSinh.Update(hocSinh);
            dbContext.SaveChanges();
            return LogType.ThanhCong;
        }

        public LogType ThemHocSinhVaoLop(int HocSinhId, int LopId)
        {
            var FindLop = dbContext.Lop.FirstOrDefault(x => x.LopId == LopId);
            var FindHocSinh = dbContext.HocSinh.FirstOrDefault(x => x.HocSinhId == HocSinhId);

            if (FindLop == null) return LogType.KhongTimThayHocSinh;
            if (FindHocSinh == null) return LogType.KhongTimThayLop;

            InputHelper.KiemTraHocSinh(FindHocSinh);
            InputHelper.KiemTraTenLop(FindLop.TenLop);


            if (FindHocSinh.LopId == LopId) return LogType.HocSinhDangOTrongLop;

            if (FindLop.SiSo + 1 > 20) return LogType.LopDuSiSo;

            FindHocSinh.LopId = LopId;
            dbContext.HocSinh.Add(FindHocSinh);
            dbContext.SaveChanges();

            CapNhatSiSo(LopId);

            return LogType.ThanhCong;
        }

        public LogType XoaHocSinh(int HocSinhId)
        {
            var FindHocSinh = dbContext.HocSinh.FirstOrDefault(x => x.HocSinhId == HocSinhId);
            if (FindHocSinh == null) return LogType.KhongTimThayHocSinh;
            dbContext.HocSinh.Remove(FindHocSinh);
            dbContext.SaveChanges();
            Console.WriteLine($"Da xoa hoc sinh co ten '{FindHocSinh.HoVaTen}' co id la {FindHocSinh.HocSinhId}");
            CapNhatSiSo(HocSinhId);
            return LogType.ThanhCong;
        }

        public LogType ChuyenLop(int HocSinhId, int OddLopId, int NewLopId)
        {
            if (!dbContext.Lop.Any(x => x.LopId == OddLopId)) return LogType.KhongTimThayLopCu;
            if (!dbContext.Lop.Any(x => x.LopId == NewLopId)) return LogType.KhongTimThayLopMoi;
            var FindHocSinh = dbContext.HocSinh.FirstOrDefault(x => x.HocSinhId == HocSinhId);
            if (FindHocSinh == null) return LogType.KhongTimThayHocSinh;
            FindHocSinh.LopId = NewLopId;
            dbContext.HocSinh.Update(FindHocSinh);
            dbContext.SaveChanges();
            return LogType.ThanhCong;
        }

    }
}
