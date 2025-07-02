using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Algoritmo_DDA
{
    internal class FloodFill
    {
        /// <summary>
        /// Algoritmo de llenado por inundación (Flood Fill) con animación visual.
        /// </summary>
        public void Fill(
            Bitmap bitmap,
            Point startPoint,
            Color targetColor,
            Color replacementColor,
            PictureBox canvas,
            ListBox lstPixeles,
            int delay = 0)
        {
            if (startPoint.X < 0 || startPoint.X >= bitmap.Width ||
                startPoint.Y < 0 || startPoint.Y >= bitmap.Height)
                return;

            if (targetColor.ToArgb() == replacementColor.ToArgb())
                return;

            if (bitmap.GetPixel(startPoint.X, startPoint.Y).ToArgb() != targetColor.ToArgb())
                return;

            Stack<Point> pila = new Stack<Point>();
            pila.Push(startPoint);

            while (pila.Count > 0)
            {
                Point punto = pila.Pop();

                if (punto.X < 0 || punto.X >= bitmap.Width || punto.Y < 0 || punto.Y >= bitmap.Height)
                    continue;

                Color actual = bitmap.GetPixel(punto.X, punto.Y);
                if (actual.ToArgb() == targetColor.ToArgb())
                {
                    bitmap.SetPixel(punto.X, punto.Y, replacementColor);

                    // Animación visual
                    canvas.Image = bitmap;
                    canvas.Refresh();

                    // Mostrar en ListBox
                    lstPixeles.Items.Add($"({punto.X}, {punto.Y})");

                    if (delay > 0) Thread.Sleep(delay);

                    // Vecinos 4-direcciones
                    pila.Push(new Point(punto.X + 1, punto.Y));
                    pila.Push(new Point(punto.X - 1, punto.Y));
                    pila.Push(new Point(punto.X, punto.Y + 1));
                    pila.Push(new Point(punto.X, punto.Y - 1));
                }
            }
        }
    }
}
