﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class PA_NtPerfilesResult
    {
        public int Id { get; set; }
        public string CallerId { get; set; }
        public string Procedencia { get; set; }
        public string Descripcion { get; set; }
        public int FechaInicio { get; set; }
        public int FechaFin { get; set; }
        public int PeriodicidadNoti { get; set; }
        public int TipoPeriodicidad { get; set; }
        public string Color { get; set; }
        public int Prioridad { get; set; }
        public bool Sonido { get; set; }
        public bool ViaMail { get; set; }
        public int PeriodicidadMail { get; set; }
        public string CuerpoMail { get; set; }
        public string FirmaMail { get; set; }
    }
}
