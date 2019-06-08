using API_Escaneo.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API_Escaneo.Logic
{
    public class Conf_User : I_User
    {
        private readonly IConfiguration _config;

        public Conf_User(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }

        public async Task<User> GetByID(string correo, string contraseña)
        {
            try
            {
                using (IDbConnection con = Connection)
                {
                    string sQuery = "udsp_get_usuario";
                    con.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Correo", correo);
                    param.Add("@Contraseña", contraseña);
                    var result = await con.QueryAsync<User>(sQuery, param, commandType: CommandType.StoredProcedure);
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
