using LemureIdentIcons.Elements;
using System.Drawing;

namespace LemureIdentIcons.Icons.NineBlocks.Shapes
{
    internal class RectangleShape : IShape
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
                new Point(shapeDrawing.X + (shapeDrawing.Width / 2), shapeDrawing.Y),
                new Point(shapeDrawing.X + (shapeDrawing.Width / 2), shapeDrawing.Y + shapeDrawing.Height),
                new Point(shapeDrawing.X, shapeDrawing.Y + shapeDrawing.Height)
            };
        }
    }
}
