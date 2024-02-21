using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoQuocDat_2321160050_De02
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            QuanLyNV ql = new QuanLyNV();
            int chon = 0;
            do
            {
                //in thuc don ra man hinh
                Console.WriteLine("***CHUONG TRINH QUAN LY NHAN VIEN***");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1.Nhap danh sach nhan vien.");
                Console.WriteLine("2.Xuat thong tin nhan vien.");
                Console.WriteLine("3.Tong tien luong cua nhan vien.");
                Console.WriteLine("4.Tien thuc lanh trung trung binh cua nhan vien.");
                Console.WriteLine("0.Thoat chuong trinh.");
                Console.WriteLine("--------------------------------");
                Console.Write("Ban chon chuc nang:");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        ql.NhapDS();
                        break;

                    case 2:
                        ql.XuatDS();
                        break;
                    case 3:
                        ql.TinhTongLuong();
                        break;
                    case 4:
                        break;
                    case 0:
                        Console.WriteLine("Cam on quy khach da su dung.");
                        Console.ReadLine();
                        break;
                }

            } while (chon != 0);
        }
    }
}

