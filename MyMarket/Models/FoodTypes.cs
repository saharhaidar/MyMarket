using System.ComponentModel.DataAnnotations;

namespace MyMarket.Models
{
    public class FoodTypes
    {
        [Key]
        public byte FoodTypeID { get; set; }
        public string FoodName { get; set; }


    }
}