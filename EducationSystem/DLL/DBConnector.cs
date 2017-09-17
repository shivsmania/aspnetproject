using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EducationSystem.DLL
{
    /// <summary>
    /// Sql Connection file
    /// Constructor
    /// Property
    /// </summary>
    public class DBConnector
    {
        private string connString;
        private SqlConnection connection;

        public DBConnector()
        {
            connString = ConfigurationManager.AppSettings["conn"];
            connection = new SqlConnection(connString);
        }

        public SqlConnection conn { get { return connection; } }
    }
}