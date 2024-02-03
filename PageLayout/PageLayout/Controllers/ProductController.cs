using Microsoft.AspNetCore.Mvc;

namespace PageLayout.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            throw new NotImplementedException();
        }

        public ActionResult Details(int Id)
        {
            if (Id < 1)
                return RedirectToAction("Index");
            var product = new Product(Id, "Laptop");
            return View("Details", product);
        }
    }

    public class Product
    {
        public int id;
        public string name;

        public Product(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
