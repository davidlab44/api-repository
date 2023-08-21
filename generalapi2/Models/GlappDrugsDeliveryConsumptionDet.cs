﻿#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi2.Models
{
    public partial class GlappDrugsDeliveryConsumptionDet
    {
        public long ConsumptionDetailId { get; set; }
        public long ConsumptionId { get; set; }
        [NotMapped]
        public string ArticleCode { get; set; }
        public decimal Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal? Delivered { get; set; }
        /*
        public long ConsumptionDetailId { get; set; }
        public long ConsumptionId { get; set; }
        public string ArticleCode { get; set; }
        public decimal Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal? Delivered { get; set; }

        //public virtual GlappDrugsDeliveryConsumption Consumption { get; set; }
        */
    }
}