﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class PA_CMISuspensionesResult
    {
        public int Id { get; set; }
        public string Empleado { get; set; }
        public string Cedula { get; set; }
        public string Cargo { get; set; }
        public DateTime Fecha { get; set; }
        [Column("Medida Correctiva")]
        public string MedidaCorrectiva { get; set; }
        public string Motivo { get; set; }
    }
}
