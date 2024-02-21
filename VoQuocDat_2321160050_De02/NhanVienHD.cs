using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoQuocDat_2321160050_De02
{
    class NhanVienHD : NhanVien
    {
        private int doanhthu;

        public NhanVienHD(): base() {}

        public NhanVienHD(string maso, string hoten, int luongcung, int doanhthu)
        {
            this.doanhthu = doanhthu;
        }
        public int Doanhthu
        {
            set { this.doanhthu = value; }
            get { return this.doanhthu; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Doanh thu cua nhan vien: ");
            this.doanhthu = int.Parse(Console.ReadLine());
        }
        public override int TinhLuong()
        {
            double luong = 0.1 * doanhthu;
            return (int)luong;
        }
    }
}
