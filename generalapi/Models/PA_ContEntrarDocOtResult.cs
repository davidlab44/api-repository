﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class PA_ContEntrarDocOtResult
    {
        public string Codigo { get; set; }
        public string Cuenta { get; set; }
        public string Detalle { get; set; }
        public string DesCcosto { get; set; }
        public string Ccosto { get; set; }
        public string NomTercero { get; set; }
        public string Tercero { get; set; }
        public decimal? Debe { get; set; }
        public decimal? Haber { get; set; }
        public decimal RCcosto { get; set; }
        public string OT { get; set; }
        public string DetOT { get; set; }
        public int IdPCGA { get; set; }
        public int IdNIIF { get; set; }
        public decimal baseRete { get; set; }
        public decimal? porRete { get; set; }
        public string tipRete { get; set; }
        public decimal valorRete { get; set; }
        public string ciudRete { get; set; }
    }
}
