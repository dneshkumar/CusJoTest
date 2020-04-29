using Newtonsoft.Json;
using SampleAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SampleAPI.Controllers
{
    public class HomeController : ApiController
    {
        public SqlConnection _sqlConnection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Database=Test; Integrated Security=True");
        

        [System.Web.Http.Route("api/Home/Get")]
        public string Get(string username)
        {
            DataTable dt = new DataTable();
            string result = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlConnection;
                cmd.CommandText = "uspGetUserPages";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                _sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                result = JsonConvert.SerializeObject(dt);
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

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Home/Post")]
        public string Post(UserPages pages)
        {
            string result = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlConnection;
                cmd.CommandText = "uspInsertOrUpdateUserPages";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", pages.username);
                cmd.Parameters.AddWithValue("@page1", pages.page1);
                cmd.Parameters.AddWithValue("@page2", pages.page2);
                cmd.Parameters.AddWithValue("@page3", pages.page3);
                _sqlConnection.Open();
                result = cmd.ExecuteScalar().ToString();
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
    }
}
