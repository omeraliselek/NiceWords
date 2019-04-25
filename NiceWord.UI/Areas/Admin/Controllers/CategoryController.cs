using NiceWord.Model.Option;
using NiceWord.Service.Option;
using NiceWord.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NiceWord.UI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
 
    {
        CategoryService _CategoryService;

        public CategoryController()
        {
            _CategoryService = new CategoryService();
        }

       
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category data)
        {
            _CategoryService.Add(data);
            return Redirect("/Admin/Category/List");
        }

        public ActionResult List()
        {
            List<Category> model = _CategoryService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            Category cat = _CategoryService.GetByID(id);
            CategoryDTO model = new CategoryDTO();
            model.ID = cat.ID;
            model.Name = cat.Name;
            model.Description = cat.Description;
            return View(model);

           
        }

        [HttpPost]
        public ActionResult Update(CategoryDTO data)
        {
            Category cat = _CategoryService.GetByID(data.ID);
           cat.ID = data.ID;
            cat.Name = data.Name;
            cat.Description = data.Description;
            _CategoryService.Update(cat);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/Category/List");
        }

        public ActionResult Delete(Guid id)
        {
            _CategoryService.Remove(id);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/Category/List");

        }


    }
}