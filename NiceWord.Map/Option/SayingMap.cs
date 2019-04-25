using NiceWord.Core.Map;
using NiceWord.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceWord.Map.Option
{
    public class SayingMap:CoreMap<Saying>
    {
        public SayingMap()
        {
            ToTable("dbo.Sayings");

            Property(x => x.Detail).HasMaxLength(140).IsOptional();
            Property(x => x.ImagePath).IsOptional();
            HasRequired(x => x.Category)
                .WithMany(x => x.Sayings)
                .HasForeignKey(x => x.CategoryID)
                .WillCascadeOnDelete(true);//katerorisi silinirse Söz silinsin
        }

    }
}
