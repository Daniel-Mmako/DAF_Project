using DAF_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DAF_Project.Pages.ViewAll
{
    public class ViewModel : PageModel
    {
        private readonly db_donationsContext _context;
        public ViewModel(db_donationsContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        
    }
}
