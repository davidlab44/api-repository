﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Proc_LiquidacionResult
    {
        public string nomNomb { get; set; }
        public string Empleado { get; set; }
        public DateTime? novini { get; set; }
        public DateTime? novfin { get; set; }
        public string nomCod { get; set; }
        public int novcst { get; set; }
        public int novdsp { get; set; }
        public string ESTADO { get; set; }
        public decimal? VlrDev { get; set; }
        public decimal? VlrDed { get; set; }
        public decimal? NetoP { get; set; }
        public string NovEmp { get; set; }
        public DateTime? HisFecLiq { get; set; }
        public string documento_liq { get; set; }
        public string fuente_liq { get; set; }
        public string documento_aporte_ley { get; set; }
        public string fuente_aporte_ley { get; set; }
        public string documento_parafiscales { get; set; }
        public string fuente_parafiscales { get; set; }
        public string documento_provesiones { get; set; }
        public string fuente_provesiones { get; set; }
        public string Tipo_Liquidacion { get; set; }
    }
}
