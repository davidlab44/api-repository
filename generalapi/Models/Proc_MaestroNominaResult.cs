﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Proc_MaestroNominaResult
    {
        public string codigo { get; set; }
        public string Bandera { get; set; }
        public string Tnomina { get; set; }
        public DateTime? Fecinicial { get; set; }
        public DateTime? Fecfinal { get; set; }
        public decimal? Tdevengados { get; set; }
        public decimal? Tdeducciones { get; set; }
        public decimal? NaPagar { get; set; }
    }
}
