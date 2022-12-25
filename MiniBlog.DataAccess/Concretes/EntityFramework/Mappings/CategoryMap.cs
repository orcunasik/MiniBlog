﻿using MiniBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            HasKey(c => c.Id);
            Property(c =>c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c =>c.Name).IsRequired().HasMaxLength(15);
            ToTable("Categories");
        }
    }
}