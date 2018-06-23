using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Text;

namespace FGOAutoScript
{
    class RsaHelper
    {
        public static string RSAEncrypt(string pemPublicKey, string m_strEncryptString)
        {
            var publicKeyParam = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKeyContent(pemPublicKey)));
            var c = CipherUtilities.GetCipher("RSA/ECB/PKCS1Padding");
            c.Init(true, publicKeyParam);
            var data = Encoding.UTF8.GetBytes(m_strEncryptString);
            data = c.DoFinal(data);
            return Convert.ToBase64String(data);
        }

        private static string publicKeyContent(string pemKey)
        {
            return pemKey.Replace("-----BEGIN PUBLIC KEY-----", "").Replace("-----END PUBLIC KEY-----", "");
        }
        
    }
}
