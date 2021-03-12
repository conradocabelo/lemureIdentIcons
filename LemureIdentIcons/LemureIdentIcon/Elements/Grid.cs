using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemureIdentIcons.Elements
{
    internal class Grid
    {
        private readonly List<byte[]> _gridValues;
        private int _subDivisionHash;

        internal Grid(int Width, int Height, int Blocks)
        {
            this.Width = Width;
            this.Height = Height;
            this.Blocks = Blocks;

            this.SizeBlock = (int)this.Width / this.Blocks;

            _gridValues = new List<byte[]>();
        }

        internal int Width { get; private set; }
        internal int Height { get; private set; }
        internal int Blocks { get; private set; }
        internal int SizeBlock { get; private set; }

        internal List<byte[]> ElementsInGrid => _gridValues;

        internal void CreateGrid(byte[] OriginalHash)
        {
            _gridValues.Clear();

            _subDivisionHash = (OriginalHash.Length / Blocks);
            int mirrorTerm = (this.Blocks / 2) ;

            for (int i = 0; i < OriginalHash.Length && i + _subDivisionHash <= OriginalHash.Length; i += _subDivisionHash)
            {
                List<byte> byteBlock = OriginalHash.Skip(i).Take(_subDivisionHash).ToList();
                var mirrorBytes = OriginalHash.Skip(i).Take(mirrorTerm).Reverse().ToArray();
                byteBlock.AddRange(mirrorBytes);

                _gridValues.Add(byteBlock.ToArray());
            }
        }
    }
}
