using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL07.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public int IDKH { get; set; }
        public string TenKh { get; set; }
        public int MaKh { get; set; }
        public string HoKh { get; set; }
        public int SoCMT { get; set; }
        public int SoDT { get; set; }
    }
}