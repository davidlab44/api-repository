﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Proc_Print_Factura_FTempoResult
    {
        public decimal id_unico { get; set; }
        public string NOMEMP { get; set; }
        public string NITEMP { get; set; }
        public string DIREMP { get; set; }
        public string TELEMP { get; set; }
        public string NroFac { get; set; }
        public string CIUEMP { get; set; }
        public string TIPODOC { get; set; }
        public string RESOLUCION { get; set; }
        public string NOMCLI { get; set; }
        public string CODCLI { get; set; }
        public string DIRCLI { get; set; }
        public decimal? SUBTOTALCAB { get; set; }
        public DateTime FECHA { get; set; }
        public decimal? IVA { get; set; }
        public decimal FLETE { get; set; }
        public string CLICIUD { get; set; }
        public DateTime? VENCIMIENTO { get; set; }
        public string TELCLI { get; set; }
        public string CVENDEDOR { get; set; }
        public string NRODOC { get; set; }
        public decimal CANART { get; set; }
        public string MEDART { get; set; }
        public string DESART { get; set; }
        public decimal? VUNART { get; set; }
        public decimal IVAART { get; set; }
        public decimal INCART { get; set; }
        public decimal? DSUBTOTAL { get; set; }
        public string OBSFAC { get; set; }
        public string detalle { get; set; }
        public int rtiva { get; set; }
        public int rtica { get; set; }
        public int rtfte { get; set; }
        public decimal? TOTAL { get; set; }
        public decimal TCambio { get; set; }
        public decimal? VLRDESCUENTO { get; set; }
        public string codart { get; set; }
        public int Anticipos { get; set; }
        public decimal? saldo { get; set; }
        public decimal AntFactura { get; set; }
        public string numeroPedido { get; set; }
        public string TipoFactura { get; set; }
        public string OTNumero { get; set; }
        public decimal Impoconsumo { get; set; }
        public string regimen { get; set; }
        public string Email { get; set; }
        public string CUFE { get; set; }
        public string MedioPago { get; set; }
        public string CodigoQR { get; set; }
        public string FormaPago { get; set; }
        public string MontoEscrito { get; set; }
        public long? secuencia { get; set; }
        public DateTime FechaAprobado { get; set; }
        public string Firma { get; set; }
        public string TipoMov { get; set; }
        public string CODART { get; set; }
        public string logempresa { get; set; }
        public string CLIMAIL { get; set; }
        public string Estado { get; set; }
        public decimal VALORIVA { get; set; }
        public decimal VALORINC { get; set; }
        public string NomFiducia { get; set; }
        public string NomTitular { get; set; }
        public string DirTitular { get; set; }
        public string CiudadTitular { get; set; }
        public string TipoReporte { get; set; }
    }
}
