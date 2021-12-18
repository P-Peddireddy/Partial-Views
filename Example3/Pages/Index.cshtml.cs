using Example3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Example3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Film> Films = new List<Film>
        {
            new Film { Title = "Naruto", Description = "Hoạt hình", Duration = TimeSpan.FromMinutes(23) },
            new Film { Title = "Dragon ball", Description = "Hoạt hình", Duration = TimeSpan.FromMinutes(22) },
            new Film { Title = "Pokemon", Description = "Hoạt hình", Duration = TimeSpan.FromMinutes(21) }
        };

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnGetPartial() =>
                Partial("ProductPartial");
    }
}
