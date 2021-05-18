using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTPMQL07.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [AllowHtml]
        public string TenKh { get; set; }
        public string MaKh { get; set; }
        public string HoKh { get; set; }
        public string SoCMT { get; set; }
        public string SoDT { get; set; }
        public string NgayDen { get; set; }
        public string NgayDi { get; set; }
      
    }
}