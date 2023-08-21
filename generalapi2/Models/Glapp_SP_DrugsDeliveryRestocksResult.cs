﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi2.Models
{
    public partial class Glapp_SP_DrugsDeliveryRestocksResult
    {
        public long RestockID { get; set; }
        public string RestockerUser { get; set; }
        public string RestockerDisplayName { get; set; }
        public string Vehicle { get; set; }
        public string Status { get; set; }
        public string CreationDate { get; set; }
        public string ModifiedDate { get; set; }
        public string Consecutive { get; set; }
    }
}
