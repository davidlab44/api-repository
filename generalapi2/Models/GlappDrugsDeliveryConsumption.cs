#nullable disable
using System;
using System.Collections.Generic;

namespace generalapi2.Models
{
    public partial class GlappDrugsDeliveryConsumption
    {
        /*
        public GlappDrugsDeliveryConsumption()
        {
            GlappDrugsDeliveryConsumptionDets = new HashSet<GlappDrugsDeliveryConsumptionDet>();
        }
        */

        public long ConsumptionId { get; set; }
        public string ConsumerUser { get; set; }
        public string Vehicle { get; set; }
        public string Status { get; set; }
        public DateTime CreationDate { get; set; }
        public int? RestockId { get; set; }

        //public virtual ICollection<GlappDrugsDeliveryConsumptionDet> GlappDrugsDeliveryConsumptionDets { get; set; }
    }
}