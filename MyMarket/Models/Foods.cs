using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMarket.Models
{
    public class Foods
    {
        [Key]
        [StringLength(15)]

        public String Barcode{ get; set; }
        [Display(Name = " Name")]
        public String Name { get; set; }
        [Display(Name = " Food Type")]
        public FoodTypes FoodType { get; set; }
       
        public byte FoodTypeID { get; set; }
        [Display(Name = " Production Date")]
        public DateTime ProductionDate { get; set; }
        [Display(Name = "Expiry Date ")]
        public DateTime ExpiryDate { get; set; }
        [Display(Name = "  Food Name")]
        public string FoodName { get; set; }




    }
}