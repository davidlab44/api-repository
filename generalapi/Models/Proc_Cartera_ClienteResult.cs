﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Proc_Cartera_ClienteResult
    {
        public string nrofac { get; set; }
        public string tipodoc { get; set; }
        public string tipocli { get; set; }
        public string codcli { get; set; }
        public string fecfac { get; set; }
        public DateTime fecha { get; set; }
        public int? venfac { get; set; }
        public decimal? vlrfac { get; set; }
        public decimal? saldo { get; set; }
        public decimal? rtfte { get; set; }
        public decimal? rtica { get; set; }
        public decimal? abonof { get; set; }
        public decimal descuento { get; set; }
        public string recibo { get; set; }
        public string nota { get; set; }
        public DateTime? fechap { get; set; }
        public int? estado { get; set; }
        public int? cancelada { get; set; }
        public string concepto { get; set; }
        public decimal? subtotal { get; set; }
        public decimal? rtiva { get; set; }
        public bool? anulada { get; set; }
        public string nombre { get; set; }
        public decimal tmpAbonos { get; set; }
        public decimal tmpDescto { get; set; }
        public string codtipo { get; set; }
        public string nomtipo { get; set; }
        public string codigo { get; set; }
        public decimal tmprtfte { get; set; }
        public decimal tmprtiva { get; set; }
        public decimal tmprtica { get; set; }
        public string CliNit { get; set; }
        public decimal Anticipos { get; set; }
        public decimal tmpAnticipos { get; set; }
        public int? TipoFac { get; set; }
        public string FacturaNew { get; set; }
        public string fatcco { get; set; }
        public int? causado { get; set; }
        public decimal? Iva { get; set; }
        public int? DiasVence { get; set; }
        public string CodEscala { get; set; }
        public string VENDEDOR { get; set; }
        public decimal? VlrMora { get; set; }
        public decimal? CliDesAut { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? tcambio { get; set; }
        public decimal? rtcree { get; set; }
        public decimal? tmprtcree { get; set; }
        public decimal? TCambioNew { get; set; }
        public decimal VlrInteres { get; set; }
        public decimal tmpVlrInteres { get; set; }
        public int Puntos { get; set; }
        public int DiasVence2 { get; set; }
    }
}