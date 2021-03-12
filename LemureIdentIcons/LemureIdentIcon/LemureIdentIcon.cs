using System;
using System.Drawing;
using LemureIdentIcons.Icons;

namespace LemureIdentIcons
{
    public class LemureIdentIcon
    {
        public Bitmap CreateIcon(string Value, IdentIconType IdentIconType = IdentIconType.WhiteBlockIcon) => 
            MakeLemureIconClass(IdentIconType).Draw(Value);

        private ILemureIcon MakeLemureIconClass(IdentIconType identIconType)
        {
            switch (identIconType)
            {
                case IdentIconType.WhiteBlockIcon: return new WhiteBlockIcon();
                default:
                    throw new NotImplementedException("Icon type not implemented");
            }
        }
    }
}
