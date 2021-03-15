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
            Bitmap.Save("./lemure-dark-block.jpg", ImageFormat.Jpeg);
            Assert.NotNull(Bitmap);
        }
    }
}
