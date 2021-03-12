using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using LemureIdentIcons.Elements;

namespace LemureIdentIcons.Icons.IconBlock
{
    internal class DarkBlockIcon : BaseBlockIcon, ILemureIcon
    {
        protected override Bitmap CreateImageIcon(List<BlockDrawing> blockDrawings)
        {
            Color colorBackGround = Color.FromArgb(33, 34, 36);

            Bitmap identyBitmap = new Bitmap(Grid.Width, Grid.Height, PixelFormat.Format24bppRgb);
            Graphics canvas = Graphics.FromImage(identyBitmap);

            SolidBrush brushBlocks = new SolidBrush(Color);
            SolidBrush brushBackground = new SolidBrush(colorBackGround);
            
            canvas.FillRectangle(brushBackground, 0, 0, Grid.Width, Grid.Height);

            foreach (var item in blockDrawings)
            {
                canvas.FillRectangle(
                    brushBlocks,
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
