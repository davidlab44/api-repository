﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi2.Models
{
    public partial class GLAPP_SP_USR_OBTENERResult
    {
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public string USUARIO { get; set; }
        public int? APROBAR { get; set; }
    }
}
