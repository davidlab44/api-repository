﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class PA_ProgMantenimientoResult
    {
        public string Dprcodact { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaLectura { get; set; }
        public string TipoLectura { get; set; }
        public decimal LecturaK { get; set; }
        public decimal LecturaH { get; set; }
        public decimal LecturaM { get; set; }
        public decimal AcumuladoK { get; set; }
        public decimal AcumuladoH { get; set; }
        public decimal AcumuladoM { get; set; }
        public string Conductor { get; set; }
        public string Cliente { get; set; }
        public string Observacion { get; set; }
    }
}