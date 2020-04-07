﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using DataMangement.EF;  
using System.Data.Entity;

namespace DataMangement.Repository
{

    
    public static class DbContextExtensions
    {
        public static DataTable DataTable(this DbContext context, string sqlQuery)
        {
            DbProviderFactory dbFactory = DbProviderFactories.GetFactory(context.Database.Connection);

            using (var cmd = dbFactory.CreateCommand())
            {
                cmd.Connection = context.Database.Connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlQuery;
                using (DbDataAdapter adapter = dbFactory.CreateDataAdapter())
                {
                    adapter.SelectCommand = cmd;

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
        }
    }

}
