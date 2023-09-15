﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi2.Models
{
    public partial class Glapp_SP_DrugsDeliveryRestocksHeaderResult
    {
        public string Consumer { get; set; }
        public string License { get; set; }
        public string LicenseCategory { get; set; }
        public string LicenseExpiration { get; set; }
        public string Vehicle { get; set; }
        public string Soat { get; set; }
        public string SoatExpiration { get; set; }
        public string Crtm { get; set; }
        public string CrtmExpiration { get; set; }
    }
}
