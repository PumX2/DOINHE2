using DOINHE.Db;
using DOINHE.Entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DOINHE.Pages
{
    public class PaymentSuccessModel : PageModel
    {
        private readonly MyDbContext _db;
        public User Users { get; set; }
        public Entitys.Product Product { get; set; }
        public Order Order { get; set; }

        public PaymentSuccessModel(MyDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }
    }
}
