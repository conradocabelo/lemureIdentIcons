using LemureIdentIcons.Elements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LemureIdentIcons.Icons.NineBlocks.Shapes
{
    internal class IsoscelesTriangleShape : IShape
    {
        public void DrawShape(Graphics canvas, ShapeDrawing shapeDrawing)
        {
            canvas.FillPolygon(
                shapeDrawing.Brush,
                CreatePoints(shapeDrawing)
            );
        }

        private Point[] CreatePoints(ShapeDrawing shapeDrawing)
        {
            return new[]
            {
                new Point(shapeDrawing.X + (shapeDrawing.Width / 2), shapeDrawing.Y),
                new Point(shapeDrawing.X, shapeDrawing.Y + shapeDrawing.Height),
                new Point(shapeDrawing.X + shapeDrawing.Width, shapeDrawing.Y + shapeDrawing.Height)
            };
        }
    }
}
