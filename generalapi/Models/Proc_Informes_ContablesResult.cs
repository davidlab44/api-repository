﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Proc_Informes_ContablesResult
    {
        public string glCod { get; set; }
        public string glnum { get; set; }
        public decimal? glSaldoIni { get; set; }
        public decimal? Debe { get; set; }
        public decimal? Haber { get; set; }
        public decimal? SaldoFin { get; set; }
        public string GRUPO { get; set; }
        public string Clasificacion { get; set; }
    }
}