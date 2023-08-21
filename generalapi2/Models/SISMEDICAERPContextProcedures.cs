using generalapi2.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
//using TemplateBorrar1.Models;

namespace generalapi2.Models
{
    public partial class SISMEDICAERPContext
    {
        private ISISMEDICAERPContextProcedures _procedures;

        public virtual ISISMEDICAERPContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new SISMEDICAERPContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public ISISMEDICAERPContextProcedures GetProcedures()
        {
            return Procedures;
        }

        protected void OnModelCreatingGeneratedProcedures(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Glapp_SP_DrugsDeliveryRestocksResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<Glapp_SP_DrugsDeliveryRestocksArticlesResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<Glapp_SP_DrugsDeliveryRestockSaveResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<Glapp_SP_DrugsDeliveryRestocksHeaderResult>().HasNoKey().ToView(null);
            //modelBuilder.Entity<Glapp_SP_DrugsDeliveryConfirmationResult>().HasNoKey().ToView(null);

        }
    }

    public partial class SISMEDICAERPContextProcedures : ISISMEDICAERPContextProcedures
    {
        private readonly SISMEDICAERPContext _context;

        public SISMEDICAERPContextProcedures(SISMEDICAERPContext context)
        {
            _context = context;
        }

        public virtual async Task<List<Glapp_SP_DrugsDeliveryRestocksResult>> Glapp_SP_DrugsDeliveryRestocksAsync(string P_User, long? P_RestockID, string P_RestockStatus, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "P_User",
                    Size = 100,
                    Value = P_User ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "P_RestockID",
                    Value = P_RestockID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.BigInt,
                },
                new SqlParameter
                {
                    ParameterName = "P_RestockStatus",
                    Size = 20,
                    Value = P_RestockStatus ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<Glapp_SP_DrugsDeliveryRestocksResult>("EXEC @returnValue = [dbo].[Glapp_SP_DrugsDeliveryRestocks] @P_User, @P_RestockID, @P_RestockStatus", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<Glapp_SP_DrugsDeliveryRestocksArticlesResult>> Glapp_SP_DrugsDeliveryRestocksArticlesAsync(string P_User, long? P_RestockID, string P_View, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "P_User",
                    Size = 100,
                    Value = P_User ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "P_RestockID",
                    Value = P_RestockID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.BigInt,
                },
                new SqlParameter
                {
                    ParameterName = "P_View",
                    Size = 100,
                    Value = P_View ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<Glapp_SP_DrugsDeliveryRestocksArticlesResult>("EXEC @returnValue = [dbo].[Glapp_SP_DrugsDeliveryRestocksArticles] @P_User, @P_RestockID, @P_View", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<Glapp_SP_DrugsDeliveryRestockSaveResult>> Glapp_SP_DrugsDeliveryRestockSaveAsync(long? P_RestockID, string P_RestockerUser, string P_Vehicle, string P_DrugsRestockDetail, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "P_RestockID",
                    Value = P_RestockID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.BigInt,
                },
                new SqlParameter
                {
                    ParameterName = "P_RestockerUser",
                    Size = 100,
                    Value = P_RestockerUser ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "P_Vehicle",
                    Size = 100,
                    Value = P_Vehicle ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "P_DrugsRestockDetail",
                    Size = -1,
                    Value = P_DrugsRestockDetail ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<Glapp_SP_DrugsDeliveryRestockSaveResult>("EXEC @returnValue = [dbo].[Glapp_SP_DrugsDeliveryRestockSave] @P_RestockID, @P_RestockerUser, @P_Vehicle, @P_DrugsRestockDetail", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<Glapp_SP_DrugsDeliveryRestocksHeaderResult>> Glapp_SP_DrugsDeliveryRestocksHeaderAsync(string P_User, long? P_RestockID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "P_User",
                    Size = 100,
                    Value = P_User ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "P_RestockID",
                    Value = P_RestockID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.BigInt,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<Glapp_SP_DrugsDeliveryRestocksHeaderResult>("EXEC @returnValue = [dbo].[Glapp_SP_DrugsDeliveryRestocksHeader] @P_User, @P_RestockID", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
        public virtual async Task<List<APP_SP_DrugsDeliveryConsumerViewArticlesResult>> APP_SP_DrugsDeliveryConsumerViewArticlesAsync(string P_User, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new[]
            {
                new SqlParameter
                {
                    ParameterName = "P_User",
                    Size = 100,
                    Value = P_User ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<APP_SP_DrugsDeliveryConsumerViewArticlesResult>("EXEC @returnValue = [dbo].[APP_SP_DrugsDeliveryConsumerViewArticles] @P_User", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<APP_SP_DrugsDeliveryConsumerViewHeaderResult>> APP_SP_DrugsDeliveryConsumerViewHeaderAsync(string P_User, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new[]
            {
                new SqlParameter
                {
                    ParameterName = "P_User",
                    Size = 100,
                    Value = P_User ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<APP_SP_DrugsDeliveryConsumerViewHeaderResult>("EXEC @returnValue = [dbo].[APP_SP_DrugsDeliveryConsumerViewHeader] @P_User", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<APP_SP_DrugsDeliveryConsumerViewSaveResult>> APP_SP_DrugsDeliveryConsumerViewSaveAsync(string P_ConsumerUser, string P_Vehicle, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new[]
            {
                new SqlParameter
                {
                    ParameterName = "P_ConsumerUser",
                    Size = 100,
                    Value = P_ConsumerUser ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "P_Vehicle",
                    Size = 100,
                    Value = P_Vehicle ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<APP_SP_DrugsDeliveryConsumerViewSaveResult>("EXEC @returnValue = [dbo].[APP_SP_DrugsDeliveryConsumerViewSave] @P_ConsumerUser, @P_Vehicle", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }


        public virtual async Task<List<Glapp_SP_DrugsDeliveryConfirmationResult>> Glapp_SP_DrugsDeliveryConfirmationAsync(long? P_RestockID, string P_User, string P_Vehicle, string P_DeliveryConfirmationImageUrl, string P_DeliveryConfirmationComments, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new[]
            {
                new SqlParameter
                {
                    ParameterName = "P_RestockID",
                    Value = P_RestockID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.BigInt,
                },
                new SqlParameter
                {
                    ParameterName = "P_User",
                    Size = 100,
                    Value = P_User ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "P_Vehicle",
                    Size = 100,
                    Value = P_Vehicle ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "P_DeliveryConfirmationImageUrl",
                    Size = 200,
                    Value = P_DeliveryConfirmationImageUrl ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "P_DeliveryConfirmationComments",
                    Size = 1000,
                    Value = P_DeliveryConfirmationComments ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<Glapp_SP_DrugsDeliveryConfirmationResult>("EXEC @returnValue = [dbo].[Glapp_SP_DrugsDeliveryConfirmation] @P_RestockID, @P_User, @P_Vehicle, @P_DeliveryConfirmationImageUrl, @P_DeliveryConfirmationComments", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        /*
        public Task<List<APP_SP_DrugsDeliveryConsumerViewArticlesResult>> APP_SP_DrugsDeliveryConsumerViewArticlesAsync(string P_User, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<APP_SP_DrugsDeliveryConsumerViewHeaderResult>> APP_SP_DrugsDeliveryConsumerViewHeaderAsync(string P_User, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<APP_SP_DrugsDeliveryConsumerViewSaveResult>> APP_SP_DrugsDeliveryConsumerViewSaveAsync(string P_ConsumerUser, string P_Vehicle, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        */
    }
}
