﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class Proc_ArtLotesResult
    {
        public decimal? Cantidad { get; set; }
        public string NomDependencia { get; set; }
        public string NomLote { get; set; }
        public DateTime FecVenLot { get; set; }
        public int ID { get; set; }
        public string CodDepend { get; set; }
    }
}
