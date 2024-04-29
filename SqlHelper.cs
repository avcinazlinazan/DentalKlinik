using System;
using System.Collections.Generic;
using Npgsql;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using System.Drawing;
using Npgsql.Internal;
using Npgsql.Internal.Postgres;
using Npgsql.PostgresTypes;
using Npgsql.TypeMapping;
using Npgsql.Util;
using NpgsqlTypes;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;

namespace DisKlinikYS
{
    internal class SqlHelper
    {
        private string ConnectionString { get; set; }
        private NpgsqlConnection Connection { get; set; }

        public SqlHelper()
        {
            ConnectionString = @"server=localHost; port=5432; Database=dentalDB; user ID=postgres; password=emr1453emr";
            Connection = new NpgsqlConnection(ConnectionString);
        }
    
        public void ExecuteProc(string procName, params NpgsqlParameter[] ps)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Parameters.AddRange(ps);
            command.Connection = Connection;

            // Bağlantı zaten açıksa yeniden açma
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }
            command.ExecuteNonQuery();

            // Bağlantıyı kapatmak istiyorsanız
            Connection.Close();
        }
        public DataTable GetTable(string query)
        {
            NpgsqlDataAdapter nda = new NpgsqlDataAdapter(query, ConnectionString);
            DataTable dt = new DataTable();
            nda.Fill(dt);
            return dt;
        }

    }
}
