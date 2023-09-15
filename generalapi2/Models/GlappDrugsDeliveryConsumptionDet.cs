#nullable disable
using System;
using System.Collections.Generic;

namespace generalapi2.Models
{
    public partial class GlappDrugsDeliveryConsumptionDet
    {
        public long consumptionDetailId { get; set; }
        public long consumptionId { get; set; }
        public string articleCode { get; set; }
        public int quantity { get; set; }
        public string unitOfMeasure { get; set; }
        public DateTime creationDate { get; set; }
        public int? delivered { get; set; }
    }
}