using System.Drawing;

namespace LemureIdentIcons.Elements
{
    internal class ShapeDrawing: ElementDrawing
    {
        public Brush Brush { get; private set; }

        public ShapeDrawing(Brush brush, int X, int Y, int Size)
        {
            this.Brush = brush;
            this.X = X;
            this.Y = Y;
            this.Height = Size;
            this.Width = Size;
        }
    }
}
