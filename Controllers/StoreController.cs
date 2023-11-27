using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Migrations;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StoreController : Controller
    {
        ITIContext db;
        public StoreController(ITIContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(StoreModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await db.stores.AddAsync(model);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch (Exception ex)
            {
                return View(ex);
            }

        }
    }
}
