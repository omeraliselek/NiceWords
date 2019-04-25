using NiceWord.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NiceWord.UI.Areas.Admin.Models.VM
{
    public class AddSayingVM:BaseVM
    {
        public AddSayingVM()
        {
            AppUsers = new List<AppUser>();
            Categories = new List<Category>();
            Sayings = new List<Saying>();
        }

        public List<AppUser> AppUsers { get; set; }
        public List<Category> Categories { get; set; }
        public List<Saying> Sayings { get; set; }
    }
}