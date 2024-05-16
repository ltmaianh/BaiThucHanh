namespace DemoMVC.Models;

public class Employee{
    public string MaNV { get; set; }
    public string TenNV { get; set; }
    public int Tuoi { get; set; }
    public int Luong { get; set; }
    public void NhapThongTin(){
         System.Console.WriteLine("Ma Nhan Vien:");
            MaNV=Console.ReadLine();
            System.Console.WriteLine("Ten nhan vien:");
            TenNV=Console.ReadLine();
            System.Console.WriteLine("Tuoi nhan vien");
            Tuoi=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("luong");
            Luong=Convert.ToInt32(Console.ReadLine());

        }
        public void HienThiThongTin(){
             System.Console.WriteLine("{0} - {1} - {2} - {3} VND", MaNV, TenNV, Tuoi, Luong);
        }

    }