using EF_01_HocSinh.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_HocSinh.View
{
    public class HocSinhView
    {
        HocSinhController controller;

        public HocSinhView()
        {
            controller = new HocSinhController();
        }

        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----------Menu----------");
                Console.WriteLine("1. Them hoc sinh vao lop");
                Console.WriteLine("2. Sua thong tin hoc sinh");
                Console.WriteLine("3. Xoa hoc sinh");
                Console.WriteLine("4. Chuyen lop cho hoc sinh");
                Console.WriteLine("5. Thoat");
                Console.Write("Chon chuc nang: ");
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine();
                controller.ThucThi(c);
            }
        }
    }
}
