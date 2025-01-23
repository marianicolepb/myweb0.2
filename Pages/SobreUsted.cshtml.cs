using Microsoft.AspNetCore.Mvc.RazorPages;
using myweb0._2.Models;

public class SobreUstedModel : PageModel
{
    private readonly DatabaseContext _context;

    public SobreUstedModel(DatabaseContext context)
    {
        _context = context;
    }

    public Usuario Usuario { get; set; }

    public void OnGet()
    {
        // Cargar datos del usuario desde la base de datos
        Usuario = _context.Usuarios.FirstOrDefault(); // Asegúrate de tener datos en la tabla
    }
}

