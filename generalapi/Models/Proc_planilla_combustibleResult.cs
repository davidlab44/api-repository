﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Proc_planilla_combustibleResult
    {
        public string COMANDA { get; set; }
        public DateTime Fecha { get; set; }
        public int vehiculo { get; set; }
        public string pronom { get; set; }
        public string PRONIT1 { get; set; }
        public decimal TOTAL { get; set; }
        public string Proveedor { get; set; }
        public int Placa { get; set; }
        public int ID { get; set; }
        public string cxp { get; set; }
        public DateTime fechacxp { get; set; }
        public decimal kilometraje { get; set; }
        public string estado_nombre { get; set; }
        public string TipoMov { get; set; }
    }
}
