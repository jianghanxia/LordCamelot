using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.BZip2;
using Xamarin.Forms;

namespace LordCamelot.Services
{
	public class Network
	{
		public static async Task GetBZip2FileAsync(string url, string file)
		{
			var sourceFile = DependencyService.Get<ISystem>().GetLocalFilePath("temp");
			File.Delete(sourceFile);

			var cli = new WebClient();
			await cli.DownloadFileTaskAsync(url, sourceFile);

			using (FileStream fileToDecompressAsStream = File.OpenRead(sourceFile))
			{
				using (FileStream decompressedStream = File.Create(DependencyService.Get<ISystem>().GetLocalFilePath(file)))
				{
					try
					{
						BZip2.Decompress(fileToDecompressAsStream, decompressedStream, true);
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}
				}
			}

			File.Delete(sourceFile);
		}

		public static async Task<string> GetWebAsync(string url, string method = "Get", string postData = "", int errnum = 0)
		{
			try
			{
				var request = WebRequest.CreateHttp(url);
				request.Method = method.ToUpper();

				if (method == "Post" && postData != "")
				{
					request.ContentType = "application/x-www-form-urlencoded";
					var bytes = Encoding.UTF8.GetBytes(postData);
					var stream = request.GetRequestStream();
					stream.Write(bytes, 0, bytes.Length);
					stream.Close();
				}

				var response = await request.GetResponseAsync();

				using (var stream = response.GetResponseStream())
				{
					using (var sReader = new StreamReader(stream, Encoding.GetEncoding("UTF-8")))
					{
						var res = sReader.ReadToEnd();
						return res;
					}
				}
			}
			catch (Exception e)
			{
				if (errnum < 5)
				{
					await Task.Delay(1000);
					errnum += 1;
					return await GetWebAsync(url, method, postData, errnum);
				}

				throw e;
			}
		}

		public static async Task<string> HttpPostAsync(string url, Hashtable parameters, int errnum = 0)
		{
			try
			{
				//HTTPSQ请求  
				ServicePointManager.ServerCertificateValidationCallback = CheckValidationResult;

				var request = WebRequest.CreateHttp(url);

				request.ProtocolVersion = HttpVersion.Version11;
				request.Method = "POST";
				request.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.4.4; MuMu Build/V417IR)";
				request.ContentType = "application/x-www-form-urlencoded";

				using (var reqstream = request.GetRequestStream())
				{
					var par = new List<string>();
					foreach (DictionaryEntry item in parameters)
					{
						par.Add($"{item.Key}={System.Web.HttpUtility.UrlEncode(item.Value.ToString())}");
					}

					var bytes = Encoding.UTF8.GetBytes(string.Join("&", par));
					reqstream.Write(bytes, 0, bytes.Length);
					reqstream.Close();
				}

				var response = await request.GetResponseAsync();

				using (var stream = response.GetResponseStream())
				{
					using (var sReader = new StreamReader(stream, Encoding.GetEncoding("UTF-8")))
					{
						var res = sReader.ReadToEnd();
						return res;
					}
				}
			}
			catch (Exception e)
			{
				if (errnum < 5)
				{
					await Task.Delay(1000);
					errnum += 1;
					return await HttpPostAsync(url, parameters, errnum);
				}

				throw e;
			}
		}

		private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
		{
			return true; //总是接受     
		}
	}
}
