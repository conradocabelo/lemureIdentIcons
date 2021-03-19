using LemureIdentIcons.Hashs;
using LemureIdentIcons.Icons;

namespace LemureIdentIcons
{
    public static class LemureExtension
    {
        public static ILemureIcon SetSizeOfBlock(this ILemureIcon lemureIcon, int block) 
        {
            lemureIcon.SizeBlocks = block;
            return lemureIcon;
        }

        public static ILemureIcon SetSizeIcon(this ILemureIcon lemureIcon, int Width, int Heigth)
        {
            lemureIcon.Width = Width;
            lemureIcon.Heigth = Heigth;

            return lemureIcon;
        }

        public static ILemureIcon UseHash(this ILemureIcon lemureIcon, HashType hashType)
        {
            lemureIcon.HashType = hashType;
            return lemureIcon;
        }
    }
}
