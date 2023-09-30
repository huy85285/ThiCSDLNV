using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace _08_VoThanhHuy
{
    public class QLSVDBcontext : DbContext
    {
        public DbSet<KHOA> KHOAs { get; set; }
        public DbSet<SINHVIEN> SINHVIENs { get; set; }
        public QLSVDBcontext(): base("name=QLSVDBcontext")
        {
        }
    }
}