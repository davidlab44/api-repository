using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi2.Models
{
    public partial class Glapp_SP_DrugsDeliveryRestockSaveResult
    {
        public string? P_RestockID { get; set; }
        public string? P_ConsumerUser { get; set; }
        public string? P_Vehicle { get; set; }
        public string? P_DrugsConsumptionDetail { get; set; }
    }
}
