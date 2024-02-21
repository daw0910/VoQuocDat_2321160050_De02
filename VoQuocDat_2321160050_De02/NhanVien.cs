﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoQuocDat_2321160050_De02
{
    class NhanVien
    {
        private string maso;
        private string hoten;
        private int luongcung;
        public NhanVien() {}
        public NhanVien (string maso,string hoten, int luongcung)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.luongcung = luongcung;
        }
        public string Maso
        {
            set { this.maso = value; }
            get { return this.maso; }
        }
        public string Hoten
        {
            set { this.hoten = value; }
            get { return this.hoten; }
        }
        public int Luongcung
        {
            set { this.luongcung = value; }
            get { return this.luongcung; }
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ma so nhan vien: ");
            this.maso = Console.ReadLine();
            Console.Write("Nhap ho ten nhan vien: ");
            this.hoten = Console.ReadLine();
            Console.Write("Nhap so luong cung: ");
            this.luongcung = int.Parse(Console.ReadLine());
        }
        public virtual int TinhLuong()
        {
            return Luongcung;
        }

    }
}
