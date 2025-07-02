using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_DDA.Clases
{
    public class BresenhamElipses
    {
        private Graphics g;
        private Bitmap bmp;
        private Action<Point> dibujarPixel;
        private Action<string> registrarPixel;

        public BresenhamElipses(Graphics g, Bitmap bmp, Action<Point> dibujarPixel, Action<string> registrarPixel)
        {
            this.g = g;
            this.bmp = bmp;
            this.dibujarPixel = dibujarPixel;
            this.registrarPixel = registrarPixel;
        }

        private async Task PlotEllipsePoints(int xc, int yc, int x, int y)
        {
            Point[] puntos = new Point[]
            {
                new Point(xc + x, yc + y),
                new Point(xc - x, yc + y),
                new Point(xc + x, yc - y),
                new Point(xc - x, yc - y)
            };

            foreach (Point p in puntos)
            {
                if (p.X >= 0 && p.Y >= 0 && p.X < bmp.Width && p.Y < bmp.Height)
                {
                    bmp.SetPixel(p.X, p.Y, Color.Black);
                    dibujarPixel(p);
                    registrarPixel($"({p.X}, {p.Y})");
                    await Task.Delay(5);
                }
            }
        }

        public async Task DibujarElipse(int xc, int yc, int rx, int ry)
        {
            int x = 0;
            int y = ry;

            double rx2 = rx * rx;
            double ry2 = ry * ry;
            double dx = 2 * ry2 * x;
            double dy = 2 * rx2 * y;

            // Región 1
            double p1 = ry2 - (rx2 * ry) + (0.25 * rx2);
            while (dx < dy)
            {
                await PlotEllipsePoints(xc, yc, x, y);
                x++;
                dx = dx + (2 * ry2);
                if (p1 < 0)
                {
                    p1 = p1 + dx + ry2;
                }
                else
                {
                    y--;
                    dy = dy - (2 * rx2);
                    p1 = p1 + dx - dy + ry2;
                }
            }

            // Región 2
            double p2 = (ry2 * ((x + 0.5) * (x + 0.5))) + (rx2 * ((y - 1) * (y - 1))) - (rx2 * ry2);
            while (y >= 0)
            {
                await PlotEllipsePoints(xc, yc, x, y);
                y--;
                dy = dy - (2 * rx2);
                if (p2 > 0)
                {
                    p2 = p2 + rx2 - dy;
                }
                else
                {
                    x++;
                    dx = dx + (2 * ry2);
                    p2 = p2 + dx - dy + rx2;
                }
            }
        }
    }
}
