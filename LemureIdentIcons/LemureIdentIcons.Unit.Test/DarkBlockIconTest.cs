using System.Drawing.Imaging;
using Xunit;

namespace LemureIdentIcons.Unit.Test
{
    public class DarkBlockIconTest
    {
        [Fact]
        public void GenerateIcon() 
        {
            var Bitmap = new LemureIdentIcon().CreateIcon("Test lemure", IdentIconType.DarkBlockIcon);
            Bitmap.Save("./lemure-dark-block.jpg", ImageFormat.Jpeg);
            Assert.NotNull(Bitmap);
        }
    }
}
