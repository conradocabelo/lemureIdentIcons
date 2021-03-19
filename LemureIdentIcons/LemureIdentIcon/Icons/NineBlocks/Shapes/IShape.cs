using LemureIdentIcons.Elements;
using System.Drawing;

namespace LemureIdentIcons.Icons.NineBlocks.Shapes
{
    internal interface IShape
    {
        void DrawShape(Graphics canvas, ShapeDrawing shapeDrawing);
    }
}
