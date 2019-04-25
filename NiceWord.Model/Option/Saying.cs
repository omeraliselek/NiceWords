using NiceWord.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceWord.Model.Option
{
    public class Saying:CoreEntity
    {
        public string Detail { get; set; }
        public string ImagePath { get; set; }
        public Guid CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public Guid AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
