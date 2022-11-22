using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizza_mama.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace pizza_mama.Pages
{
    public class MenuPizzaModel : PageModel
    {
        private readonly pizza_mama.Data.DataContex _context;

        public MenuPizzaModel(pizza_mama.Data.DataContex context) {
            _context = context;
        }

        public IList<Pizza> Pizza { get; set; }

        public async Task OnGetAsync() {
            Pizza = await _context.Pizzas.ToListAsync();
        }
    }
}