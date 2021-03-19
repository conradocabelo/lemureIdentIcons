using LemureIdentIcons.Hashs;
using System.Drawing;

namespace LemureIdentIcons.Icons
{
    public interface ILemureIcon
    {
        public int SizeBlocks { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }
        public HashType HashType { get; set; }

        public Bitmap Draw(string Value);
    }
}
