using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL07.Models
{
    [Table("ThuePhongs")]
    public class ThuePhong
    {
        [Key]
        public string TenPhong { get; set; }
        public string ViTri  { get; set; }
        public string Loai{ get; set; }
        public string TinhTrang { get; set; }
        public string Gia { get; set; }
      
    }
}