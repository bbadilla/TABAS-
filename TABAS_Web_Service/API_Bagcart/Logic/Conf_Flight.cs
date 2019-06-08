using API_Bagcart.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API_Bagcart.Logic
{
    internal class Conf_Flight : I_Flight
    {
        private readonly IConfiguration _config;


        public Conf_Flight(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }



        public Flight Asign_airship(Flight flight)
        {
            try
            {
                using (IDbConnection con = Connection)
                {
                    con.Open();
                    var result = con.Query<Flight>("UPDATE \"vuelo\" SET \"id_aeronave\" ='" + flight.id_aeronave + "'" + " WHERE \"codigo\" ='" + flight.codigo + "'");
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