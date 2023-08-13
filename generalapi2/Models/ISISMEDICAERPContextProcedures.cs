﻿using generalapi2.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace generalapi2.Models
{
    public partial interface ISISMEDICAERPContextProcedures
    {
        Task<List<APP_SP_DrugsDeliveryConsumerViewArticlesResult>> APP_SP_DrugsDeliveryConsumerViewArticlesAsync(string P_User, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<APP_SP_DrugsDeliveryConsumerViewHeaderResult>> APP_SP_DrugsDeliveryConsumerViewHeaderAsync(string P_User, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<APP_SP_DrugsDeliveryConsumerViewSaveResult>> APP_SP_DrugsDeliveryConsumerViewSaveAsync(string P_ConsumerUser, string P_Vehicle, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
