using DAF_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DAF_Project.Pages.Capture.CaptureGoods
{
    public class CaptureGoodsModel : PageModel
    {
        private readonly db_donationsContext _context;
        public String newDate = "";
        public int newNumberOfItems;
        public String newCategory = "";
        public String newDescription = "";
        public String newDonor = "";
        public String errorMessage = "";
        public String varL = "";
        public CaptureGoodsModel(db_donationsContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            
        }
        public void OnPost()
        {
            newDate = Request.Form["date"];
            newCategory = Request.Form["category"];
            newDescription = Request.Form["description"];
            newDonor = Request.Form["donor"];

            try
            {
                var goods = new Models.Good
                {
                    Date = Convert.ToDateTime(newDate).Date,
                    NumberOfItems = newNumberOfItems,
                    Category = newCategory,
                    Description = newDescription,
                    Donor = newDonor
                };

                _context.Add(goods);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            Response.Redirect("/Index");
        }

        protected void ddlCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            varL = "Hello World";
        }
    }
}
