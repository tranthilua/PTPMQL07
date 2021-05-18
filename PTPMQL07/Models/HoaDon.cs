using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL07.Models
{
    [Table("HoaDons")]
    public class HoaDon
    {
        [Key]
        public string MaHD { get; set; }
        public string TenHD { get; set; }
        public string NgayTT { get; set; }
        public int ThanhTien { get; set; }
        public string MaKH { get; set; }
    }
}