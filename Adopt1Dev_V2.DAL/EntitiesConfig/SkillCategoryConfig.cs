using Adopt1Dev_V2.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt1Dev_V2.DAL.EntitiesConfig
{
    class SkillCategoryConfig : IEntityTypeConfiguration<SkillCategory>
    {
        public void Configure(EntityTypeBuilder<SkillCategory> builder)
        {
            builder.ToTable(nameof(SkillCategory));

            builder.HasKey(sc => sc.SkillCategoryId);

            builder.Property(sc => sc.Name)
                .HasMaxLength(255)
                .IsRequired();

            builder.HasMany(sc => sc.Skills)
                .WithMany(sk => sk.SkillCategories);

            builder.HasIndex(sc => sc.Name)
                .IsUnique();
        }
    }
}
