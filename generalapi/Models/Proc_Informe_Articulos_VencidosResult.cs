﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Proc_Informe_Articulos_VencidosResult
    {
        public string Codigo { get; set; }
        public string ESPECIFI { get; set; }
        public string REFERENCIA { get; set; }
        public string MARCA { get; set; }
        public string Linea { get; set; }
        public string DES { get; set; }
        public string MEDIDA { get; set; }
        public string Dependencia { get; set; }
        public decimal ArIva { get; set; }
        public string Lote { get; set; }
        public decimal Existencia { get; set; }
        public decimal? Existencia_Lote { get; set; }
        public decimal Arventa { get; set; }
        public DateTime Fecha_Vence { get; set; }
        public int? DiasPorVencer { get; set; }
        public decimal Costo { get; set; }
    }
}