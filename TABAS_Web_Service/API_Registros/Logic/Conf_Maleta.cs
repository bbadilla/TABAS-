using API_Registros.Logic;
using API_Registros.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API_Registros.Data
{
    internal class Conf_Maleta : I_Maleta
    {
        private readonly IConfiguration _config;


        public Conf_Maleta(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(_config.GetConnectionString("PostgresConnection"));
            }
        }


       

        public Maleta Create(Maleta maleta)
        {
            try
            {
                using (IDbConnection con = Connection)
                {
                    con.Open();
                    var result = con.Query<Maleta>("INSERT INTO \"maleta\" VALUES(" + maleta.identificador + ",'" + maleta.color + "', " + maleta.peso + ", " + maleta.costo + ",'" + maleta.c_usuario + "');");
                    return result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      

    }

}
