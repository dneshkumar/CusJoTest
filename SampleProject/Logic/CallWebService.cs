using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace SampleProject.Logic
{
    public class CallWebService
    {

        public static string GET(string url)
        {
            string html = string.Empty;
            try {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return html;
        }

        public static string POST(string url, string jsonContent)
        {
            string finalResponse = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";

            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            Byte[] byteArray = encoding.GetBytes(jsonContent);

            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";
            try
            {
                byte[] data = encoding.GetBytes(jsonContent);
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(data, 0, data.Length);
                dataStream.Close();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                finalResponse = reader.ReadToEnd();
            }
            catch (WebException ex)
            {
                throw ex;
            }
            return finalResponse;
        }
    }
}