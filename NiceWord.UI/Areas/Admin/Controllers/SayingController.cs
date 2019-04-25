using NiceWord.DAL.Context;
using NiceWord.Model.Option;
using NiceWord.Service.Option;
using NiceWord.UI.Areas.Admin.Models.DTO;
using NiceWord.UI.Areas.Admin.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NiceWord.UI.Areas.Admin.Controllers
{
    public class SayingController : Controller
    {
        public CategoryService _categoryService;
        public AppUserService _appUserService;
        public SayingService _sayingService;

        public SayingController()
        {
           _categoryService = new CategoryService();
            _appUserService = new AppUserService();
            _sayingService = new SayingService();
        }
        
        // GET: Admin/Saying
        public ActionResult Add()
        {
            AddSayingVM model = new AddSayingVM()
            {

                Categories = _categoryService.GetActive(),
               AppUsers = _appUserService.GetActive(),
                Sayings = _sayingService.GetActive(),

            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Saying data)
        {
          _sayingService.Add(data);
      return Redirect("/Admin/Saying/List");
        }

        public ActionResult List()
        {
            List<Saying> model = _sayingService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            UpdateSayingVM model = new UpdateSayingVM();

            Saying saying = _sayingService.GetByID(id);
            model.Sayings.ID = saying.ID;
            model.Sayings.Detail = saying.Detail;
            model.Sayings.ImagePath = saying.ImagePath;
            model.Categories = _categoryService.GetActive();
            model.AppUsers = _appUserService.GetActive();
           

            return View(model);


        }

        [HttpPost]
        public ActionResult Update(SayingDTO data)
        {
            Saying saying = _sayingService.GetByID(data.ID);
            saying.ID = data.ID;
            saying.Detail = data.Detail;
            saying.ImagePath = data.ImagePath;
            saying.CategoryID = data.CategoryID;
            saying.AppUserID = data.AppUserID;
            

            _sayingService.Update(saying);

            return Redirect("/Admin/Saying/List");
        }

        public ActionResult Delete(Guid id)
        {
            _sayingService.Remove(id);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/Saying/List");
        }
    }
}