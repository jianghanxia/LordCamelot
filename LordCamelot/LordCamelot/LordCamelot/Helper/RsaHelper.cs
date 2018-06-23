using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace LordCamelot.Helper
{
	class RsaHelper
	{
		private static string publicKeyJava = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDttd0hD3o6KYH60pEtjuejr4AZ\r\nvu9BZqIimONSXat/gOyVKYAz6Px6HF7/p8Jzsw4cOVE7dT9l/9/+v/MwxmHUsAwE\r\nw14JHjE0IiU9ruGDwUt+mNGk+dH7E9rgdfEoraV9VEAF7tGTTZ2hyU1zuxMEQ2Lo\r\nr6u7M0X/169sVX781wIDAQAB";

		public static string Decrypt(string source)
		{
			byte[] publicInfoByte = Convert.FromBase64String(publicKeyJava);
			AsymmetricKeyParameter pubKey = PublicKeyFactory.CreateKey(publicInfoByte);
			IAsymmetricBlockCipher engine = new Pkcs1Encoding(new RsaEngine());
			try
			{
				engine.Init(false, pubKey);
				byte[] byteData = Convert.FromBase64String(source);
				var resultData = engine.ProcessBlock(byteData, 0, byteData.Length);
				return Encoding.UTF8.GetString(resultData);
			}
			catch (Exception e)
			{
				return e.Message;
			}
		}

		public static string RSAEncrypt(string mStrEncryptString, string pemPublicKey)
		{
			var publicKeyParam = (RsaKeyParameters) PublicKeyFactory.CreateKey(Convert.FromBase64String(PublicKey(pemPublicKey)));
			var c = CipherUtilities.GetCipher("RSA/ECB/PKCS1Padding");
			c.Init(true, publicKeyParam);
			var data = Encoding.UTF8.GetBytes(mStrEncryptString);
			data = c.DoFinal(data);
			return Convert.ToBase64String(data);
		}

		private static string PublicKey(string pemKey)
		{
			return pemKey.Replace("-----BEGIN PUBLIC KEY-----", "").Replace("-----END PUBLIC KEY-----", "");
		}
	}
}
