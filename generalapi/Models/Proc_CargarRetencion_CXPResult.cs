﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Proc_CargarRetencion_CXPResult
    {
        public string LinCtaReteFte { get; set; }
        public string glnum { get; set; }
        public decimal glRetMonto { get; set; }
        public decimal? glRetPorcentaje { get; set; }
        public decimal? TOTAL { get; set; }
        public decimal? ValorRete { get; set; }
        public string SubCentro { get; set; }
        public string NomSubCentro { get; set; }
        public string MASTIPO { get; set; }
    }
}