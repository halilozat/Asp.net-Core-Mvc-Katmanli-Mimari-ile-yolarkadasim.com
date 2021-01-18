using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YolArkadasim.Entities.Concrete;

namespace YolArkadasim.Data.Concrete.EntityFramework.Mappings
{
    public class CityMap: IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(c => c.CityId);
            
            builder.Property(c => c.CityName).IsRequired();
            builder.Property(c => c.CityName).HasMaxLength(50);
            builder.HasIndex(c => c.CityName).IsUnique(); //zaten var mı?
            builder.ToTable("Cities");

        }
    }
}
