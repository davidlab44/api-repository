﻿#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace generalapi2.Models
{
    public partial class SISMEDICAERPContext : DbContext
    {
        public SISMEDICAERPContext()
        {
        }

        public SISMEDICAERPContext(DbContextOptions<SISMEDICAERPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GlappDrugsDeliveryConfirmation> GlappDrugsDeliveryConfirmations { get; set; }
        public virtual DbSet<GlappDrugsDeliveryConsumption> GlappDrugsDeliveryConsumptions { get; set; }
        public virtual DbSet<GlappDrugsDeliveryConsumptionDet> GlappDrugsDeliveryConsumptionDets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_1xCompat_CP850_CI_AS");


            modelBuilder.Entity<APP_SP_DrugsDeliveryConsumerViewHeaderResult>(entity =>
            {
                entity.HasKey(e => e.License)
                    .HasName("PK__products__1E5A0B8E2D96C866");
                //entity.ToTable("acccccxc");
                //entity.
                entity.Property(e => e.License).HasColumnName("License");
                /*
                entity.Property(e => e.Consumer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Consumer");
                */
            });

            modelBuilder.Entity<APP_SP_DrugsDeliveryConsumerViewArticlesResult>(entity =>
            {
                entity.HasKey(e => e.ArticleCode)
                    .HasName("PK__products__1E5A0B8E2D96C866");
                //entity.ToTable("acccccxc");
                //entity.
                entity.Property(e => e.ArticleCode).HasColumnName("ArticleCode");
                /*
                entity.Property(e => e.Consumer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Consumer");
                */
            });

            modelBuilder.Entity<GlappDrugsDeliveryConfirmation>(entity =>
            {
                entity.HasKey(e => e.ConfirmationId)
                    .HasName("PK_glapp_drugs_confirmation_id");

                entity.Property(e => e.ConfirmationId).HasColumnName("ConfirmationID");

                entity.Property(e => e.ArticleCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmerUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryConfirmationComments)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryConfirmationDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryConfirmationImageUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RestockId).HasColumnName("RestockID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PENDING')");

                entity.Property(e => e.UnitOfMeasure)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GlappDrugsDeliveryConsumption>(entity =>
            {
                entity.HasKey(e => e.ConsumptionId)
                    .HasName("PK_glapp_drugs_consumption_id");

                entity.ToTable("GlappDrugsDeliveryConsumption");

                entity.Property(e => e.ConsumptionId).HasColumnName("ConsumptionID");

                entity.Property(e => e.ConsumerUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RestockId).HasColumnName("RestockID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PENDING')");

                entity.Property(e => e.Vehicle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GlappDrugsDeliveryConsumptionDet>(entity =>
            {
                entity.HasKey(e => e.ConsumptionDetailId)
                    .HasName("PK_glapp_drugs_consumption_det_id");

                entity.ToTable("GlappDrugsDeliveryConsumptionDet");

                entity.Property(e => e.ConsumptionDetailId).HasColumnName("ConsumptionDetailID");

                entity.Property(e => e.ArticleCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumptionId).HasColumnName("ConsumptionID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Delivered).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnitOfMeasure)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
                /*
                entity.HasOne(d => d.Consumption)
                    .WithMany(p => p.GlappDrugsDeliveryConsumptionDets)
                    .HasForeignKey(d => d.ConsumptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GlappDrug__Consu__325CDC32");
                */
            });

            OnModelCreatingGeneratedProcedures(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        public DbSet<generalapi2.Models.APP_SP_DrugsDeliveryConsumerViewHeaderResult> APP_SP_DrugsDeliveryConsumerViewHeaderResult { get; set; }
        public DbSet<generalapi2.Models.APP_SP_DrugsDeliveryConsumerViewArticlesResult> APP_SP_DrugsDeliveryConsumerViewArticlesResult { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}