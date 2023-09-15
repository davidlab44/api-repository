using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi2.Models
{
    public partial class Glapp_SP_DrugsDeliveryConfirmationInnerModel
    {
        public int P_RestockID { get; set; }
        public string P_User { get; set; }
        public string P_Vehicle { get; set; }
        public string P_DeliveryConfirmationImageUrl { get; set; }
        public string P_DeleveryConfirmationComments { get; set; }
    }
}
