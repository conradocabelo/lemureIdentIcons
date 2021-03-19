using LemureIdentIcons.Icons;
using System.Drawing.Imaging;
using Xunit;

namespace LemureIdentIcons.Unit.Test
{
    public class DarkBlockIconTest
    {
        [Fact]
        public void GenerateIcon() 
        {
            ILemureIcon lemureIcon = new LemureIdentIcon().CreateLemure(IdentIconType.DarkBlockIcon);
            var Bitmap = lemureIcon.Draw("lemureteste");
            Bitmap.Save("./lemure-dark-block-md5.jpg", ImageFormat.Jpeg);
            Assert.NotNull(Bitmap);
        }

        [Fact]
        public void GenerateIconSHA1()
        {
            ILemureIcon lemureIcon = new LemureIdentIcon().CreateLemure(IdentIconType.DarkBlockIcon);
            lemureIcon.UseHash(Hashs.HashType.SHA1);

            var Bitmap = lemureIcon.Draw("lemureteste");
            Bitmap.Save("./lemure-dark-block-sha1.jpg", ImageFormat.Jpeg);
            Assert.NotNull(Bitmap);
        }

        [Fact]
        public void GenerateIconSHA256()
        {
            ILemureIcon lemureIcon = new LemureIdentIcon().CreateLemure(IdentIconType.DarkBlockIcon);
            lemureIcon.UseHash(Hashs.HashType.SHA256);

            var Bitmap = lemureIcon.Draw("lemureteste");
            Bitmap.Save("./lemure-dark-block-sha256.jpg", ImageFormat.Jpeg);
            Assert.NotNull(Bitmap);
        }

        [Fact]
        public void GenerateIconSHA512()
        {
            ILemureIcon lemureIcon = new LemureIdentIcon().CreateLemure(IdentIconType.DarkBlockIcon);
            lemureIcon.UseHash(Hashs.HashType.SHA512);

            var Bitmap = lemureIcon.Draw("lemureteste");
            Bitmap.Save("./lemure-dark-block-sha512.jpg", ImageFormat.Jpeg);
            Assert.NotNull(Bitmap);
        }
    }
}
