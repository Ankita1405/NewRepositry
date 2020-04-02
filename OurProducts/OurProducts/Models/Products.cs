using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OurProducts.Models
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        public float Pprice { get; set; }
        public string PDesc { get; set; }


    }
}
