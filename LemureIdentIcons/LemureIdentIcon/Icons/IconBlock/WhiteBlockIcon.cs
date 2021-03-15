using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using LemureIdentIcons.Elements;
using LemureIdentIcons.Hashs;

namespace LemureIdentIcons.Icons.IconBlock
{
    internal class WhiteBlockIcon : BaseBlockIcon
    {
        protected override Bitmap CreateImageIcon(List<BlockDrawing> blockDrawings)
        {
            Bitmap identyBitmap = new Bitmap(Grid.Width, Grid.Height, PixelFormat.Format24bppRgb);
            Graphics canvas = Graphics.FromImage(identyBitmap);
            SolidBrush shadowBrush = new SolidBrush(Color);

            canvas.FillRectangle(Brushes.White, 0, 0, Grid.Width, Grid.Height);

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
    }
}
