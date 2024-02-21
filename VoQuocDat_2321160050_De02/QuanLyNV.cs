using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoQuocDat_2321160050_De02
{
    class QuanLyNV
    {
        private List<NhanVien> dsNV;
        public QuanLyNV()
        {
            dsNV = new List<NhanVien>();
        }
        public void NhapDS()
        {
            string tieptuc = "y";
            int chon;
            NhanVien nv;
            do
            {
                Console.WriteLine("Ban hay chon loai nhan vien:[1.Bien che 2.Hop dong]");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    case 2:
                        nv = new NhanVienHD();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    default:
                        Console.Write("Ban da chon sai, xin vui long nhap lai 1 va 2!");
                        break;
                }
                Console.Write("Ban co muon tiep tuc khong? Y/N: ");
                tieptuc = Console.ReadLine();
            } while (tieptuc.ToLower() == "y");
        }
        public void XuatDS()
        {
            Console.WriteLine($"{"Ma so",-10}  {"Ho Ten",20}  {"Luong Lanh Thuc",10}");
            foreach (NhanVien x in dsNV)
            {
                Console.WriteLine($"{x.Maso,-10} {x.Hoten,20} {x.TinhLuong(),10}");
            }
        }
        public int TinhTongLuong()
        {
            int sum = 0;
            foreach (NhanVien nv in dsNV)
            {
                sum += nv.TinhLuong();
            }

            return sum;
        }
        //public double TinhLuongTrungBinh()
        //{
           
        //}
    }
}

