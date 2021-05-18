using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL07.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public int MaNV { get; set; }
        public string HoNV { get; set; }
        public string TenNV { get; set; }
        public string ChucVu { get; set; }
        public int SoCMT { get; set; }
        public string DiaChi { get; set; }
    }
}