using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EmplyoeeManagement.Api.Dapper
{
    public interface IDataBaseConnection
    {
        IDbConnection Connection { get; }
    }
}
