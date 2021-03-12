using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using LemureIdentIcons.Elements;
using LemureIdentIcons.Hashs;

namespace LemureIdentIcons.Icons
{
    internal class WhiteBlockIcon : ILemureIcon
    {
        private Grid _grid;
        private Color _color;

        public Bitmap Draw(string Value)
        {
            byte[] hash = Value.ToMd5();

            _color = CreateBrushColor(hash);

            _grid = new Grid(250, 250, 5);
            _grid.CreateGrid(hash);

            List<BlockDrawing> blockDrawings = CreateBlockDrawing(_grid);

            return CreateImageIcon(blockDrawings);
        }

        private Color CreateBrushColor(byte[] hash)
        {
            var colorValue = hash.TakeLast(3).ToArray();
            return Color.FromArgb(colorValue[0], colorValue[1], colorValue[2]);
        }

        private Bitmap CreateImageIcon(List<BlockDrawing> blockDrawings)
        {
            Bitmap identyBitmap = new Bitmap(_grid.Width, _grid.Height, PixelFormat.Format24bppRgb);
            Graphics canvas = Graphics.FromImage(identyBitmap);
            SolidBrush shadowBrush = new SolidBrush(_color);

            canvas.FillRectangle(Brushes.White, 0, 0, _grid.Width, _grid.Height);

            foreach (var item in blockDrawings)
            {
                canvas.FillRectangle(
                    shadowBrush,
                    new Rectangle
                    {
                        X = item.X,
                        Y = item.Y,
                        Width = item.Width,
                        Height = item.Height
                    }
                );
            }

            return identyBitmap;
        }

        private List<BlockDrawing> CreateBlockDrawing(Grid grid)
        {
            List<BlockDrawing> drawings = new List<BlockDrawing>();

            for (int y = 0; y < grid.ElementsInGrid.Count; y++)
            {
                var line = grid.ElementsInGrid[y];

                for (int x = 0; x < line.Length; x++)
                {
                    if (line[x] % 2 == 0)
                    {
                        int positionX = x * grid.SizeBlock;
                        int positionY = y * grid.SizeBlock;

                        drawings.Add(new BlockDrawing(positionX, positionY, grid.SizeBlock));
                    }
                }
            }

            return drawings;
        }
    }
}
