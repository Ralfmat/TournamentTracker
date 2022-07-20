﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            
            if (db == DatabaseType.Sql)
            {
                //TODO - Set up the SQL Connectior properly
                SqlConnector sql = new SqlConnector();
                Connections = sql;
            }

            else if (db == DatabaseType.TextFile)
            {
                //TODO - Create the Text connection
                TextConnector text = new TextConnector();
                Connections = text;

            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
 