using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using Newtonsoft.Json;

namespace Secund
{
    public static class WebApiMethods<T>
    {
        public static T Get(string sApiMethod)
        {
            var sUrlApi = string.Format("http://localhost:29929/secund-api/{0}", sApiMethod);
            
            WebRequest oRequest = WebRequest.Create(sUrlApi);
            oRequest.Method = WebRequestMethods.Http.Get;
          
            var response = (HttpWebResponse)oRequest.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            var oEntidad = JsonConvert.DeserializeObject<T>(responseString);

            return oEntidad;
        }

        public static T Post(string[] parametros, string sApiMethod)
        {
            var sUrlApi = string.Format("http://localhost:29929/secund-api/{0}", sApiMethod);
            var postData = parametros.Length > 0 ? string.Format("?{0}", string.Join("&", parametros)) : "";

            var oData = Encoding.ASCII.GetBytes(postData);
            WebRequest oRequest = WebRequest.Create(sUrlApi + postData);
            oRequest.Method = WebRequestMethods.Http.Post;
            oRequest.ContentType = "application/json";

            if (oData.Length > 0)
            {
                oRequest.ContentLength = oData.Length;
                using (var stream = oRequest.GetRequestStream())
                {
                    stream.Write(oData, 0, oData.Length);
                }
            }

            var response = (HttpWebResponse)oRequest.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            var oEntidad = JsonConvert.DeserializeObject<T>(responseString);

            return oEntidad;
        }
    }
}