using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NiceWord.UI.Areas.Admin.Models.DTO
{
    public class SayingDTO:BaseDTO
    {
        public string Detail { get; set; }
        public string ImagePath { get; set; }

        public Guid CategoryID { get; set; }
        public Guid AppUserID { get; set; }
    }
}