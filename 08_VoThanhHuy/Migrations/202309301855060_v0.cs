namespace _08_VoThanhHuy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KHOA",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 128),
                        TenKH = c.String(),
                    })
                .PrimaryKey(t => t.MaKH);
            
            CreateTable(
                "dbo.SINHVIEN",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 128),
                        HoTen = c.String(),
                        SoMon = c.Int(nullable: false),
                        MaKH = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaSV)
                .ForeignKey("dbo.KHOA", t => t.MaKH)
                .Index(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SINHVIEN", "MaKH", "dbo.KHOA");
            DropIndex("dbo.SINHVIEN", new[] { "MaKH" });
            DropTable("dbo.SINHVIEN");
            DropTable("dbo.KHOA");
        }
    }
}
