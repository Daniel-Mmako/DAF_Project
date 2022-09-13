using DAF_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DAF_Project.Pages.Purchase
{
    public class PurchaseModel : PageModel
    {
        private readonly db_donationsContext _context;
        public String successMessage = "";
        public Decimal? price;
        public String goods = "";
        public Decimal? availableAmount;
        public PurchaseModel(db_donationsContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            availableAmount = _context.Monetaries.Select(e => e.Amount).Sum();
        }
    }
}
