﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Proc_Imprimir_DevResult
    {
        public string devnro { get; set; }
        public string devcli { get; set; }
        public DateTime devfec { get; set; }
        public string devdet { get; set; }
        public string devart { get; set; }
        public decimal devcan { get; set; }
        public string devdoc { get; set; }
        public string devtip { get; set; }
        public string clinom { get; set; }
        public decimal? Precio { get; set; }
        public decimal? ccivadev { get; set; }
        public decimal? IvaArt { get; set; }
        public decimal Retefuente { get; set; }
        public decimal ReteIva { get; set; }
        public decimal ReteIca { get; set; }
        public decimal ReteCree { get; set; }
        public decimal? totalIMP { get; set; }
        public decimal? totalVA { get; set; }
    }
}
