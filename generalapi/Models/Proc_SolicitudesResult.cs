﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Proc_SolicitudesResult
    {
        public string TipoSol { get; set; }
        public string Empleado { get; set; }
        public DateTime fecharegistro { get; set; }
        public DateTime fechaini { get; set; }
        public DateTime horaini { get; set; }
        public DateTime fechafin { get; set; }
        public DateTime horafin { get; set; }
        public string motivo { get; set; }
        public int id { get; set; }
        public DateTime reingreso { get; set; }
        public string Observaciones { get; set; }
    }
}
