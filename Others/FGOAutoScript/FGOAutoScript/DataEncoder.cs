using System;
using System.Security.Cryptography;
using System.IO;

namespace FGOAutoScript
{
	class DataEncoder
	{

		private static string KEY_64 = "63HOIs7e";
		private static string IV_64 = "DjxtBjkw";

		public static string Encode(string data)
		{
			var byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(KEY_64);
			var byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV_64);

			var cryptoProvider = new DESCryptoServiceProvider();
			var i = cryptoProvider.KeySize;
			var ms = new MemoryStream();
			var cst = new CryptoStream(ms, cryptoProvider.CreateEncryptor(byKey, byIV), CryptoStreamMode.Write);

			var sw = new StreamWriter(cst);
			sw.Write(data);
			sw.Flush();
			cst.FlushFinalBlock();
			sw.Flush();
			return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);

		}

		public static string Decode(string data)
		{
			var byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(KEY_64);
			var byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV_64);

			byte[] byEnc;
			try
			{
				byEnc = Convert.FromBase64String(data);
			}
			catch
			{
				return null;
			}

			var cryptoProvider = new DESCryptoServiceProvider();
			var ms = new MemoryStream(byEnc);
			var cst = new CryptoStream(ms, cryptoProvider.CreateDecryptor(byKey, byIV), CryptoStreamMode.Read);
			var sr = new StreamReader(cst);
			return sr.ReadToEnd();
		}
	}
}
