﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mix.Cms.Lib.Enums;
using Mix.Cms.Lib.Models.Cms;

namespace Mix.Cms.Lib.Models.EntityConfigurations.MySQL
{
    public class MixDatabaseDataAssociationConfiguration : IEntityTypeConfiguration<MixDatabaseDataAssociation>
    {
        public void Configure(EntityTypeBuilder<MixDatabaseDataAssociation> entity)
        {
            entity.HasKey(e => new { e.Id, e.Specificulture })
                    .HasName("PRIMARY");

            entity.ToTable("mix_database_data_association");

            entity.Property(e => e.Id)
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_unicode_ci");

            entity.Property(e => e.Specificulture)
                .HasColumnType("varchar(10)")
                .HasCharSet("utf8")
                .HasCollation("utf8_unicode_ci");

            entity.Property(e => e.MixDatabaseName)
                .HasColumnType("varchar(250)")
                .HasCharSet("utf8")
                .HasCollation("utf8_unicode_ci");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_unicode_ci");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

            entity.Property(e => e.DataId)
                .IsRequired()
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_unicode_ci");

            entity.Property(e => e.Description)
                .HasColumnType("varchar(450)")
                .HasCharSet("utf8")
                .HasCollation("utf8_unicode_ci");

            entity.Property(e => e.LastModified).HasColumnType("datetime");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_unicode_ci");

            entity.Property(e => e.ParentId)
                .IsRequired()
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_unicode_ci");

            entity.Property(e => e.ParentType)
                .IsRequired()
                .HasConversion(new EnumToStringConverter<MixDatabaseParentType>())
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_unicode_ci");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasConversion(new EnumToStringConverter<MixContentStatus>())
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_unicode_ci");
        }
    }
}