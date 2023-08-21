﻿#nullable disable
using System;
using System.Collections.Generic;

namespace generalapi2.Models
{
    public partial class GlappDrugsDeliveryRestock
    {
        /*
        public GlappDrugsDeliveryRestock()
        {
            GlappDrugsDeliveryRestocksDets = new HashSet<GlappDrugsDeliveryRestocksDet>();
        }
        */

        public long RestockId { get; set; }
        public string RestockerUser { get; set; }
        public string Vehicle { get; set; }
        public string Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string DeliveryConfirmationImageUrl { get; set; }
        public string DeliveryConfirmationComments { get; set; }
        public string ConfirmerUser { get; set; }
        public DateTime? DeliveryConfirmationDate { get; set; }
        public string Consecutive { get; set; }
        public string SourceId { get; set; }
        public int? Aproved { get; set; }

        //public virtual ICollection<GlappDrugsDeliveryRestocksDet> GlappDrugsDeliveryRestocksDets { get; set; }
    }
}