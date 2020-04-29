using SampleAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleAPI.Controllers
{
    public class ValuesController : ApiController
    {
      public SqlConnection _sqlConnection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Database=Test; Integrated Security=True");
       
       
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }





       public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post(RegisterHelpers register)
        {
            string result = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlConnection;
                cmd.CommandText = "uspInsertRegister";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", register.username);
                cmd.Parameters.AddWithValue("@email", register.email);
                cmd.Parameters.AddWithValue("@password", register.password);
                _sqlConnection.Open();
                result=cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _sqlConnection.Close();
            }
            return result;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
