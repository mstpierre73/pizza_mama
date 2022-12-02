using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

namespace pizza_mama.Models {
    public class Pizza {

        [JsonIgnore]
        public int PizzaID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
        
        [Display(Name = "Price($)")]
        public float Price { get; set; }

        [Display(Name = "Vegetarian")]
        public bool Vegetarian { get; set; }

        [JsonIgnore]
        public string Ingredients { get; set; }

        [NotMapped]
        [JsonPropertyName("Ingredients")]
        public string[] IngredientList {
            get {
                if((Ingredients == null) || (Ingredients.Count() == 0)) {
                    return null;
                }

                return Ingredients.Split(",");
            }
        }
    }
}
