﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class PA_GETFRECResult
    {
        public DateTime FechaSalida { get; set; }
        public DateTime HoraSalida { get; set; }
        public string PortadorSalida { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime HoraDevolucion { get; set; }
        public string PortadorDevolucion { get; set; }
        public string NumeroGuia { get; set; }
    }
}