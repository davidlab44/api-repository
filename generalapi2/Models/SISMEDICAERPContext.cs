
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
//using TemplateBorrar1.Models;
//using TemplateBorrar1.Models;

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
        public virtual DbSet<GlappDrugsDeliveryRestock> GlappDrugsDeliveryRestocks { get; set; }
        public virtual DbSet<GlappDrugsDeliveryRestocksDet> GlappDrugsDeliveryRestocksDets { get; set; }


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
                /*
                entity.ToTable("GlappDrugsDeliveryConsumptionDet");


                entity.Property(e => e.ConsumptionDetailId).HasColumnName("ConsumptionDetailId");

                entity.Property(e => e.ArticleCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumptionId).HasColumnName("ConsumptionId");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Delivered).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnitOfMeasure)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
                */
                /*
                entity.HasOne(d => d.Consumption)
                    .WithMany(p => p.GlappDrugsDeliveryConsumptionDets)
                    .HasForeignKey(d => d.ConsumptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GlappDrug__Consu__325CDC32");
                */
            });

            modelBuilder.Entity<GlappDrugsDeliveryRestock>(entity =>
            {
                entity.HasKey(e => e.RestockId)
                    .HasName("PK_glapp_drugs_restock_id");

                entity.Property(e => e.RestockId).HasColumnName("RestockID");

                entity.Property(e => e.ConfirmerUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Consecutive)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeliveryConfirmationComments)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryConfirmationDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryConfirmationImageUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RestockerUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

            modelBuilder.Entity<GlappDrugsDeliveryRestocksDet>(entity =>
            {
                entity.HasKey(e => e.RestockDetailId)
                    .HasName("PK_glapp_drugs_restock_det_id");
                /*
                entity.ToTable("GlappDrugsDeliveryRestocksDet");

                entity.Property(e => e.RestockDetailId).HasColumnName("RestockDetailID");

                entity.Property(e => e.ArticleCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Delivered).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RestockId).HasColumnName("RestockID");

                entity.Property(e => e.UnitOfMeasure)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
                */
                /*
                entity.HasOne(d => d.Restock)
                    .WithMany(p => p.GlappDrugsDeliveryRestocksDets)
                    .HasForeignKey(d => d.RestockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GlappDrug__Resto__3AF22233");
                */
            });









            //STORED PROCEDURES

            modelBuilder.Entity<Glapp_SP_DrugsDeliveryRestocksArticlesResult>(entity =>
            {
                entity.HasNoKey();
                /*
                entity.HasKey(e => e.ArticleCode)
                    .HasName("PK__products__1E5A0B8E2D96C866");
                //entity.ToTable("acccccxc");
                //entity.
                entity.Property(e => e.ArticleCode).HasColumnName("ArticleCode");
                */
                /*
                entity.Property(e => e.Consumer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Consumer");
                */
            });

            modelBuilder.Entity<Glapp_SP_DrugsDeliveryRestocksHeaderResult>(entity =>
            {
                entity.HasNoKey();
                /*
                entity.HasKey(e => e.License)
                    .HasName("PK__products__1E5A0B8E2D96C866");
                //entity.ToTable("acccccxc");
                //entity.
                entity.Property(e => e.License).HasColumnName("License");
                */
                /*
                entity.Property(e => e.Consumer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Consumer");
                */
            });
            
            modelBuilder.Entity<Glapp_SP_DrugsDeliveryRestocksResult>(entity =>
            {
                entity.HasNoKey();
                /*
                entity.HasKey(e => e.RestockID)
                    .HasName("PK__products__1E5A0B8E2D96C866");
                //entity.ToTable("acccccxc");
                //entity.
                entity.Property(e => e.RestockID).HasColumnName("RestockID");
                */
                /*
                entity.Property(e => e.Consumer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Consumer");
                */
            });

            modelBuilder.Entity<APP_SP_DrugsDeliveryConsumerViewSaveResult>(entity =>
            {
                //entity.HasNoKey();
                entity.HasKey(e => e.P_DrugsConsumptionDetail).HasName("PK__products__1E5A0B8E2D96C866");
                //entity.ToTable("acccccxc");
                //entity.
                //entity.Property(e => e.RestockID).HasColumnName("RestockID");
                /*
                entity.Property(e => e.Consumer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Consumer");
                */
            });

            modelBuilder.Entity<Glapp_SP_DrugsDeliveryConfirmationResult>(entity =>
            {
                //entity.HasNoKey();
                entity.HasKey(e => e.MENSAJE).HasName("PK__products__1E5A0B8E2D96C866");
                //entity.ToTable("acccccxc");
                //entity.
                //entity.Property(e => e.RestockID).HasColumnName("RestockID");
                /*
                entity.Property(e => e.Consumer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Consumer");
                */
            });

            OnModelCreatingGeneratedProcedures(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }
        public DbSet<generalapi2.Models.Glapp_SP_DrugsDeliveryRestocksArticlesResult> Glapp_SP_DrugsDeliveryRestocksArticlesResult { get; set; }
        public DbSet<generalapi2.Models.Glapp_SP_DrugsDeliveryRestocksHeaderResult> Glapp_SP_DrugsDeliveryRestocksHeaderResult { get; set; }
        public DbSet<generalapi2.Models.Glapp_SP_DrugsDeliveryRestocksResult> Glapp_SP_DrugsDeliveryRestocksResult { get; set; }
        public DbSet<generalapi2.Models.APP_SP_DrugsDeliveryConsumerViewArticlesResult> APP_SP_DrugsDeliveryConsumerViewArticlesResult { get; set; }
        public DbSet<generalapi2.Models.APP_SP_DrugsDeliveryConsumerViewHeaderResult> APP_SP_DrugsDeliveryConsumerViewHeaderResult { get; set; }
        public DbSet<generalapi2.Models.APP_SP_DrugsDeliveryConsumerViewSaveResult> APP_SP_DrugsDeliveryConsumerViewSaveResult { get; set; }
        public DbSet<generalapi2.Models.Glapp_SP_DrugsDeliveryConfirmationResult> Glapp_SP_DrugsDeliveryConfirmationResult { get; set; }








partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}