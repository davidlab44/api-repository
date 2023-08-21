using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi2.Models
{
    public partial class APP_SP_DrugsDeliveryConsumerViewArticlesResult
    {
        public string ArticleCode { get; set; }
        public string ArticleDescription { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal? QuantityAvailable { get; set; }
        public decimal? QuantityToStock { get; set; }
        public int? QuantityConsumed { get; set; }
    }
}
