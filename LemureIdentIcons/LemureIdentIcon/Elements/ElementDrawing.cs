using System;
using System.Collections.Generic;
using System.Text;

namespace LemureIdentIcons.Elements
{
    internal abstract class ElementDrawing
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; }
    }
}
