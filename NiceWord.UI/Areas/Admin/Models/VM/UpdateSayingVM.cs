using NiceWord.Model.Option;
using NiceWord.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NiceWord.UI.Areas.Admin.Models.VM
{
    public class UpdateSayingVM
    {
        public UpdateSayingVM()
        {
            AppUsers = new List<AppUser>();
            Categories = new List<Category>();
            Sayings = new SayingDTO();
        }

        public List<AppUser> AppUsers { get; set; }
        public List<Category> Categories { get; set; }
        public SayingDTO Sayings { get; set; }
    }
}