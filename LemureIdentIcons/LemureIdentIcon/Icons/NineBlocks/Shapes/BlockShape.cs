using LemureIdentIcons.Elements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LemureIdentIcons.Icons.NineBlocks.Shapes
{
    internal class BlockShape : IShape
    {
        public void DrawShape(Graphics canvas, ShapeDrawing shapeDrawing)
        {
            canvas.FillRectangle(
                   shapeDrawing.Brush,
                   new Rectangle
                   {
                       X = shapeDrawing.X,
                       Y = shapeDrawing.Y,
                       Width = shapeDrawing.Width,
                       Height = shapeDrawing.Height
                   });
        }
    }
}
