﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class PA_OrdMovResult
    {
        public int Item { get; set; }
        public DateTime movfec { get; set; }
        public string movtip { get; set; }
        public string tracod { get; set; }
        public decimal movcan { get; set; }
        public decimal movvlr { get; set; }
        public int TipoLiq { get; set; }
        public int Facturable { get; set; }
    }
}
