﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Proc_Novedades_MasivasResult
    {
        public decimal IdNovedad { get; set; }
        public string Concepto { get; set; }
        public string TipoNomina { get; set; }
        public DateTime FechaNovedad { get; set; }
        public decimal ValorNovedad { get; set; }
        public string Usuario { get; set; }
        public string Estacion { get; set; }
        public string CodConcepto { get; set; }
        public string CodNomina { get; set; }
        public string Documento { get; set; }
        public string Fuente { get; set; }
        public string Estado { get; set; }
        public string NomFuente { get; set; }
    }
}
