using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using FgoResourceDecryptor;

namespace FGoResource
{
	class Program
	{
		private Dictionary<string, int> ver = new Dictionary<string, int>();

		static void Main(string[] args)
		{
			var s = CatAndMouseGame.MouseGame3(new WebClient().DownloadString("https://line3-s2-bili-fate.bilibiligame.net/rongame_beta/rgfate/60_member/network/AssetStorage.txt"));

			StreamReader streamReader = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(s)));
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				if (!text.Contains("FgoDataVersion") && !text.StartsWith("~"))
				{
					var array = text.Split(',');
					if (array[4].Contains("/"))
					{
						var name = $"Download\\{array[4].Replace("/", "\\")}";

						if (!name.EndsWith(".cpk.bytes") && !name.EndsWith(".mp4"))
						{
							name = $"{name}.unity3d";

							using (var wclient = new WebClient())
							{
								wclient.BaseAddress = "https://line2-patch-fate.bilibiligame.net/1200/NewResources/Android/";
								Directory.CreateDirectory(Path.GetDirectoryName(name));

								var address = $"{array[0]}/{getShaName($"{array[4].Replace("/", "@")}.unity3d")}";

								Console.WriteLine(name);
								var array2 = CatAndMouseGame.MouseGame4(wclient.DownloadData(address));

								var file = new FileStream(name, FileMode.Create);
								file.Write(array2, 0, array2.Length);
								file.Close();
							}
						}
					}
				}
			}
		}

		public static string getShaName(string name)
		{
			HashAlgorithm hashAlgorithm = new SHA1CryptoServiceProvider();
			byte[] bytes = new UTF8Encoding().GetBytes(name);
			byte[] array = hashAlgorithm.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in array)
			{
				stringBuilder.AppendFormat("{0,0:x2}", (int)(b ^ 170));
			}
			stringBuilder.Append(".bin");
			return stringBuilder.ToString();
		}
	}
}
