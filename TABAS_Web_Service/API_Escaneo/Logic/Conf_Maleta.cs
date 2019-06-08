using API_Escaneo.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API_Escaneo.Logic
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



        public Maleta Asign_BC(Maleta maleta)
        {
            try
            {
                using (IDbConnection con = Connection)
                {
                    con.Open();
                    var result = con.Query<Maleta>("UPDATE \"maleta\" SET \"id_bagcart\" ='" + maleta.id_bagcart + "'" + " WHERE \"identificador\" ='" + maleta.identificador + "'");
                    return result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Maleta Asign_airship(Maleta maleta)
        {
            try
            {
                using (IDbConnection con = Connection)
                {
                    con.Open();
                    var result = con.Query<Maleta>("UPDATE \"maleta\" SET \"id_avion\" ='" + maleta.id_avion + "'" + " WHERE \"identificador\" ='" + maleta.identificador + "'");
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
