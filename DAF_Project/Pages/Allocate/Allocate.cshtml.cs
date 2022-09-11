using DAF_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DAF_Project.Pages.Allocate
{
    public class AllocateModel : PageModel
    {
        private readonly db_donationsContext _context;
        public String disaster = "";
        public Decimal amount;
        public int numOfGoods;
        public String successMessage = "";
        public String errorMessage = "";
        public AllocateModel(db_donationsContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }
    }
}
