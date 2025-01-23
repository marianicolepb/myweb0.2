using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myweb0._2.Models;

namespace myweb0._2.Pages.myWeb
{
    public class ContactoModel : PageModel
    {
        private readonly DatabaseContext _context;

        public ContactoModel(DatabaseContext context)
        {
            _context = context;
        }

        public List<Contacto> Contactos { get; set; }

        public async Task OnGetAsync()
        {
            Contactos = await _context.Contacto.ToListAsync();
        }
    }
    
}
