using DAF_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DAF_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly db_donationsContext _context;
        public dynamic? money;
        public dynamic? goods;
        public dynamic? disaster;
        public IndexModel(ILogger<IndexModel> logger, db_donationsContext context)
        {
            _logger = logger;
            _context = context;
        }
        public void OnGet()
        {
            money = _context.Monetaries.Select(e => e.Amount).Sum();
            goods = _context.Goods.Select(e => e.NumberOfItems).Sum();
        }
        public void OnPost()
        {
            OnGetMyOnClick();
            Response.Redirect("/Index");
        }
        public void OnGetMyOnClick()
        {
            HttpContext.Session.Clear();
        }
    }
}