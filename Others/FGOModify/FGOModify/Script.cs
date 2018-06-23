using Fiddler;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace FGOModify
{
    public class Script : IAutoTamper
    {
        public void AutoTamperRequestAfter(Session oSession)
        {
        }

        public void AutoTamperRequestBefore(Session oSession)
        {
        }

        public void AutoTamperResponseAfter(Session oSession)
        {
        }


		public static string ResponseCacheDecrypt(string str)
		{
			FiddlerApplication.Log.LogString("ResponseCacheDecrypt");

			try
			{
				byte[] array = Convert.FromBase64String(str);
				byte[] bytes = Encoding.UTF8.GetBytes("1EgjS2hL3zSgwjcwLVmoPTmp");
				byte[] bytes2 = Encoding.UTF8.GetBytes("lfAKRpm1");
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				byte[] array2;
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDESCryptoServiceProvider.CreateDecryptor(bytes, bytes2), CryptoStreamMode.Write))
					{
						cryptoStream.Write(array, 0, array.Length);
						cryptoStream.Close();
					}
					array2 = memoryStream.ToArray();
					memoryStream.Close();
				}

				FiddlerApplication.Log.LogString(Encoding.UTF8.GetString(array2));
				return Encoding.UTF8.GetString(array2);
			}
			catch (Exception e)
			{
				FiddlerApplication.Log.LogString(e.Message);
				return "";
			}
		}

        void ReplaceSvtInfo(JArray svts, List<int> followers)
        {
            FiddlerApplication.Log.LogString("ReplaceSvtInfo");
            for (var i = 0; i < svts.Count; i++)
            {
                var svtObj = (JObject)svts[i];
                if (svtObj.Property("userId").Value.ToString() == "0" && !followers.Contains(svtObj.Property("svtId").Value.Value<int>()))
                {
                    if (svtObj.Property("atk") != null)
                    {
                        svtObj.Property("atk").Value = 10;
                        svtObj.Property("hp").Value = 30000;
                    }
                }
                svts[i] = svtObj;
            }
        }

        List<int> GetFollowerSvtIds(JObject cacheObj)
        {
            var list = new List<int>();
            var array = (JArray)cacheObj.SelectToken("updated.userSvtCollection");
            if (array == null)
                return list;
            for (int i = 0; i < array.Count; i++)
            {
                var svt = (JObject)array[i];
                list.Add(svt.Property("svtId").Value.Value<int>());
            }
            return list;
        }

        public void AutoTamperResponseBefore(Session oSession)
        {
            if (oSession.url.IndexOf("/ac.php?_userId=") != -1)
            {
				//FiddlerApplication.Log.LogString("AutoTamperResponseBefore");

				try
                {
                    var content = Encoding.UTF8.GetString(Convert.FromBase64String(Utilities.UrlDecode(oSession.GetResponseBodyAsString())));
                    var root = JsonConvert.DeserializeObject<JObject>(content);
                    var response = (JObject)root.SelectToken("response[0]");
                    var isEncrypt = response.Property("isEncrypt");
                    if (isEncrypt != null && isEncrypt.Value.Value<bool>())
                    {
                        var cache = root.Property("cache");
                        JObject cacheObj;
                        if (cache.Value.Type == JTokenType.String)
                        {
                            var cacheStr = ResponseCacheDecrypt(cache.Value.ToString());
                            cacheObj = JsonConvert.DeserializeObject<JObject>(cacheStr);
                        }
                        else
                        {
                            cacheObj = (JObject)cache.Value;
                        }

						//FiddlerApplication.Log.LogString(cacheObj.ToString());

						var svts = (JArray)cacheObj.SelectToken("replaced.battle[0].battleInfo.userSvt");
                        if (svts != null)
                        {
                            var follwers = GetFollowerSvtIds(cacheObj);
                            ReplaceSvtInfo(svts, follwers);
                        }
                        else
                            return;

                        isEncrypt.Value = 0;
                        cache.Value = cacheObj;

                        var json = root.ToString();
                        var encodeTxt = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(json));
                        encodeTxt = System.Web.HttpUtility.UrlEncode(encodeTxt);
                        oSession.utilSetResponseBody(encodeTxt);
                    }
                    else
                    {
						var cache = root.Property("cache");
	                    JObject cacheObj= (JObject)cache.Value;

	                    //FiddlerApplication.Log.LogString("cache Obj");

	                    var svts = (JArray)cacheObj.SelectToken("replaced.battle[0].battleInfo.userSvt");
	                    if (svts != null)
	                    {
		                    var follwers = GetFollowerSvtIds(cacheObj);
		                    ReplaceSvtInfo(svts, follwers);
	                    }
	                    else
		                    return;

	                    isEncrypt.Value = 0;
	                    cache.Value = cacheObj;

	                    var json = root.ToString();
	                    var encodeTxt = Convert.ToBase64String(Encoding.UTF8.GetBytes(json));
	                    encodeTxt = System.Web.HttpUtility.UrlEncode(encodeTxt);
	                    oSession.utilSetResponseBody(encodeTxt);
					}
                }
                catch (Exception)
                {
                }
            }
        }

        public void OnBeforeReturningError(Session oSession)
        {
        }

        public void OnBeforeUnload()
        {
        }

        public void OnLoad()
        {
        }
    }
}
