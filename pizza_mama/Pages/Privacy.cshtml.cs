using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using pizza_mama.Data;
using pizza_mama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pizza_mama.Pages {
    public class PrivacyModel : PageModel {
        private readonly ILogger<PrivacyModel> _logger;
        DataContex DataContex;

        public PrivacyModel(ILogger<PrivacyModel> logger, DataContex dataContex) {
            _logger = logger;
            this.DataContex = dataContex;

        }

        public void OnGet() {
            var pizza = new Pizza() {
                PizzaID = 1,
                Name = "PizzaTest",
                Price = 5,
                Vegetarian = false,
                Ingredients = "cheese"
            };
            DataContex.Add(pizza);
            DataContex.SaveChanges();
        }
    }
}
