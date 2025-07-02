using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoCircunferencia
{
    internal class AlgoritmoCircunferencia
    {
        private int X, Y, Radio;
        private bool graficarCircunferencia = false;
        private int SF = 20;

        public List<Point> pixelesEncendidos = new List<Point>();

        public void SetCircunferencia(int xc, int yc, int r, int escala = 20)
        {
            X = xc;
            Y = yc;
            Radio = r;
            SF = escala;
            graficarCircunferencia = true;
        }

        public void LeerCoordenas(TextBox txtX, TextBox txtY, TextBox txtRadio, PictureBox picCanvas)
        {
            try
            {
                int Xc = int.Parse(txtX.Text);
                int Yc = int.Parse(txtY.Text);
                int r = int.Parse(txtRadio.Text);

                if (r < 0)
                {
                    throw new ArgumentException("El Radio debe ser mayor a 0.");
                }

                SetCircunferencia(Xc, Yc, r, 10);
                pixelesEncendidos.Clear();
                picCanvas.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reset()
        {
            graficarCircunferencia = false;
            pixelesEncendidos.Clear();
        }

        public void DibujarPlanoCartesiano(Graphics g, PictureBox picCanvas)
        {
            int origenX = picCanvas.Width / 2;
            int origenY = picCanvas.Height / 2;
            Pen penPlano = new Pen(Color.Gray, 1);

            g.DrawLine(penPlano, 0, origenY, picCanvas.Width, origenY);
            g.DrawLine(penPlano, origenX, 0, origenX, picCanvas.Height);

            for (int i = origenX; i <= picCanvas.Width; i += SF)
                g.DrawLine(penPlano, i, origenY - 3, i, origenY + 3);
            for (int i = origenX; i >= 0; i -= SF)
                g.DrawLine(penPlano, i, origenY - 3, i, origenY + 3);

            for (int i = origenY; i <= picCanvas.Height; i += SF)
                g.DrawLine(penPlano, origenX - 3, i, origenX + 3, i);
            for (int i = origenY; i >= 0; i -= SF)
                g.DrawLine(penPlano, origenX - 3, i, origenX + 3, i);
        }

        public void DibujarCircunferencia(Graphics g, PictureBox picCanvas)
        {
            if (graficarCircunferencia)
            {
                int origenX = picCanvas.Width / 2;
                int origenY = picCanvas.Height / 2;

                int x0 = origenX + (X * SF);
                int y0 = origenY - (Y * SF);
                int r = Radio * SF;

                int x = 0;
                int y = r;
                int p = 1 - r;

                DibujarOctantes(x0, y0, x, y);

                while (x < y)
                {
                    x++;
                    if (p < 0)
                        p += 2 * x + 1;
                    else
                    {
                        y--;
                        p += 2 * (x - y) + 1;
                    }

                    DibujarOctantes(x0, y0, x, y);
                }
            }
        }

        private void DibujarOctantes(int x0, int y0, int x, int y)
        {
            List<Point> puntos = new List<Point>
            {
                new Point(x0 + x, y0 + y),
                new Point(x0 - x, y0 + y),
                new Point(x0 + x, y0 - y),
                new Point(x0 - x, y0 - y),
                new Point(x0 + y, y0 + x),
                new Point(x0 - y, y0 + x),
                new Point(x0 + y, y0 - x),
                new Point(x0 - y, y0 - x),
            };

            foreach (var p in puntos)
                pixelesEncendidos.Add(p);
        }
    }
}
