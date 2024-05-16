namespace NewApp.Models{
        public class Student
    {
        public string MaSinhVien {get; set;}
        public string HoTen {get; set; }
        public string DIaChi{get; set;}
     public Student()
    {
        MaSinhVien = "20210500076";
        HoTen = "Le Thi Mai Anh";
        DIaChi = "Ha Noi";
    }
     public void HienThiThongTin()
     {
            System.Console.WriteLine("{0} - {1} - {2} ", MaSinhVien, HoTen, DIaChi);
}
    }
    }