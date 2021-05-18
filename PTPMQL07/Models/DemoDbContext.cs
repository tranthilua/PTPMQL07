using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PTPMQL07.Models
{
    public partial class DemoDbContext : DbContext
    {
        

        public DemoDbContext()
            : base("name=DemoDbContext")
        {
        }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<ThuePhong> ThuePhongs { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<BaoCao> BaoCaos { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
 

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {  }

       
    }
}


