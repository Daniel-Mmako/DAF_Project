using DAF_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DAF_Project.Pages.Purchase
{
    public class PurchaseModel : PageModel
    {
        private readonly db_donationsContext _context;
        public List<SelectListItem>? Options { get; set; }
        public String successMessage = "";
        public Decimal? price;
        public String goods = "";
        public Decimal? availableAmount;
        public int numOfItems;
        public PurchaseModel(db_donationsContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            availableAmount = _context.Monetaries.Select(e => e.Amount).Sum();
            Options = _context.Goods.Select(e => new SelectListItem
            {
                Text = e.Category,
            }).ToList();
        }
    }
}
