﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class spOITParametrosResult
    {
        public string TipoDocumento { get; set; }
        public string Identificacion { get; set; }
        public string DigitoVerificacion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string NitPTE { get; set; }
        public int? TipoPersona { get; set; }
        public string Regimen { get; set; }
        public string CodigoPostal { get; set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string RegistroMercantil { get; set; }
        public bool CreatedApi { get; set; }
    }
}
