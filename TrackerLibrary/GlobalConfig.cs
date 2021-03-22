using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Interfaces;
using System.Configuration;


namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        /// <summary>
        /// Holds anything that implements IDataconnection interface
        /// </summary>
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(DatabaseType db)
        {
            
            if(db == DatabaseType.Sql)
            {
                //TODO - Set up SQL connection properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;

            }
            else if(db == DatabaseType.TextFile)
            {
                //TODO - Set up Text connection properly
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
