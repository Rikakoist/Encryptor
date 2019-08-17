using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Encryptor
{
    class Encrypt
    {
        public static byte[] CalcHash(string inputString, uint Mode)
        {
            switch (Mode)
            {
                case 0:
                    {
                        HashAlgorithm algorithm = MD5.Create();
                        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
                    }
                case 1:
                    {
                        HashAlgorithm algorithm = SHA1.Create();
                        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
                    }
                case 2:
                    {
                        HashAlgorithm algorithm = SHA256.Create();
                        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
                    }
                case 3:
                    {
                        HashAlgorithm algorithm = SHA384.Create();
                        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
                    }
                case 4:
                    {
                        HashAlgorithm algorithm = SHA512.Create();
                        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
                    }
                default:
                    {
                        return null;
                    }
            }
        }

        public static string GetHash(string inputString, uint Mode)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in CalcHash(inputString, Mode))
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
