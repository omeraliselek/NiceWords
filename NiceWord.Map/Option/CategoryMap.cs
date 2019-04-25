using NiceWord.Core.Map;
using NiceWord.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceWord.Map.Option
{
    public class CategoryMap:CoreMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");
            Property(x => x.Name).IsOptional();
            Property(x => x.Description).IsOptional();

            HasMany(x => x.Sayings)//Birden fazla ürünü olacaktır.
                .WithRequired(x => x.Category)//Bir ürünün bir kategorisi olur.
                .HasForeignKey(x => x.CategoryID);
        }
    }
}
