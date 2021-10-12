﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                //TODO - Set up SQL connnector
                SqlConnector sql = new SqlConnector();
                Connection = (sql);
            }
            else if (db == DatabaseType.TextFile)
            {
                //TODO - Create Text Connection
                TextConnector text = new TextConnector();
                Connection = (text);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
