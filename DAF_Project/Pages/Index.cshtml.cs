using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DAF_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

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