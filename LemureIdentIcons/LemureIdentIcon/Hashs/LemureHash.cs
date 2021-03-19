using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace LemureIdentIcons.Hashs
{
    internal class LemureHash: ILemureHash
    {
        public byte[] Compute(string Content, HashType hashType)
        {
            using HashAlgorithm hashAlgorithm = CreateHashAlgotiyhm(hashType);
            byte[] inputBytes = Encoding.ASCII.GetBytes(Content);
            byte[] hashBytes = hashAlgorithm.ComputeHash(inputBytes);

            return hashBytes.Take(16).ToArray();
        }

        private HashAlgorithm CreateHashAlgotiyhm(HashType hashType)
        {
            switch (hashType)
            {
                case HashType.MD5: return MD5.Create();
                case HashType.SHA1: return SHA1.Create();
                case HashType.SHA256: return SHA256.Create();
                case HashType.SHA512: return SHA512.Create();
                default:
                    throw new InvalidOperationException("Algorithm hash not implemented");
            }
        }
    }
}
