﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class proc_FormulasResult
    {
        public string CodArt { get; set; }
        public string Nombre { get; set; }
        public string Medida { get; set; }
        public string Costo { get; set; }
        public string Marca { get; set; }
        public string Linea { get; set; }
        public bool? Seleccion { get; set; }
        public decimal? cantidadTotal { get; set; }
    }
}