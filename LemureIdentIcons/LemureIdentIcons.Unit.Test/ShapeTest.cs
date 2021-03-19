using LemureIdentIcons.Icons.NineBlocks.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace LemureIdentIcons.Unit.Test
{
    public class ShapeTest
    {

        [Fact]
        public void DrawShape01()
        {
            Brush brush;
            Bitmap bitmap;
            Graphics canvas;

            PrepareBitMap(out brush, out bitmap, out canvas);

            IShape shape = new BlockShape();
            shape.DrawShape(canvas, new Elements.ShapeDrawing(brush, 0, 0, 50));

            bitmap.Save("./shapes-01.jpg");
        }

        [Fact]
        public void DrawShape02()
        {
            Brush brush;
            Bitmap bitmap;
            Graphics canvas;

            PrepareBitMap(out brush, out bitmap, out canvas);

            IShape shape = new RectangleTriangleShape();
            shape.DrawShape(canvas, new Elements.ShapeDrawing(brush, 0, 0, 50));

            bitmap.Save("./shapes-02.jpg");
        }

        [Fact]
        public void DrawShape03()
        {
            Brush brush;
            Bitmap bitmap;
            Graphics canvas;

            PrepareBitMap(out brush, out bitmap, out canvas);

            IShape shape = new IsoscelesTriangleShape();
            shape.DrawShape(canvas, new Elements.ShapeDrawing(brush, 0, 0, 50));

            bitmap.Save("./shapes-03.jpg");
        }

        [Fact]
        public void DrawShape04()
        {
            Brush brush;
            Bitmap bitmap;
            Graphics canvas;

            PrepareBitMap(out brush, out bitmap, out canvas);

            IShape shape = new RectangleShape();
            shape.DrawShape(canvas, new Elements.ShapeDrawing(brush, 0, 0, 50));

            bitmap.Save("./shapes-04.jpg");
        }

        [Fact]
        public void DrawShape05()
        {
            Brush brush;
            Bitmap bitmap;
            Graphics canvas;

            PrepareBitMap(out brush, out bitmap, out canvas);

            IShape shape = new DiamondShape();
            shape.DrawShape(canvas, new Elements.ShapeDrawing(brush, 0, 0, 50));

            bitmap.Save("./shapes-05.jpg");
        }

        [Fact]
        public void DrawShape06()
        {
            Brush brush;
            Bitmap bitmap;
            Graphics canvas;

            PrepareBitMap(out brush, out bitmap, out canvas);

            IShape shape = new ArrowShape();
            shape.DrawShape(canvas, new Elements.ShapeDrawing(brush, 0, 0, 50));

            bitmap.Save("./shapes-06.jpg");
        }



        private static void PrepareBitMap(out Brush brush, out Bitmap bitmap, out Graphics canvas)
        {
            brush = new SolidBrush(Color.Black);
            bitmap = new Bitmap(50, 50);
            canvas = Graphics.FromImage(bitmap);
            SolidBrush brushBackground = new SolidBrush(Color.White);
            canvas.FillRectangle(brushBackground, 0, 0, 50, 50);
        }
    }
}
