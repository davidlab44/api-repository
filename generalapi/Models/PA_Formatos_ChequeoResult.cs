﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class PA_Formatos_ChequeoResult
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string versionF { get; set; }
        public DateTime fechavigencia { get; set; }
        public string Tipo { get; set; }
        public string TipoFormato { get; set; }
        public int idTipoFormato { get; set; }
    }
}
