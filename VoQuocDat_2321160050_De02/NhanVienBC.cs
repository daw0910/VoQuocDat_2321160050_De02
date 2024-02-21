using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoQuocDat_2321160050_De02
{
    class NhanVienBC:NhanVien
    {
        private string mucxeploai;

        public NhanVienBC() : base() { }

        public NhanVienBC(string maso, string hoten, int luongcung, string mucxeploai)
        {
            this.mucxeploai = mucxeploai;
        }
        public string Mucxeploai
        {
            set { this.mucxeploai = value; }
            get { return this.mucxeploai; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Muc xep loai cua nhan vien: ");
            this.mucxeploai = Console.ReadLine();
        }
        public override int TinhLuong()
        {
            double luong;
            if (this.mucxeploai == "a")
            {
                luong = Luongcung + 1.5 * Luongcung;
            }
            else if(this.mucxeploai == "b")
            {
                luong = Luongcung + 1.0 * Luongcung;
            }
            else
            {
                luong = Luongcung + 0.5 * Luongcung;
            }
            return (int)luong;
        }
    }
}
