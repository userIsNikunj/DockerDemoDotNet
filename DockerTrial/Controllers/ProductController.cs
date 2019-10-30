using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DockerTrial.Controllers
{
    [RoutePrefix("api/v1")]
    public class ProductController : ApiController
    {
        private readonly IDbConnection _dbConnection = new SqlConnection(@"Server=db;Database=master;User=SA;Password=123@456ABC;");

        [Route("products")]
        public IHttpActionResult Get()
        {
            /*List<String> products = new List<String> { 
            "Football",
            "Clothes",
            "Toys"
            };*/
            List<string> products = new List<String>();
            const string queryString = "SELECT Name FROM Product";
            
            using (_dbConnection)
            {
                try
                {
                    //Create the Command
                    IDbCommand command = _dbConnection.CreateCommand();
                    command.CommandText = queryString;
                    command.CommandType = CommandType.Text;

                    //Open the Connection
                    _dbConnection.Open();

                    //Retrive the data
                    IDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        products.Add(reader[0].ToString());
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return Ok(products);
        }
    }
}
