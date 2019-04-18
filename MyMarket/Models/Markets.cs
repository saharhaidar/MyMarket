using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMarket.Models
{
    public class Markets
    {
        [Key]
        public int TransactionID { get; set; }
        [StringLength(15)]
        public String Barcode { get; set; }
        [Display(Name = " Quantity Sold")]
        public int QuantitySold { get; set; }
        [Display(Name = "  DateTime Sold")]
        public DateTime DateTimeSold { get; set; }
        [Display(Name = "  Total Price")]
        public int TotalPrice { get; set; }
        [Display(Name = "  Food Name")]
        public string FoodName { get; set; }

    }
}