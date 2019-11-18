using ExcellentTaste.DAL;
using ExcellentTaste.Extensions;
using ExcellentTaste.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ExcellentTaste.Controllers
{
    public class ProductController : Controller
    {
        private ExcellentContext db = new ExcellentContext();

        // GET: Product
        public ActionResult Index()
        {
            List<Product> TempList = db.Products.ToList();
            foreach (Product product in db.Products)
            {
                if (product.Availability == false)
                {
                    TempList.Remove(product);
                }
            }
            return View(TempList as IEnumerable<Product>);
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ProductViewModel prodvm = new ProductViewModel(new Product()) { ListCategories = new SelectList(db.Categories, "CategoryID", "CategoryType") };
            //foreach (var category in db.Categories)
            //{
            //    prodvm.ListCategories.Add(new SelectListItem() { Value = category.CategoryID.ToString(), Text = category.CategoryType });
            //}
            //prod.listCategories = db.Categories.ToList();
            return View(prodvm);
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ConsumableType,Name,Price,VAT,Availability")] Product product, Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Category tempCat = db.Categories.Find(int.Parse(category.CategoryType));
                    if (tempCat == null)
                    {
                        ModelState.AddModelError("", "Kan categorie niet vinden.");
                        return RedirectToAction("Create");
                    }

                    product.Price = DoubleExtension.ConvertInput(Request.Form["PriceTextbox"]);
                    product.Category = tempCat;
                    db.Products.Add(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException Dex)
            {
                ModelState.AddModelError("", "Kan de wijzigingen niet opslaan. Probeer het opnieuw en neem contact op met uw systeembeheerder als het probleem zich blijft voordoen.");
                return View("Error", new HandleErrorInfo(Dex, "Product", "Create"));
            }

            return RedirectToAction("Create");
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            ProductViewModel pvm = new ProductViewModel(product) { ListCategories = new SelectList(db.Categories, "CategoryID", "CategoryType") };
            if (pvm == null)
            {
                return HttpNotFound();
            }
            return View(pvm);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(Product product, Category category)
        {
            if (product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var tempProduct = db.Products.Find(product.ProductID);

            try
            {
                Category tempCat = db.Categories.Find(int.Parse(category.CategoryType));
                if (tempCat == null)
                {
                    ModelState.AddModelError("", "Kan categorie niet vinden.");
                    return RedirectToAction("Edit");
                }

                tempProduct.Price = DoubleExtension.ConvertInput(Request.Form["PriceTextbox"]);
                tempProduct.Category = tempCat;

                if (TryUpdateModel(tempProduct, "", new string[] { "ConsumableType", "Name", "VAT", "Availability", "Category" }))
                {
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch (DataException Dex)
            {
                ModelState.AddModelError("", "Kan de wijzigingen niet opslaan. Probeer het opnieuw en neem contact op met uw systeembeheerder als het probleem zich blijft voordoen.");
                return View("Error", new HandleErrorInfo(Dex, "Product", "Create"));
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}