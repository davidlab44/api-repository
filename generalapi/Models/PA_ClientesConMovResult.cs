﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class PA_ClientesConMovResult
    {
        public string Clinit { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Vendedor { get; set; }
        public string Zona { get; set; }
        public decimal? SaldoCupo { get; set; }
        public string Contacto { get; set; }
        public string NomEmpresa { get; set; }
        public string NitEmpresa { get; set; }
        public string CliCod { get; set; }
        public string ACTIVIDAD { get; set; }
        public string REGIMEN { get; set; }
        public string TIPO_PERSONA { get; set; }
        public string MOTIVO { get; set; }
        public DateTime UltiCompra { get; set; }
        public string NOMCORTOACT { get; set; }
        public bool? seleccion { get; set; }
        public string TipoPA_Provee { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaRetiro { get; set; }
        public int? MesesCautivos { get; set; }
        public int? AñosCautivos { get; set; }
    }
}