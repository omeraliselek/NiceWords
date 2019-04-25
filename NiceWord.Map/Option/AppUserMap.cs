﻿using NiceWord.Core.Map;
using NiceWord.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceWord.Map.Option
{
    public class AppUserMap:CoreMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("dbo.Users");
            Property(x => x.Address).HasMaxLength(150).IsOptional();
            Property(x => x.Birthdate).HasColumnType("datetime2").IsOptional();
            Property(x => x.Email).HasMaxLength(90).IsOptional();
            Property(x => x.ImagePath).IsOptional();
            Property(x => x.UserName).HasMaxLength(50).IsRequired();
            Property(x => x.Password).HasMaxLength(50).IsRequired();
            Property(x => x.Role).IsOptional();
            Property(x => x.FirstName).HasMaxLength(50).IsOptional();
            Property(x => x.LastName).HasMaxLength(50).IsOptional();
        }
    }
}
