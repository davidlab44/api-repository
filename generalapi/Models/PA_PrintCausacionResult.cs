﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class PA_PrintCausacionResult
    {
        public string PRONOM { get; set; }
        public string NROCXP { get; set; }
        public string NROFAC { get; set; }
        public string SUMA { get; set; }
        public string DETALLE { get; set; }
        public decimal VLRFAC { get; set; }
        public string FECHAFAC { get; set; }
        public string FECHAVENCE { get; set; }
        public string FECHAIMPRESION { get; set; }
        public string CODIGOS { get; set; }
        public string CUENTAS { get; set; }
        public decimal? DEBITOS { get; set; }
        public decimal? CREDITOS { get; set; }
        public string SUBCCOSTO { get; set; }
        public string Tipo { get; set; }
        public decimal TOTALAPAGAR { get; set; }
        public string usuario { get; set; }
    }
}
