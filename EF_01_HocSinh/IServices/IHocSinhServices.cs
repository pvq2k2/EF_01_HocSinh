using EF_01_HocSinh.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_HocSinh.IServices
{
    public interface IHocSinhServices
    {
        LogType ThemHocSinhVaoLop(int HocSinhId, int LopId);
        LogType SuaThongTinHocSinh(int HocSinhId);
        LogType XoaHocSinh(int HocSinhId);
        LogType ChuyenLop(int HocSinhId, int OddLopId, int NewLopId);
    }
}
