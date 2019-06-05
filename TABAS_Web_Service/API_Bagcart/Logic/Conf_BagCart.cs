using API_Bagcart.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using Marten;
using DynamixPostgreSQLHandler;

namespace API_Bagcart.Logic
{
    internal class Conf_BagCart: I_BagCart
    {
        private readonly IConfiguration _config;
       

        public Conf_BagCart(IConfiguration config)
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

        public List<BagCart> GetAll()
        {
            try
            {
                using (IDbConnection con = Connection)
                {

                    
                    con.Open();
                    var value = con.Query<BagCart>("SELECT * FROM BagCart;");
                    return value.ToList();
         


                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        //public async Task<BagCart> Edit(BagCart persona)
        //{
        //    try
        //    {
        //        using (IDbConnection con = Connection)
        //        {
        //            string sQuery = "udsp_ins_usuario";
        //            con.Open();
        //            DynamicParameters param = new DynamicParameters();
        //            param.Add("@Nombre", persona.Nombre);
        //            param.Add("@Apellido1", persona.Apellido1);
        //            param.Add("@Apellido2", persona.Apellido2);
        //            param.Add("@Telefono", persona.Telefono);
        //            param.Add("@Carne", persona.Carne);
        //            param.Add("@Correo", persona.Correo);
        //            param.Add("@Contraseña", persona.Contraseña);
        //            param.Add("@Rol", persona.ID_Rol);
        //            param.Add("@Universidad", persona.Universidad);
        //            var result = await con.QueryAsync<BagCart>(sQuery, param, commandType: CommandType.StoredProcedure);
        //            return result.FirstOrDefault();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

    }
}
