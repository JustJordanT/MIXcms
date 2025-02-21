﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mix.Cms.Lib.Enums;
using Mix.Cms.Lib.Models.Cms;

namespace Mix.Cms.Lib.Models.EntityConfigurations.MSSQL
{
    public class MixDatabaseDataValueConfiguration : IEntityTypeConfiguration<MixDatabaseDataValue>
    {
        public void Configure(EntityTypeBuilder<MixDatabaseDataValue> entity)
        {
            entity.HasKey(e => new { e.Id, e.Specificulture })
                    .HasName("PK_mix_database_data_value");

            entity.ToTable("mix_database_data_value");

            entity.HasIndex(e => e.DataId);

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("Vietnamese_CI_AS");

            entity.Property(e => e.MixDatabaseColumnName)
                .IsRequired()
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("Vietnamese_CI_AS");

            entity.Property(e => e.MixDatabaseName)
                .HasColumnType("nvarchar(250)")
                .HasCharSet("utf8")
                .HasCollation("Vietnamese_CI_AS");

            entity.Property(e => e.BooleanValue).HasColumnType("bit");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("Vietnamese_CI_AS");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

            entity.Property(e => e.DataId)
                .IsRequired()
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("Vietnamese_CI_AS");

            entity.Property(e => e.DateTimeValue).HasColumnType("datetime");

            entity.Property(e => e.EncryptKey)
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("Vietnamese_CI_AS");

            entity.Property(e => e.EncryptValue)
                .HasColumnType("ntext")
                .HasCharSet("utf8")
                .HasCollation("Vietnamese_CI_AS");

            entity.Property(e => e.LastModified).HasColumnType("datetime");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("Vietnamese_CI_AS");

            entity.Property(e => e.Regex)
                .HasColumnType("nvarchar(250)")
                .HasCharSet("utf8")
                .HasCollation("Vietnamese_CI_AS");

            entity.Property(e => e.Specificulture)
                .IsRequired()
                .HasColumnType("varchar(10)")
                .HasCharSet("utf8")
                .HasCollation("Vietnamese_CI_AS");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasConversion(new EnumToStringConverter<MixContentStatus>())
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("Vietnamese_CI_AS");

            entity.Property(e => e.DataType)
                .IsRequired()
                .HasConversion(new EnumToStringConverter<MixDataType>())
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("Vietnamese_CI_AS");

            entity.Property(e => e.StringValue)
                .HasColumnType("ntext")
                .HasCharSet("utf8")
                .HasCollation("Vietnamese_CI_AS");
        }
    }
}