﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Glapp_SP_DrugsDeliveryRestocksArticlesResult
    {
        public string ArticleCode { get; set; }
        public string ArticleDescription { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal? QuantityAvailable { get; set; }
        public decimal? QuantityToStock { get; set; }
        public int? QuantityConsumed { get; set; }
    }
}
