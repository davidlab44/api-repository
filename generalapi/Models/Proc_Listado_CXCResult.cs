﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Proc_Listado_CXCResult
    {
        public string tipodoc { get; set; }
        public string codcli { get; set; }
        public string clinit { get; set; }
        public string clinom { get; set; }
        public string nrofac { get; set; }
        public string DETALLE { get; set; }
        public decimal saldo { get; set; }
        public DateTime? vencimiento { get; set; }
        public decimal valor { get; set; }
        public DateTime fecfac { get; set; }
        public string clitel { get; set; }
        public string clidir { get; set; }
        public decimal subtotal { get; set; }
        public decimal iva { get; set; }
        public int? ndias { get; set; }
        public decimal tCambio { get; set; }
    }
}