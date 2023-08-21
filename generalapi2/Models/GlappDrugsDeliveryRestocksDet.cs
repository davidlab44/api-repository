﻿
#nullable disable
using System;
using System.Collections.Generic;

namespace generalapi2.Models
{
    public partial class GlappDrugsDeliveryRestocksDet
    {
        public long RestockDetailId { get; set; }
        public long RestockId { get; set; }
        public string ArticleCode { get; set; }
        public decimal Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal? Delivered { get; set; }

        //public virtual GlappDrugsDeliveryRestock Restock { get; set; }
    }
}