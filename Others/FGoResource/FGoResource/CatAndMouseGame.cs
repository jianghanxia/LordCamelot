using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using ICSharpCode.SharpZipLib.BZip2;

namespace FgoResourceDecryptor
{
	// Token: 0x02000006 RID: 6
	public class CatAndMouseGame
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002B7C File Offset: 0x00000D7C
		public static string MouseGame3(string str)
		{
			byte[] array = CatAndMouseGame.MouseHomeMain(Convert.FromBase64String(str), CatAndMouseGame.stageData, CatAndMouseGame.stageTop, true);
			if (array == null)
			{
				return null;
			}
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (byte)~array[i];
			}
			return Encoding.UTF8.GetString(array).TrimEnd(new char[1]);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002BD4 File Offset: 0x00000DD4
		public static byte[] MouseGame4(byte[] data)
		{
			byte[] array = CatAndMouseGame.MouseHomeMain(data, CatAndMouseGame.baseData, CatAndMouseGame.baseTop, false);
			if (array == null)
			{
				return null;
			}
			int num = 0;
			while (num < array.Length && num + 1 < data.Length)
			{
				byte b = array[num];
				byte b2 = array[num + 1];
				array[num] = (byte)(b2 ^ 210);
				array[num + 1] = (byte)(b ^ 206);
				num += 2;
			}
			return array;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002C34 File Offset: 0x00000E34
		public static byte[] MouseHomeMain(byte[] data, byte[] home, byte[] info, bool isPress = false)
		{
			MemoryStream memoryStream = null;
			CryptoStream cryptoStream = null;
			byte[] result;
			try
			{
				ICryptoTransform transform = new RijndaelManaged
				{
					Padding = PaddingMode.PKCS7,
					Mode = CipherMode.CBC,
					KeySize = 256,
					BlockSize = 256
				}.CreateDecryptor(home, info);
				byte[] array = new byte[data.Length];
				memoryStream = new MemoryStream(data);
				cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
				cryptoStream.Read(array, 0, array.Length);
				if (isPress)
				{
					MemoryStream memoryStream2 = new MemoryStream();
					MemoryStream memoryStream3 = new MemoryStream(array);
					BZip2InputStream bzip2InputStream = new BZip2InputStream(memoryStream3);
					byte[] array2 = new byte[16384];
					int count;
					while ((count = bzip2InputStream.Read(array2, 0, array2.Length)) > 0)
					{
						memoryStream2.Write(array2, 0, count);
					}
					bzip2InputStream.Close();
					array = memoryStream2.ToArray();
					memoryStream3.Close();
					memoryStream2.Close();
				}
				result = array;
			}
			catch (Exception)
			{
				result = null;
			}
			finally
			{
				if (memoryStream != null)
				{
					memoryStream.Close();
				}
				if (cryptoStream != null)
				{
					cryptoStream.Close();
				}
			}
			return result;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002D40 File Offset: 0x00000F40
		static CatAndMouseGame()
		{
			CatAndMouseGame.stageTop = new byte[32];
			CatAndMouseGame.stageData = new byte[32];
			CatAndMouseGame.baseTop = new byte[32];
			CatAndMouseGame.baseData = new byte[32];
			byte[] bytes = Encoding.UTF8.GetBytes("d3b13d9093cc6b457fd89766bafa1620ee2ef76626d49ce0d424f4156231ce5a");
			byte[] bytes2 = Encoding.UTF8.GetBytes("5ec7ce0fddc50bca9f82b8338b9135c79e0e9e169648df69054dcb96553598eb");
			for (int i = 0; i < bytes2.Length; i++)
			{
				if (i % 2 == 0)
				{
					CatAndMouseGame.baseData[i / 2] = bytes2[i];
				}
				else
				{
					CatAndMouseGame.baseTop[i / 2] = bytes2[i];
				}
			}
			for (int j = 0; j < bytes.Length / 4; j++)
			{
				if (j % 2 == 0)
				{
					CatAndMouseGame.stageData[j / 2 * 4] = bytes[j * 4];
					CatAndMouseGame.stageData[j / 2 * 4 + 1] = bytes[j * 4 + 1];
					CatAndMouseGame.stageData[j / 2 * 4 + 2] = bytes[j * 4 + 2];
					CatAndMouseGame.stageData[j / 2 * 4 + 3] = bytes[j * 4 + 3];
				}
				else
				{
					CatAndMouseGame.stageTop[j / 2 * 4] = bytes[j * 4];
					CatAndMouseGame.stageTop[j / 2 * 4 + 1] = bytes[j * 4 + 1];
					CatAndMouseGame.stageTop[j / 2 * 4 + 2] = bytes[j * 4 + 2];
					CatAndMouseGame.stageTop[j / 2 * 4 + 3] = bytes[j * 4 + 3];
				}
			}
		}

		// Token: 0x0400000C RID: 12
		protected static byte[] baseData = new byte[32];

		// Token: 0x0400000D RID: 13
		protected static byte[] baseTop = new byte[32];

		// Token: 0x0400000E RID: 14
		protected static byte[] stageData = new byte[32];

		// Token: 0x0400000F RID: 15
		protected static byte[] stageTop = new byte[32];

		// Token: 0x04000010 RID: 16
		protected static byte[] stageData2 = new byte[32];

		// Token: 0x04000011 RID: 17
		protected static byte[] stageTop2 = new byte[32];
	}
}
