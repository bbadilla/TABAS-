using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API_Registros.Data
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

        public async Task<User> Edit(User persona)
        {
            try
            {
                using (IDbConnection con = Connection)
                {
                    string sQuery = "udsp_ins_usuario";
                    con.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Nombre", persona.Nombre);
                    param.Add("@Apellido1", persona.Apellido1);
                    param.Add("@Apellido2", persona.Apellido2);
                    param.Add("@Telefono", persona.Telefono);
                    param.Add("@Carne", persona.Carne);
                    param.Add("@Correo", persona.Correo);
                    param.Add("@Contraseña", persona.Contraseña);
                    param.Add("@Rol", persona.ID_Rol);
                    param.Add("@Universidad", persona.Universidad);
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
