using LemureIdentIcons.Elements;
using LemureIdentIcons.Hashs;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace LemureIdentIcons.Icons.IconBlock
{
    internal abstract class BaseBlockIcon: ILemureIcon
    {
        protected Grid Grid;
        protected Color Color;

        public int SizeBlocks { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }
        public HashType HashType { get; set; }

        protected virtual List<BlockDrawing> CreateBlockDrawing(Grid grid)
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

        public Bitmap Draw(string Value)
        {
            byte[] hash = new LemureHash().Compute(Value, HashType);

            Color = CreateBrushColor(hash);

            Grid = new Grid(this.Heigth, Width, SizeBlocks);
            Grid.CreateGrid(hash);

            List<BlockDrawing> blockDrawings = CreateBlockDrawing(Grid);

            return CreateImageIcon(blockDrawings);
        }

        protected Color CreateBrushColor(byte[] hash)
        {
            var colorValue = hash.TakeLast(3).ToArray();
            return Color.FromArgb(colorValue[0], colorValue[1], colorValue[2]);
        }

        protected abstract Bitmap CreateImageIcon(List<BlockDrawing> blockDrawings);
    }
}
