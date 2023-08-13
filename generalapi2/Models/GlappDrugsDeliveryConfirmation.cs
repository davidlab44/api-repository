﻿#nullable disable
using System;
using System.Collections.Generic;

namespace generalapi2.Models
{
    public partial class GlappDrugsDeliveryConfirmation
    {
        public long ConfirmationId { get; set; }
        public long? RestockId { get; set; }
        public string DeliveryConfirmationImageUrl { get; set; }
        public string DeliveryConfirmationComments { get; set; }
        public string ConfirmerUser { get; set; }
        public DateTime? DeliveryConfirmationDate { get; set; }
        public string Status { get; set; }
        public string ArticleCode { get; set; }
        public decimal Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
    }
}