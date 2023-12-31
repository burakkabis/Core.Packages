﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Serilog.ConfigurationModel;


//https://github.com/serilog-mssql/serilog-sinks-mssqlserver

public class MsSqlConfiguration
{
    //MsSql e log yazarken ihtiyacimiz olanlar.
    public string ConnectionString { get; set; }
    public string TableName { get; set; }
    public bool AutoCreateSqlTable { get; set; }

    public MsSqlConfiguration()
    {
        ConnectionString = string.Empty;
        TableName = string.Empty;
    }

    public MsSqlConfiguration(string connectionString, string tableName, bool autoCreateTable)
    {
        ConnectionString = connectionString;
        TableName = tableName;
        AutoCreateSqlTable = autoCreateTable;

    }
}