using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("KHOA")]
public class KHOA
{
    [Key]
    public string MaKH { get; set; }
    public string TenKH { get; set; }
    public List<SINHVIEN> SINHVIEN { get; set; }
}