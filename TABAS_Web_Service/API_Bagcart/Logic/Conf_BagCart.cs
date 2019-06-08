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

        public  BagCart Create(BagCart bagcart)
        {
            try
            {
                using (IDbConnection con = Connection)
                {
                    con.Open();
                    var result =  con.Query<BagCart>("INSERT INTO \"bagcart\" VALUES("+ bagcart.identificador + ",'" +bagcart.modelo +"','" + bagcart.marca +  "');");
                    return result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BagCart Asign_BC_Flight(BagCart bagcart)
        {
            try
            {
                using (IDbConnection con = Connection)
                {
                    con.Open();
                    var result = con.Query<BagCart>("UPDATE \"bagcart\" SET \"c_vuelo\" ='" + bagcart.c_vuelo + "'" + " WHERE \"identificador\" ='"+ bagcart.identificador + "'");
                    return result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BagCart Close_BC(BagCart bagcart)
        {
            try
            {
                using (IDbConnection con = Connection)
                {
                    con.Open();
                    var result = con.Query<BagCart>("UPDATE \"bagcart\" SET \"sello\" ='" + bagcart.sello + "'" + " WHERE \"identificador\" ='" + bagcart.identificador + "'");
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
