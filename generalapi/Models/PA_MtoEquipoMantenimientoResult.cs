﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class PA_MtoEquipoMantenimientoResult
    {
        public int CodigoEquipo { get; set; }
        public string CodigoMto { get; set; }
        public string TipoMto { get; set; }
        public decimal CondKms { get; set; }
        public decimal CondHrs { get; set; }
        public int CondMov { get; set; }
        public string CondFecha { get; set; }
        public string CondFechaTemp { get; set; }
        public string Estado { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
