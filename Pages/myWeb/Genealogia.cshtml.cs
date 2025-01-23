using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myweb0._2.Models;

namespace myweb0._2.Pages.myWeb
{
    public class GenealogiaModel : PageModel
    {
        private readonly DatabaseContext _context;

        public GenealogiaModel(DatabaseContext context)
        {
            _context = context;
        }

        public List<Genealogia> Genealogias { get; set; }

        public async Task OnGetAsync()
        {
            Genealogias = await _context.Genealogia.ToListAsync();
        }
    }
}
