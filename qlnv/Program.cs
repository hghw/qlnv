using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace qlnv
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NhanVien> listNhanVien = new List<NhanVien>();

            int check = 0;
            do
            {
                Console.WriteLine("-------Menu---------");
                Console.WriteLine("1. Hien thi danh sach");
                Console.WriteLine("2. Them moi nhan vien");
                Console.WriteLine("3. Sua nhan vien");
                Console.WriteLine("4. Xoa nhan vien");
                Console.WriteLine("5. Thoat!");

                check = int.Parse(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        hienthiNV(listNhanVien);
                        break;
                    case 2:
                        themNV(listNhanVien);
                        break;
                    case 3:
                        suaNV(listNhanVien);
                        break;
                    case 4:
                        xoaNV(listNhanVien);
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Ban da chon sai");
                        break;
                }

            } while (check != 5);
        }

        public static void themNV(List<NhanVien> listNhanVien)
        {
            Console.WriteLine("Ban da chon them moi nhan vien");
            string maNhanVien;
            string hoTen;
            string sdt; ;
            string diaChi; ;
            int tuoi;

            NhanVien nv = new NhanVien();

            Console.WriteLine("Nhap mnv: ");
            nv.maNhanVien = Console.ReadLine();
            Console.WriteLine("Nhap ho ten: ");
            nv.hoTen = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            nv.tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap sdt: ");
            nv.sdt = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            nv.diaChi = Console.ReadLine();

            /*var info = "maNhanVien, hoTen, tuoi, sdt, diaChi";*/
            /*Console.WriteLine(info);*/
            /*var convertInfo = JsonConvert.SerializeObject(info);
            Console.WriteLine(convertInfo);*/

            listNhanVien.Add(nv);


        }
            public static void suaNV(List<NhanVien> listNhanVien)
            {
            Console.WriteLine("Ban da chon sua nhan vien");
            NhanVien nv = new NhanVien();
                Console.WriteLine("Nhap ma nhan vien muon sua:");
                string maNhanVien = Console.ReadLine();
                for (int i = 0; i < listNhanVien.Count; i++)
                {
                    if (listNhanVien[i].maNhanVien == maNhanVien)
                    {
                        Console.WriteLine("Nhap ho ten: ");
                        listNhanVien[i].hoTen = Console.ReadLine();
                        Console.WriteLine("Nhap tuoi: ");
                        listNhanVien[i].tuoi = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap sdt: ");
                        listNhanVien[i].sdt = Console.ReadLine();
                        Console.WriteLine("Nhap dia chi: ");
                        listNhanVien[i].diaChi = Console.ReadLine();


                }
                else
                {
                    Console.WriteLine("Khong ton tai ma nhan vien nay");
                }

            }
            }
            public static void xoaNV(List<NhanVien> listNhanVien)
            {
            Console.WriteLine("Ban da chon xoa nhan vien");
            Console.WriteLine("Nhap ma nhan vien muon xoa: ");
                string maNhanVien = Console.ReadLine();
                for (int i = 0; i < listNhanVien.Count; i++)
                {
                    if (listNhanVien[i].maNhanVien == maNhanVien)
                    {
                        listNhanVien.RemoveAt(i);
                }
                else
                {
                    Console.WriteLine("Khong ton tai ma nhan vien nay");
                }
                }
            }
            public static void hienthiNV(List<NhanVien> listNhanVien)
            {
            Console.WriteLine("Ban da chon hien thi nhan vien");
                foreach (NhanVien item in listNhanVien)
                    {
                        Console.Write("MNV: " + item.maNhanVien);
                        Console.Write(" Ho ten: " + item.hoTen);
                        Console.Write(" Tuoi: " + item.tuoi);
                        Console.Write(" SDT: " + item.sdt);
                        Console.Write(" Dia Chi: " + item.diaChi);
                        Console.WriteLine();

            }
            }

    }
}

