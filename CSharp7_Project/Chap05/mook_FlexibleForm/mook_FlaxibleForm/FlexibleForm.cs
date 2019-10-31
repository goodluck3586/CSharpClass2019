using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace mook_FlexibleForm
{
    class FlexibleForm
    {
        public static void CreateControlRegion(Control control, Bitmap bitmap)
        {
            if (control == null || bitmap == null)
                return;
            control.Width = bitmap.Width;
            control.Height = bitmap.Height;

            if (control is System.Windows.Forms.Form)
            {
                Form form = (Form)control;

                form.Width += 20;
                form.Height += 80;
                form.FormBorderStyle = FormBorderStyle.None;
                form.BackgroundImage = bitmap;
                GraphicsPath graphicsPath = CalculateControlGraphicsPath(bitmap);
                form.Region = new Region(graphicsPath);
            }
            else if (control is System.Windows.Forms.Button)
            {
                Button button = (Button)control;
                button.Text = "";
                button.Cursor = Cursors.Hand;
                button.BackgroundImage = bitmap;
                GraphicsPath graphicsPath = CalculateControlGraphicsPath(bitmap);
                button.Region = new Region(graphicsPath);
            }
        }

        private static GraphicsPath CalculateControlGraphicsPath(Bitmap bitmap)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            Color colorTransparent = bitmap.GetPixel(0, 0);

            int colOpaquePixel = 0;

            for (int row = 0; row < bitmap.Height; row++)
            {
                colOpaquePixel = 0;
                for (int col = 0; col < bitmap.Width; col++)
                {
                    if (bitmap.GetPixel(col, row) != colorTransparent)
                    {
                        colOpaquePixel = col;
                        int colNext = col;
                        for (colNext = colOpaquePixel; colNext < bitmap.Width; colNext++)
                            if (bitmap.GetPixel(colNext, row) == colorTransparent)
                                break;
                        graphicsPath.AddRectangle(new Rectangle(colOpaquePixel, row, colNext - colOpaquePixel, 1));
                        col = colNext;
                    }
                }
            }
            return graphicsPath;
        }
    }
}
