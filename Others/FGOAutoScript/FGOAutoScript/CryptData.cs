using ICSharpCode.SharpZipLib.BZip2;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace FGOAutoScript
{
    public class CryptData
    {
        protected const int WRITE_BUFFER_SIZE = 16384;

        public static string ResponseCacheDecrypt(string str, bool isPress = false)
        {
            var array = Convert.FromBase64String(str);
            var bytes = Encoding.UTF8.GetBytes("1EgjS2hL3zSgwjcwLVmoPTmp");
            var bytes2 = Encoding.UTF8.GetBytes("lfAKRpm1");
            var tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
            byte[] array2;
            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, tripleDESCryptoServiceProvider.CreateDecryptor(bytes, bytes2), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(array, 0, array.Length);
                    cryptoStream.Close();
                }
                array2 = memoryStream.ToArray();
                memoryStream.Close();
            }
            if (isPress)
            {
                using (var memoryStream2 = new MemoryStream())
                {
                    using (var memoryStream3 = new MemoryStream(array2))
                    {
                        using (var bZip2InputStream = new BZip2InputStream(memoryStream3))
                        {
                            var array3 = new byte[16384];
                            int num;
                            while ((num = bZip2InputStream.Read(array3, 0, array3.Length)) > 0)
                            {
                                memoryStream2.Write(array3, 0, num);
                            }
                            bZip2InputStream.Close();
                        }
                        memoryStream3.Close();
                    }
                    array2 = memoryStream2.ToArray();
                    memoryStream2.Close();
                }
            }
            return Encoding.UTF8.GetString(array2);
        }

        public static string GetDecryptFunnyKey()
        {
            var str = "+eTq/PgKHhpvmMWboN+Flb3okskn3SD325tVSqPf5nCjqAtdR6BN7Q==";
            return CryptData.FunnyKeyDecrypt(str);
        }

        public static string EncryptMD5Usk(string usk)
        {
            var decryptFunnyKey = CryptData.GetDecryptFunnyKey();
            var str = decryptFunnyKey + usk;
            return CryptData.EncryptMD5(str);
        }

        public static string EncryptMD5(string str)
        {
            MD5 mD = new MD5CryptoServiceProvider();
            var bytes = Encoding.UTF8.GetBytes(str);
            var array = mD.ComputeHash(bytes);
            var stringBuilder = new StringBuilder();
            var array2 = array;
            for (var i = 0; i < array2.Length; i++)
            {
                var b = array2[i];
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return stringBuilder.ToString();
        }

        public static string FunnyKeyDecrypt(string str)
        {
            var array = Convert.FromBase64String(str);
            var bytes = Encoding.UTF8.GetBytes("Af80jlDHNlubKJ76bkFGKNjg");
            var bytes2 = Encoding.UTF8.GetBytes("ld521lxj");
            var tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
            byte[] array2;
            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, tripleDESCryptoServiceProvider.CreateDecryptor(bytes, bytes2), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(array, 0, array.Length);
                    cryptoStream.Close();
                }
                array2 = memoryStream.ToArray();
                memoryStream.Close();
            }
            using (var memoryStream2 = new MemoryStream())
            {
                using (var memoryStream3 = new MemoryStream(array2))
                {
                    var array3 = new byte[16384];
                    int num;
                    while ((num = memoryStream3.Read(array3, 0, array3.Length)) > 0)
                    {
                        memoryStream2.Write(array3, 0, num);
                    }
                    memoryStream3.Close();
                }
                array2 = memoryStream2.ToArray();
                memoryStream2.Close();
            }
            return Encoding.UTF8.GetString(array2);
        }
    }
}
