﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Proc_Print_PedidosResult
    {
        public string NroFac { get; set; }
        public string tipodoc { get; set; }
        public DateTime? fecha { get; set; }
        public string HORA { get; set; }
        public string clicod { get; set; }
        public string CliDir { get; set; }
        public string cCliCiud { get; set; }
        public int? vence { get; set; }
        public string TipoFactura { get; set; }
        public string TelCli { get; set; }
        public string cVendedor { get; set; }
        public string arUbicacion { get; set; }
        public string CodArt { get; set; }
        public string LotNom { get; set; }
        public decimal canart { get; set; }
        public decimal Vunart { get; set; }
        public string desart { get; set; }
        public decimal costo { get; set; }
        public decimal ivaart { get; set; }
        public decimal? Vtoart { get; set; }
        public decimal? subtotal { get; set; }
        public decimal? vlrdescuento { get; set; }
        public decimal? Iva { get; set; }
        public decimal? total { get; set; }
        public string Detalle { get; set; }
        public decimal? tcambio { get; set; }
        public string nomemp { get; set; }
        public string nitemp { get; set; }
        public string Cliente { get; set; }
    }
}