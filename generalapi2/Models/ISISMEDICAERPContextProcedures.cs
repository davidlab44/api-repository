using generalapi2.Models;
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
        Task<List<Glapp_SP_DrugsDeliveryRestocksResult>> Glapp_SP_DrugsDeliveryRestocksAsync(string P_User, long? P_RestockID, string P_RestockStatus, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Glapp_SP_DrugsDeliveryRestocksArticlesResult>> Glapp_SP_DrugsDeliveryRestocksArticlesAsync(string P_User, long? P_RestockID, string P_View, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Glapp_SP_DrugsDeliveryRestockSaveResult>> Glapp_SP_DrugsDeliveryRestockSaveAsync(long? P_RestockID, string P_RestockerUser, string P_Vehicle, string P_DrugsRestockDetail, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Glapp_SP_DrugsDeliveryRestocksHeaderResult>> Glapp_SP_DrugsDeliveryRestocksHeaderAsync(string P_User, long? P_RestockID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Glapp_SP_DrugsDeliveryConfirmationResult>> Glapp_SP_DrugsDeliveryConfirmationAsync(long? P_RestockID, string P_User, string P_Vehicle, string P_DeliveryConfirmationImageUrl, string P_DeliveryConfirmationComments, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
