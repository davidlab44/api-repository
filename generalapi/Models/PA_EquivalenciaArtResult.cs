﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class PA_EquivalenciaArtResult
    {
        public string medOrig { get; set; }
        public string medDesc { get; set; }
        public string codBarra { get; set; }
        public double? equivalencia { get; set; }
        public decimal escalaPre1 { get; set; }
        public decimal escalaPre2 { get; set; }
        public decimal escalaPre3 { get; set; }
        public decimal escalaPre4 { get; set; }
        public decimal escalaPor1 { get; set; }
        public decimal escalaPor2 { get; set; }
        public decimal escalaPor3 { get; set; }
        public decimal escalaPor4 { get; set; }
        public decimal escalaDesc1 { get; set; }
        public decimal escalaDesc2 { get; set; }
        public decimal escalaDesc3 { get; set; }
        public decimal escalaDesc4 { get; set; }
        public string codEqui { get; set; }
        public decimal id { get; set; }
        public int porDefecto { get; set; }
    }
}
