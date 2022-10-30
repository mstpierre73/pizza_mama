using System.ComponentModel.DataAnnotations;

namespace pizza_mama.Models {
    public class Pizza {

        public int PizzaID { get; set; }
        public string Name { get; set; }
        [Display(Name="Price($)")]
        public float Price { get; set; }
        public bool Vegetarian { get; set; }
        public string Ingredients { get; set; }
    }
}
