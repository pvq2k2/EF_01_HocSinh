using EF_01_HocSinh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_HocSinh.Helper
{
    public class InputHelper
    {
        public static int InputInt(string message, string error, int minValue = int.MinValue, int maxValue = int.MaxValue, string errorValue = "")
        {
            string num;
            bool isNum;
            int numResult;
            do
            {
                Console.Write(message);
                num = Console.ReadLine();
                isNum = int.TryParse(num, out numResult);
                if (!isNum)
                {
                    Console.WriteLine(error);
                }
                else if (numResult < minValue && numResult > maxValue)
                {
                    Console.WriteLine(errorValue);
                }
            } while (!isNum);

            return numResult;
        }

        public static double InputDouble(string message, string error, string errorLength, double minValue = double.MinValue, double maxValue = double.MaxValue)
        {
            string num;
            bool isNum;
            double numResult;
            do
            {
                Console.Write(message);
                num = Console.ReadLine();
                isNum = double.TryParse(num, out numResult);
                if (!isNum)
                {
                    Console.WriteLine(error);
                }
                else if (numResult < minValue && numResult > maxValue)
                {
                    Console.WriteLine(errorLength);
                }
            } while (!isNum);

            return numResult;
        }

        public static string InputString(string message, string error = "", int minValue = int.MinValue, int maxValue = int.MaxValue, Func<string, bool> validationFunc = null, string errorRegex = "")
        {
            string str;
            bool isValid = false;

            do
            {
                Console.Write(message);
                str = Console.ReadLine();
                if (str.Length < minValue || str.Length > maxValue)
                {
                    Console.WriteLine(error);
                }
                else if (validationFunc != null && !validationFunc(str))
                {
                    Console.WriteLine(errorRegex);
                }
                else
                {
                    isValid = true;
                }
            } while (!isValid);

            return str;
        }

        public static string InputName(string message, string error = "", string errorSoTu = "", int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            string str;
            bool isValid = false;

            do
            {
                Console.Write(message);
                str = Console.ReadLine();
                if (str.Length < minValue || str.Length > maxValue)
                {
                    Console.WriteLine(error);
                }
                else if (str.Split(" ").Length < 2)
                {
                    Console.WriteLine(errorSoTu);
                }
                else
                {
                    isValid = true;
                }
            } while (!isValid);

            return str;
        }

        public static DateTime InputDateTime(string message, string error, int startYear, int endYear, string errorYear)
        {
            bool match;
            DateTime datePs;
            do
            {
                Console.Write(message);
                match = DateTime.TryParse(Console.ReadLine(), out datePs);
                if (!match)
                {
                    Console.WriteLine(error);
                } else if (datePs.Year < startYear && datePs.Year > endYear)
                {
                    Console.WriteLine(errorYear);
                }
            }
            while (!match);
            return datePs;
        }

        public static string InputCheckCity(string message, string error)
        {
            string str;
            bool isValid = false;
            bool coChuaTenThanhPho;
            List<string> tinhThanhList = new List<string>()
        {
            "Hà Nội",
            "Hồ Chí Minh",
            "Hải Phòng",
            "Cần Thơ",
            "Đà Nẵng",
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bà Rịa Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Tĩnh",
            "Hải Dương",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái",
            "Phú Yên"
        };
            do
            {
                Console.Write(message);
                str = Console.ReadLine();
                coChuaTenThanhPho = tinhThanhList.Any(tinhThanh =>
                str.IndexOf(tinhThanh, StringComparison.OrdinalIgnoreCase) >= 0);

                if (!coChuaTenThanhPho)
                {
                    Console.WriteLine(error);
                }
                else
                {
                    isValid = true;
                }

            } while (!isValid);

            return str;
        }

        public static LogType KiemTraHocSinh(HocSinh hocSinh)
        {
            List<string> tinhThanhList = new List<string>()
        {
            "Hà Nội",
            "Hồ Chí Minh",
            "Hải Phòng",
            "Cần Thơ",
            "Đà Nẵng",
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bà Rịa Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Tĩnh",
            "Hải Dương",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái",
            "Phú Yên"
        };
            bool coChuaTenThanhPho = tinhThanhList.Any(tinhThanh =>
            hocSinh.QueQuan.IndexOf(tinhThanh, StringComparison.OrdinalIgnoreCase) >= 0);
            if (hocSinh.HoVaTen.Length > 20) return LogType.ErrorHoVaTen;
            if (hocSinh.HoVaTen.Split(" ").Length < 2) return LogType.ErrorSoTu;
            if (hocSinh.NgaySinh.Year < 2001 && hocSinh.NgaySinh.Year > 2013) return LogType.ErrorNgaySinh;
            if (!coChuaTenThanhPho) return LogType.ErrorQueQuan;
            return LogType.Thoat;
        }
        public static LogType KiemTraTenLop(string str)
        {
            if (str.Length < 0 && str.Length > 20) return LogType.ErrorTenLop;
            return LogType.Thoat;
        }
    }
}
