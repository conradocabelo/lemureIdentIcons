using System;
using LemureIdentIcons.Icons;
using LemureIdentIcons.Icons.IconBlock;

namespace LemureIdentIcons
{
    public class LemureIdentIcon
    {
        public ILemureIcon CreateLemure(IdentIconType IdentIconType = IdentIconType.WhiteBlockIcon) =>
            MakeLemureIconClass(IdentIconType).SetSizeIcon(250, 250).SetSizeOfBlock(5).UseHash(Hashs.HashType.MD5);

        private ILemureIcon MakeLemureIconClass(IdentIconType identIconType)
        {
            switch (identIconType)
            {
                case IdentIconType.WhiteBlockIcon: return new WhiteBlockIcon();
                case IdentIconType.DarkBlockIcon: return new DarkBlockIcon();
                default:
                    throw new NotImplementedException("Icon type not implemented");
            }
        }


    }
}
