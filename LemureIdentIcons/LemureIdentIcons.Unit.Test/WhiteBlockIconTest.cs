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
    }
}
