using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FGOAutoScript
{
    class NetworkAPI
    {
        public static string CreateGetHttpResponse(string url, int timeout,Hashtable dic)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            var result = "";
            var builder = new StringBuilder();
            builder.Append(url);
            if (dic != null && dic.Count > 0)
            {
                builder.Append("?");
                var i = 0;
                foreach (DictionaryEntry item in dic)
                {
                    if (i > 0)
                        builder.Append("&");
                    builder.AppendFormat("{0}={1}", item.Key, item.Value);
                    i++;
                }
            }
            var req = (HttpWebRequest)WebRequest.Create(builder.ToString());
            req.Timeout = timeout;
            var resp = (HttpWebResponse)req.GetResponse();
            var stream = resp.GetResponseStream();
            try
            {
                //获取内容  
                using (var reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            finally
            {
                stream.Close();
            }
            return result;
        }
        public static string CreatePostHttpResponse(string url, Hashtable parameters)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            HttpWebRequest request = null;
            //HTTPSQ请求  
            ServicePointManager.ServerCertificateValidationCallback = CheckValidationResult;
            request = WebRequest.Create(url) as HttpWebRequest;
            request.ProtocolVersion = HttpVersion.Version11;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";          
            //如果需要POST数据     
            if (!(parameters == null || parameters.Count == 0))
            {
                var buffer = new StringBuilder();
                var i = 0;
                byte[] data;
                if (url.Contains("/api/client/login"))
                {
                    request.UserAgent = "Mozilla/5.0 BSGameSDK";
                    var d = new Dictionary<string, string>();
                    foreach (string key in parameters.Keys)
                    {
                        d.Add(key, parameters[key].ToString());
                    }
                    foreach (var key in d.Keys)
                    {
                        if (i > 0)
                        {
                            buffer.AppendFormat("&{0}={1}", key, d[key]);
                        }
                        else
                        {
                            buffer.AppendFormat("{0}={1}", key, d[key]);
                        }
                        i++;
                    }
                    var postData = string.Join("&", d.Select(
                    p => $"{p.Key}={System.Web.HttpUtility.UrlEncode(p.Value, Encoding.UTF8)}").ToArray());
                    data = Encoding.UTF8.GetBytes(postData);
                }
                else
                {
                    foreach (string key in parameters.Keys)
                    {
                        if (i > 0)
                        {
                            buffer.AppendFormat("&{0}={1}", key, parameters[key]);
                        }
                        else
                        {
                            buffer.AppendFormat("{0}={1}", key, parameters[key]);
                        }
                        i++;
                    }
                    data = Encoding.UTF8.GetBytes(buffer.ToString());
                }
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            return new StreamReader(request.GetResponse().GetResponseStream()).ReadToEnd();
        }

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; //总是接受     
        }
    }
}
