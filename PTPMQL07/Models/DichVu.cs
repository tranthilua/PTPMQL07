using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL07.Models
{
    [Table("DichVus")]
    public class DichVu
    {
        [Key]
        public string TenDV { get; set; }
        public string MaDV { get; set; }
        public string Gia { get; set; }
    }
}