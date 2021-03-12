using System.Drawing.Imaging;
using Xunit;

namespace LemureIdentIcons.Unit.Test
{
    public class WhiteBlockIconTest
    {
        [Fact]
        public void GenerateIcon()
        {
            var Bitmap = new LemureIdentIcon().CreateIcon("Test lemure", IdentIconType.WhiteBlockIcon);
            Bitmap.Save("./lemure-white-block.jpg", ImageFormat.Jpeg);
            Assert.NotNull(Bitmap);
        }
    }
}
