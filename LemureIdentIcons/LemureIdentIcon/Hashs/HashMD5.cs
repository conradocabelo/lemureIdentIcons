using System.Text;

namespace LemureIdentIcons.Hashs
{
    internal static class HashMD5
    {
        public static byte[] ToMd5(this string source) 
        {
            using System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(source);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            return hashBytes;
        }
    }
}
