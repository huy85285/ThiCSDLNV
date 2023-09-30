namespace _08_VoThanhHuy.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<_08_VoThanhHuy.QLSVDBcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(_08_VoThanhHuy.QLSVDBcontext context)
        {
            context.KHOAs.Add(new KHOA { MaKH = "TH", TenKH = "Tin học" });
            context.KHOAs.Add(new KHOA { MaKH = "KT", TenKH = "Kế toán Doanh nghiệp" });
            context.KHOAs.Add(new KHOA { MaKH = "AV", TenKH = "Anh văn" });
            context.KHOAs.Add(new KHOA { MaKH = "QT", TenKH = "Quản trị" });

            context.SINHVIENs.Add(new SINHVIEN { MaSV = "A01", HoTen = "Trần Văn Hùng", SoMon = 4, MaKH = "TH" });
            context.SINHVIENs.Add(new SINHVIEN { MaSV = "A02", HoTen = "Lý Hùng Tâm", SoMon = 4, MaKH = "TH" });
            context.SINHVIENs.Add(new SINHVIEN { MaSV = "A03", HoTen = "Trần Thị Hoa", SoMon = 5, MaKH = "KT" });
            context.SINHVIENs.Add(new SINHVIEN { MaSV = "B01", HoTen = "Lê Văn Long", SoMon = 3, MaKH = "KT" });
            context.SINHVIENs.Add(new SINHVIEN { MaSV = "B02", HoTen = "Nguyễn Văn Dũng", SoMon = 4, MaKH = "AV" });
            context.SINHVIENs.Add(new SINHVIEN { MaSV = "C01", HoTen = "Lê Thị Loan", SoMon = 2, MaKH = "AV" });
        }
    }
}
