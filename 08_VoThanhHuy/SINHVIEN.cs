using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("SINHVIEN")]
public class SINHVIEN
{
    [Key]
    public string MaSV { get; set; }
    public string HoTen { get; set; }
    public int SoMon { get; set; }
    public string MaKH { get; set; }
    public KHOA KHOA { get; set; }
}