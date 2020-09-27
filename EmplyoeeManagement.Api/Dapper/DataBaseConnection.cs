using EmplyoeeManagement.Api.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EmplyoeeManagement.Api.Dapper
{
    public class DataBaseConnection : IDataBaseConnection
    {
        private readonly AppSettings _appSettings;

        public DataBaseConnection(IOptions<AppSettings> appSettings)
        {
            this._appSettings = appSettings?.Value;

            if (!string.IsNullOrEmpty(this._appSettings?.ConnectionStrings))
            {
                Connection = new SqlConnection(this._appSettings.ConnectionStrings);
            }
        }



        public IDbConnection Connection { get; }
    }
}
