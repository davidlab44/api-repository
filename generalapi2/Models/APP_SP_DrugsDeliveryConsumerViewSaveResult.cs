using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi2.Models
{
    public partial class APP_SP_DrugsDeliveryConsumerViewSaveResult
    {
        public string? P_ConsumerUser { get; set; }
        public string? P_Vehicle { get; set; }
        public string? P_DrugsConsumptionDetail { get; set; }
        //public string CODIGO { get; set; }
        //public long ConsumptionDetailId { get; set; }
        //public long ConsumptionId { get; set; }
        //public string ArticleCode { get; set; }
        //public decimal Quantity { get; set; }
        //public string UnitOfMeasure { get; set; }
        //public DateTime CreationDate { get; set; }
        //public decimal? Delivered { get; set; }
    }
}
