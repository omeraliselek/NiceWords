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
    public class AppUserController : Controller
    {
        AppUserService _appUserService;

        public AppUserController()
        {
            _appUserService = new AppUserService();
        }
        // GET: Admin/AppUser
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AppUser data)
        {
            _appUserService.Add(data);
            return Redirect("/Admin/AppUser/List");
        }

        public ActionResult List()
        {
            List<AppUser> model = _appUserService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            
            AppUser user = _appUserService.GetByID(id);
            AppUserDTO model = new AppUserDTO();
            model.ID = user.ID;
            model.FirstName = user.FirstName;
            model.LastName = user.LastName;
            model.Email = user.Email;
            model.Password = user.Password;
            model.UserName = user.UserName;
            model.Role = user.Role;

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(AppUserDTO data)
        {
           
            AppUser user = _appUserService.GetByID(data.ID);
            user.FirstName = data.FirstName;
            user.LastName = data.LastName;
            user.UserName = data.UserName;
            user.Email = data.Email;
            user.Password = data.Password;
            user.Role = data.Role;

           _appUserService.Update(user);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/AppUser/List");
        }

        public ActionResult Delete(Guid id)
        {
            _appUserService.Remove(id);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/AppUser/List");
            
        }


    }
}