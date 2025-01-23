using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myweb0._2.Models;

namespace myweb0._2.Pages.myWeb
{
    public class PasatiempoModel : PageModel
    {
        private readonly DatabaseContext _context;

        public PasatiempoModel(DatabaseContext context)
        {
            _context = context;
        }

        public List<Pasatiempo> Pasatiempos { get; set; }

        public async Task OnGetAsync()
        {
            Pasatiempos = await _context.Pasatiempos.ToListAsync();
        }
    }
}
