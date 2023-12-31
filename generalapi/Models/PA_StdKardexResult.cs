﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class PA_StdKardexResult
    {
        public decimal karid { get; set; }
        public string Codigo { get; set; }
        public string Articulo { get; set; }
        public string Referencia { get; set; }
        public string Depencencia { get; set; }
        public string Medida { get; set; }
        public string Documento { get; set; }
        public DateTime FechaMov { get; set; }
        public string TIPOMOV { get; set; }
        public string Tercero { get; set; }
        public decimal CantidadEnt { get; set; }
        public decimal CostoEnt { get; set; }
        public decimal? Debe { get; set; }
        public decimal CantidadSal { get; set; }
        public decimal CostoSal { get; set; }
        public decimal? Haber { get; set; }
        public decimal CantidadActual { get; set; }
        public decimal CostoPonderado { get; set; }
        public decimal? CostoTotal { get; set; }
        public string DocContable { get; set; }
        [Column("Fecha Servidor")]
        public DateTime FechaServidor { get; set; }
        public string Usuario { get; set; }
        public string Estación { get; set; }
        public string Marca { get; set; }
        public string Linea { get; set; }
        public string Grupo { get; set; }
        [Column("Serial/Lote")]
        public string SerialLote { get; set; }
        public string Imei { get; set; }
        public string Iccd { get; set; }
    }
}
