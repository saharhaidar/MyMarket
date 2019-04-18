using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMarket.Models
{
    public class Stocks
    {
        [Key]
        public int ItemID { get; set; }
        [StringLength(15)]

        public String Barcode { get; set; }
        public int Quantity { get; set; }
        [Display(Name = " Price Per Unit")]
        public float PricePerUnit { get; set; }
        [Display(Name = "  Food Name")]
        public string FoodName { get; set; }



    }
}