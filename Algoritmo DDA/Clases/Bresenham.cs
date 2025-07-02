using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bresenham
{
    internal class Bresenham
    {
        private float xInicial, yInicial, xFinal, yFinal;
        private bool graficarLinea = false;
        private int SF = 20;

        private List<Point> pixeles = new List<Point>();
        private Timer animTimer;
        private int pixelIndex = 0;
        private PictureBox canvas;
        private ListBox listaPixeles;

        public Bresenham()
        {
            animTimer = new Timer();
            animTimer.Interval = 50; 
            animTimer.Tick += AnimTimer_Tick;
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            if (pixelIndex < pixeles.Count)
            {
                using (Graphics g = canvas.CreateGraphics())
                {
                    Point p = pixeles[pixelIndex];
                    g.FillRectangle(Brushes.MediumVioletRed, p.X, p.Y, 2, 2);
                    listaPixeles.Items.Add($"({p.X}, {p.Y})");
                    pixelIndex++;
                }
            }
            else
            {
                animTimer.Stop();
            }
        }

        public void SetCoordenadas(float xi, float yi, float xf, float yf, int escala = 20)
        {
            xInicial = xi;
            yInicial = yi;
            xFinal = xf;
            yFinal = yf;
            SF = escala;
            graficarLinea = true;
        }

        public void LeerCoordenas(TextBox txtXi, TextBox txtYi, TextBox txtXf, TextBox txtYf, PictureBox picCanvas, ListBox lstPixeles)
        {
            try
            {
                float xi = float.Parse(txtXi.Text);
                float yi = float.Parse(txtYi.Text);
                float xf = float.Parse(txtXf.Text);
                float yf = float.Parse(txtYf.Text);

                if (xi < 0 || yi < 0 || xf < 0 || yf < 0)
                    throw new ArgumentException("Todos los valores deben ser mayores o iguales a 0.");

                SetCoordenadas(xi, yi, xf, yf, 10);
                canvas = picCanvas;
                listaPixeles = lstPixeles;
                listaPixeles.Items.Clear();
                canvas.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reset()
        {
            graficarLinea = false;
            pixeles.Clear();
            pixelIndex = 0;
            animTimer.Stop();
        }

        public void DibujarPlanoCartesiano(Graphics g, PictureBox picCanvas)
        {
            int origenX = 0;
            int origenY = picCanvas.Height;
            Pen penPlano = new Pen(Color.Gray, 1);

            g.DrawLine(penPlano, origenX, origenY - 1, picCanvas.Width, origenY - 1);
            g.DrawLine(penPlano, origenX, 0, origenX, origenY);

            for (int i = 0; i <= picCanvas.Width; i += SF)
                g.DrawLine(penPlano, i, origenY - 3, i, origenY + 3);

            for (int i = 0; i <= picCanvas.Height; i += SF)
                g.DrawLine(penPlano, origenX - 3, origenY - i, origenX + 3, origenY - i);
        }

        public void DibujarLineaBresenham(Graphics g, PictureBox picCanvas)
        {
            if (!graficarLinea) return;

            pixeles.Clear();
            int centroX = 0;
            int centroY = picCanvas.Height;

            int x0 = (int)(centroX + xInicial * SF);
            int y0 = (int)(centroY - yInicial * SF);
            int x1 = (int)(centroX + xFinal * SF);
            int y1 = (int)(centroY - yFinal * SF);

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;

            bool caso1 = dx > dy;
            int p = caso1 ? 2 * dy - dx : 2 * dx - dy;

            int x = x0, y = y0;

            if (caso1)
            {
                for (int i = 0; i <= dx; i++)
                {
                    pixeles.Add(new Point(x, y));
                    if (p >= 0) { y += sy; p -= 2 * dx; }
                    p += 2 * dy;
                    x += sx;
                }
            }
            else
            {
                for (int i = 0; i <= dy; i++)
                {
                    pixeles.Add(new Point(x, y));
                    if (p >= 0) { x += sx; p -= 2 * dy; }
                    p += 2 * dx;
                    y += sy;
                }
            }

            pixelIndex = 0;
            animTimer.Start();
        }
    }
}


