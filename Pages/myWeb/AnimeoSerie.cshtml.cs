using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myweb0._2.Models;

namespace myweb0._2.Pages
{
    public class AnimeoSerieModel : PageModel
    {
        private readonly DatabaseContext _context;
        public AnimeoSerieModel(DatabaseContext context)
        {
            _context = context;
        }

        public List<AnimeOSerie> AnimeOSeries { get; set; }

        public async Task OnGetAsync()
        {
            AnimeOSeries = await _context.AnimesOSeries.ToListAsync();
        }
    }
}
