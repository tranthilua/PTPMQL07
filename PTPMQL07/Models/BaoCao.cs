using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTPMQL07.Models
{
    [Table("BaoCao")]
    public class BaoCao
    {
        [Key]
        public string DTNgay { get; set; }
        [AllowHtml]
        public string DTThang { get; set; }
        public string DTNam { get; set; }
    }
}