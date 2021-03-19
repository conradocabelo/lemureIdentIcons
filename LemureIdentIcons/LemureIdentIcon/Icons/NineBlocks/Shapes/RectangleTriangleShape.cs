using LemureIdentIcons.Elements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("LemureIdentIcons.Unit.Test")]
namespace LemureIdentIcons.Icons.NineBlocks.Shapes
{
    internal class RectangleTriangleShape : IShape
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
                new Point(shapeDrawing.X, shapeDrawing.Y),
                new Point(shapeDrawing.X + shapeDrawing.Width, shapeDrawing.Y),
                new Point(shapeDrawing.X, shapeDrawing.Y + shapeDrawing.Height)
            };
        }
    }
}
