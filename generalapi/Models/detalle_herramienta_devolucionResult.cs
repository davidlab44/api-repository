﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class detalle_herramienta_devolucionResult
    {
        public string nombre { get; set; }
        public string referencia { get; set; }
        public string unidad { get; set; }
        public string fecha_entrega { get; set; }
        public string fecha_devolucion { get; set; }
        public string serial { get; set; }
        public int prestados { get; set; }
        public int hdevueltos { get; set; }
        public int? saldo { get; set; }
        public int devueltos { get; set; }
        public string estado_devolucion2 { get; set; }
        public string observacion { get; set; }
        public string accion_novedad2 { get; set; }
        public int estado_devolucion { get; set; }
        public int accion_novedad { get; set; }
        public decimal id { get; set; }
        public string idmovimiento { get; set; }
        public int? codigo { get; set; }
        public bool? seriales { get; set; }
        public string area_trabajo { get; set; }
        public string dprcodact { get; set; }
    }
}