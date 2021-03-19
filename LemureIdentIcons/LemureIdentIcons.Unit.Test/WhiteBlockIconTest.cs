using LemureIdentIcons.Icons;
using System.Drawing.Imaging;
using Xunit;

namespace LemureIdentIcons.Unit.Test
{
    public class WhiteBlockIconTest
    {
        [Fact]
        public void GenerateIcon()
        {
            ILemureIcon lemureIcon = new LemureIdentIcon().CreateLemure();
            var Bitmap = lemureIcon.Draw("lemureteste");
            Bitmap.Save("./lemure-white-block.jpg", ImageFormat.Jpeg);
            Assert.NotNull(Bitmap);
        }

        [Fact]
        public void GenerateIconOtherSize()
        {
            ILemureIcon lemureIcon = new LemureIdentIcon().CreateLemure();
            lemureIcon.SetSizeIcon(500, 500).SetSizeOfBlock(6);

            var Bitmap = lemureIcon.Draw("lemureteste");
            Bitmap.Save("./lemure-white-500-500-8-block.jpg", ImageFormat.Jpeg);

            Assert.NotNull(Bitmap);
        }

        [Fact]
        public void GenerateIconSHA1()
        {
            ILemureIcon lemureIcon = new LemureIdentIcon().CreateLemure();
            lemureIcon.UseHash(Hashs.HashType.SHA1);

            var Bitmap = lemureIcon.Draw("lemureteste");
            Bitmap.Save("./lemure-white-block-sha1.jpg", ImageFormat.Jpeg);
            Assert.NotNull(Bitmap);
        }

        [Fact]
        public void GenerateIconSHA256()
        {
            ILemureIcon lemureIcon = new LemureIdentIcon().CreateLemure();
            lemureIcon.UseHash(Hashs.HashType.SHA256);

            var Bitmap = lemureIcon.Draw("lemureteste");
            Bitmap.Save("./lemure-white-block-sha256.jpg", ImageFormat.Jpeg);
            Assert.NotNull(Bitmap);
        }

        [Fact]
        public void GenerateIconSHA512()
        {
            ILemureIcon lemureIcon = new LemureIdentIcon().CreateLemure();
            lemureIcon.UseHash(Hashs.HashType.SHA512);

            var Bitmap = lemureIcon.Draw("lemureteste");
            Bitmap.Save("./lemure-white-block-sha512.jpg", ImageFormat.Jpeg);
            Assert.NotNull(Bitmap);
        }
    }
}
