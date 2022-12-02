using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizza_mama.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pizza_mama.Pages
{
    public class MenuPizzaModel : PageModel
    {
        private readonly pizza_mama.Data.DataContext _context;

        public MenuPizzaModel(pizza_mama.Data.DataContext context) {
            _context = context;
        }

        public IList<Pizza> Pizza { get; set; }

        public async Task OnGetAsync() {
            Pizza = await _context.Pizzas.ToListAsync();
            Pizza.OrderBy(p => p.Name).ToList();
        }
    }
}
