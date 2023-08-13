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
            /*
            modelBuilder.Entity<APP_SP_DrugsDeliveryConsumerViewArticlesResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<APP_SP_DrugsDeliveryConsumerViewHeaderResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<APP_SP_DrugsDeliveryConsumerViewSaveResult>().HasNoKey().ToView(null);
            */
        }
    }

    public partial class SISMEDICAERPContextProcedures : ISISMEDICAERPContextProcedures
    {
        private readonly SISMEDICAERPContext _context;

        public SISMEDICAERPContextProcedures(SISMEDICAERPContext context)
        {
            _context = context;
        }

        public virtual async Task<List<APP_SP_DrugsDeliveryConsumerViewArticlesResult>> APP_SP_DrugsDeliveryConsumerViewArticlesAsync(string P_User, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
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

            var sqlParameters = new []
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

            var sqlParameters = new []
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
    }
}
