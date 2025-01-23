using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myweb0._2.Models;

namespace myweb0._2.Pages.myWeb
{
    public class RedSocialModel : PageModel
    {
        private readonly DatabaseContext _context;

        public RedSocialModel(DatabaseContext context)
        {
            _context = context;
        }

        // Propiedad para almacenar las redes sociales
        public List<RedSocial> RedesSociales { get; set; }

        // Método OnGet para cargar las redes sociales desde la base de datos
        public async Task OnGetAsync()
        {
            // Obtén todas las redes sociales de la base de datos
            RedesSociales = await _context.RedesSociales.ToListAsync();
        }
    }
}
