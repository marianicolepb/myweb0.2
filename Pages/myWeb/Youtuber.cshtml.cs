using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myweb0._2.Models;

namespace myweb0._2.Pages.myWeb
{
    public class YoutuberModel : PageModel
    {
        private readonly DatabaseContext _context;

        public YoutuberModel(DatabaseContext context)
        {
            _context = context;
        }

        public List<YouTuber> YouTubers { get; set; }

        public async Task OnGetAsync()
        {
            YouTubers = await _context.Youtubers.ToListAsync();
        }
    }
}
