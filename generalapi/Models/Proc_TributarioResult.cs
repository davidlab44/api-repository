﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Proc_TributarioResult
    {
        public string RetPuc { get; set; }
        public string RetNom { get; set; }
        public decimal? RetPor { get; set; }
        public decimal RetMon { get; set; }
        public string TerNit { get; set; }
        public string TerNom { get; set; }
        public string NroFac { get; set; }
        public DateTime? FecFac { get; set; }
        public decimal? Base { get; set; }
        public decimal? ValorRetenido { get; set; }
    }
}