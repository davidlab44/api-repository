﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Glapp_SP_GetInventoryCountConsolidatedResult
    {
        public long InventoryCountID { get; set; }
        public string ArticleCode { get; set; }
        public string ArticleDescription { get; set; }
        public decimal Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public DateTime LastCountDate { get; set; }
        public string LastCountingUser { get; set; }
    }
}
