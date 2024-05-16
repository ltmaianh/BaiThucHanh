namespace NewApp.Models{
    public class SinhVien{
        public string TenSinhVien { get; set; }
        public string DiaChi { get; set; }
        public int Tuoi { get; set; }
        public string SoDienThoai{get;set;}
        public void NhapThongTin (){
            System.Console.WriteLine("Ten sinh Vien:");
            TenSinhVien=Console.ReadLine();
            System.Console.WriteLine("Dia Chi sinh vien:");
            DiaChi=Console.ReadLine();
            System.Console.WriteLine("Tuoi sinh vien");
            Tuoi=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("So Dien Thoai:");
            SoDienThoai=Console.ReadLine();
    }
    public void HienThiThongTin(){
        System.Console.WriteLine("{0}-{1}-{2}-{3}",TenSinhVien, DiaChi, Tuoi,SoDienThoai);
    }
}
}