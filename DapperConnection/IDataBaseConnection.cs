using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DapperConnection
{
    public interface IDataBaseConnection
    {
        IDbConnection Connection { get; }
    }
}
