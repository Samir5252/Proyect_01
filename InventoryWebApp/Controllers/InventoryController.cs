using InventoryWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryWebApp.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Update()
        {
            return View(new UpdateInventoryRequest());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(UpdateInventoryRequest request)
        {
            Console.WriteLine("=== MÉTODO POST EJECUTADO ===");

            if (!ModelState.IsValid)
            {
                return View(request);
            }


            Console.WriteLine($"inventario Recibido: Producto {request.ProductId},Cantidad {request.QuantityChanges}");
            TempData["SuccessMessage"] = $"Datos recibidos: {request.ProductId} / {request.QuantityChanges}";
            return RedirectToAction("Index", "Home");
        }

    //    // GET: InventoryController
    //    {
    //    public ActionResult Index()
    //        return View();
    //    }

    //    // GET: InventoryController/Details/5
    //    public ActionResult Details(int id)
    //    {
    //        return View();
    //    }

    //    // GET: InventoryController/Create
    //    public ActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: InventoryController/Create
    //    [HttpPost]

    //    // GET: InventoryController/Edit/5
    //    public ActionResult Edit(int id)
    //    {
    //        return View();
    //    }

    //    // POST: InventoryController/Edit/5
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Edit(int id, IFormCollection collection)
    //    {
    //        try
    //        {
    //            return RedirectToAction(nameof(Index));
    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }

    //    // GET: InventoryController/Delete/5
    //    public ActionResult Delete(int id)
    //    {
    //        return View();
    //    }

    //    // POST: InventoryController/Delete/5
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Delete(int id, IFormCollection collection)
    //    {
    //        try
    //        {
    //            return RedirectToAction(nameof(Index));
    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }
    }
}
