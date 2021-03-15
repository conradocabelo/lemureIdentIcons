using System.Drawing;

namespace LemureIdentIcons.Icons
{
    public interface ILemureIcon
    {
        public int SizeBlocks { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }

        public Bitmap Draw(string Value);
    }
}
