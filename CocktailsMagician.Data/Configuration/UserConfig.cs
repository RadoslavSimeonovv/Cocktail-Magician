﻿using CocktailsMagician.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailsMagician.Data.Configuration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.UserName).IsRequired().HasMaxLength(50);
            builder.HasIndex(u => u.UserName).IsUnique();
            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(25);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(25);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(50);

        }
    }
}
