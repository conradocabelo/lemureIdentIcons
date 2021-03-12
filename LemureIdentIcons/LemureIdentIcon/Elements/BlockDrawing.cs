using System;
using System.Collections.Generic;
using System.Text;

namespace LemureIdentIcons.Elements
{
    internal class BlockDrawing: ElementDrawing
    {
        public BlockDrawing(int X, int Y, int Size)
        {
            this.X = X;
            this.Y = Y;
            this.Width = Size;
            this.Height = Size;
        }
    }
}
