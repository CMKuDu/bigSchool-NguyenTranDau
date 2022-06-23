using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bigSchool_NguyenTranDau.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }

    }
}