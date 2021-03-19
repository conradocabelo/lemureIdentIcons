using System;
using System.Collections.Generic;
using System.Text;

namespace LemureIdentIcons.Hashs
{
    public interface ILemureHash
    {
        byte[] Compute(string Content, HashType hashType);
    }
}
