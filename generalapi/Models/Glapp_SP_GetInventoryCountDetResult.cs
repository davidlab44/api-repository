﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Glapp_SP_GetInventoryCountDetResult
    {
        public long CountId { get; set; }
        public long InventoryCountID { get; set; }
        public string ArticleCode { get; set; }
        public string CountingUser { get; set; }
        public decimal Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public string ModifiedDate { get; set; }
        public string ArticleDescription { get; set; }
        public string Barcode { get; set; }
    }
}
